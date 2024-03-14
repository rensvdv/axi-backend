using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer
{
    public class Vragen
    {
        public string Kwestie {  get; private set; }
        public string Antwoord { get; private set; }

        public Vragen(string kwestie, string antwoord)
        {
            Kwestie = kwestie;
            Antwoord = antwoord;
        }
    }
}
