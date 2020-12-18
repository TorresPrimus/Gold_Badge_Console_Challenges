using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ChallengeFourRepo.OutingContent;

namespace ChallengeFourRepo
{
    public class OutingRepo
    {
        private List<OutingContent> _outingContent = new List<OutingContent>();

        //create
        public void AddNewOuting(OutingContent content)
        {
            _outingContent.Add(content);
        }
        //read
        public List<OutingContent> GetAllOutings()
        {
            return _outingContent;
        }

        //update
        public bool UpdateOuting(Events originalEventType, OutingContent newOutingContent)
        {
            OutingContent oldOutingContent = GetOutingByType(originalEventType);

            if (oldOutingContent != null)
            {
                oldOutingContent.EventType = newOutingContent.EventType;
                oldOutingContent.AttendanceNumber = newOutingContent.AttendanceNumber;
                oldOutingContent.DateOfEvent = newOutingContent.DateOfEvent;
                oldOutingContent.CostPerPerson = newOutingContent.CostPerPerson;
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete
        public bool DeleteOuting(Events eventType)
        {
            OutingContent outingContent = GetOutingByType(eventType);

            if (outingContent == null)
            {
                return false;
            }

            int initialCount = _outingContent.Count();
            _outingContent.Remove(outingContent);

            if (initialCount > _outingContent.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper
        public OutingContent GetOutingByType(Events eventType)
        {
            foreach (OutingContent item in _outingContent)
            {
                if (item.EventType == eventType)
                {
                    return item;
                }
                
            }
            return null;
        }
    }
}
