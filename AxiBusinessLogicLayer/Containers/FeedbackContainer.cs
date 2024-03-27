using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Containers
{
    public class FeedbackContainer
    {
        IFeedback FeedbackDAL;

        public FeedbackContainer(IFeedback DAL)
        {
            FeedbackDAL = DAL;
        }

        public bool MaakFeedback(Feedback feedback)
        {
            bool result = false;
            FeedbackDTO feedbackDTO = feedback.ToDTO(feedback);
            result = FeedbackDAL.MaakFeedback(feedbackDTO);
            
            return result;
        }

        public string UpdateFeedback(Feedback feedback)
        {
            string e = "";
            return e;
        }

        public string OntzichtbaarMaken(Feedback feedback)
        {
            string e = "";
            return e;
        }

        public string Archiveren(Feedback feedback)
        {
            string e = "";
            return e;
        }

        public List<Feedback> GetMijnFeedback(int id)
        {
            List<Feedback> feedbacks = new List<Feedback>();

            try
            {
                List<FeedbackDTO> feedbackDTOs = FeedbackDAL.GetMijnFeedback(id);
                foreach(FeedbackDTO feedbackDTO in feedbackDTOs)
                {
                    Feedback feedback = new Feedback(feedbackDTO);
                    feedbacks.Add(feedback);
                }
                return feedbacks;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }

        public List<Feedback> GetGroupFeedbackAll(int groepId)
        {
            try
            {
                return FeedbackDAL.GetGroupFeedbackAll(groepId).Select(feedback => new Feedback(feedback)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }

        }
    }
}
