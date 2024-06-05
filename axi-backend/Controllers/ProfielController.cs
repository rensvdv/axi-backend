using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
using Microsoft.AspNetCore.Mvc;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackapi/[controller]")]
    public class ProfielController : ControllerBase
    {
        private readonly ILogger<ProfielController> _logger;
        private readonly ProfielContainer profielContainer;

        public ProfielController(ILogger<ProfielController> logger)
        {
            profielContainer = new ProfielContainer(new ProfielDAL(), new RechtDAL());
            _logger = logger;
        }

        [HttpPost("maakprofiel")]
        public IActionResult MaakProfiel([FromBody] Profiel profiel)
        {
            var result = profielContainer.MaakProfiel(profiel);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("bewerkprofiel")]
        public IActionResult BewerkProfiel([FromBody] Profiel profiel)
        {
            var result = profielContainer.BewerkProfiel(profiel);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijderprofiel")]
        public IActionResult VerwijderProfiel([FromBody] Profiel profiel)
        {
            var result = profielContainer.VerwijderProfiel(profiel);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("zoekprofielen")]
        public List<Profiel> ZoekProfielen()
        {
            return profielContainer.ZoekProfielen();
        }

        [HttpGet("zoekgebruikerprofielen/{gebruikerId}")]
        public List<Profiel> ZoekGebruikerProfielen(int gebruikerId)
        {
            return profielContainer.ZoekGebruikerProfielen(gebruikerId);
        }

        [HttpGet("zoekprofiel/{id}")]
        public Profiel ZoekProfiel(int id)
        {
            return profielContainer.ZoekProfiel(id);
        }
    }
}
