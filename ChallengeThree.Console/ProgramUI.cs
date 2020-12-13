using ChallengeThree_Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Console
{
    class ProgramUI
    {
        private BadgeRepo _badgeRepo = new BadgeRepo();
        private DoorRepo _doorRepo = new DoorRepo();

        public void Run()
        {
            DefaultBadges();
            SecurityMenu();
        }

        public void SecurityMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Chose a menu item:\n" +
                    "1. Add a Badge\n" +
                    "2. Edit a Badge\n" +
                    "3. List All Badges\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewBadge();
                        break;
                    case "2":
                        UpdateBadgeDoors();
                        break;
                    case "3":
                        GetAllBadges();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using KomodoSecurityOS, Good Bye!");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Error... please enter valid number!");
                        break;
                }
            }
        }

        private void AddNewBadge()
        {
            //badge number
            //add door to badge

            //add more doors?

        }

        private void UpdateBadgeDoors()
        {
            //lookup badge
            //return badge number and list of doors accessible

            //option to add or remove doors

            //add door

            //remove door

        }

        private void GetAllBadges()
        {
            //list all badges and door access

        }
        private void DefaultBadges()
        {

        }

    }
}
