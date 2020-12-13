using ChallengeThree.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeThree_Repo
{
    public class BadgeContent
    {
        public int BadgeID { get; set; }

        public List<DoorContent> ListOfDoors { get; set; }

        public BadgeContent() { }

        public BadgeContent(int badgeID, List<DoorContent> listOfDoors)
        {
            BadgeID = badgeID;
            ListOfDoors = listOfDoors;
        }
    }
}
