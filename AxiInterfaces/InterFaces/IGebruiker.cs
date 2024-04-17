using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.InterFaces
{
    public interface IGebruiker
    {
        public GebruikerDTO GetUserById(int Id);
    }
}
