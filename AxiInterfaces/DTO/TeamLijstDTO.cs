using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("TeamLijst")]
    public record TeamLijstDTO
    {
        [ForeignKey("TeamId")]
        public int TeamId { get; set; }
        [ForeignKey("LijstId")]
        public int LijstId { get; set; }
    }
}
