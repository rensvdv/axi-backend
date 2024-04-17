using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record VraagLijstDTO
    {
        public int VraagId { get; init; }
        public int LijstId { get; init; }
    }
}
