using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
using AxiInterfaces.InterFaces;
using Microsoft.AspNetCore.Mvc;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackAPI/[controller]")]
    public class TeamController: ControllerBase
    {
        private readonly ILogger<TeamController> Logger;
        private readonly TeamContainer Container;

        public TeamController(ILogger<TeamController> logger, TeamContainer container)
        {
            Logger = logger;
            Container = new TeamContainer(new TeamDAL(), new GebruikerDAL());
        }

        [HttpPost("maakteam")]
        public IActionResult MaakTeam([FromBody] Team team)
        {
            var result = Container.MaakTeam(team);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("werkteambij")]
        public IActionResult WerkTeamBij([FromBody] Team team)
        {
            var result = Container.WerkTeamBij(team);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijderteam")]
        public IActionResult VerwijderTeam([FromBody] Team team)
        {
            var result = Container.VerwijderTeam(team);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost("voeggebruikeraanteamtoe/{teamId}/{gebruikerId}")]
        public IActionResult VoegGebruikerAanTeamToe(int teamId, int gebruikerId)
        {
            var result = Container.VoegGebruikerAanTeamToe(teamId, gebruikerId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("verwijdergebruikeruitteam/{teamId}/{gebruikerId}")]
        public IActionResult VerwijderGebruikerUitTeam(int teamId, int gebruikerId)
        {
            var result = Container.VerwijderGebruikerUitTeam(teamId, gebruikerId);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("getteams")]
        public List<Team> GetTeams()
        {
            return Container.GetTeams();
        }

        [HttpGet("getteam/{teamId}")]
        public Team GetTeam(int teamId)
        {
            return Container.GetTeam(teamId);
        }
    }
}
