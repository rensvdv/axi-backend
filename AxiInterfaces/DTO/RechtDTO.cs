using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record RechtDTO
    {
        public int Id { get; init; }
        public string Rechtnaam { get; init; }
    }
}
