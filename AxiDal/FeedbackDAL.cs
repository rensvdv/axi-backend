using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiDal
{
    public class FeedbackDAL : DbContext, IFeedback
    {
        public List<FeedbackDTO> GetGroepFeedbackAll(int teamid)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Reading all team feedback");

                

                //var teamId = 123; // Replace with the desired TeamId

                var feedbackQuery = from team in db.TeamDTO
                                    join gebruikerTeam in db.gebruikerTeamProfielDTO
                                        on team.Id equals gebruikerTeam.TeamId
                                    join gebruiker in db.GebruikerDTO
                                        on gebruikerTeam.GebruikerId equals gebruiker.Id
                                    join feedback in db.FeedbackDTO
                                        on gebruiker.Id equals feedback.Id
                                    where team.Id == teamid
                                    select new FeedbackDTO
                                    {
                                        Id = feedback.Id,
                                        GivenFeedback = feedback.GivenFeedback,
                                        Actief = feedback.Actief,
                                        Verzender = feedback.Verzender,
                                        Ontvanger = feedback.Ontvanger
                                    };
               return feedbackQuery.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool MaakFeedback(FeedbackDTO feedbackDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Creating new feedback");
                db.Add(feedbackDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<FeedbackDTO> GetMijnFeedback(int id)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Reading Personal feedback.");
                //List<FeedbackDTO> feedback = db.FeedbackDTO
                //    .Where(f => f.Id == id)
                //    .ToList();


                var query = from feedback1 in db.FeedbackDTO
                            join sender in db.GebruikerDTO
                            on feedback1.Verzender.Id equals sender.Id
                            join receiver in db.GebruikerDTO
                            on feedback1.Ontvanger.Id equals receiver.Id
                            select new FeedbackDTO
                            {
                                Id = feedback1.Id,
                                GivenFeedback = feedback1.GivenFeedback,
                                Actief = feedback1.Actief,
                                Verzender = new GebruikerDTO
                                {
                                    Id = sender.Id,
                                    Name = sender.Name,
                                    Email = sender.Email,
                                    Password = sender.Password,
                                    Actief = sender.Actief,
                                },
                                Ontvanger = new GebruikerDTO
                                {
                                    Id = receiver.Id,  
                                    Name = receiver.Name,
                                    Email = receiver.Email,
                                    Password = receiver.Password,
                                    Actief = receiver.Actief,
                                },
                            };


                return query.ToList();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool UpdateFeedback(FeedbackDTO feedbackDTO)
        {
            throw new NotImplementedException();
        }
    }
}
