using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record GebruikerDTO
    {
        public int Id { get; init; }
        public ProfielDTO ProfielDTO { get; init; }
    }
}
