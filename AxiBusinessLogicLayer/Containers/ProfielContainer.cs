using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AxiBusinessLogicLayer.Entiteiten;
using AxiBusinessLogicLayer.Objecten;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class ProfielContainer
    {
        private IProfiel ProfielDAL;
        private IRecht RechtDAL;
        private RechtContainer rechtContainer;

        public ProfielContainer(IProfiel profielDAL, IRecht rechtDAL)
        {
            ProfielDAL = profielDAL;
            RechtDAL = rechtDAL;
            rechtContainer = new RechtContainer(RechtDAL);
        }



        public bool MaakProfiel(Profiel profiel)
        {
            try
            {
                ProfielDTO dto = ToDTO(profiel);
                List<RechtDTO> rechten = new List<RechtDTO>();
                foreach (Recht recht in profiel.Rechten)
                {
                    RechtDTO prDTO = rechtContainer.ToDTO(recht);
                    rechten.Add(prDTO);
                }
                return ProfielDAL.MaakProfiel(dto, rechten);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool BewerkProfiel(Profiel profiel)
        {
            try
            {
                ProfielDTO dto = ToDTO(profiel);
                List<ProfielRechtenDTO> rechten = new List<ProfielRechtenDTO>();
                foreach (Recht recht in profiel.Rechten)
                {
                    ProfielRechtenDTO prDTO = ToExtraDTO(profiel, recht);
                    rechten.Add(prDTO);
                }
                return ProfielDAL.BewerkProfiel(dto, rechten);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderProfiel(Profiel profiel)
        {
            try
            {
                ProfielDTO dto = ToDTO(profiel);
                return ProfielDAL.VerwijderProfiel(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Profiel> ZoekProfielen()
        {
            List<Profiel> profielen = new List<Profiel>();
            try
            {
                profielen = ProfielDAL.ZoekProfielen().Select(profiel => ToProfiel(profiel)).ToList();
                return profielen;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Profiel>();
            }
        }

        public List<Profiel> ZoekGebruikerProfielen(int gebruikerid)
        {
            List<Profiel> profielen = new List<Profiel>();
            try
            {
                profielen = ProfielDAL.ZoekGebruikerProfielen(gebruikerid).Select(profiel => ToProfiel(profiel)).ToList();
                return profielen;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Profiel>();
            }
        }

        public Profiel ZoekProfiel(int id)
        {
            try
            {
                ProfielDTO dto = ProfielDAL.ZoekProfiel(id);
                Profiel profiel = ToProfiel(dto);
                return profiel;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new Profiel();
            }
        }

        

        public ProfielDTO ToDTO(Profiel profiel)
        {
            ProfielDTO dto = new ProfielDTO()
            {
                ProfielId = profiel.ProfielId,
                Naam = profiel.ProfielNaam
            };

            return dto;
        }

        public ProfielRechtenDTO ToExtraDTO(Profiel profiel, Recht recht)
        {
            ProfielRechtenDTO dto = new ProfielRechtenDTO()
            {
                ProfielId = profiel.ProfielId,
                RechtId = recht.Id
            };

            return dto;
        }
        public Profiel ToProfiel(ProfielDTO dto)
        {
            
            Profiel profiel = new Profiel()
            {
                ProfielId = dto.ProfielId,
                ProfielNaam = dto.Naam,
                Rechten = rechtContainer.ZoekProfielRechten(dto.ProfielId)
            };

            return profiel;
        }
    }
}
