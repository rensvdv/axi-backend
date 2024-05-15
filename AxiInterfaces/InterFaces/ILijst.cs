using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.InterFaces
{
    public interface ILijst
    {
        public List<LijstDTO> GetLijstenByTeamId(int teamId);
        public LijstDTO GetLijst(int id);
    }
}
