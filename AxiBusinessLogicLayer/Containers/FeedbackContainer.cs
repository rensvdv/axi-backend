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

        public (string, List<Feedback>) GetMijnFeedback(int id)
        {
            (string e, List<FeedbackDTO> feedbackDTOs) = FeedbackDAL.GetMijnFeedback(id);


            //return (e, feedback);
            throw new NotImplementedException();
        }

        public List<Feedback> GetGroupFeedback(int groepId)
        {
            return new List<Feedback>();

        }
    }
}
