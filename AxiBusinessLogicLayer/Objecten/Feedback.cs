using AxiInterfaces.DTO;

namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Feedback
    {
        public int Id { get; set; }
        public string? GivenFeedback { get; set; }
        public bool Actief { get; set; }
        public Gebruiker? Zender { get; set; }
        public Gebruiker? Ontvanger { get; set; }

        public Feedback(int id, string givenFeedback, bool actief, Gebruiker zender, Gebruiker ontvanger)
        {
            Id = id;
            GivenFeedback = givenFeedback;
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
    }
}