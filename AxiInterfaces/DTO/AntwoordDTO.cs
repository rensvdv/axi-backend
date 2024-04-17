using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record AntwoordDTO
    {
        public int Id { get; init; }
        public string Reactie { get; init; }
        public int VraagId { get; init; }
        public int FeedbackId { get; init; }
    }
}
