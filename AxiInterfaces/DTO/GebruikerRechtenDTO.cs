using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record GebruikerRechtenDTO
    {
        [Column("GebruikerId")]
        public int GebruikerId { get; init; }
        [Column("RechtId")]
        public int RechtId { get; init; }
    }
}
