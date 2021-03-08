using System;
using System.IO;
using System.Collections.Generic;
namespace Classes_CS_Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.ToString());
            List<int> li = new List<int>() ;
            li.Add(12);
            li.Add(44);
            foreach (var item in li)
            {
                Console.Write( $" {item}");
            }
            Garage garage = new Garage();
            garage.addCar(new Car("Volkswagen", new Engine(1,8), 170, 160));
            garage.addCar(new Car("BMW x5", new Engine(2,3), 180, 200));
            Console.WriteLine(garage.ToString());
            DateTime dateTime = DateTime.Now;
            DateTime birth = new DateTime(2005,11,2);
            Console.WriteLine(dateTime);
            Console.WriteLine(dateTime.Year);
            TimeSpan time = dateTime - birth;
            int age = (int)(time.TotalDays / 365.25);
            Console.WriteLine($"Age : {age}");

        }
    }
}
