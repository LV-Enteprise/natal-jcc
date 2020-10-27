using AutoMapper;
using Family.Manager.API.Models;
using Family.Manager.Infrastructure.DataProviders.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Family.Manager.API.Controllers
{
    [ApiController]
    [Route("api/v1/kids")]
    public class KidController : ControllerBase
    {
        private readonly ILogger<KidController> _logger;
        private readonly IKidRepository _kidRepository;
        private readonly IKidReligionInformationRepository _kidReligionInformationRepository;
        private readonly IMapper _mapper;

        public KidController(
            ILogger<KidController> logger,
            IKidRepository kidRepository,
            IKidReligionInformationRepository kidReligionInformationRepository,
            IMapper mapper)
        {
            _logger = logger;
            _kidRepository = kidRepository;
            _kidReligionInformationRepository = kidReligionInformationRepository;
            _mapper = mapper;
        }

        //[HttpGet]
        //[ProducesResponseType(typeof(IEnumerable<GetKidResponseModel>), StatusCodes.Status200OK)]
        //public async Task<IActionResult> GetAllAsync()
        //{
        //    var kids = await _kidRepository.GetAllKidsAsync();
        //    var result = _mapper.Map<IEnumerable<GetKidResponseModel>>(kids);
        //    return Ok(result);
        //}

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(GetKidResponseModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var kid = await _kidRepository.GetKidByIdAsync(Guid.Parse(id));
            var result = _mapper.Map<GetKidResponseModel>(kid);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutAsync(string id, [FromBody] EditKid_Request request)
        {
            request.Id = Guid.Parse(id);
            var kid = await _kidRepository.GetKidByIdAsync(request.Id);

            if (kid is null)
            {
                return NotFound();
            }

            kid.UpdateName(request.Name);
            kid.UpdateBirthDate(request.BirthDate);
            kid.UpdateObservation(request.Observation);

            kid.KidReligionInformation.IsBaptized = request.IsBaptized;
            kid.KidReligionInformation.DoingCatechesis = request.DoingCatechesis;
            kid.KidReligionInformation.DoneCatechesis = request.DoneCatechesis;
            kid.KidReligionInformation.DoingPerse = request.DoingPerse;
            kid.KidReligionInformation.DonePerse = request.DonePerse;
            kid.KidReligionInformation.DoingConfirmationSacrament = request.DoingConfirmationSacrament;
            kid.KidReligionInformation.DoneConfirmationSacrament = request.DoneConfirmationSacrament;

            await _kidRepository.UpdateAsync(kid);
            await _kidReligionInformationRepository.UpdateAsync(kid.KidReligionInformation);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(string id)
        {
            var kid = await _kidRepository.GetByIdAsync(Guid.Parse(id));

            if (kid is null)
            {
                return NotFound();
            }

            await _kidRepository.DeleteAsync(kid);
            return NoContent();
        }
    }
}
