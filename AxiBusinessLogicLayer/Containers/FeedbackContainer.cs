using AxiBusinessLogicLayer.Entiteiten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Containers
{
    public class FeedbackContainer
    {
        public FeedbackContainer()
        {
            
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
            return new List<Feedback>();
        }

        public List<Feedback> GetGroupFeedback(int groepId)
        {
            return new List<Feedback>();

        }
    }
}
