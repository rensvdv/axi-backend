using System.Security.Cryptography.X509Certificates;
using AxiBusinessLogicLayer.Objecten;
using AxiDal;
using Microsoft.AspNetCore.Mvc;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackapi/[controller]")]
    public class RechtController : ControllerBase
    {
        private readonly ILogger<RechtController> _logger;
        private readonly RechtContainer rechtContainer;

        public RechtController(ILogger<RechtController> logger)
        {
            rechtContainer = new RechtContainer(new RechtDAL());
            _logger = logger;
        }

        [HttpPost("maakrecht")]
        public IActionResult MaakRecht([FromBody] Recht recht)
        {
            var result = rechtContainer.MaakRecht(recht);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("updaterecht")]
        public IActionResult UpdateRecht([FromBody] Recht recht)
        {
            var result = rechtContainer.UpdateRecht(recht);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijderrecht")]
        public IActionResult VerwijderRecht([FromBody] Recht recht)
        {
            var result = rechtContainer.VerwijderRecht(recht);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("zoekrechten")]
        public List<Recht> ZoekRechten()
        {
            return rechtContainer.ZoekRechten();
        }

        [HttpGet("zoekprofielrechten/{profielId}")]
        public List<Recht> ZoekProfielRechten(int profielId)
        {
            return rechtContainer.ZoekProfielRechten(profielId);
        }

        [HttpGet("zoekgebruikerrechten/{gebruikerId}")]
        public List<Recht> ZoekGebruikerRechten(int gebruikerid)
        {
            return rechtContainer.ZoekGebruikerRechten(gebruikerid);
        }

        [HttpGet("zoekrecht/{rechtId}")]
        public Recht ZoekRecht(int rechtId)
        {
            return rechtContainer.ZoekRecht(rechtId);
        }
    }
}
