using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Challenge
{
    class ProgramUI
    {
        private Events _events;
        private EventsRepository _eventsRepo;

        public ProgramUI()
        {
            _events = new Events();
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Veiw outing List" +
                    "2. Get cost of all outings combined" +
                    "3. Get cost of all outing types combined\n" +
                    "4. Exit Application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        ViewEventsList();
                        break;
                    case 2:
                        CalculateTotalCost();
                        break;
                    case 3:
                        CalculateTotalCostByOutingType();
                        break;
                    case 4:
                        running = false;
                        break;

                }

            }
        }

        public void ViewEventsList()
        {
            List<Events> events = _eventsRepo.GetEventsList();

            foreach (Events eventsList in events)
            {
                Console.ReadLine($"{eventsList.Attendees}
                { eventsList});
            }
        }

        public decimal CalculateByType(EventType eventType)
        {
            decimal eventCost = 0m;
            List<Events> eventList = _eventsRepo.GetEventsList();
            switch (eventType)
            {
                case EventType.AmusmentPark:
                    foreach (var events in eventList)
                    {
                        if(events.EventType == EventType.AmusmentPark)
                        {
                            eventCost += events.TotalCost;
                        }
                    }
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;

                case EventType.Golf:
                    foreach (var events in eventList)
                    {
                        if (events.EventType == EventType.AmusmentPark)
                        {
                            eventCost += events.TotalCost;
                        }
                    }
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;

                case EventType.Bowling:
                    foreach (var events in eventList)
                    {
                        if (events.EventType == EventType.AmusmentPark)
                        {
                            eventCost += events.TotalCost;
                        }
                    }
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;

                case EventType.Concert:
                    foreach (var events in eventList)
                    {
                        if (events.EventType == EventType.AmusmentPark)
                        {
                            eventCost += events.TotalCost;
                        }
                    }
                    eventCost = _events.Attendees * _events.IndividualCost;
                    break;
            }

            return eventCost;
        }
    }
}
