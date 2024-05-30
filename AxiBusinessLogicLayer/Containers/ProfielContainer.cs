using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class ProfielContainer
    {
        private IProfiel ProfielDAL;

        public ProfielContainer(IProfiel profielDAL)
        {
            ProfielDAL = profielDAL;
        }


        public bool MaakProfiel(Profiel profiel) { }

        public GebruikerDTO ToDTO(Gebruiker gebruiker)
        {
            GebruikerDTO dto = new GebruikerDTO()
            {
                Id = gebruiker.Id,
                Name = gebruiker.Naam,
                Email = gebruiker.Email,
                Password = gebruiker.Password,
                Actief = gebruiker.Actief
            };
        }
        public Profiel ToProfiel(ProfielDTO dto)
        {
            Profiel profiel = new Profiel(dto.Id, dto.);
            return gebruiker;
        }
    }
}
