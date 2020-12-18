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

        //delete

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
