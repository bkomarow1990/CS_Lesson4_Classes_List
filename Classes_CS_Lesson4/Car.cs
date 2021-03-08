using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_CS_Lesson4
{
    class Engine
    {
        public Engine(double volume, int v)
        {
            this.volume = volume;
        }
        public Engine()
        {
            volume = 0;
        }
        public double Volume // full propetry
        {
            get
            {
                return volume;
            }
            set
            {
                if (value > 0)
                {
                    this.volume = value;
                }

            }
        }
      
        private double volume;
        public override string ToString()
        {
            return $"Engine with volume : {volume}";
        }
    }
    class Car
    {
        private string brand;
        private uint speed;
        public readonly uint MaxSpeed = 360;
        public uint Speed
        {
            get=>speed;
            set => speed = value > MaxSpeed ? MaxSpeed : value;
        }
        public Engine Engine { get; set; }
        public string Brand
        {
            get => brand;
            set => brand = String.IsNullOrWhiteSpace(value) ? "NoBrand" : value;
        }
        public Car(string brand, Engine engine, uint speed=0, uint maxSpeed=360)
        {
            this.MaxSpeed = maxSpeed;
            this.Brand = brand;
            this.Speed = speed;
            this.Engine = engine;
        }
        public Car()
        :this("NoBrand", default(Engine)){

        }
        public override string ToString()
        {
            return $"Car- Brand: {brand}, Speed: {speed}, MaxSpeed: {MaxSpeed}, Engine: {Engine?.ToString()}";
        }
    }
}
