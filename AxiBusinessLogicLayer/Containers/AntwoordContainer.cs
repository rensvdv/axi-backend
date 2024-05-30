using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.InterFaces;
using AxiInterfaces.DTO;
using AxiBusinessLogicLayer.Objecten;

namespace AxiBusinessLogicLayer.Containers
{
    public class AntwoordContainer
    {
        IAntwoord AntwoordDAL;

        public AntwoordContainer (IAntwoord antwoordDAL)
        {
            AntwoordDAL = antwoordDAL;
        }

        public AntwoordDTO toDTO(Antwoord antwoord)
        {
            return new()
            {
                Id = antwoord.Id,
                Reactie = antwoord.Reactie,
                VraagId = antwoord.Vraag.Id,
                FeedbackId = antwoord.Feedback.Id
            };
        }

        public bool BeantwoordVraag(Antwoord antwoord)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(antwoord.Reactie))
                {
                    return false;
                }
                else
                {
                    return AntwoordDAL.MaakAntwoord(toDTO(antwoord));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return false;
            }
        }
    }
}
