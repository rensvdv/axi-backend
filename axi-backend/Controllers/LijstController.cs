using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Objecten;
using AxiDal;
using Microsoft.AspNetCore.Mvc;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackAPI/[controller]")]
    public class LijstController : ControllerBase
    {
        private readonly ILogger<LijstController> _logger;
        private readonly LijstContainer lijstContainer;
        public LijstController(ILogger<LijstController> logger)
        {
            lijstContainer = new (new LijstDAL());
            _logger = logger;
        }
        [HttpGet]
        public List<Lijst>GetLijst(int teamId)
        {
            return lijstContainer.GetLijstenByTeamId(teamId);
        }
    }
}
