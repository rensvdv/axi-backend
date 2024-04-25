using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
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

        [HttpGet]
        public List<Gebruiker> GetMijnFeedback()
        {
            return gebruikerContainer.GetAllGebruikers();
        }


    }
}
