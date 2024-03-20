using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Profiel
    {
        public Profiel()
        {
            
        }

        public Profiel(ProfielDTO profielDTO)
        {
            
        }

        public ProfielDTO ToDTO(Profiel profiel)
        {
            return new ProfielDTO();
        }
    }
}
