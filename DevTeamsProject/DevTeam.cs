using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeam
    {
        public int Id { get; set; }
        public List<Developer> listOfDevelopers { get; set; } = new List<Developer>();
        public string  TeamName { get; set; }

        public DevTeam()
        {

        }

        public DevTeam(int id, List<Developer> listofdevelopers, string teamname)
        {
            Id = id;
            listOfDevelopers = listofdevelopers;
            TeamName = teamname;
        }
    }

}
