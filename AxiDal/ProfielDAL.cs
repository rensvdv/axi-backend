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
    public class ProfielDAL : DbContext, IProfiel
    {
        public bool MaakProfiel(ProfielDTO dto, List<RechtDTO> rechten)
        {
            using var db = new SetUp();
            Console.WriteLine("Nieuw profiel aanmaken");

            try
            {
                db.Add(dto);

                db.SaveChanges();

                ProfielDTO profiel = db.ProfielDTO
                    .Where(p => p.Naam == dto.Naam)
                    .FirstOrDefault();

                foreach (RechtDTO recht in rechten)
                {
                    ProfielRechtenDTO profielRechtenDTO = new ProfielRechtenDTO()
                    {
                        ProfielId = profiel.ProfielId,
                        RechtId = recht.RechtId
                    };

                    db.ProfielRechtenDTO.Add(profielRechtenDTO);
                }
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            

        }

        public bool BewerkProfiel(ProfielDTO dto, List<ProfielRechtenDTO> rechten)
        {
            using var db = new SetUp();
            Console.WriteLine("Profiel bijwerken");
            try
            {
                db.Attach(dto);
                db.Entry(dto).State = EntityState.Modified;

                db.Remove(db.ProfielRechtenDTO
                    .Where(p => p.ProfielId == dto.ProfielId));

                foreach (ProfielRechtenDTO recht in rechten)
                {
                    db.ProfielRechtenDTO.Add(recht);
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderProfiel(ProfielDTO dto)
        {
            using var db = new SetUp();
            Console.WriteLine("Profiel verwijderen");
            try
            {
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

        public List<ProfielDTO> ZoekGebruikerProfielen(int gebruikerid)
        {
            using var db = new SetUp();
            try
            {
                List<ProfielDTO> profielen = db.GebruikerTeamProfielDTO
                    .Where(g => g.GebruikerId == gebruikerid)
                    .SelectMany(g => db.ProfielDTO
                        .Where(p => p.ProfielId == g.ProfielId))
                    .ToList();

                return profielen;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<ProfielDTO>();
            }
        }

        public ProfielDTO ZoekProfiel(int id)
        {
            using var db = new SetUp();
            try
            {
                ProfielDTO dto = db.ProfielDTO
                    .Where(p => p.ProfielId == id)
                    .FirstOrDefault();
                return dto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new ProfielDTO();
            }
        }

        public List<ProfielDTO> ZoekProfielen()
        {
            using var db = new SetUp();
            try
            {
                List<ProfielDTO> profielen = db.ProfielDTO.ToList();
                return profielen;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<ProfielDTO>();
            }
        }
    }
}
