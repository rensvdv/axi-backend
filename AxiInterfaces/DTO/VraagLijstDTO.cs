﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    [Table("VraagLijst")]
    public record VraagLijstDTO
    {
        [Column("VraagId")]
        public int VraagId { get; init; }
        [Column("LijstId")]
        public int LijstId { get; init; }
    }
}
