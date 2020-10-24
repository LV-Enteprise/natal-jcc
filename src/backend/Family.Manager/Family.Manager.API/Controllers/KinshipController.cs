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
    [Route("api/v1/kinships")]
    public class KinshipController : ControllerBase
    {
        private readonly ILogger<KinshipController> _logger;
        private readonly IKinshipRepository _kinshipRepository;
        private readonly IMapper _mapper;

        public KinshipController(
            ILogger<KinshipController> logger,
            IKinshipRepository kinshipRepository,
            IMapper mapper)
        {
            _logger = logger;
            _kinshipRepository = kinshipRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(GetKidResponseModel), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var kinship = await _kinshipRepository.GetByIdAsync(Guid.Parse(id));
            var result = _mapper.Map<FamilyWithKidsAndKinships_Kinships_Response>(kinship);
            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutAsync(string id, [FromBody] EditKinship_Request request)
        {
            request.Id = Guid.Parse(id);
            var kinship = await _kinshipRepository.GetByIdAsync(request.Id);

            if (kinship is null)
            {
                return NotFound();
            }

            kinship.Description = request.Description;
            kinship.PersonName = request.PersonName;
            await _kinshipRepository.UpdateAsync(kinship);

            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(string id)
        {
            var kinship = await _kinshipRepository.GetByIdAsync(Guid.Parse(id));

            if (kinship is null)
            {
                return NotFound();
            }

            await _kinshipRepository.DeleteAsync(kinship);
            return NoContent();
        }
    }
}
