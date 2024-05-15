using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.DTO;

namespace AxiInterfaces.InterFaces
{
    public interface IVraag
    {
        public bool CreateVraag(VraagDTO vraagDTO);
        public List<VraagDTO> GetVragen(int lijstId);
    }
}
