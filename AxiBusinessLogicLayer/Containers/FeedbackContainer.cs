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

        public string CreateFeedback(Feedback feedback)
        {
            string e = "";
            return e;
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
            (string e, List<FeedbackDTO> feedbackDTOs) = FeedbackDAL.GetMijnFeedback(id);


            //return (e, feedback);
            throw new NotImplementedException();
        }

        public List<Feedback> GetGroupFeedback(int groepId)
        {
            try
            {
                return FeedbackDAL.GetGroupFeedback(groepId).Select(feedback => new Feedback(feedback)).ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
