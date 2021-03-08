using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_CS_Lesson4
{
    class Garage
    {
        List<Car> cars = new List<Car>();
        public void addCar(Car car)
        {
            if (car != null)
            {
                this.cars.Add(car);
            }
        }
        public void addCar(params Car[] cars)
        {
            if (cars != null)
            {
                this.cars.AddRange(cars);
            }
        }
        public override string ToString()
        {
            return String.Join('\n', cars);
        }
    }
}
