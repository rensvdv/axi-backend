using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.DTO;

namespace AxiInterfaces.InterFaces
{
    public interface IRecht
    {
        public bool MaakRecht(RechtDTO dto);
    }
}
