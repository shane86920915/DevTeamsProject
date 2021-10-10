using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        public void AddTeamToList(DevTeam devteam)
        {
            _devTeams.Add(devteam);
        }

        public bool AddDevToTeam (DevTeam devteam)
        {
            int beforecount = _devTeams.Count;
            _devTeams.Add(devteam);

            int aftercount = _devTeams.Count;

       

            return aftercount == beforecount + 1;
        }

        public void AddDevs(int teamId, Developer developer)
        {
            foreach (var item in _devTeams)
            { 
                
                if (teamId == item.Id)
                {
                    item.listOfDevelopers.Add(developer);
                }
            }
        }
        public List<DevTeam> GetDevTeamsList()
        {
            return _devTeams;
        }

        public List<DevTeam> GetDevTeamslist()
        {
            return _devTeams;
        }
        public bool UpdateExistingDevTeam(int originalId, DevTeam newDevTeam)
        {
            DevTeam oldDevTeam = GetDevTeamById(originalId);

            if (oldDevTeam != null)
            {
                oldDevTeam.Id = newDevTeam.Id;
                oldDevTeam.listOfDevelopers = oldDevTeam.listOfDevelopers;
                oldDevTeam.TeamName = oldDevTeam.TeamName;
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool RemoveDevTeamFromList(int originalId)
        {
            DevTeam devteam = GetDevTeamById(originalId);

            if (devteam == null)
            {
                return false;
            }
            int initialcount = _devTeams.Count;
            _devTeams.Remove(devteam);

            if (initialcount > _devTeams.Count)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public bool DeleteDevFromTeam (int Id, int teamid)
            
        {
            DeveloperRepo Repo = new DeveloperRepo();
            Developer developer = Repo.GetDeveloperById(Id);

            if (developer == null)
            {
                return false;

            }
            int initialcount = _devTeams.Count;
        
            foreach (var item in _devTeams)
            {
                if(teamid == item.Id)
                {

                item.listOfDevelopers.Remove(developer);
                }
            }
            return true;
        }

        public DevTeam GetDevTeamById (int id)
        {
            foreach (DevTeam DevTeam in _devTeams)
            {
                if (DevTeam.Id == id)
                    return DevTeam;
            }
            return null;
        }

    }
}
