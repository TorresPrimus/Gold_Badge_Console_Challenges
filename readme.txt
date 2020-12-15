Project Title:
Gold Badge Challenges

Motivation:
To be able to graduate from Gold badge and get into the next badge to learn more about coding.

Build Status:
C# completed with tests, some UI can be broken with incorrect inputs

Code Style:
I believe this is standard, I am unsure of what code styling is.

Screenshots:
none

Tech/Framework used:
Visual Studio 2019

Features:
Multi features to add and remove objects

Code Example:
CRUD method used for library

private void UpdateBadgeDoors()
        {
            Console.Clear();
            //show list of badges to choose from
            GetAllBadges();
            //return badge number and list of doors accessible
            Console.WriteLine("\nWhat badge would you like to update:");
            string badgeAsString = Console.ReadLine().ToLower();
            int userInput = int.Parse(badgeAsString);
            BadgeContent pulledID = _badgeRepo.GetBadgeContentByID(userInput);

            //option to add or remove doors
            Console.Clear();
            Console.WriteLine($"What would you like to do with {badgeAsString}:\n" +
                $"1. Add a Door\n" +
                $"2. Remove a Door");
            string menuChoice = Console.ReadLine().ToLower();

            //add door
            if (menuChoice == "1")
            {
                Console.WriteLine("What door would you like to add?");
                string userDoor = Console.ReadLine().ToLower();
                pulledID.ListOfDoors.Add(userDoor);
            }

            //remove door
            else if (menuChoice == "2")
            {
                Console.WriteLine("What door would you like to remove?");
                string userRemove = Console.ReadLine().ToLower();
                pulledID.ListOfDoors.Remove(userRemove);
            }

            else
            {
                Console.WriteLine("Incorrect entry, please enter 1 or 2...");
                Console.ReadLine();
            }

Installation:
no idea how to install this as an exe

Tests:
Tests for each programs CRUD methods
simply press F5 to start tests, all tests passed as intended

Credit:
Classmates at ElevenFifty and Instructors