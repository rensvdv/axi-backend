using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("Team")]
    public class TeamDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
