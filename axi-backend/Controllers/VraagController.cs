using Microsoft.AspNetCore.Mvc;
using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackAPI/[controller]")]
    public class VraagController : ControllerBase
    {
        private readonly ILogger<VraagController> _logger;
        private readonly VraagContainer _container;
        public VraagController(ILogger<VraagController> logger)
        {
            _container = new VraagContainer(new VraagDAL());
            _logger = logger;
        }

        [HttpGet("GetVragenByLijstId/{LijstId}")]
        public List<Vraag> GetVragenLijst(int LijstId)
        {
            return _container.GetVragenLijst(LijstId);
        }

        [HttpPost("CreateVraag")]
        public bool CreateVraag([FromBody] Vraag Vraag)
        {
            return _container.CreateVraag(Vraag);
        }
    }
}
