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

        public List<VraagDTO> GetVragen(int lijstId)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Reading all lijst vragen");

                List<VraagLijstDTO> VraagLijstDTOs = db.VraagLijstDTO
                    .Where(VraagLijstDTO => VraagLijstDTO.LijstId == lijstId)
                    .ToList();

                List<VraagDTO> vragen = new List<VraagDTO>();
                foreach (VraagLijstDTO vraagLijstDTO in VraagLijstDTOs)
                {
                    vragen.AddRange(db.VraagDTO
                        .Where(VraagDTO => VraagDTO.Id == vraagLijstDTO.VraagId)
                        .ToList());
                }

                return vragen;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
