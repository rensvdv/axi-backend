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

        [HttpGet("{userid}", Name = "GetMijnFeedback")]
        public List<Feedback> GetMijnFeedback(int id)
        {
            return _container.GetMijnFeedback(id); 
            //Mock return
            /*new List<Feedback> { new Feedback(1, "hi", null, true, null, null) };*/
        }
    }
}

