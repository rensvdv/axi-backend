using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using AxiUnitTests.StubDAL;
using System.Diagnostics;

namespace AxiUnitTests.UnitTests
{
    [TestClass]
    public class FeedbackUnitTest
    {
        [TestMethod]
        public void TestGetGroep1Feedback()
        {
            ////Arrange
            //int groepId = 1;

            //FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            //FeedbackContainer feedbackContainer = new FeedbackContainer(stubDAL);

            //int expectedCount = 3;

            //Vraag vraag = new Vraag("Test Kwestie", "Test Antwoord");
            //List<Vraag> vraagList = new List<Vraag>() { vraag };
            //Profiel profiel = new Profiel();
            //Gebruiker gebruiker = new Gebruiker();
            //Feedback feedback1 = new Feedback(1, "Test1", true, gebruiker, gebruiker);
            //Feedback feedback2 = new Feedback(2, "Test2", true, gebruiker, gebruiker);
            //Feedback feedback3 = new Feedback(4, "Test4", true, gebruiker, gebruiker);

            ////Act
            //List<Feedback> feedback = feedbackContainer.GetGroepFeedbackAll(groepId);

            ////Assert
            //Assert.AreEqual(feedback1.Id, feedback[0].Id);
            //Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            ////Assert.AreEqual(feedback1.Vragen[0].Kwestie, feedback[0].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback1.Vragen[0].Antwoord, feedback[0].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback1.Actief, feedback[0].Actief);

            //Assert.AreEqual(feedback2.Id, feedback[1].Id);
            //Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            ////Assert.AreEqual(feedback2.Vragen[0].Kwestie, feedback[1].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback2.Vragen[0].Antwoord, feedback[1].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback2.Actief, feedback[1].Actief);

            //Assert.AreEqual(feedback3.Id, feedback[2].Id);
            //Assert.AreEqual(feedback3.GivenFeedback, feedback[2].GivenFeedback);
            ////Assert.AreEqual(feedback3.Vragen[0].Kwestie, feedback[2].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback3.Vragen[0].Antwoord, feedback[2].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback3.Actief, feedback[2].Actief);

            //Assert.AreEqual(expectedCount, feedback.Count);
            //Assert.AreEqual(groepId, stubDAL.GivenId);
        }

        [TestMethod]
        public void TestGetGroep2Feedback()
        {
            ////Arrange
            //int groepId = 2;

            //FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            //FeedbackContainer feedbackContainer = new FeedbackContainer(stubDAL);

            //Vraag vraag = new Vraag("Test Kwestie", "Test Antwoord");
            //List<Vraag> vraagList = new List<Vraag>() { vraag };
            //Profiel profiel = new Profiel();
            //Gebruiker gebruiker = new Gebruiker();
            //Feedback feedback1 = new Feedback(1, "Test1", true, gebruiker, gebruiker);
            //Feedback feedback2 = new Feedback(3, "Test3", false, gebruiker, gebruiker);

            //int expectedCount = 2;

            ////Act
            //List<Feedback> feedback = feedbackContainer.GetGroepFeedbackAll(groepId);

            ////Assert
            //Assert.AreEqual(feedback1.Id, feedback[0].Id);
            //Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            ////Assert.AreEqual(feedback1.Vragen[0].Kwestie, feedback[0].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback1.Vragen[0].Antwoord, feedback[0].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback1.Actief, feedback[0].Actief);

            //Assert.AreEqual(feedback2.Id, feedback[1].Id);
            //Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            ////Assert.AreEqual(feedback2.Vragen[0].Kwestie, feedback[1].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback2.Vragen[0].Antwoord, feedback[1].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback2.Actief, feedback[1].Actief);

            //Assert.AreEqual(expectedCount, feedback.Count);
            //Assert.AreEqual(groepId, stubDAL.GivenId);
        }

        [TestMethod]
        public void TestGetGroepFeedbackAllFail()
        {
            ////Arrange
            //int groepId = 3;

            //FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            //FeedbackContainer feedbackContainer = new FeedbackContainer(stubDAL);

            ////Act
            //List<Feedback> feedback = feedbackContainer.GetGroepFeedbackAll(groepId);

            ////Assert
            //Assert.IsNull(feedback);
            //Assert.AreEqual(groepId, stubDAL.GivenId);
        }


        [TestMethod]
        [DataRow(4, "Test4", true, true)]
        [DataRow(4, "", true, false)]
        public void TestMaakFeedback(int id, string givenfeedback, bool actief, bool expected)
        {
            ////Arrange
            //FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            //FeedbackContainer feedbackcontainer = new FeedbackContainer(stubDAL);
            //List<Vraag> vraaglijst = new List<Vraag>();
            //Profiel profiel = new Profiel();
            //Gebruiker gebruiker = new Gebruiker();
            //Feedback feedback = new Feedback(id, givenfeedback, actief, gebruiker, gebruiker);

            ////Act
            //bool result = feedbackcontainer.MaakFeedback(feedback);

            ////Assert
            //Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void TestGetMijnFeedback()
        {
            ////Arrange
            //FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            //FeedbackContainer feedbackContainer = new FeedbackContainer(stubDAL);
            
            //Vraag vraag = new Vraag("Test Kwestie", "Test Antwoord");
            //List<Vraag> vraagList = new List<Vraag>() { vraag };
            //Profiel profiel = new Profiel();
            //Gebruiker gebruiker = new Gebruiker();
            //Feedback feedback1 = new Feedback(1, "Test1", true, gebruiker, gebruiker);
            //Feedback feedback2 = new Feedback(2, "Test2", true, gebruiker, gebruiker);
            //Feedback feedback3 = new Feedback(3, "Test3", false, gebruiker, gebruiker);

            ////Act
            //List<Feedback> feedback = feedbackContainer.GetMijnFeedback(1);

            ////Assert
            //Assert.AreEqual(feedback1.Id, feedback[0].Id);
            //Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            ////Assert.AreEqual(feedback1.Vragen[0].Kwestie, feedback[0].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback1.Vragen[0].Antwoord, feedback[0].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback1.Actief, feedback[0].Actief);
            ////Assert.AreEqual(feedback1.Zender.Profiel, feedback[0].Zender.Profiel);
            ////Assert.AreEqual(feedback1.Ontvanger.Profiel, feedback[0].Ontvanger.Profiel);
            //Assert.AreEqual(feedback2.Id, feedback[1].Id);
            //Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            ////Assert.AreEqual(feedback2.Vragen[0].Kwestie, feedback[1].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback2.Vragen[0].Antwoord, feedback[1].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback2.Actief, feedback[1].Actief);
            ////Assert.AreEqual(feedback2.Zender.Profiel, feedback[1].Zender.Profiel);
            ////Assert.AreEqual(feedback2.Ontvanger.Profiel, feedback[1].Ontvanger.Profiel);
            //Assert.AreEqual(feedback3.Id, feedback[2].Id);
            //Assert.AreEqual(feedback3.GivenFeedback, feedback[2].GivenFeedback);
            ////Assert.AreEqual(feedback3.Vragen[0].Kwestie, feedback[2].Vragen[0].Kwestie);
            ////Assert.AreEqual(feedback3.Vragen[0].Antwoord, feedback[2].Vragen[0].Antwoord);
            //Assert.AreEqual(feedback3.Actief, feedback[2].Actief);
            ////Assert.AreEqual(feedback3.Zender.Profiel, feedback[2].Zender.Profiel);
            ////Assert.AreEqual(feedback3.Ontvanger.Profiel, feedback[2].Ontvanger.Profiel);
            //Assert.AreEqual(1, stubDAL.GivenId);
        }

        [TestMethod]
        [DataRow(4, "Test4", true, true)]
        [DataRow(4, "", true, false)]
        public void TestUpdateFeedbcak(int id, string givenfeedback, bool actief, bool expected)
        {
            ////Arrange
            //FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            //FeedbackContainer feedbackcontainer = new FeedbackContainer(stubDAL);
            //List<Vraag> vraaglijst = new List<Vraag>();
            //Profiel profiel = new Profiel();
            //Gebruiker gebruiker = new Gebruiker();
            //Feedback feedback = new Feedback(id, givenfeedback, actief, gebruiker, gebruiker);

            ////Act
            //bool result = feedbackcontainer.UpdateFeedback(feedback);

            ////Assert
            //Assert.AreEqual(result, expected);
        }
    }
}