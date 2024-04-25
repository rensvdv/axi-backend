using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class AntwoordContainer
    {
        IAntwoord AntwoordDAL;

        public AntwoordContainer (IAntwoord antwoordDAL)
        {
            AntwoordDAL = antwoordDAL;
        }
    }
}
