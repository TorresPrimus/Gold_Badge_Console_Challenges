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
            Amusement_Park = 1,
            Bowling,
            Concert,
            Golf
        }
        public Events EventType { get; set; }
        public int AttendanceNumber { get; set; }
        public DateTime DateOfEvent { get; set; }
        public double CostPerPerson { get; set; }
        public double TotalCost 
        {
            get {
                double totalCost = CostPerPerson * AttendanceNumber;
                return totalCost;
            }
        }
        
        public OutingContent() {}
        public OutingContent(Events eventType, int attendanceNumber, DateTime dateOfEvent, double costPerPerson)
        {
            EventType = eventType;
            AttendanceNumber = attendanceNumber;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            
        }

    }


}
