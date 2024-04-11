using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("GebruikerTeamProfiel")]
    public record GebruikerTeamProfielDTO
    {
        [Column("GebruikerId")]
        public int GebruikerId { get; init; }
        [Column("TeamId")]
        public int TeamId { get; init; }
        [Column("ProfielId")]
        public int ProfielId { get; init; }
    }
}
