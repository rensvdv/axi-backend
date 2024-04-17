using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Containers
{
    public class GebruikerContainer
    {
        public Gebruiker ToGebruiker(GebruikerDTO gebruikerDTO)
        {
            Gebruiker gebruiker = new Gebruiker(
                gebruikerDTO.Id,
                gebruikerDTO.Name,
                gebruikerDTO.Email,
                gebruikerDTO.Password,
                gebruikerDTO.Actief);
            return gebruiker;
        }

        public GebruikerDTO ToDTO(Gebruiker gebruiker)
        {
            GebruikerDTO gebruikerDTO = new GebruikerDTO()
            {
                Id = gebruiker.Id,
                Name = gebruiker.Naam,
                Email = gebruiker.Email,
                Password = gebruiker.Password,
                Actief = gebruiker.Actief
            };
            return gebruikerDTO;
        }
    }
}
