using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Gebruiker
    {
        public Profiel Profiel { get; private set; }
        public int Id { get; set; }

        public string Naam { get; set; }

        public Gebruiker(Profiel profiel)
        {
            Profiel = profiel;
        }

        public Gebruiker(GebruikerDTO gebruikerDTO)
        {
            ProfielDTO profielDTO = gebruikerDTO.ProfielDTO;
            Profiel = new Profiel(profielDTO);
        }

        public GebruikerDTO ToDTO(Gebruiker gebruiker)
        {
            Profiel profiel = new Profiel();
            ProfielDTO profielDTO = profiel.ToDTO(gebruiker.Profiel);
            GebruikerDTO gebruikerDTO = new GebruikerDTO()
            {
                ProfielDTO = profielDTO,
            };
            return gebruikerDTO;
        }
    }
}
