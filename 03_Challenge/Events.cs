using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Challenge
{
    public enum EventType {Golf, Bowling, AmusmentPark, Concert}


    public class Events
    {
        public int Attendees { get; set; }
        public DateTime Date { get; set; }
        public Decimal IndividualCost { get; set; }
        public Decimal TotalCost { get; set; }
        public EventType EventType { get; set; }


        public Events(int attendees, DateTime date, decimal individualCost, decimal totalCost, EventType eventType)
        {
            Attendees = attendees;
            Date = date;
            IndividualCost = individualCost;
            TotalCost = totalCost;
            EventType = EventType;
        }

        public Events()
        {

        }
    }
}
