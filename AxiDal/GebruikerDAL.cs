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
    public class GebruikerDAL : DbContext, IGebruiker
    {
        public List<GebruikerDTO> GetAll()
        {
            using var db = new SetUp();
            try
            {
                List<GebruikerDTO> gebruikerDTOs = db.GebruikerDTO.ToList();
                return gebruikerDTOs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public GebruikerDTO GetUserById(int id)
        {
            using var db = new SetUp();
            try
            {
                GebruikerDTO dto = db.GebruikerDTO
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
