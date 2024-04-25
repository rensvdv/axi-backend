using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Objecten
{
    public class Antwoord
    {
        public int Id { get; set; }
        public string Reactie { get; set; }
        public Vraag Vraag { get; set; }
        public Feedback Feedback { get; set; }

        public Antwoord(int id, string reactie, Vraag vraag, Feedback feedback)
        {
            Id = id;
            Reactie = reactie;
            Vraag = vraag;
            Feedback = feedback;
        }

        public Antwoord() 
        {
            //
        }
    }
}
