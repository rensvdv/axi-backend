using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Gebruiker
    {
        //public Profiel Profiel { get; private set; }
        public int Id { get; set; }
        public string? Naam { get; set; }

        [JsonIgnore] //Tijdelijke oplossing voor feedback maken
        public string? Email { get; set; }

        [JsonIgnore] //Tijdelijke oplossing voor feedback maken
        public string? Password { get; set; }
        public bool Actief { get; set; }

        public Gebruiker()
        {

        }

        public Gebruiker(int id, string naam, string email, string password, bool actief)
        { 
            Id = id;
            Naam = naam;
            Email = email;
            Password = password;
            Actief = actief;
        }

        public Gebruiker(GebruikerDTO gebruikerDTO)
        {
            //ProfielDTO profielDTO = gebruikerDTO;
            //Profiel = new Profiel(profielDTO);
            Id = gebruikerDTO.Id;
            Naam = gebruikerDTO.Name;
            Email = gebruikerDTO.Email;
            Password = gebruikerDTO.Password;
            Actief = gebruikerDTO.Actief;

        }

        public Gebruiker()
        {
            //
        }
    }
}
