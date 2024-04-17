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
        public string Name { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }
        public bool Actief { get; init; }
        //public ProfielDTO ProfielDTO { get; init; }
    }
}
