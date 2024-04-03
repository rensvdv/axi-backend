using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
using Microsoft.AspNetCore.Mvc;

namespace axi_backend.Controllers
{
    [ApiController]
    [Route("feedbackAPI/[controller]")]
    public class FeedbackController : ControllerBase
    {
        private readonly ILogger<FeedbackController> _logger;
        private readonly FeedbackContainer _container;
        public FeedbackController(ILogger<FeedbackController> logger)
        {
            _container = new FeedbackContainer(new FeedbackDAL());
            _logger = logger;

        }

        [HttpGet("{feedbackid}", Name = "GetMijnFeedback")]
        public List<Feedback> GetMijnFeedback(int id)
        {
            return _container.GetMijnFeedback(id); 
            
            //Mock return
            /* return new List<Feedback> {
                new Feedback(1, "feedback van gebruiker 4 over gebruiker 1", null, true, new Gebruiker(new Profiel()) {Id = 4, Naam = "Gebruiker 4"}, new Gebruiker(new Profiel()) {Id = 1, Naam = "Gebruiker 1" }),
                new Feedback(2, "feedback van gebruiker 3 over gebruiker 1", null, true, new Gebruiker(new Profiel()) {Id = 3, Naam = "Gebruiker 3"}, new Gebruiker(new Profiel()) {Id = 1, Naam = "Gebruiker 1" }),
                new Feedback(3, "feedback van gebruiker 2 over gebruiker 1", null, true, new Gebruiker(new Profiel()) {Id = 2, Naam = "Gebruiker 2"}, new Gebruiker(new Profiel()) {Id = 1, Naam = "Gebruiker 1" }),

                };*/
        }
    }
}

