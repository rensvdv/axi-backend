using AxiBusinessLogicLayer.Containers;
using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using AxiUnitTests.StubDAL;
using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace AxiUnitTests.UnitTests
{
    [TestClass]
    public class FeedbackUnitTest
    {
        [TestMethod]
        [DataRow(4)]
        [DataRow(5)]
        public void TestGetGroepFeedback(int id)
        {
            //Arrange
            FeedbackStubDAL feedbackStubDal = new FeedbackStubDAL();
            FeedbackContainer container = new FeedbackContainer((feedbackStubDal));

            Gebruiker gebruiker = new Gebruiker(1, "MAAAAAAAAAAAAAAAAAAAAAAAAAAMWAWOWOWOW", "SNOEP@PINGAS.com", "Mamamia", true);
            Feedback feedback1 = new Feedback(1, "Test1", true, gebruiker, gebruiker);
            Feedback feedback2 = new Feedback(2, "Test2", true, gebruiker, gebruiker);
            Feedback feedback3 = new Feedback(3, "Test3", false, gebruiker, gebruiker);

            //Act
            List<Feedback> feedback = container.GetGroepFeedbackAll(id);

            //Assert
            Assert.AreEqual(id, feedbackStubDal.GivenId);

            Assert.AreEqual(feedback1.Id, feedback[0].Id);
            Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            Assert.AreEqual(feedback1.Actief, feedback[0].Actief);
            Assert.AreEqual(feedback1.Zender, feedback[0].Zender);
            Assert.AreEqual(feedback1.Ontvanger, feedback[0].Ontvanger);

            Assert.AreEqual(feedback2.Id, feedback[1].Id);
            Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            Assert.AreEqual(feedback2.Actief, feedback[1].Actief);
            Assert.AreEqual(feedback2.Zender, feedback[1].Zender);
            Assert.AreEqual(feedback2.Ontvanger, feedback[1].Ontvanger);

            Assert.AreEqual(feedback3.Id, feedback[2].Id);
            Assert.AreEqual(feedback3.GivenFeedback, feedback[2].GivenFeedback);
            Assert.AreEqual(feedback3.Actief, feedback[2].Actief);
            Assert.AreEqual(feedback3.Zender, feedback[2].Zender);
            Assert.AreEqual(feedback3.Ontvanger, feedback[2].Ontvanger);
        }

        [TestMethod]
        [DataRow(4, "Test4", true, true)]
        [DataRow(4, "", true, false)]
        public void TestMaakFeedback(int id, string givenfeedback, bool actief, bool expected)
        {
            //Arrange
            FeedbackStubDAL feedbackStubDAL = new FeedbackStubDAL();
            GebruikerStubDAL gebruikerStubDAL = new GebruikerStubDAL();
            FeedbackContainer feedbackContainer = new FeedbackContainer(feedbackStubDAL, gebruikerStubDAL);

            Gebruiker gebruiker = new Gebruiker(1, "Test naam", "Test@Naam.com", "Password", true);
            Feedback feedback = new Feedback()
            {
                Id = id,
                GivenFeedback = givenfeedback,
                Actief = actief,
                Ontvanger = gebruiker,
                Zender = gebruiker
            };

            //Act
            bool result = feedbackContainer.MaakFeedback(feedback);

            //Assert
            Assert.AreEqual(expected, result);
            if (result == true)
            {
                Assert.AreEqual(feedback.Id, feedbackStubDAL.Id);
                Assert.AreEqual(feedback.GivenFeedback, feedbackStubDAL.GivenFeedback);
                Assert.AreEqual(feedback.Actief, feedbackStubDAL.Actief);
                Assert.AreEqual(feedback.Ontvanger.Id, feedbackStubDAL.Ontvanger);
                Assert.AreEqual(feedback.Zender.Id, feedbackStubDAL.Zender);
            }
        }

        [TestMethod]
        public void TestGetMijnFeedback()
        {
            //Arrange
            FeedbackStubDAL feedbackStubDAL = new FeedbackStubDAL();
            GebruikerStubDAL gebruikerStubDAL = new GebruikerStubDAL();
            FeedbackContainer feedbackContainer = new FeedbackContainer(feedbackStubDAL, gebruikerStubDAL);
            Gebruiker gebruiker = new Gebruiker(1, "Test naam", "Test@Naam.com", "Password", true);
            Feedback feedback1 = new Feedback(1, "Test1", true, gebruiker, gebruiker);
            Feedback feedback2 = new Feedback(2, "Test2", true, gebruiker, gebruiker);
            Feedback feedback3 = new Feedback(3, "Test3", false, gebruiker, gebruiker);

            //Act
            List<Feedback> feedback = feedbackContainer.GetMijnFeedback(1);

            //Assert
            Assert.AreEqual(1, feedbackStubDAL.GivenId);
            Assert.AreEqual(feedback1.Id, feedback[0].Id);
            Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            Assert.AreEqual(feedback1.Actief, feedback[0].Actief);
            Assert.AreEqual(feedback1.Zender.Id, feedback[0].Zender.Id);
            Assert.AreEqual(feedback1.Ontvanger.Id, feedback[0].Ontvanger.Id);
            Assert.AreEqual(feedback2.Id, feedback[1].Id);
            Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            Assert.AreEqual(feedback2.Actief, feedback[1].Actief);
            Assert.AreEqual(feedback2.Zender.Id, feedback[1].Zender.Id);
            Assert.AreEqual(feedback2.Ontvanger.Id, feedback[1].Ontvanger.Id);
            Assert.AreEqual(feedback3.Id, feedback[2].Id);
            Assert.AreEqual(feedback3.GivenFeedback, feedback[2].GivenFeedback);
            Assert.AreEqual(feedback3.Actief, feedback[2].Actief);
            Assert.AreEqual(feedback3.Zender.Id, feedback[2].Zender.Id);
            Assert.AreEqual(feedback3.Ontvanger.Id, feedback[2].Ontvanger.Id);
        }

        [TestMethod]
        [DataRow(4, "Test4", true, true)]
        [DataRow(4, "", true, false)]
        public void TestUpdateFeedbcak(int id, string givenfeedback, bool actief, bool expected)
        {
            //Arrange
            FeedbackStubDAL stubDAL = new FeedbackStubDAL();

            FeedbackContainer feedbackcontainer = new FeedbackContainer(stubDAL);
            Gebruiker gebruiker = new Gebruiker();
            Feedback feedback = new Feedback(id, givenfeedback, actief, gebruiker, gebruiker);

            //Act
            bool result = feedbackcontainer.UpdateFeedback(feedback);

            //Assert
            Assert.AreEqual(result, expected);
            if (result == true)
            {
                Assert.AreEqual(feedback.Id, stubDAL.Id);
                Assert.AreEqual(feedback.GivenFeedback, stubDAL.GivenFeedback);
                Assert.AreEqual(feedback.Actief, stubDAL.Actief);
                Assert.AreEqual(feedback.Ontvanger.Id, stubDAL.Ontvanger);
                Assert.AreEqual(feedback.Zender.Id, stubDAL.Zender);
            }
        }

        [TestMethod]
        [DataRow(6, "Testing", true, true)]
        public void ArchiveerFeedback(int id, string givenfeedback, bool actief, bool expected)
        {
            //Arrange
            FeedbackStubDAL stubDAL = new FeedbackStubDAL();

            FeedbackContainer feedbackcontainer = new FeedbackContainer(stubDAL);
            Gebruiker gebruiker = new Gebruiker();
            Feedback feedback = new Feedback(id, givenfeedback, actief, gebruiker, gebruiker);

            //Act
            bool result = feedbackcontainer.Archiveren(feedback);

            //Assert
            Assert.AreEqual(result, expected);
            Assert.IsFalse(stubDAL.Actief);
        }

        [TestMethod]
        public void GetZenderFeedback()
        {
            //Arrange
            Gebruiker gebruiker = new Gebruiker(1, "Test naam", "Test@Naam.com", "Password", true);

            GebruikerStubDAL gebruikerStubDAL = new GebruikerStubDAL();
            FeedbackStubDAL feedbackStubDAL = new FeedbackStubDAL();
            FeedbackContainer container = new FeedbackContainer(feedbackStubDAL, gebruikerStubDAL);

            Feedback feedback1 = new Feedback()
            {
                Id = 1,
                GivenFeedback = "Test1",
                Actief = true,
                Zender = gebruiker,
                Ontvanger = gebruiker
            };

            Feedback feedback2 = new Feedback()
            {
                Id = 2,
                GivenFeedback = "Test2",
                Actief = true,
                Zender = gebruiker,
                Ontvanger = gebruiker
            };

            //Act
            List<Feedback> feedback = container.GetZenderFeedback(1);

            //Assert
            Assert.AreEqual(1, feedbackStubDAL.GivenId);
            Assert.AreEqual(feedback1.Id, feedback[0].Id);
            Assert.AreEqual(feedback1.GivenFeedback, feedback[0].GivenFeedback);
            Assert.AreEqual(feedback1.Actief, feedback[0].Actief);
            Assert.AreEqual(feedback1.Zender.Id, feedback[0].Zender.Id);
            Assert.AreEqual(feedback1.Ontvanger.Id, feedback[0].Ontvanger.Id);
            Assert.AreEqual(feedback2.Id, feedback[1].Id);
            Assert.AreEqual(feedback2.GivenFeedback, feedback[1].GivenFeedback);
            Assert.AreEqual(feedback2.Actief, feedback[1].Actief);
            Assert.AreEqual(feedback2.Zender.Id, feedback[1].Zender.Id);
            Assert.AreEqual(feedback2.Ontvanger.Id, feedback[1].Ontvanger.Id);
        }
    }
}