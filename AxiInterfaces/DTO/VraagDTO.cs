﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.DTO
{
    public record VraagDTO
    {
        public string Kwestie { get; init; }
        public string Antwoord { get; init; }
    }
}
