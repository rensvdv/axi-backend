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
            try
            {
                bool result = false;

                if (string.IsNullOrEmpty(feedback.GivenFeedback))
                {
                    return false;
                }
                FeedbackDTO feedbackDTO = feedback.ToDTO(feedback);
                result = FeedbackDAL.MaakFeedback(feedbackDTO);

                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public bool UpdateFeedback(Feedback feedback)
        {
            try
            {
                bool result = false;

                if (string.IsNullOrEmpty(feedback.GivenFeedback))
                {
                    return false;
                }
                FeedbackDTO feedbackDTO = feedback.ToDTO(feedback);
                result = FeedbackDAL.UpdateFeedback(feedbackDTO);

                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public string OntzichtbaarMaken(Feedback feedback)
        {
            string e = "";
            return e;
        }

        public bool Archiveren(Feedback feedback)
        {

            try
            {
                bool result = false;
                FeedbackDTO feedbackDTO = feedback.ToDTO(feedback);
                result = FeedbackDAL.
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
            

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

        public List<Feedback> GetGroepFeedbackAll(int groepId)
        {
            try
            {
                return FeedbackDAL.GetGroepFeedbackAll(groepId).Select(feedback => new Feedback(feedback)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }

        }
    }
}
