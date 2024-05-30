using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiBusinessLogicLayer.Objecten;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Profiel
    {
        public int ProfielId { get; set; }
        public string ProfielNaam { get; set; }
        public List<Recht> Rechten { get; set; }

        public Profiel(int profielId, string profielNaam, List<Recht> rechten)
        {
            ProfielId = profielId;
            ProfielNaam = profielNaam;
            Rechten = rechten;
        }

        public Profiel(string profielNaam, List<Recht> rechten)
        {
            ProfielNaam = profielNaam;
            Rechten = rechten;
        }

        public Profiel()
        {
            //
        }
    }
}
