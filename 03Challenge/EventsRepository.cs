using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Challenge
{
    public class EventsRepository
    {
        List<Events> _eventsList = new List<Events>();
        Events _events = new Events();

        public void AddEventsToList(Events events)
        {
            _eventsList.Add(events);
        }

        public List<Events> GetEventsList()
        {
            return _eventsList;
        }

        public void RemoveEventsFromList(Events events)
        {
            _eventsList.Remove(events);
        }
        public bool RemoveEventsItemsBySpecifications(int id)
        {
            bool successful = false;
            foreach (Events events in _eventsList)
            {
                if (events.ID == id)
                {
                    RemoveEventsFromList(events);
                    successful = true;
                    break;
                }
            }
            return successful;
        }
        //public decimal CalculateTotalCost(EventType eventType)
        //{
        //    decimal eventCost = 0m;
        //    foreach (Events events in _eventsList)
        //    {
        //        switch (eventType)
        //        {
        //            case EventType.AmusmentPark:
        //               if(events.EventType == eventType) eventCost = _events.Attendees * _events.IndividualCost;
        //                break;

        //            case EventType.Golf:
        //                eventCost = _events.Attendees * _events.IndividualCost;
        //                break;

        //            case EventType.Bowling:
        //                eventCost = _events.Attendees * _events.IndividualCost;
        //                break;

        //            case EventType.Concert:
        //                eventCost = _events.Attendees * _events.IndividualCost;
        //                break;
        //        }
        //    }
        //    return eventCost;
        //}
    }
}
