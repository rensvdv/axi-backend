namespace AxiBusinessLogicLayer.Entiteiten
{
    public class Feedback
    {
        public int Id { get; private set; }
        public string GivenFeedback { get; private set; }
        public List<Vraag> Vragen { get; private set; }
        public bool Actief { get; private set; }
        public Gebruiker Gebruiker { get; private set; }

        public Feedback(int id, string givenFeedback, List<Vraag> vragen, bool actief, Gebruiker gebruiker)
        {
            Id = id;
            GivenFeedback = givenFeedback;
            Vragen = vragen;
            Actief = actief;
            Gebruiker = gebruiker;
        }

        public Feedback(string givenFeedback)
        {
            GivenFeedback = givenFeedback;
        }
    }
}