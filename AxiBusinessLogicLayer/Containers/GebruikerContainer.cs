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

        public GebruikerContainer(IGebruiker gebruikerDAL)
        {
            GebruikerDAL = gebruikerDAL;
        }

        public GebruikerContainer()
        {

        }

        public bool MaakGebruiker(Gebruiker gebruiker)
        {
            try
            {
                return GebruikerDAL.MaakGebruiker(ToDTO(gebruiker));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateGebruiker(Gebruiker gebruiker)
        {
            try
            {
                return GebruikerDAL.UpdateGebruiker(ToDTO(gebruiker));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruiker(Gebruiker gebruiker)
        {
            try
            {
                return GebruikerDAL.VerwijderGebruiker(ToDTO(gebruiker));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool GeefGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            try
            {
                GebruikerTeamProfielDTO dto = ToGTPDTO(gebruikerId, teamId, profielId);

                return GebruikerDAL.GeefGebruikerTeamProfiel(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool UpdateGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            try
            {
                GebruikerTeamProfielDTO dto = ToGTPDTO(gebruikerId, teamId, profielId);

                return GebruikerDAL.UpdateGebruikerTeamProfiel(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruikerTeamProfiel(int profielId, int gebruikerId, int teamId)
        {
            try
            {
                GebruikerTeamProfielDTO dto = ToGTPDTO(gebruikerId, teamId, profielId);

                return GebruikerDAL.VerwijderGebruikerTeamProfiel(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool GeefGebruikerRecht(int rechtId, int gebruikerId)
        {
            try
            {
                GebruikerRechtenDTO dto = new()
                {
                    RechtId = rechtId,
                    GebruikerId = gebruikerId
                };
                return GebruikerDAL.GeefGebruikerRecht(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public bool VerwijderGebruikerRecht(int rechtId, int gebruikerId)
        {
            try
            {
                GebruikerRechtenDTO dto = new()
                {
                    RechtId = rechtId,
                    GebruikerId = gebruikerId
                };

                return GebruikerDAL.VerwijderGebruikerRecht(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public List<Gebruiker> GetAllGebruikers()
        {
            return GebruikerDAL.GetAll().Select(m => new Gebruiker(m)).ToList();
        }

        public Gebruiker GetGebruiker(int id)
        {
            return new(GebruikerDAL.GetUserById(id));
        }
        public Gebruiker ToGebruiker(GebruikerDTO gebruikerDTO)
        {
            return new(
                gebruikerDTO.Id,
                gebruikerDTO.Name,
                gebruikerDTO.Email,
                gebruikerDTO.Password,
                gebruikerDTO.Actief);
        }

        public GebruikerDTO ToDTO(Gebruiker gebruiker)
        {
            return new()
            {
                Id = gebruiker.Id,
                Name = gebruiker.Naam,
                Email = gebruiker.Email,
                Password = gebruiker.Password,
                Actief = gebruiker.Actief
            };
        }

        public GebruikerTeamProfielDTO ToGTPDTO(int gebruikerId, int teamId, int profielId)
        {
            GebruikerTeamProfielDTO dto = new()
            {
                GebruikerId = gebruikerId,
                TeamId = teamId,
                ProfielId = profielId

            };
            return dto;
        }
    }
}
