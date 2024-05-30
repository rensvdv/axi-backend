using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record ProfielDTO
    {
        [Column("ProfielId")]
        public int Id { get; init; }
        [Column("Naam")]
        public string Naam { get; init; }
    }
}
