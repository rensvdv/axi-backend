using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public class TeamDTO
    {
        public int Id { get; init; }
        public string Naam { get; init; }
        public string Beschrijving { get; init; }

        public TeamDTO(int id, string naam, string beschrijving)
        {
            Id = id;
            Naam = naam;
            Beschrijving = beschrijving;
        }
    }
}
