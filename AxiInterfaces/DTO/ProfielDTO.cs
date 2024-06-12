using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("Profiel")]
    public record ProfielDTO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProfielId")]
        public int ProfielId { get; init; }
        [Column("Naam")]
        public string Naam { get; init; }
    }
}
