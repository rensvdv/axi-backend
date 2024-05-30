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
    public class RechtDAL : DbContext, IRecht
    {
        public bool MaakRecht(RechtDTO dto)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Nieuw recht aanmaken");
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

        public bool UpdateRecht(RechtDTO dto)
        {
            using var db = new SetUp();

            try
            {
                Console.WriteLine("Gebruiker bijwerken");
                db.Attach(dto);
                db.Entry(dto).State = EntityState.Modified;

                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderRecht(RechtDTO dto)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Recht verwijderen");
                db.Remove(dto);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<RechtDTO> ZoekGebruikerRechten(int gebruikerId)
        {
            using var db = new SetUp();
            try
            {
                List<RechtDTO> rechten = db.GebruikerRechtenDTO
                    .Where(g => g.GebruikerId == gebruikerId)
                    .SelectMany(g => db.RechtDTO
                        .Where(r => r.RechtId == g.RechtId))
                    .ToList();

                return rechten;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<RechtDTO> ZoekProfielRechten(int profielId)
        {
            using var db = new SetUp();
            try
            {
                List<RechtDTO> rechten = db.ProfielRechtenDTO
                    .Where(p => p.ProfielId == profielId)
                    .SelectMany(p => db.RechtDTO
                        .Where(r => r.RechtId == p.RechtId))
                    .ToList();

                return rechten;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }

        public RechtDTO ZoekRecht(int id)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Recht Ophalen");
                RechtDTO rechtdto = db.RechtDTO.Where(r => r.RechtId == id).FirstOrDefault();
                return rechtdto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public List<RechtDTO> ZoekRechten()
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Rechten Ophalen");
                List<RechtDTO> rechten = db.RechtDTO.ToList();

                return rechten;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
