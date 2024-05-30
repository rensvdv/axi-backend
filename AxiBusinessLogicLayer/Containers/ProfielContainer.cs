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
            bool result = false;
            try
            {
                ProfielDTO dto = ToDTO(profiel);
                result = ProfielDAL.MaakProfiel(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            

        }

        public bool BewerkProfiel(Profiel profiel)
        {
            bool result = false;
            try
            {
                ProfielDTO dto = ToDTO(profiel);
                result = ProfielDAL.BewerkProfiel(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderProfiel(Profiel profiel)
        {
            bool result = false;
            try
            {
                ProfielDTO dto = ToDTO(profiel);
                result = ProfielDAL.VerwijderProfiel(dto);
                return result;
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
                return null;
            }
        }

        public List<Profiel> ZoekGebruikerProfielen(int gebruikerid)
        {
            List<Profiel> profielen = new List<Profiel>();
            try
            {
                profielen = ProfielDAL.ZoekGebruikerProfielen(gebruikerid).Select(profiel => ToProfiel(profiel)).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
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
                return null;
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
