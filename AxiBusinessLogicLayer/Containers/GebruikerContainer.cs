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
        private IGebruiker GebruikerDAL;
        private ProfielContainer ProfielContainer;

        public GebruikerContainer(IGebruiker gebruikerDAL, ProfielContainer profielContainer)
        {
            GebruikerDAL = gebruikerDAL;
            ProfielContainer = profielContainer;
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
                result = GebruikerDAL.MaakGebruiker(gebruikerDTO);
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
                result = GebruikerDAL.UpdateGebruiker(gebruikerDTO);
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
                result = GebruikerDAL.VerwijderGebruiker(gebruikerDTO);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool GeefGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            bool result = false;
            try
            {
                GebruikerTeamProfielDTO dto = ToGTPDTO(gebruikerId, teamId, profielId);

                result = GebruikerDAL.GeefGebruikerTeamProfiel(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            bool result = false;
            try
            {
                GebruikerTeamProfielDTO dto = ToGTPDTO(gebruikerId, teamId, profielId);

                result = GebruikerDAL.UpdateGebruikerTeamProfiel(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            bool result = false;
            try
            {
                GebruikerTeamProfielDTO dto = ToGTPDTO(gebruikerId, teamId, profielId);

                result = GebruikerDAL.VerwijderGebruikerTeamProfiel(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool GeefGebruikerRecht(int rechtId, int gebruikerId)
        {
            bool result = false;
            try
            {
                GebruikerRechtenDTO dto = new GebruikerRechtenDTO()
                {
                    RechtId = rechtId,
                    GebruikerId = gebruikerId
                };

                result = GebruikerDAL.GeefGebruikerRecht(dto);
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruikerRecht(int rechtId, int gebruikerId)
        {
            bool result = false;
            try
            {
                GebruikerRechtenDTO dto = new GebruikerRechtenDTO()
                {
                    RechtId = rechtId,
                    GebruikerId = gebruikerId
                };

                result = GebruikerDAL.VerwijderGebruikerRecht(dto);
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
            List<GebruikerDTO> gebruikerDTOs = GebruikerDAL.GetAll();

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

        public GebruikerTeamProfielDTO ToGTPDTO(int gebruikerId, int teamId, int profielId)
        {
            GebruikerTeamProfielDTO dto = new GebruikerTeamProfielDTO()
            {
                GebruikerId = gebruikerId,
                TeamId = teamId,
                ProfielId = profielId

            };

            return dto;
        }
    }
}
