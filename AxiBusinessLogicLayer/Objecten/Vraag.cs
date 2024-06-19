using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Vraag
    {
        public int Id { get; set; }
        public string? Kwestie { get; set; }

        public Vraag(int id, string kwestie)
        {
            Id = id;
            Kwestie = kwestie;
        }

        public Vraag() { }
        public Vraag(VraagDTO vraagDTO)
        {
            Kwestie = vraagDTO.Kwestie;
            //Antwoord = vraagDTO.Antwoord;
        }

        public VraagDTO ToDTO(Vraag vraag)
        {
            VraagDTO vraagDTO = new VraagDTO()
            {
                Id = this.Id,
                Kwestie = vraag.Kwestie,
                //Antwoord = vraag.Antwoord
            };
            return vraagDTO;
        }
    }
}
