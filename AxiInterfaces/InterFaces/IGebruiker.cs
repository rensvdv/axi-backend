using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.InterFaces
{
    public interface IGebruiker
    {
        public bool MaakGebruiker(GebruikerDTO gebruikerDTO);
        public bool UpdateGebruiker(GebruikerDTO gebruikerDTO);
        public bool VerwijderGebruiker(GebruikerDTO gebruikerDTO);
        public GebruikerDTO GetUserById(int Id); 
        public List<GebruikerDTO> GetAll();
        public bool GeefGebruikerTeamProfiel(GebruikerTeamProfielDTO dto);
        public bool UpdateGebruikerTeamProfiel(GebruikerTeamProfielDTO dto);
        public bool VerwijderGebruikerTeamProfiel(GebruikerTeamProfielDTO dto);
        public bool GeefGebruikerRecht(GebruikerRechtenDTO dto);
        public bool VerwijderGebruikerRecht(GebruikerRechtenDTO dto);
    }
}
