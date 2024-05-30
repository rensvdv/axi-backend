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
        public bool UpdateRecht(RechtDTO dto);
        public bool VerwijderRecht(RechtDTO dto);
        public List<RechtDTO> ZoekRechten();
        public List<RechtDTO> ZoekProfielRechten(int profielId);
        public List<RechtDTO> ZoekgebruikerRechten(int gebruikerId);
        public RechtDTO ZoekRecht(int rechtId);
    }
}
