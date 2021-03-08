using System;

namespace Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cl = new Client("Boris", "+380688241700");
            Console.WriteLine(cl.ToString());
        }
    }
}
