using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
using AxiInterfaces.InterFaces;
using Microsoft.AspNetCore.Mvc;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackAPI/[controller]")]
    public class GebruikerController : ControllerBase
    {
        private readonly ILogger<GebruikerController> _logger;
        private readonly GebruikerContainer gebruikerContainer;
        public GebruikerController(ILogger<GebruikerController> logger)
        {
            gebruikerContainer = new GebruikerContainer(new GebruikerDAL());
            _logger = logger;

        }

        [HttpPost("maakgebruiker")]
        public IActionResult MaakGebruiker([FromBody] Gebruiker gebruiker)
        {
            var result = gebruikerContainer.MaakGebruiker(gebruiker);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("updategebruiker")]
        public IActionResult UpdateGebruiker([FromBody] Gebruiker gebruiker)
        {
            var result = gebruikerContainer.UpdateGebruiker(gebruiker);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijdergebruiker")]
        public IActionResult VerwijderGebruiker([FromBody] Gebruiker gebruiker)
        {
            var result = gebruikerContainer.VerwijderGebruiker(gebruiker);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("geefgebruikerteamprofiel/{profielId}/{gebruikerId}/{teamId}")]
        public IActionResult GeefGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            var result = gebruikerContainer.GeefGebruikerTeamProfiel(profielId, gebruikerId, teamId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("updategebruikerteamprofiel/{profielId}/{gebruikerId}/{teamId}")]
        public IActionResult UpdateGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            var result = gebruikerContainer.UpdateGebruikerTeamProfiel(profielId, gebruikerId, teamId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijdergebruikerteamprofiel/{profielId}/{gebruikerId}/{teamId}")]
        public IActionResult VerwijderGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            var result = gebruikerContainer.VerwijderGebruikerTeamProfiel(profielId, gebruikerId, teamId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("geefgebruikerrecht/{rechtId}/{gebruikerId}")]
        public IActionResult GeefGebruikerRecht(int rechtId, int gebruikerId)
        {
            var result = gebruikerContainer.GeefGebruikerRecht(rechtId, gebruikerId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijdergebruikerrecht/{rechtId}/{gebruikerId}")]
        public IActionResult VerwijderGebruikerRecht(int rechtId, int gebruikerId)
        {
            var result = gebruikerContainer.VerwijderGebruikerRecht(rechtId, gebruikerId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("getallgebruikers")]
        public List<Gebruiker> GetAllGebruikers()
        {
            return gebruikerContainer.GetAllGebruikers();
        }

        [HttpGet("getgebruiker/{gebruikerid}")]
        public Gebruiker GetGebruiker(int gebruikerid)
        {
            return gebruikerContainer.GetGebruiker(gebruikerid);
        }
    }
}
