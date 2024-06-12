using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("Feedback")]
    public record FeedbackDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FeedbackId")]
        public int Id { get; init; }
        [Column("GegevenFeedback")]
        public string GivenFeedback { get; init; }
        //public List<VraagDTO> Vragen { get; init; }
        [Column("Actief")]
        public bool Actief { get; init; }
        [Column("VerzenderId")]
        public int VerzenderId { get; init; }
        [Column("OntvangerId")]
        public int OntvangerId { get; init; }
    }
}
