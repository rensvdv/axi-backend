using Microsoft.AspNetCore.Mvc;
using AxiBusinessLogicLayer.Containers;
using AxiDal;
using AxiBusinessLogicLayer.Objecten;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackAPI/[controller]")]
    public class AntwoordController : ControllerBase
    {
        private readonly ILogger<AntwoordController> _logger;
        private readonly AntwoordContainer _container;
        public AntwoordController(ILogger<AntwoordController> logger)
        {
            _container = new AntwoordContainer(new AntwoordDAL());
            _logger = logger;
        }

        [HttpPost("maakantwoord")]
        public IActionResult MaakAntwoord([FromBody] Antwoord antwoord)
        {
            var result = _container.BeantwoordVraag(antwoord);
            return result ? Ok(result) : BadRequest();
        }
    }
}
