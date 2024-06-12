using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Objecten
{
    public class Recht
    {
        public int Id { get; set; }
        public string RechtNaam { get; set; }

        public Recht(int id, string rechtNaam)
        {
            Id = id;
            RechtNaam = rechtNaam;
        }

        public Recht(string rechtNaam)
        {
            RechtNaam = rechtNaam;
        }

        public Recht()
        {
            //
        }
    }
}
