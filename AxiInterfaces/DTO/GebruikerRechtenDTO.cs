using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record GebruikerRechtenDTO
    {
        public int GebruikerId { get; init; }
        public int RechtenId { get; init; }
    }
}
