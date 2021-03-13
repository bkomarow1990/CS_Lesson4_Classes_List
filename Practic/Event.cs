using System;
using System.Collections.Generic;
using System.Text;

namespace Practic
{
    class Event
    {
        private string name;
        private uint count_peoples;
        private DateTime time_event= new DateTime();
        private string place_event;
        public readonly uint ID;
        private static uint counter;
        static Event() {
            counter = 0;
        }
        private Client client= new Client();
        public string Name
        {
            get => name;
            set {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        public uint CountPeoples
        {
            get => count_peoples;
            set
            {
                this.count_peoples = value;
            }
        }
        public DateTime TimeEvent
        {
            get => time_event;
            set
            {
                if (DateTime.Now > value)
                {
                    Console.WriteLine("Event must be in future");
                    return;
                }
                this.time_event = value;
            }
        }
        public string PlaceEvent
        {
            get => place_event;
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    this.place_event = value;
                }
            }
        }
        public Client Client
        {
            get => client;
            set
            {
                if (value!= null)
                {
                    this.client = value;
                    return;
                }
                Console.WriteLine("Client isn`t init");
            }
        }
        public Event(Client client, DateTime time_event, string name = "NoName", uint count_peoples = 0, string place_event = "NoPlace")
        {
            this.ID = ++counter;
            this.Client = client;
            this.TimeEvent = time_event;
            this.Name = name;
            this.CountPeoples = count_peoples;
            this.PlaceEvent = place_event;
            
        }
        public override string ToString()
        {
            return $"----------------------------------------Event with id - {ID}---------------------------------------- \n{client.ToString()} \nTime of event: {time_event}, \t Name of event {name}, \t Count peoples {count_peoples}, \nPlace of event: {place_event}";
        }
        public void addDays(uint days)
        {
            if (days <= 0)
            {
                Console.WriteLine("Nothing to do");
                return;
            }
            this.time_event = time_event.AddDays(days);
        }
        public void addWeeks(uint weeks)
        {
            if (weeks <= 0)
            {
                Console.WriteLine("Nothing to do");
                return;
            }
            weeks *= 7;
            this.time_event = time_event.AddDays(weeks);
        }
        public static List<Event> getEventsOnNextWeek( List<Event> events)
        {
            List<Event> result= new List<Event>();
            foreach (var item in events)
            {
                if (DateTime.Now.AddDays(6) <= item.TimeEvent && item.TimeEvent <= DateTime.Now.AddDays(14))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
