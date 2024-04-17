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
            _container = new FeedbackContainer(new FeedbackDAL(), new GebruikerDAL());
            _logger = logger;

        }

        [HttpGet("getmijnfeedback/{feedbackid}")]
        public List<Feedback> GetMijnFeedback(int feedbackid)
        {
            return _container.GetMijnFeedback(feedbackid);
            //Mock return
            //return new List<Feedback> { new Feedback(1, "hi", null, true, null, null) };
        }

        [HttpPost("maakfeedback")]
        public IActionResult MaakFeedback([FromBody] Feedback feedback)
        {
            var result = _container.MaakFeedback(feedback);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet("getgroepfeedback/{groepid}")]
        public List<Feedback> GetGroepFeedback(int groepid)
        {
            return _container.GetGroepFeedbackAll(groepid);
            //Mock Return
            /*return new List<Feedback> { new Feedback(1, "Dit is mijn feedback", true, new Gebruiker(){Id = 1, Naam = "Zender 1"}, new Gebruiker(){Id = 2, Naam = "Ontvanger 1"}),
                 new Feedback(2, "En dit is mijn feedback", true, new Gebruiker(){Id = 3, Naam = "Zender 2"}, new Gebruiker(){Id = 5, Naam = "Ontvanger 2"}),
                 new Feedback(3, "Vergeet mijn feedback niet!", true, new Gebruiker(){Id = 4, Naam = "Zender 3"}, new Gebruiker(){Id = 6, Naam = "Ontvanger 3"}) }; */
        }

        [HttpPut("updatefeedback")]
        public IActionResult UpdateFeedback([FromBody] Feedback feedback)
        {
            bool result = _container.UpdateFeedback(feedback);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}

