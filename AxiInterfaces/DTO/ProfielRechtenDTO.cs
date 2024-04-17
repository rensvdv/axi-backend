using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record ProfielRechtenDTO
    {
        public int ProfielId { get; init; }
        public int RechtId { get; init; }
    }
}
