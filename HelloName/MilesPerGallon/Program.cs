using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            string userInput = Console.ReadLine();
            double miles = double.Parse(userInput);
            Console.WriteLine("How many gallons of gas were used?");
            userInput = Console.ReadLine();
            double gallons = double.Parse(userInput);
            double milesPerGal = miles / gallons;
            Console.WriteLine("Miles per gallon is " + milesPerGal);
        }
    }
}
