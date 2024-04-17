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
            /*return new List<Feedback> { new Feedback(1, "hi", null, true, null, null),
                 new Feedback(2, "ho", null, true, null, null),
                 new Feedback(3, "ha", null, true, null, null) }; */
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

