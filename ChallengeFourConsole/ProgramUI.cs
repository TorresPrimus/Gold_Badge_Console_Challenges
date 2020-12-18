using ChallengeFourRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChallengeFourRepo.OutingContent;

namespace ChallengeFourConsole
{
    public class ProgramUI
    {
        private OutingContent _content = new OutingContent();
        private OutingRepo _repo = new OutingRepo();

        public void Run()
        {
            DefaultOuting();
            Menu();
        }

        public void Menu()
        {
            bool keeprunning = true;
            while (keeprunning)
            {
                Console.Clear();
                Console.WriteLine("1. Display all Outings.\n" +
                    "2. Add indivisdual Outing.\n" +
                    "3. Calculations\n" +
                    "4. Exit");
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        DisplayAllOutings();
                        break;
                    case "2":
                        AddOuting();
                        break;
                    case "3":
                        Calculations();
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using KomodoEventsOS!, Good bye!");
                        keeprunning = false;
                        break;
                    default:
                        Console.WriteLine("Error... please enter valid number!");
                        break;
                }
            }
        }
        private void DisplayAllOutings()
        {
            Console.Clear();
            List<OutingContent> listContents = _repo.GetAllOutings();

            //list all outings
            Console.WriteLine("{0,-15} {1,-12}{2,-12}{3,-12}{4,-12}", "Event Type", "# of people", "Date", "Cost/Person", "Total Cost");

            foreach (OutingContent item in listContents)
            {
                Console.WriteLine($"{item.EventType,-16}{item.AttendanceNumber,-12}{item.DateOfEvent.ToString("MM/dd/yyyy"),-12}{item.CostPerPerson,-12:C}{item.TotalCost,-12:C}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void AddOuting()
        {
            OutingContent newOuting = new OutingContent();

            Console.Clear();
            Console.WriteLine("Enter Event Type:\n" +
                "1. Amusement Park\n" +
                "2. Bowling\n" +
                "3. Concert\n" +
                "4. Golf");
            string typeAsString = Console.ReadLine();
            int typeAsInt = int.Parse(typeAsString);
            newOuting.EventType = (Events)typeAsInt;

            Console.WriteLine("How many people attended the event? (enter number)");
            newOuting.AttendanceNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of event: (ex. 01/01/2020");
            newOuting.DateOfEvent = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What is the cost per person? ex. 99.99");
            newOuting.CostPerPerson = double.Parse(Console.ReadLine());

            _repo.AddNewOuting(newOuting);

        }
        private void Calculations()
        {
            List<OutingContent> listContents = _repo.GetAllOutings();
            Console.Clear();
            Console.WriteLine("What would you like to see\n" +
                "1. Combined cost of all outings\n" +
                "2. Outing Cost by type");
            switch (Console.ReadLine())
            {
                case "1":
                    //foreach (OutingContent item in listContents)
                    //{
                    //    item.TotalCost;
                    //}
                    double total = listContents.Sum(item => item.TotalCost);
                    Console.WriteLine($"All outings combined cost: {total:C}");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine("Enter Event Type:\n" +
                        "1. Amusement Park\n" +
                        "2. Bowling\n" +
                        "3. Concert\n" +
                        "4. Golf");
                    Events events = (Events)int.Parse(Console.ReadLine());
                    var pulledEvents = _repo.GetOutingByType(events);
                    Console.WriteLine($"All {events} outings cost {listContents.Sum(item => pulledEvents.TotalCost):C}"); //getting incorrect number when add
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Error... please enter valid option...");
                    break;
            }
        }

        public void DefaultOuting()
        {
            OutingContent torres = new OutingContent(OutingContent.Events.Amusement_Park, 150, new DateTime(2020, 06, 04), 25);
            OutingContent owen = new OutingContent(OutingContent.Events.Bowling, 50, new DateTime(2020, 10, 31), 15);
            OutingContent ruudberg = new OutingContent(OutingContent.Events.Concert, 450, new DateTime(2020, 07, 26), 45);
            OutingContent litzsey = new OutingContent(OutingContent.Events.Golf, 16, new DateTime(2020, 09, 14), 65);

            _repo.AddNewOuting(torres);
            _repo.AddNewOuting(owen);
            _repo.AddNewOuting(ruudberg);
            _repo.AddNewOuting(litzsey);
        }
    }
}
