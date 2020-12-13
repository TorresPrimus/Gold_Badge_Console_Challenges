using ChallengeThree.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Repo
{
    public class DoorRepo
    {
        private List<DoorContent> _listOfDoors = new List<DoorContent>();

        //Create
        public void AddDoor(DoorContent content)
        {
            _listOfDoors.Add(content);
        }

        //Read
        public List<DoorContent> GetDoors()
        {
            return _listOfDoors;
        }

        //Update
        public bool UpdateDoor(string originalDoor, DoorContent newDoor)
        {
            DoorContent oldDoor = GetDoorByName(originalDoor);

            if (oldDoor != null)
            {
                oldDoor.DoorName = newDoor.DoorName;
                return true;
            }
            else
            {
                return false;
            }

            int initialCount = _listOfDoors.Count;
            _listOfDoors.Remove(oldDoor);

            if (initialCount > _listOfDoors.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Delete
        public bool RemoveDoor(string ingredientName)
        {
            DoorContent door = GetDoorByName(ingredientName);

            if (door == null)
            {
                return false;
            }

            int initialCount = _listOfDoors.Count;
            _listOfDoors.Remove(door);

            if (initialCount > _listOfDoors.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Helper
        public DoorContent GetDoorByName(string doorName)
        {
            foreach (DoorContent content in _listOfDoors)
            {
                if (content.DoorName == doorName)
                {
                    return content;
                }
            }

            return null;
        }
    }
}
