using AutoMapper;
using Family.Manager.API.Models;
using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.DataProviders.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.API.Controllers
{
    [ApiController]
    [Route("api/v1/families")]
    public class FamilyController : ControllerBase
    {
        private readonly ILogger<FamilyController> _logger;
        private readonly IFamilyRepository _familyRepository;
        private readonly IKidRepository _kidRepository;
        private readonly IKinshipRepository _kinshipRepository;
        private readonly IMapper _mapper;

        public FamilyController(
            ILogger<FamilyController> logger,
            IFamilyRepository familyRepository,
            IKidRepository kidRepository,
            IKinshipRepository kinshipRepository,
            IMapper mapper)
        {
            _logger = logger;
            _familyRepository = familyRepository;
            _kidRepository = kidRepository;
            _kinshipRepository = kinshipRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<FamilyWithKidsAndKinshipsResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllFamiliesAsync()
        {
            var families = await _familyRepository.GetFamiliesWithKidsAndKinshipsAsync();
            var result = _mapper.Map<IEnumerable<FamilyWithKidsAndKinshipsResponse>>(families);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostFamilyAsync([FromBody] CreateFamilyRequest request)
        {
            var kinships = new List<Kinship>();
            var kids = new List<Kid>();
            var family = _mapper.Map<Domain.Entities.Family>(request);

            foreach (var kinship in request.Kinships)
            {
                kinships.Add(new Kinship(kinship.Description, kinship.PersonName, family.Id));
            }

            foreach (var kid in request.Kids)
            {
                var newKid = new Kid(kid.Name, kid.BirthDate, kid.Observation, family.Id);
                var religionInformation = new KidReligionInformation(newKid, kid.IsBaptized, kid.DoingCatechesis, kid.DoneCatechesis, kid.DoingPerse, kid.DonePerse, kid.DoingConfirmationSacrament, kid.DoneConfirmationSacrament);
                newKid.UpdateReligionInformation(religionInformation);

                kids.Add(newKid);
            }

            family.AddKinships(kinships);
            family.AddKids(kids);
            await _familyRepository.CreateAsync(family);

            return Ok(family);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> PutFamilyAsync(string id, [FromBody] UpdateFamilyRequest request)
        {
            request.Id = Guid.Parse(id);
            var family = _mapper.Map<Domain.Entities.Family>(request);
            await _familyRepository.UpdateAsync(family);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteFamilyAsync(string id)
        {
            var family = await _familyRepository.GetByIdAsync(Guid.Parse(id));

            if (family is null)
            {
                return NotFound();
            }

            await _familyRepository.DeleteAsync(family);
            return NoContent();
        }

        [HttpPost]
        [Route("{familyId}/kid")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostKidAsync(string familyId, [FromBody] EditKid_Request request)
        {
            var kid = new Kid(request.Name, request.BirthDate, request.Observation, Guid.Parse(familyId));
            var religionInformation = new KidReligionInformation(kid, request.IsBaptized, request.DoingCatechesis, request.DoneCatechesis, request.DoingPerse, request.DonePerse, request.DoingConfirmationSacrament, request.DoneConfirmationSacrament);
            kid.UpdateReligionInformation(religionInformation);
            await _kidRepository.CreateAsync(kid);

            return Ok();
        }

        [HttpPost]
        [Route("{familyId}/kinship")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostKinshipAsync(string familyId, [FromBody] EditKinship_Request request)
        {
            request.FamilyId = Guid.Parse(familyId);
            var kinship = new Kinship(request.Description, request.PersonName, request.FamilyId);
            await _kinshipRepository.CreateAsync(kinship);

            return Ok();
        }
    }
}
