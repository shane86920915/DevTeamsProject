using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DevTeamRepo
    {
        //private readonly DeveloperRepo _developerRepo = new DeveloperRepo(); // this gives you access to the _developerDirectory so you can access existing Developers and add them to a team
        private readonly List<DevTeam> _devTeams = new List<DevTeam>();

        //DevTeam Create
        public void AddTeamToList(DevTeam devteam)
        {
            _devTeams.Add(devteam);
        }

        //Another method called AddDevToTeam()*will need to use helper method.
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
        //DevTeam Read*need to be able to see the list of devs in that team.
        public List<DevTeam> GetDevTeamsList()
        {
            return _devTeams;
        }

        public List<DevTeam> GetDevTeamslist()
        {
            return _devTeams;
        }
        //DevTeam Update
        public bool UpdateExistingDevTeam(int originalId, DevTeam newDevTeam)
        {
            //find the content
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
        //DevTeam Delete
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

        //Another method called DeleteDevFromTeam()
        public bool DeleteDevFromTeam (int Id, int teamid)
            
        {
            DeveloperRepo Repo = new DeveloperRepo();
            Developer developer = Repo.GetDeveloperById(Id);

            if (developer == null)
            {
                return false;

            }
            int initialcount = _devTeams.Count;
            //_devTeams.Remove();
            //find the team that I want to delete a dev from use the team id and item id 
            foreach (var item in _devTeams)
            {
                if(teamid == item.Id)
                {

                item.listOfDevelopers.Remove(developer);
                }

            }
            
            

            return true;

            

        }

        //DevTeam Helper (Get Team by ID)
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



            





        
            

