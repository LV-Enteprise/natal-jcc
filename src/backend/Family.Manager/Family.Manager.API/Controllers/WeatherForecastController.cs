using System.Threading.Tasks;
using Family.Manager.Infrastructure;
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

        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            BusinessLogicData businessLogicData)
        {
            _logger = logger;
            _businessLogicData = businessLogicData;
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

            //var kidReligionInfo = new ReligionInformation(true, false, true, false, true, false, true);
            //var kid = new Kid("Vinicius de Souza Avansini", new DateTime(1997, 6, 22), kidReligionInfo, null, family.Id);

            //await _businessLogicData.AddFamily(family);
            //await _businessLogicData.AddKinship(father);
            //await _businessLogicData.AddKinship(mother);
            //await _businessLogicData.AddKid(kid);

            var families = await _businessLogicData.GetAllFamilies();
            return Ok(families);
        }
    }
}
