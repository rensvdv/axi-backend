using AxiInterfaces.DTO;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Feedback
    {
        public int Id { get; set; }
        public string? GivenFeedback { get; set; }
        //public List<Vraag> Vragen { get; private set; }
        public bool Actief { get; set; }
        public Gebruiker? Zender { get; set; }
        public Gebruiker? Ontvanger { get; set; }

        public Feedback(int id, string givenFeedback/*, List<Vraag> vragen*/, bool actief, Gebruiker zender, Gebruiker ontvanger)
        {
            Id = id;
            GivenFeedback = givenFeedback;
            //Vragen = vragen;
            Actief = actief;
            Zender = zender;
            Ontvanger = ontvanger;
        }

        public Feedback()
        {

        }

        public Feedback(string givenFeedback)
        {
            GivenFeedback = givenFeedback;
        }

        public Feedback(FeedbackDTO dto)
        {
            Id = dto.Id;
            GivenFeedback = dto.GivenFeedback;

            //List<Vraag> Vragenlijst = new List<Vraag>();

            //foreach (VraagDTO vraagDTO in dto.Vragen)
            //{
            //    Vraag vraag = new Vraag(vraagDTO);
            //    Vragenlijst.Add(vraag);
            //}

            //Vragen = Vragenlijst;
            Actief = dto.Actief;

            GebruikerDTO gebruikerDTO = dto.Verzender;
            Zender = new Gebruiker(gebruikerDTO);

            GebruikerDTO gebruikerDTO1 = dto.Ontvanger;
            Ontvanger = new Gebruiker(gebruikerDTO1);
        }

        public FeedbackDTO ToDTO(Feedback feedback)
        {
            //List<VraagDTO> vraagDTOs = new List<VraagDTO>();
            //foreach(Vraag vraag in feedback.Vragen)
            //{
            //    VraagDTO vraagDTO = new VraagDTO()
            //    {
            //        Kwestie = vraag.Kwestie,
            //        Antwoord = vraag.Antwoord,
            //    };
            //    vraagDTOs.Add(vraagDTO);
            //}

            GebruikerDTO gebruikerDTO1 = feedback.Zender.ToDTO(feedback.Zender);

            GebruikerDTO gebruikerDTO2 = feedback.Zender.ToDTO(feedback.Ontvanger);

            FeedbackDTO feedbackDTO = new FeedbackDTO()
            {
                Id = feedback.Id,
                GivenFeedback = feedback.GivenFeedback,
                //Vragen = vraagDTOs,
                Actief = feedback.Actief,
                Verzender = gebruikerDTO1,
                Ontvanger = gebruikerDTO2,
            };
            return feedbackDTO;
        }
    }
}