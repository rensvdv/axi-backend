namespace AxiBusinessLogicLayer
{
    public class Feedback
    {
        public string GivenFeedback {  get; private set; }
        public List<Vragen> Vragen { get; private set; }

        public Feedback(string givenFeedback, List<Vragen> vragen)
        {
            GivenFeedback = givenFeedback;
            Vragen = vragen;
        }

        public Feedback(string givenFeedback)
        {
            GivenFeedback = givenFeedback;
        }
    }
}