﻿using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiDal
{
    public class FeedbackDAL : IFeedback
    {
        public List<FeedbackDTO> GetGroupFeedback(int groepId)
        {
            throw new NotImplementedException();
        }

        public (string, List<FeedbackDTO>) GetMijnFeedback(int id)
        {
            throw new NotImplementedException();
        }
    }
}
