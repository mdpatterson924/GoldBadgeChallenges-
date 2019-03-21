using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Challenge
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

        public decimal CalculateTotalCost(EventType eventType)
        {
            decimal eventCost = 0m;

            switch (eventType)
            {
                case EventType.AmusmentPark:
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;

                case EventType.Golf:
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;

                case EventType.Bowling:
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;

                case EventType.Concert:
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;
            }

            return eventCost;
        }
    }
}
