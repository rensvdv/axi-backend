using AxiBusinessLogicLayer.Entiteiten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class VraagContainer
    {
        IVraag VraagDAL;
        public VraagContainer(IVraag vraagDAL)
        {
            VraagDAL = vraagDAL;
        }

        public string CreateVraag(Vraag vraag)
        {
            string e = "";
            return e;
        }

        public string UpdateVraag(Vraag vraag)
        {
            string e = "";
            return e;
        }
        public string DeleteVraag(Vraag vraag)
        {
            string e = "";
            return e;
        }

        public List<Vraag> GetVragen()
        {
            return new List<Vraag>();
        }
    }
}
