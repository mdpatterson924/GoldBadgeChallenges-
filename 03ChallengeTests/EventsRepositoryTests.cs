using System;
using _03Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03ChallengeTests
{
    [TestClass]
    public class EventsRepositoryTests
    {
        private EventsRepositoryTests eventsRepository;

        [TestMethod]
        public void EventsRepository_GetItemsCorrectCount()
        {
            EventsRepository _eventsRepo = new EventsRepository();
            Events itemOne = new Events();

            _eventsRepo.AddEventsToList(itemOne);

            int actual = _eventsRepo.GetEventsList().Count;
            int expected = 1;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EventsRepository_RemoveEventsFromList()
        {
            EventsRepository _eventsRepo = new EventsRepository();
            Events itemOne = new Events();
            Events itemTwo = new Events();

            _eventsRepo.AddEventsToList(itemOne);
            _eventsRepo.AddEventsToList(itemTwo);

            _eventsRepo.RemoveEventsFromList(itemOne);
            _eventsRepo.RemoveEventsFromList(itemTwo);

            int actual = _eventsRepo.GetEventsList().Count;
            int expected = 0;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EventsRepository_RemoveEventsItemsBySpecifications_BoolShouldReturnTrue()
        {
            EventsRepository _eventsRepo = new EventsRepository();
            Events events = new Events();

            _eventsRepo.AddEventsToList(events);

            
            bool actual = _eventsRepo.RemoveEventsItemsBySpecifications(5);
            bool expected = false;

            Assert.AreEqual(expected, actual);
        }
    }
}
