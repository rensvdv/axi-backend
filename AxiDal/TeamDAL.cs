using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using Microsoft.EntityFrameworkCore;

namespace AxiDal
{
    public class TeamDAL : DbContext, ITeam
    {
        public TeamDTO GetTeam(int teamId)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Team ophalen");
                TeamDTO dto = db.TeamDTO.Where(t => t.TeamId == teamId)
                    .FirstOrDefault();

                return dto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new TeamDTO();
            }
        }

        public List<TeamDTO> GetTeams()
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Teams ophalen");
                List<TeamDTO> teams = db.TeamDTO.ToList();
                return teams;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<TeamDTO>();
            }
        }

        public bool MaakTeam(TeamDTO teamDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Team Toevoegen");
                db.Add(teamDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruikerUitTeam(int teamId, int gebruikerId)
        {
            using var db = new SetUp();
            try
            {
                GebruikerTeamProfielDTO dto = db.GebruikerTeamProfielDTO
                    .Where(g => g.GebruikerId == gebruikerId && g.TeamId == teamId)
                    .FirstOrDefault();
                Console.WriteLine("Gebruiker uit team verwijderen");
                db.GebruikerTeamProfielDTO.Remove(dto);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderTeam(TeamDTO teamDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Team verwijderen");
                db.Remove(teamDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VoegGebruikerAanTeamToe(int teamId, int gebruikerId)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Gebruiker aan team toevoegen");
                GebruikerTeamProfielDTO dto = new GebruikerTeamProfielDTO()
                {
                    TeamId = teamId,
                    GebruikerId = gebruikerId
                };
                db.Add(dto);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool WerkTeamBij(TeamDTO teamDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Team bijwerken");
                db.Attach(teamDTO);
                db.Entry(teamDTO).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
