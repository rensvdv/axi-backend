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
        public int Id { get; set; }
        public string GivenFeedback { get; set; }
        public bool Actief { get; set; }
        public int Zender { get; set; }
        public int Ontvanger { get; set; }

        public int GivenId { get; set; }

        public List<FeedbackDTO> GetGroepFeedbackAll(int groepId)
        {
            GivenId = groepId;

            GebruikerDTO gebruiker = new GebruikerDTO()
            {
                Id = 1,
                Name = "MAAAAAAAAAAAAAAAAAAAAAAAAAAMWAWOWOWOW",
                Email = "SNOEP@PINGAS.com",
                Password = "Mamamia",
                Actief = true
            };

            FeedbackDTO feedback1 = new FeedbackDTO()
            {
                Id = 1,
                GivenFeedback = "Test1",
                Actief = true,
                VerzenderId = gebruiker.Id,
                OntvangerId = gebruiker.Id
            };
            FeedbackDTO feedback2 = new FeedbackDTO()
            {
                Id = 2,
                GivenFeedback = "Test2",
                Actief = true,
                VerzenderId = gebruiker.Id,
                OntvangerId = gebruiker.Id
            };
            FeedbackDTO feedback3 = new FeedbackDTO()
            {
                Id = 3,
                GivenFeedback = "Test3",
                Actief = false,
                VerzenderId = gebruiker.Id,
                OntvangerId = gebruiker.Id
            };

            List<FeedbackDTO> feedbackDTOs = new List<FeedbackDTO>() { feedback1, feedback2, feedback3 };
            return feedbackDTOs;
        }

        public List<FeedbackDTO> GetMijnFeedback(int id)
        {
            GivenId = id;

            GebruikerDTO gebruiker = new GebruikerDTO()
            {
                Id = 1,
                Name = "Test naam",
                Email = "Test@Naam.com",
                Password = "Password",
                Actief = true
            };

            FeedbackDTO feedback1 = new FeedbackDTO()
            {
                Id = 1,
                GivenFeedback = "Test1",
                Actief = true,
                VerzenderId = gebruiker.Id,
                OntvangerId = gebruiker.Id
            };
            FeedbackDTO feedback2 = new FeedbackDTO()
            {
                Id = 2,
                GivenFeedback = "Test2",
                Actief = true,
                VerzenderId = gebruiker.Id,
                OntvangerId = gebruiker.Id
            };
            FeedbackDTO feedback3 = new FeedbackDTO()
            {
                Id = 3,
                GivenFeedback = "Test3",
                Actief = false,
                VerzenderId = gebruiker.Id,
                OntvangerId = gebruiker.Id
            };

            List<FeedbackDTO> feedbackDTOs = new List<FeedbackDTO>() { feedback1, feedback2, feedback3 };
            return feedbackDTOs;
        }

        public bool MaakFeedback(FeedbackDTO feedbackDTO)
        {
            Id = feedbackDTO.Id;
            GivenFeedback = feedbackDTO.GivenFeedback;
            Actief = feedbackDTO.Actief;
            Zender = feedbackDTO.VerzenderId;
            Ontvanger = feedbackDTO.OntvangerId;

            return true;
        }

        public bool UpdateFeedback(FeedbackDTO feedbackDTO)
        {
            Id = feedbackDTO.Id;
            GivenFeedback = feedbackDTO.GivenFeedback;
            Actief = feedbackDTO.Actief;
            Zender = feedbackDTO.VerzenderId;
            Ontvanger = feedbackDTO.OntvangerId;

            return true;
        }

        public bool Archiveer(FeedbackDTO feedbackDTO)
        {
            Id = feedbackDTO.Id;
            GivenFeedback = feedbackDTO.GivenFeedback;
            Actief = false;
            Zender = feedbackDTO.VerzenderId;
            Ontvanger = feedbackDTO.OntvangerId;
            return true;
        }

        public List<FeedbackDTO> GetZenderFeedback(int id)
        {
            GivenId = id;

            GebruikerDTO gebruiker1 = new GebruikerDTO()
            {
                Id = 1,
                Name = "Test naam",
                Email = "Test@Naam.com",
                Password = "Password",
                Actief = true
            };

            FeedbackDTO feedback1 = new FeedbackDTO()
            {
                Id = 1,
                GivenFeedback = "Test1",
                Actief = true,
                VerzenderId = gebruiker1.Id,
                OntvangerId = gebruiker1.Id
            };
            FeedbackDTO feedback2 = new FeedbackDTO()
            {
                Id = 2,
                GivenFeedback = "Test2",
                Actief = true,
                VerzenderId = gebruiker1.Id,
                OntvangerId = gebruiker1.Id
            };
            FeedbackDTO feedback3 = new FeedbackDTO()
            {
                Id = 3,
                GivenFeedback = "Test3",
                Actief = false,
                VerzenderId = gebruiker1.Id,
                OntvangerId = gebruiker1.Id
            };

            List<FeedbackDTO> feedbackDTOs = new List<FeedbackDTO>() { feedback1, feedback2 };
            return feedbackDTOs;
        }
    }
}
