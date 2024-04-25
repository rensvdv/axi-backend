using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiBusinessLogicLayer.Objecten;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
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
            bool result = false;
            try
            {
                if (recht.RechtNaam == null)
                {
                    return false;
                }

                RechtDTO dto = ToDTO(recht);
                result = RechtDAL.MaakRecht(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        //public bool UpdateRecht(Recht recht)
        //{
        //    bool result = false;
        //    try
        //    {
        //        if (recht.RechtNaam == null)
        //        {
        //            return false;
        //        }

        //        RechtDTO dto = ToDTO(recht);
        //        result = RechtDAL.UpdateRecht(dto);
        //        return result;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return false;
        //    }
        //}

        //public bool VerwijderRecht(Recht recht)
        //{
        //    bool result = false;
        //    try
        //    {
        //        RechtDTO dto = ToDTO(recht);
        //        result = IRecht.VerwijderRecht(dto);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e);
        //        return false;
        //    }
        //}

        //public Recht ZoekRechten()
        //{
        //    List<RechtDTO> DTOs = IRecht.ZoekRechten();


        //}
        public RechtDTO ToDTO(Recht recht)
        {
            RechtDTO dto = new RechtDTO()
            {
                Id = recht.Id,
                Rechtnaam = recht.RechtNaam
            };
            return dto;
        }

        public Recht ToRecht(RechtDTO dto)
        {
            Recht recht = new Recht(dto.Id, dto.Rechtnaam);

            return recht;
        }
    }
}
