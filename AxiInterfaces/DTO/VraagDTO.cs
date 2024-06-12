using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("Vraag")]
    public record VraagDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("VraagId")]
        public int Id { get; init; }
        [Column("Kwestie")]
        public string Kwestie { get; init; }
    }
}
