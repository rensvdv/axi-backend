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

        public List<FeedbackDTO> GetGroepFeedbackAll(int groepId)
        {
            GivenId = groepId;

            //MockVraag
            VraagDTO vraag = new()
            {
                Kwestie = "Test Kwestie",
                Antwoord = "Test Antwoord"
            };
            List<VraagDTO> vraagList = new() { vraag };

            //Gebruikers voor teams
            ProfielDTO profiel = new();
            GebruikerDTO gebruiker = new()
            {
                Id = 1,
                ProfielDTO = profiel
            };
            GebruikerDTO gebruiker2 = new()
            {
                Id = 2,
                ProfielDTO = profiel
            };
            GebruikerDTO gebruiker3 = new()
            {
                Id = 3,
                ProfielDTO = profiel
            };
            GebruikerDTO gebruiker4 = new()
            {
                Id = 4,
                ProfielDTO = profiel
            };

            //Teams
            List<GebruikerDTO> teamleden1 = new() { gebruiker, gebruiker2, gebruiker4 };
            List<GebruikerDTO> teamleden2 = new() { gebruiker, gebruiker3 };
            TeamDTO team1 = new(1, "Team1", teamleden1);
            TeamDTO team2 = new(2, "Team2", teamleden2);

            //Lijst aan teams
            List<TeamDTO> teamDTOs = new() { team1, team2 };

            //Lijst aan feedback
            FeedbackDTO feedback1 = new()
            {
                Id = 1,
                GivenFeedback = "Test1",
                Vragen = vraagList,
                Actief = true,
                Zender = gebruiker,
                Ontvanger = gebruiker
            };
            FeedbackDTO feedback2 = new()
            {
                Id = 2,
                GivenFeedback = "Test2",
                Vragen = vraagList,
                Actief = true,
                Zender = gebruiker2,
                Ontvanger = gebruiker
            };
            FeedbackDTO feedback3 = new()
            {
                Id = 3,
                GivenFeedback = "Test3",
                Vragen = vraagList,
                Actief = false,
                Zender = gebruiker3,
                Ontvanger = gebruiker
            };
            FeedbackDTO feedback4 = new()
            {
                Id = 4,
                GivenFeedback = "Test4",
                Vragen = vraagList,
                Actief = true,
                Zender = gebruiker4,
                Ontvanger = gebruiker
            };
            List<FeedbackDTO> feedbackDTOs = new() { feedback1, feedback2, feedback3, feedback4 };

            //Zoekt naar de gekozen team via groepId in de constructor
            TeamDTO gekozenTeam = null;
            foreach (TeamDTO teamDTO in teamDTOs)
            {
                if(teamDTO.Id == groepId)
                {
                    gekozenTeam = teamDTO;
                }
            }

            //Zoekt naar alle feedback van de teamleden
            List<FeedbackDTO> feedbackTeam = null;
            if (gekozenTeam != null)
            {
                feedbackTeam = new();
                foreach (GebruikerDTO gebruikerDTO in gekozenTeam.Teamleden)
                {
                    foreach (FeedbackDTO feedbackDTO in feedbackDTOs)
                    {
                        if(gebruikerDTO.Id == feedbackDTO.Zender.Id)
                        {
                            feedbackTeam.Add(feedbackDTO);
                        }
                    }
                }
            }
            return feedbackTeam;
        }

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

        public bool MaakFeedback(FeedbackDTO feedbackDTO)
        {
            return true;
        }

        public bool UpdateFeedback(FeedbackDTO feedbackDTO)
        {
            return true;
        }
    }
}
