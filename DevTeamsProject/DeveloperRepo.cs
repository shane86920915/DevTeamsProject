using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        public void AddDevToList(Developer developer)
        {
            _developerDirectory.Add(developer);

        }
        public List<Developer> GetDevelopersList()
        {
            return _developerDirectory;
        }

        public bool UpdateExistingDeveloper(int originalId, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDeveloperById(originalId);

            if (oldDeveloper != null)
            {
                oldDeveloper.Id = newDeveloper.Id;
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.HasPluralsight = newDeveloper.HasPluralsight;
                oldDeveloper.Devroles = newDeveloper.Devroles;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool RemoveDeveloperFromList(int originalId)
        {
            Developer developer = GetDeveloperById(originalId);

            if (developer == null)
            {
                return false;
            }
            int initialcount = _developerDirectory.Count;
            _developerDirectory.Remove(developer);

            if (initialcount > _developerDirectory.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Developer GetDeveloperById(int id)
        {
            foreach (Developer Developer in _developerDirectory)
            {
                if (Developer.Id == id)
                {
                    return Developer;
                }
            }
            Console.WriteLine("There is no Dev with the ID of {0}", id);
            return null;
        }
    }
}
