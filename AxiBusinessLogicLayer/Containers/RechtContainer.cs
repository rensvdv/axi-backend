using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiDal;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Objecten
{
    public class RechtContainer
    {
        private IRecht RechtDAL;

        public RechtContainer(IRecht rechtDAL)
        {
            RechtDAL = rechtDAL;
        }

        public bool MaakRecht(Recht recht)
        {
            try
            {
                if (recht.RechtNaam == null)
                {
                    return false;
                }

                RechtDTO dto = ToDTO(recht);
                return RechtDAL.MaakRecht(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateRecht(Recht recht)
        {
            try
            {
                if (recht.RechtNaam == null)
                {
                    return false;
                }

                RechtDTO dto = ToDTO(recht);
                return RechtDAL.UpdateRecht(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderRecht(Recht recht)
        {
            try
            {
                RechtDTO dto = ToDTO(recht);
                return RechtDAL.VerwijderRecht(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Recht> ZoekRechten()
        {
            List<Recht> rechten = new List<Recht>();
            try
            {
                rechten = RechtDAL.ZoekRechten().Select(recht => ToRecht(recht)).ToList();
                return rechten;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Recht>();
            }
        }

        public List<Recht> ZoekProfielRechten(int profielId)
        {
            List<Recht> rechten = new List<Recht>();
            try
            {
                rechten = RechtDAL.ZoekProfielRechten(profielId).Select(recht => ToRecht(recht)).ToList();
                return rechten;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Recht>();
            }
        }

        public List<Recht> ZoekGebruikerRechten(int gebruikerId)
        {
            List<Recht> rechten = new List<Recht>();
            try
            {
                rechten = RechtDAL.ZoekGebruikerRechten(gebruikerId).Select(recht => ToRecht(recht)).ToList();
                return rechten;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new List<Recht>();
            }
        }
        public Recht ZoekRecht(int rechtid)
        {
            try
            {
                RechtDTO rechtDTO = RechtDAL.ZoekRecht(rechtid);
                Recht recht = ToRecht(rechtDTO);
                return recht;
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                return new Recht();
            }
        }

        public RechtDTO ToDTO(Recht recht)
        {
            RechtDTO dto = new RechtDTO()
            {
                RechtId = recht.Id,
                Rechtnaam = recht.RechtNaam
            };
            return dto;
        }

        public Recht ToRecht(RechtDTO dto)
        {
            Recht recht = new Recht(dto.RechtId, dto.Rechtnaam);

            return recht;
        }
    }
}
