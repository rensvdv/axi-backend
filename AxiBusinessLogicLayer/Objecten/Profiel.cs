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
        int Id { get; set; }
        string ProfielNaam { get; set; }
        List<Recht> Rechten { get; set; }

        public Profiel(int id, string profielNaam, List<Recht> rechten)
        {
            Id = id;
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
