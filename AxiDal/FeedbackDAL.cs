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

                var feedback = db.GebruikerTeamProfielDTO
                    .Where(g => g.TeamId == teamid)
                    .SelectMany(g => db.FeedbackDTO
                        .Where(f => f.OntvangerId == g.GebruikerId))
                    .ToList();

                return feedback;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<FeedbackDTO>();
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
                List<FeedbackDTO> feedback = db.FeedbackDTO
                    .Where(f => f.OntvangerId == id)
                    .ToList();

                return feedback;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<FeedbackDTO>();
            }
        }

        public List<FeedbackDTO> GetZenderFeedback(int id)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Reading Personal feedback.");
                List<FeedbackDTO> feedback = db.FeedbackDTO
                    .Where(f => f.VerzenderId == id)
                    .ToList();

                return feedback;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return new List<FeedbackDTO>();
            }
        }

        public bool UpdateFeedback(FeedbackDTO feedbackDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Updating feedback");
                db.Attach(feedbackDTO);
                db.Entry(feedbackDTO).State = EntityState.Modified;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public bool Archiveer(FeedbackDTO feedbackDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Archiving feedback");
                db.Attach(feedbackDTO);
                db.Entry(feedbackDTO).State = EntityState.Modified;

                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
