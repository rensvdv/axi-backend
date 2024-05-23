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

                List<LijstDTO> Lijsten = db.LijstDTO.Join(db.TeamLijstDTO, lijst => lijst.Id, teamlijst => teamlijst.LijstId, (lijst, teamlijst) => new { lijst, teamlijst }).Where(dto => dto.teamlijst.TeamId == teamId).Select(lijst => lijst.lijst).ToList();
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
