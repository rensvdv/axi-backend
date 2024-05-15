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
    public class LijstDAL : DbContext, ILijst
    {
        public List<LijstDTO> GetLijstenByTeamId(int teamId)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Reading all team feedback");

                List<TeamLijstDTO> TeamLijstDTOs = db.TeamLijstDTO
                    .Where(TeamLijstDTO => TeamLijstDTO.TeamId == teamId)
                    .ToList();

                List<LijstDTO> Lijsten = new List<LijstDTO>();

                foreach (TeamLijstDTO TeamLijstDTO in TeamLijstDTOs)
                {
                    Lijsten.AddRange(db.LijstDTO
                        .Where(LijstDTO => LijstDTO.Id == TeamLijstDTO.LijstId)
                        .ToList());
                }

                return Lijsten;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public LijstDTO GetLijst(int id)
        {
            using var db = new SetUp();
            try
            {
                LijstDTO dto = db.LijstDTO
                    .Where(x => x.Id == id)
                    .FirstOrDefault();
                return dto;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
