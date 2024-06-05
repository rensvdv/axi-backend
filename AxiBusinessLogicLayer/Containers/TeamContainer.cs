using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxiBusinessLogicLayer.Entiteiten;
using AxiDal;
using AxiInterfaces.DTO;
using AxiInterfaces.InterFaces;

namespace AxiBusinessLogicLayer.Containers
{
    public class TeamContainer
    {
        private ITeam TeamDAL;
        private IGebruiker GebruikerDAL;
        private GebruikerContainer gebruikerContainer;
        public TeamContainer(ITeam teamDAL, IGebruiker gebruikerDAL)
        {
            TeamDAL = teamDAL;
            GebruikerDAL = gebruikerDAL;
            gebruikerContainer = new GebruikerContainer(GebruikerDAL);
        }

        public bool MaakTeam(Team team)
        {
            return TeamDAL.MaakTeam(ToDTO(team));
        }

        public bool WerkTeam(Team team)
        {
            return TeamDAL.WerkTeamBij(ToDTO(team));
        }

        public bool VerwijderTeam(Team team)
        {
            return TeamDAL.VerwijderTeam(ToDTO(team));
        }

        public bool VoegGebruikerAanTeamToe(int teamId, int gebruikerId)
        {
            return TeamDAL.VoegGebruikerAanTeamToe(teamId, gebruikerId);
        }

        public bool VerwijderGebruikerUitTeam(int teamId, int gebruikerId)
        {
            return TeamDAL.VerwijderGebruikerUitTeam(teamId, gebruikerId);
        }

        public List<Team> GetTeams()
        {
            return TeamDAL.GetTeams().Select(t => new Team(t)).ToList();
        }

        public Team GetTeam(int teamId)
        {
            try
            {
                TeamDTO dto = TeamDAL.GetTeam(teamId);
                return ToTeam(dto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return new Team();
            }
        }

        public TeamDTO ToDTO(Team team)
        {
            TeamDTO dto = new TeamDTO()
            {
                TeamId = team.TeamId,
                Naam = team.Naam,
                Beschrijving = team.Beschrijving,
                Actief = team.Actief
            };

            return dto;
        }

        public Team ToTeam(TeamDTO dto)
        {
            Team team = new Team()
            {
                TeamId = dto.TeamId,
                Naam = dto.Naam,
                Beschrijving = dto.Beschrijving,
                Actief = dto.Actief,
                Teamleden = gebruikerContainer.GetTeamGebruikers(dto.TeamId)
            };

            return team;
        }
    }
}
