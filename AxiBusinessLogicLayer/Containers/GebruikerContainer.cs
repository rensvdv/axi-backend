using AxiBusinessLogicLayer.Entiteiten;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Containers
{
    public class GebruikerContainer
    {
        private IGebruiker? gebruikerDAL;

        public GebruikerContainer(IGebruiker gebruikerDAL)
        {
            this.gebruikerDAL = gebruikerDAL;
        }

        public GebruikerContainer()
        {

        }

        public bool MaakGebruiker(Gebruiker gebruiker)
        {
            bool result = false;
            try
            {
                GebruikerDTO gebruikerDTO = ToDTO(gebruiker);
                result = IGebruiker.MaakGebruiker(gebruikerDTO);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateGebruiker(Gebruiker gebruiker)
        {
            bool result = false;
            try
            {
                GebruikerDTO gebruikerDTO = ToDTO(gebruiker);
                result = IGebruiker.UpdateGebruiker(gebruikerDTO);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruiker(Gebruiker gebruiker)
        {
            bool result = false;
            try
            {
                GebruikerDTO gebruikerDTO = ToDTO(gebruiker);
                result = IGebruiker.VerwijderGebruiker(gebruikerDTO);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Gebruiker> GetAllGebruikers()
        {
            List<Gebruiker> gebruikers = new List<Gebruiker>();
            List<GebruikerDTO> gebruikerDTOs = this.gebruikerDAL.GetAll();

            foreach(GebruikerDTO gebruikerDTO in gebruikerDTOs)
            {
                Gebruiker gebruiker = this.ToGebruiker(gebruikerDTO);
                gebruikers.Add(gebruiker);
            }
            return gebruikers;
        }
        public Gebruiker ToGebruiker(GebruikerDTO gebruikerDTO)
        {
            Gebruiker gebruiker = new Gebruiker(
                gebruikerDTO.Id,
                gebruikerDTO.Name,
                gebruikerDTO.Email,
                gebruikerDTO.Password,
                gebruikerDTO.Actief);
            return gebruiker;
        }

        public GebruikerDTO ToDTO(Gebruiker gebruiker)
        {
            GebruikerDTO gebruikerDTO = new GebruikerDTO()
            {
                Id = gebruiker.Id,
                Name = gebruiker.Naam,
                Email = gebruiker.Email,
                Password = gebruiker.Password,
                Actief = gebruiker.Actief
            };
            return gebruikerDTO;
        }
    }
}
