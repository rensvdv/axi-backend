using AxiBusinessLogicLayer.Entiteiten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiInterfaces.InterFaces;
using AxiInterfaces.DTO;

namespace AxiBusinessLogicLayer.Containers
{
    public class VraagContainer
    {
        IVraag VraagDAL;
        public VraagContainer(IVraag vraagDAL)
        {
            VraagDAL = vraagDAL;
        }

        public VraagDTO ToDTO(Vraag vraag)
        {
            return new()
            {
                Id = vraag.Id,
                Kwestie = vraag.Kwestie
            };
        }
        public Vraag ToVraag(VraagDTO vraagDTO)
        {
            return new(vraagDTO.Id, vraagDTO.Kwestie);
        }

        public bool CreateVraag(Vraag vraag)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(vraag.Kwestie))
                {
                    return false;
                }
                else
                {
                    return VraagDAL.CreateVraag(ToDTO(vraag));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return false;
            }
        }

        public string UpdateVraag(Vraag vraag)
        {
            string e = "";
            return e;
        }
        public string DeleteVraag(Vraag vraag)
        {
            string e = "";
            return e;
        }

        public List<Vraag> GetVragen(int lijstId)
        {
            try
            {
                List<Vraag> vragen = VraagDAL.GetVragen(lijstId).Select(vraag => ToVraag(vraag)).ToList();
                return vragen;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }
    }
}
