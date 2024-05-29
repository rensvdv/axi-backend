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
    public class VraagDAL : DbContext, IVraag
    {
        public bool CreateVraag(VraagDTO vraagDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Creating new vraag");
                db.Add(vraagDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<VraagDTO> GetVragenLijst(int lijstId)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Reading all vragen");
                var lijsten = db.VraagLijstDTO
                    .Where(g => g.LijstId == lijstId)
                    .SelectMany(g => db.VraagDTO
                        .Where(f => f.Id == g.VraagId))
                    .ToList();
                return lijsten;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
