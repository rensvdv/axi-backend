using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record FeedbackDTO
    {
        public int Id { get; init; }
        public string GivenFeedback { get; init; }
        public List<VraagDTO> Vragen { get; init; }
        public bool Actief { get; init; }
        public GebruikerDTO Zender { get; init; }
        public GebruikerDTO Ontvanger { get; init; }
    }
}
