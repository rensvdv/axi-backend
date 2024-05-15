using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("Antwoord")]
    public record AntwoordDTO
    {
        [Column("AntwoordId")]
        public int Id { get; init; }
        [Column("Reactie")]
        public string Reactie { get; init; }
        [Column("VraagId")]
        public int VraagId { get; init; }
        [Column("FeedbackId")]
        public int FeedbackId { get; init; }
    }
}
