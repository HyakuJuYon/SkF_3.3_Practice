using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Hyaku";

            Console.WriteLine("My Name is " + MyName);

            byte MyAge = 30;

            Console.WriteLine("My Age is " + MyAge);

            bool DoIHavePets = true;

            Console.WriteLine("Do I have any pets? "+ DoIHavePets);

            double MyShoeSize = 39;

            Console.WriteLine("The size of my shoes is " + MyShoeSize);

            Console.WriteLine("IntMin {0} ", int.MinValue);

            Console.WriteLine("IntMax {0} ", int.MaxValue);

            Console.ReadKey();
        }
    }
}
