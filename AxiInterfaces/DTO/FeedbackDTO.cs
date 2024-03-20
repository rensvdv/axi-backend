using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record FeedbackDTO
    {
        public int Id { get; private set; }
        public string GivenFeedback { get; private set; }
        public List<VraagDTO> Vragen { get; private set; }
        public bool Actief { get; private set; }
        public GebruikerDTO Zender { get; private set; }
        public GebruikerDTO Ontvanger { get; private set; }
    }
}
