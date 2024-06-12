using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        public bool Actief { get; set; }
        public List<Gebruiker> Teamleden { get; set; }

        public Team(int teamId, string naam, string beschrijving, bool actief, List<Gebruiker> teamleden)
        {
            TeamId = teamId;
            Naam = naam;
            Beschrijving = beschrijving;
            Actief = actief;
            Teamleden = teamleden;
        }

        public Team(string naam, string beschrijving, bool actief, List<Gebruiker> teamleden)
        {
            Naam = naam;
            Beschrijving = beschrijving;
            Actief = actief;
            Teamleden = teamleden;
        }

        public Team()
        {
            
        }
        
    }
}
