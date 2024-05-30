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
        bool BewerkProfiel(ProfielDTO dto);
        bool MaakProfiel(ProfielDTO dto);
        bool VerwijderProfiel(ProfielDTO dto);
        List<ProfielDTO> ZoekGebruikerProfielen(int gebruikerid);
        List<ProfielDTO> ZoekProfielen();
        ProfielDTO ZoekProfiel(int id);
        
    }
}
