using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record TeamDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("teamId")]
        public int TeamId { get; init; }
        [Column("naam")]
        public string Naam { get; init; }
        [Column("beschrijving")]
        public string Beschrijving { get; init; }
        [Column("actief")]
        public bool Actief { get; init; }
    }
}
