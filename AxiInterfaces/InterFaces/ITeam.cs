using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiInterfaces.InterFaces
{
    public interface ITeam
    {
        public bool MaakTeam(TeamDTO teamDTO);
        public bool VerwijderTeam(TeamDTO teamDTO);
        public bool WerkTeamBij(TeamDTO teamDTO);
        public bool VoegGebruikerAanTeamToe(int teamId, int gebruikerId);
        public bool VerwijderGebruikerUitTeam(int teamId, int gebruikerId);
        public List<TeamDTO> GetTeams();
        public TeamDTO GetTeam(int teamId);
    }
}
