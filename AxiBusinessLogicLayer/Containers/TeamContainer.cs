using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class TeamContainer
    {
        ITeam TeamDAL;
        public TeamContainer(ITeam teamDAL)
        {
            TeamDAL = teamDAL;
        }
    }
}
