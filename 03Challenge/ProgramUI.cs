using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03Challenge
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
                        CalculateByType();
                        break;
                    case 4:
                        running = false;
                        break;

                }
            }
        }

        private void CalculateTotalCost()
        {
            List<Events> outings = _eventsRepo.GetEventsList();
            decimal total = 0; 
            foreach (Events outing in outings)
            {
                total += outing.TotalCost;
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }

        public void ViewEventsList()
        {
            List<Events> events = _eventsRepo.GetEventsList();

            foreach (Events eventsList in events)
            {
                Console.WriteLine($"{eventsList.Attendees}{ eventsList}");
            }
        }
        public void CalculateByType()
        {
            decimal eventCost = 0m;
            List<Events> eventList = _eventsRepo.GetEventsList();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Please select whcih outing type you would like to display the cost of\n" +
                    "1.Golf" +
                    "2.Bowling" +
                    "3.Amusment Park" +
                    "4.Concert" +
                    "5.Go to main menu");

                int input = int.Parse(Console.ReadLine());

                decimal bowling = 0;
                decimal golf = 0;
                decimal amusmentPark = 0;
                decimal concert = 0;


                switch (input)
                {
                    case 1:
                        foreach (var events in eventList)
                        {
                            if (events.EventType == EventType.AmusmentPark)
                            {
                                golf += events.TotalCost;
                            }
                        }
                        eventCost = _events.Attendees * _events.IndividualCost;
                        break;

                    case 2:
                        foreach (var events in eventList)
                        {
                            if (events.EventType == EventType.AmusmentPark)
                            {
                                bowling += events.TotalCost;
                            }
                        }
                        eventCost = _events.Attendees * _events.IndividualCost;
                        break;

                    case 3:
                        foreach (var events in eventList)
                        {
                            if (events.EventType == EventType.AmusmentPark)
                            {
                                amusmentPark += events.TotalCost;
                            }
                        }
                        eventCost = _events.Attendees * _events.IndividualCost;
                        break;

                    case 4:
                        foreach (var events in eventList)
                        {
                            if (events.EventType == EventType.AmusmentPark)
                            {
                                concert += events.TotalCost;
                            }
                        }
                        eventCost = _events.Attendees * _events.IndividualCost;
                        break;
                }
            }
            Console.WriteLine($"Total cost for event: {eventCost}");
        }
    }
}
