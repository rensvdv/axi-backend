using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.InterFaces
{
    public interface IProfiel
    {
        bool MaakProfiel(ProfielDTO dto, List<RechtDTO> rechten);
        bool BewerkProfiel(ProfielDTO dto, List<ProfielRechtenDTO> rechten);
        bool VerwijderProfiel(ProfielDTO dto);
        List<ProfielDTO> ZoekGebruikerProfielen(int gebruikerid);
        List<ProfielDTO> ZoekProfielen();
        ProfielDTO ZoekProfiel(int id);
        
    }
}
