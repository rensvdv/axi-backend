using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiUnitTests.StubDAL
{
    internal class GebruikerStubDAL : IGebruiker
    {
        public int givenId { get; set; }

        public List<GebruikerDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public GebruikerDTO GetUserById(int Id)
        {
            givenId = Id;

            GebruikerDTO gebruiker = new GebruikerDTO()
            {
                Id = 1,
                Name = "Test naam",
                Email = "Test@Naam.com",
                Password = "Password",
                Actief = true
            };

            return gebruiker;
        }
    }
}
