using DevTeamsProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devteamconsole
{
    class ProgramUI//the resposibility of the programUI is to run all the ui methods
    {

        private DeveloperRepo _developerRepo = new DeveloperRepo();
        private readonly DevTeamRepo _devTeamRepo = new DevTeamRepo();
        public void Run()
        {
            seedDeveloperList();
            Menu();
        }

        private void Menu()
        {
            bool KeepRunning = true;
            while (KeepRunning)
            {

                // display out options to the user
                Console.WriteLine("Select a menu option:\n" +
                    "1. Creat new dev team\n" +
                    "2. Creat new dev member\n" +
              
                    "3  Delete existing team"+
                    "4. View all team members\n" +
                    "5. Update existing developers\n" +
                    "6. Delete existing developers\n" +
                    "7. Exit") ;




                //get the users input
                string input = Console.ReadLine();

                //evaluate the users input and act accordingly
                switch (input)
                {
                    case "1":
                        CreateNewTeam();
                        break;
                    //creat new content
                    case "2":
                        CreatNewDeveloper();
                        break;
                    case "3":
                        DeleteExistingTeam();
                        break;
                    case "4":

                        //View all Team Members
                        DisplayAllDevelopers();
                        break;

                    case "5":
                        //Update Existing Developers
                        UpdateExistingDevelopers();

                        break;
                    case "6":
                        //Delete Existion Developers
                        DeleteExistingDevelopers();
                        break;
                    case "7":
                        //exit
                        Console.WriteLine("Goodbye!");
                        KeepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;

                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();


            }

        }
        private void CreateNewTeam()
        {
            DevTeam newDevTeam = new DevTeam();
            Console.WriteLine("Enter the id number of the team of developers");
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);
            newDevTeam.Id = idAsInt;


            Console.WriteLine("Enter the name of the team.");
            newDevTeam.TeamName = Console.ReadLine();
        }








        private void CreatNewDeveloper()
                {
                    Console.Clear();

                    //type      //name         //value
                    Developer newDeveloper = new Developer();
                    Console.WriteLine("Enter the id number of the developer.");
                    string idAsString = Console.ReadLine();
                    int idAsInt = int.Parse(idAsString);
                    newDeveloper.Id = idAsInt;

                    Console.WriteLine("Enter the name of the developer.");
                    newDeveloper.Name = Console.ReadLine();

                    Console.WriteLine("Does the developer hava a pluralsight account? (y/n)");
                    string hasPluralsight = Console.ReadLine().ToLower();

                    if (hasPluralsight == "y")
                    {
                        newDeveloper.HasPluralsight = true;
                    }
                    else
                    {
                        newDeveloper.HasPluralsight = false;
                    }

                    Console.WriteLine("Enter the role  of the developer:\n" +
                        "1.Junior\n" +
                        "2.Midlevel\n" +
                        "3.Senior");

                    string devroleAsString = Console.ReadLine();
                    int devroleAsInt = int.Parse(devroleAsString);
                    newDeveloper.Devroles = (DevRole)devroleAsInt;

                    _developerRepo.AddDevToList(newDeveloper);

        }


        public void DeleteExistingTeam()
        {
            string idAsString = Console.ReadLine();
            int idAsInt = int.Parse(idAsString);

            bool wasDeleted = _devTeamRepo.RemoveDevTeamFromList(idAsInt);
            

            if (wasDeleted)
            {
                Console.WriteLine("Team was successfully deleted.");

            }
            else
            {
                Console.WriteLine("The team could not be deleted.");
            }

        }












        public void DisplayAllDevelopers()


            {
                Console.Clear();
                List<Developer> listOfDeveloper = _developerRepo.GetDevelopersList();

                foreach (Developer developers in listOfDeveloper)
                {
                    Console.WriteLine($"Id: {developers.Id}\n" +
                        $"Name: {developers.Name}\n" +
                        $"HasPlurelsight: {developers.HasPluralsight}\n" +
                        $"Devrole: {developers.Devroles}");

                }




            }



            public void UpdateExistingDevelopers()
            {
                //display all content
                DisplayAllDevelopers();


                //ask for the title of the content to update
                Console.WriteLine("Enter the ID of the developer you would like to update:");

                //get that title
                string OldId = Console.ReadLine();
                int oldIdAsInt = int.Parse(OldId);

                //we will build a new object
                Developer newDeveloper = new Developer();
                Console.WriteLine("Enter the id number of the developer.");
                string idAsString = Console.ReadLine();
                int idAsInt = int.Parse(idAsString);
                newDeveloper.Id = idAsInt;

                Console.WriteLine("Enter the name of the developer.");
                newDeveloper.Name = Console.ReadLine();

                Console.WriteLine("Does the developer hava a pluralsight account? (y/n)");
                string hasPluralsight = Console.ReadLine().ToLower();

                if (hasPluralsight == "y")
                {
                    newDeveloper.HasPluralsight = true;
                }
                else
                {
                    newDeveloper.HasPluralsight = false;
                }

                Console.WriteLine("Enter the role  of the developer:\n" +
                    "1.Junior\n" +
                    "2.Midlevel\n" +
                    "3.Senior");

                string devroleAsString = Console.ReadLine();
                int devroleAsInt = int.Parse(devroleAsString);
                newDeveloper.Devroles = (DevRole)devroleAsInt;

                _developerRepo.UpdateExistingDeveloper(oldIdAsInt, newDeveloper);


            }




            private void DeleteExistingDevelopers()
            {



            


            Console.WriteLine("Enter the Id of the Developer you would like to remove:");

                string idAsString = Console.ReadLine();
                int idAsInt = int.Parse(idAsString);

                bool wasDeleted = _developerRepo.RemoveDeveloperFromList(idAsInt);

                if (wasDeleted)
                {
                    Console.WriteLine("Developer was successfully deleted.");

                }
                else
                {
                    Console.WriteLine("The content could not be deleted.");
                }







            }

            private void seedDeveloperList()
            {
                Developer DavidWillis = new Developer(6, "DavidWillis", true, DevRole.Midlevel);
                Developer JonDow = new Developer(7, "JonDow", true, DevRole.Midlevel);
                Developer MaryLindle = new Developer(8, "MaryLindle", false, DevRole.Senior);



                _developerRepo.AddDevToList(DavidWillis);
                _developerRepo.AddDevToList(JonDow);
                _developerRepo.AddDevToList(MaryLindle);

            }





       
    }
}








