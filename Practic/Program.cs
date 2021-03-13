using System;
using System.Linq;
using System.Collections.Generic;
namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client("Boris", "+380688241700");
            Console.WriteLine(cl.ToString());
            Event hb = new Event(cl,new DateTime(2021, 6, 21),"Birthday",22, "Macuri" );
            Console.WriteLine(hb.ToString());
            Console.WriteLine("Added days: ");
            hb.addDays(222);
            Console.WriteLine(hb.ToString());
            Console.WriteLine("Added weeks: ");
            hb.addWeeks(2);
            Console.WriteLine(hb.ToString());
            Console.WriteLine("Main tasks: ");
            Console.WriteLine("All events in next week: ");
            List<Event> events = new List<Event>();
            events.Add(new Event(new Client("Leha", "+380688241701"), new DateTime(2021, 6, 21), "Birthday", 22, "Macuri"));
            events.Add(new Event(new Client("Max", "+38095828929"), new DateTime(2021, 6, 28), "Birthday2", 23, "Macuri"));
            events.Add(new Event(new Client("Oleg", "+38046828929"), new DateTime(2021, 6, 28), "Birthday2", 19, "Macuri"));
            events.Add(new Event(new Client("Max2", "+38090828929"), new DateTime(2021, 3, 24), "Birthday2", 24, "Macuri"));
            var events_next_week = Event.getEventsOnNextWeek(events);
            foreach (var item in events_next_week)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Min max count clients");
            int max_c = (int)events.Max(one => one.CountPeoples);
            int min_c = (int)events.Min(one => one.CountPeoples);
            Console.WriteLine($"Max Count: {max_c}");
            Console.WriteLine($"Min Count: {min_c}");
        }
    }
}
