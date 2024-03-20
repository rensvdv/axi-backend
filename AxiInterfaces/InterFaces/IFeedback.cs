using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.InterFaces
{
    public interface IFeedback
    {
        public (string, List<FeedbackDTO>) GetMijnFeedback(int id);
        public List<FeedbackDTO> GetGroupFeedback(int groepId);
    }
}
