using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("ProfielRechten")]
    public record ProfielRechtenDTO
    {
        [Column("ProfielId")]
        public int ProfielId { get; init; }
        [Column("RechtId")]
        public int RechtId { get; init; }
    }
}
