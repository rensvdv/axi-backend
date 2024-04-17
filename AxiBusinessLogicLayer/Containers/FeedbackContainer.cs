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
        IGebruiker GebruikerDAL;

        public FeedbackContainer(IFeedback DAL, IGebruiker GebruikerDAL)
        {
            FeedbackDAL = DAL;
            GebruikerDAL = GebruikerDAL;
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
                FeedbackDTO feedbackDTO = ToDTO(feedback);
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
                    return result;
                }
                FeedbackDTO feedbackDTO = ToDTO(feedback);
                result = FeedbackDAL.UpdateFeedback(feedbackDTO);

                return result;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Archiveren(Feedback feedback)
        {
            bool result = false;
            try
            {
                FeedbackDTO feedbackDTO = feedback.ToDTO(feedback);
                result = FeedbackDAL.Archiveer(feedbackDTO);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return result;
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
                    Feedback feedback = ToFeedback(feedbackDTO);
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
                return FeedbackDAL.GetGroepFeedbackAll(groepId).Select(feedback => ToFeedback(feedback)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }

        }

        public Feedback ToFeedback(FeedbackDTO feedbackDTO)
        {
            GebruikerContainer gebruikerContainer = new GebruikerContainer();

            Feedback feedback = new Feedback(
                feedbackDTO.Id,
                feedbackDTO.GivenFeedback,
                feedbackDTO.Actief,
                gebruikerContainer.ToGebruiker(GebruikerDAL.GetUserById(feedbackDTO.VerzenderId)),
                gebruikerContainer.ToGebruiker(GebruikerDAL.GetUserById(feedbackDTO.OntvangerId)));
            return feedback;
        }

        public FeedbackDTO ToDTO(Feedback feedback)
        {
            FeedbackDTO feedbackDTO = new FeedbackDTO()
            {
                Id = feedback.Id,
                GivenFeedback = feedback.GivenFeedback,
                Actief = feedback.Actief,
                VerzenderId = feedback.Zender.Id,
                OntvangerId = feedback.Ontvanger.Id
            };
            return feedbackDTO;
        }
    }
}
