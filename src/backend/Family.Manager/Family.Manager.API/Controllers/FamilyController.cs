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
        [ProducesResponseType(typeof(IEnumerable<FamilyWithDescriptionResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAllFamiliesDescriptionAsync()
        {
            var families = await _familyRepository.GetFamiliesDescriptionAsync();
            var result = _mapper.Map<IEnumerable<FamilyWithDescriptionResponse>>(families);
            return Ok(result);
        }

        [HttpGet]
        [Route("{familyId}")]
        [ProducesResponseType(typeof(FamilyWithKidsAndKinshipsResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFamilyAsync(string familyId)
        {
            var family = await _familyRepository.GetFamilyWithKidsAndKinshipsAsync(Guid.Parse(familyId));
            var result = _mapper.Map<FamilyWithKidsAndKinshipsResponse>(family);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostFamilyAsync([FromBody] CreateFamilyRequest request)
        {
            var kinships = new List<Kinship>();
            var family = _mapper.Map<Domain.Entities.Family>(request);

            foreach (var kinship in request.Kinships)
            {
                kinships.Add(new Kinship(kinship.Description, kinship.PersonName, family.Id));
            }

            family.AddKinships(kinships);
            await _familyRepository.CreateAsync(family);

            return Ok();
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
        [Route("{familyId}/kids")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostKidAsync(string familyId, [FromBody] IEnumerable<EditKid_Request> requests)
        {
            var kids = new List<Kid>();
            foreach (var kidRequest in requests)
            {
                kidRequest.FamilyId = Guid.Parse(familyId);
                var kid = _mapper.Map<Kid>(kidRequest);
                kid.Id = Guid.NewGuid();

                var religionInformation = new KidReligionInformation(kid, kidRequest.IsBaptized, kidRequest.DoingCatechesis, kidRequest.DoneCatechesis, kidRequest.DoingPerse, kidRequest.DonePerse, kidRequest.DoingConfirmationSacrament, kidRequest.DoneConfirmationSacrament);
                kid.UpdateReligionInformation(religionInformation);

                kids.Add(kid);
            }

            await _kidRepository.BulkInsertAsync(kids);
            return Ok();
        }

        [HttpPost]
        [Route("{familyId}/kinships")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> PostKinshipAsync(string familyId, [FromBody] IEnumerable<EditKinship_Request> requests)
        {
            var kinships = new List<Kinship>();
            foreach (var kinshipRequest in requests)
            {
                kinshipRequest.FamilyId = Guid.Parse(familyId);
                var kinship = _mapper.Map<Kinship>(kinshipRequest);
                kinship.Id = Guid.NewGuid();
                kinships.Add(kinship);
            }
            
            await _kinshipRepository.BulkInsertAsync(kinships);
            return Ok();
        }
    }
}
