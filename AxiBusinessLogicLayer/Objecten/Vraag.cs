using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Vraag
    {
        public string Kwestie { get; private set; }
        public string Antwoord { get; private set; }

        public Vraag(string kwestie, string antwoord)
        {
            Kwestie = kwestie;
            Antwoord = antwoord;
        }
    }
}
