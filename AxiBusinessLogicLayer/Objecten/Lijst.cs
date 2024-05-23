using AxiBusinessLogicLayer.Entiteiten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Objecten
{
    public class Lijst
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Vraag> Vragen {  get; set; }
        public Lijst(int id, string name, List<Vraag> vragen)
        {
            Id = id;
            Name = name;
            Vragen = vragen;
        }

        public Lijst() 
        { 
            //
        }
    }
}
