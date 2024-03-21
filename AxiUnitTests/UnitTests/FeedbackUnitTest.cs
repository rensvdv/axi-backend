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
        public void TestGetGroepFeedback()
        {
            //Arrange
            int groepId = 1;
            FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            FeedbackContainer feedbackContainer = new FeedbackContainer(stubDAL);

            Vraag vraag = new Vraag("Test Kwestie", "Test Antwoord");
            List<Vraag> vraagList = new List<Vraag>() { vraag };
            Profiel profiel = new Profiel();
            Gebruiker gebruiker = new Gebruiker(profiel);
            Feedback feedback1 = new Feedback(1, "Test1", vraagList, true, gebruiker, gebruiker);
            Feedback feedback2 = new Feedback(2, "Test2", vraagList, true, gebruiker, gebruiker);
            Feedback feedback3 = new Feedback(3, "Test3", vraagList, false, gebruiker, gebruiker);
            Feedback feedback4 = new Feedback(4, "Test3", vraagList, true, gebruiker, gebruiker);

            int expectedCount = 3;
            int expectedFeedbackId1 = 1;
            int expectedFeedbackId2 = 2;
            int expectedFeedbackId3 = 4;

            //Act
            List<Feedback> feedback = feedbackContainer.GetGroupFeedback(groepId);

            //Assert
            Assert.AreEqual(expectedFeedbackId1, feedback[0].Id);
            Assert.AreEqual(expectedFeedbackId2, feedback[1].Id);
            Assert.AreEqual(expectedFeedbackId3, feedback[2].Id);

            Assert.AreEqual(expectedCount, feedback.Count);
            Assert.AreEqual(groepId, stubDAL.GivenId);
        }


        [TestMethod]
        public void TestGetMijnFeedback()
        {
            //Arrange
            FeedbackStubDAL stubDAL = new FeedbackStubDAL();
            FeedbackContainer feedbackContainer = new FeedbackContainer(stubDAL);
            
            Vraag vraag = new Vraag("Test Kwestie", "Test Antwoord");
            List<Vraag> vraagList = new List<Vraag>() { vraag };
            Profiel profiel = new Profiel();
            Gebruiker gebruiker = new Gebruiker(profiel);
            Feedback feedback1 = new Feedback(1, "Test1", vraagList, true, gebruiker, gebruiker);
            Feedback feedback2 = new Feedback(2, "Test2", vraagList, true, gebruiker, gebruiker);
            Feedback feedback3 = new Feedback(3, "Test3", vraagList, false, gebruiker, gebruiker);

            //Act
            List<Feedback> feedback = feedbackContainer.GetMijnFeedback(1);

            //Assert
            Assert.AreEqual(feedback1.Id, feedback[0].Id);
            Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            Assert.AreEqual(feedback1.Vragen[0].Kwestie, feedback[0].Vragen[0].Kwestie);
            Assert.AreEqual(feedback1.Vragen[0].Antwoord, feedback[0].Vragen[0].Antwoord);
            Assert.AreEqual(feedback1.Actief, feedback[0].Actief);
            //Assert.AreEqual(feedback1.Zender.Profiel, feedback[0].Zender.Profiel);
            //Assert.AreEqual(feedback1.Ontvanger.Profiel, feedback[0].Ontvanger.Profiel);
            Assert.AreEqual(feedback2.Id, feedback[1].Id);
            Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            Assert.AreEqual(feedback2.Vragen[0].Kwestie, feedback[1].Vragen[0].Kwestie);
            Assert.AreEqual(feedback2.Vragen[0].Antwoord, feedback[1].Vragen[0].Antwoord);
            Assert.AreEqual(feedback2.Actief, feedback[1].Actief);
            //Assert.AreEqual(feedback2.Zender.Profiel, feedback[1].Zender.Profiel);
            //Assert.AreEqual(feedback2.Ontvanger.Profiel, feedback[1].Ontvanger.Profiel);
            Assert.AreEqual(feedback3.Id, feedback[2].Id);
            Assert.AreEqual(feedback3.GivenFeedback, feedback[2].GivenFeedback);
            Assert.AreEqual(feedback3.Vragen[0].Kwestie, feedback[2].Vragen[0].Kwestie);
            Assert.AreEqual(feedback3.Vragen[0].Antwoord, feedback[2].Vragen[0].Antwoord);
            Assert.AreEqual(feedback3.Actief, feedback[2].Actief);
            //Assert.AreEqual(feedback3.Zender.Profiel, feedback[2].Zender.Profiel);
            //Assert.AreEqual(feedback3.Ontvanger.Profiel, feedback[2].Ontvanger.Profiel);
            Assert.AreEqual(1, stubDAL.GivenId);
        }
    }
}