using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiUnitTests.StubDAL
{
    public class FeedbackStubDAL : IFeedback
    {
        public int Id { get; private set; }
        public string GivenFeedback { get; private set; }
        public List<VraagDTO> Vragen { get; private set; }
        public bool Actief { get; private set; }
        public GebruikerDTO Zender { get; private set; }
        public GebruikerDTO Ontvanger { get; private set; }

        public int GivenId { get; private set; }

        public List<FeedbackDTO> GetMijnFeedback(int id)
        {
            GivenId = id;

            VraagDTO vraag = new VraagDTO()
            {
                Kwestie = "Test Kwestie",
                Antwoord = "Test Antwoord"
            };
            List<VraagDTO> vraagList = new List<VraagDTO>() { vraag };
            ProfielDTO profiel = new ProfielDTO();
            GebruikerDTO gebruiker = new GebruikerDTO()
            {
                ProfielDTO = profiel
            };

            FeedbackDTO feedback1 = new FeedbackDTO()
            {
                Id = 1,
                GivenFeedback = "Test1",
                Vragen = vraagList,
                Actief = true,
                Zender = gebruiker,
                Ontvanger = gebruiker
            };
            FeedbackDTO feedback2 = new FeedbackDTO()
            {
                Id = 2,
                GivenFeedback = "Test2",
                Vragen = vraagList,
                Actief = true,
                Zender = gebruiker,
                Ontvanger = gebruiker
            };
            FeedbackDTO feedback3 = new FeedbackDTO()
            {
                Id = 3,
                GivenFeedback = "Test3",
                Vragen = vraagList,
                Actief = false,
                Zender = gebruiker,
                Ontvanger = gebruiker
            };

            List<FeedbackDTO> feedbackDTOs = new List<FeedbackDTO>() { feedback1, feedback2, feedback3 };
            return feedbackDTOs;
        }
    }
}
