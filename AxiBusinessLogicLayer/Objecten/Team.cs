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
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public List<Gebruiker> Teamleden { get; private set; }

        public Team(int id, string naam, List<Gebruiker> teamleden)
        {
            Id = id;
            Naam = naam;
            Teamleden = teamleden;
        }

        public Team(TeamDTO teamDTO)
        {
            Naam = teamDTO.Naam;
            if(teamDTO.Teamleden != null)
            {
                Teamleden = teamDTO.Teamleden.Select(teamlid => new Gebruiker(teamlid)).ToList();
            }
        }

        public TeamDTO ToDTO()
        {
            if (Teamleden != null)
            {
                return new(Id, Naam, Teamleden.Select(teamlid => teamlid.ToDTO(teamlid)).ToList());
            }
            else
            {
                return new(Id, Naam, null);
            }
        }
    }
}
