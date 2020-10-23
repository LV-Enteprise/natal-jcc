using System;
using System.Threading.Tasks;
using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure;
using Family.Manager.Infrastructure.DataProviders.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Family.Manager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly BusinessLogicData _businessLogicData;
        private readonly IRepositoryBase<Kid, Guid> _kidRepository;

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            BusinessLogicData businessLogicData,
            IRepositoryBase<Kid, Guid> kidRepository)
        {
            _logger = logger;
            _businessLogicData = businessLogicData;
            _kidRepository = kidRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var kinships = new List<Kinship>();
            //var kids = new List<Kid>();

            //var family = new Domain.Entities.Family(
            //    "Rua Pirassununga, 743, Pq Novo Mundo - Americana", "-", "19981192732", "Católico", "Par. São Francisco de Assis", null, 3, kinships, kids);

            //var father = new Kinship("Pai", "Osmar Avansini", family.Id);
            //var mother = new Kinship("Mãe", "Syrlene Aparecida de Souza Avansini", family.Id);

            //var kid = new Kid("Vinicius de Souza Avansini", new DateTime(1997, 6, 22), null, family.Id);
            //var kidReligionInfo = new KidReligionInformation(kid, false, true, false, true, false, true);

            //await _businessLogicData.AddFamily(family);
            //await _businessLogicData.AddKinship(father);
            //await _businessLogicData.AddKinship(mother);
            //await _businessLogicData.AddKid(kid);
            //await _businessLogicData.AddKidReligionInformation(kidReligionInfo);

            //var families = await _businessLogicData.GetAllFamilies();

            var result = await _kidRepository.GetAll();
            return Ok(result);
        }
    }
}
