using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsProject
{
    public class DeveloperRepo
    {
        //simulate a database
        private readonly List<Developer> _developerDirectory = new List<Developer>();

        //Developer Create
        public void AddDevToList(Developer developer)
        {
            _developerDirectory.Add(developer);

        }
        //Developer Read
        public List<Developer> GetDevelopersList()
        {
            return _developerDirectory;
        }

        //Developer Update
        public bool UpdateExistingDeveloper(int originalId, Developer newDeveloper)
        {
            //find the content
            Developer oldDeveloper = GetDeveloperById(originalId);

            //update the content
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

        //Developer Delete
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

        //Developer Helper (Get Developer by ID)
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
