using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class ProfielContainer
    {
        private IProfiel ProfielDAL;

        public ProfielContainer(IProfiel profielDAL)
        {
            ProfielDAL = profielDAL;
        }

    }
}
