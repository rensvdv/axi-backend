using AxiBusinessLogicLayer.Objecten;
using AxiInterfaces.InterFaces;
using AxiInterfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxiBusinessLogicLayer.Containers
{
    public class LijstContainer
    {
        private readonly ILijst ILijst;

        public Lijst ToLijst(LijstDTO lijst)
        {
            return new(lijst.Id, lijst.Naam, null);
        }

        public LijstContainer(ILijst iLijst)
        {
            ILijst = iLijst;
        }

        public List<Lijst> GetLijstenByTeamId(int teamId)
        {
            try
            {
                return ILijst.GetLijstenByTeamId(teamId).Select(lijst => ToLijst(lijst)).ToList();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
                return null;
            }
        }
        public Lijst GetLijst(int id)
        {
            return ToLijst(ILijst.GetLijst(id));
        }
    }
}
