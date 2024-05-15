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
    public class AntwoordDAL : DbContext, IAntwoord
    {
        public bool MaakAntwoord(AntwoordDTO antwoordDTO)
        {
            using var db = new SetUp();
            try
            {
                Console.WriteLine("Creating new antwoord");
                db.Add(antwoordDTO);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
