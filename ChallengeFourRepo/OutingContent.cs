using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeFourRepo
{
    public class OutingContent
    {
        public enum Events
        {
            Golf = 0,
            Bowling,
            Amusement_Park,
            Concert
        }
        public Events EventType { get; set; }
        public int AttendanceNumber { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double CostPerPerson { get; set; }
        public double TotalCost { get; set; }
        
        public OutingContent() {}
        public OutingContent(Events eventType, int attendanceNumber, DateTime dateOfEvent, double costPerPerson, double totalCost)
        {
            EventType = eventType;
            AttendanceNumber = attendanceNumber;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost;
        }

    }


}
