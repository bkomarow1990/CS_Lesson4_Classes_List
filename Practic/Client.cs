using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practic
{
    class Client
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }
        private string number;
        public string Number
        {
            get => number;
            set
            {
                string tmp = value.Remove(0, 1);// (string)value;
                if (tmp.All(c => char.IsDigit(c)) && value[0] == '+')
                {
                    this.number = value;
                }
                else {
                    Console.WriteLine("Don`t work");
                }
                
            }
        }
        public Client(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public override string ToString()
        {
            return $".Client. Name: {name}, Phone: {number}";
        }

    }
}
