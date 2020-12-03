using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance
{
    class ProgramUi
    {

        public void Run()
        {
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Select a menu option:\n" +
                     "1. Creat new developer team member\n" +
                     "2. View all team members\n" +
                     "3. Update existing developers\n" +
                     "4. Delete existing developers\n" +
                     "5. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        CreateNewDevTeam();
                        break;

                    case "2":


                         DisplayAllDevTeam();
                         break;

                    case "3":

                        UpdateExistingDevelopers();
                        break;

                    case "4":

                        DeleteExistingDevelopers();
                        break;

                    case "5":

                         Console.WriteLine("Goodbye!");
                        keepRunning = false;
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
    }

    private void CreateNewDevTeam()
    {
        Console.Clear();

        devTeam newDevTeam = new DevTeam();
        Console.WriteLine("Enter the id number of the developer.");
        string idAsString = Console.ReadLine();
        int idAsInt = int.Parse(idAsString);
        newDevTeam.Id = idAsInt;


    }
}




/*Info from Komodo Insurance:
Developers have names and ID numbers; we need to be able to identify one developer without mistaking them for another. We also need to know whether or not they have access to the online learning tool: Pluralsight.

Our managers need to be able to add and remove members to/from a team by their unique identifier. They should be able to see a list of existing developers to choose from and add to existing teams. Odds are, the manager will create a team, and then add Developers individually from the Developer Directory to that team.

Challenge: Our HR Department uses the software monthly to get a list of all our Developers that need a Pluralsight license. Create this functionality in the Console Application

Challenge: Some of our managers are nitpicky and would like the functionality to add multiple Developers to a team at once, rather than one by one. Integrate this into your application.


