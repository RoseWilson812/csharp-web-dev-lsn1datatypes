using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rectangle width");
            string userInput = Console.ReadLine();
            double width = double.Parse(userInput);
            Console.WriteLine("Enter rectangle length");
            userInput = Console.ReadLine();
            double length = double.Parse(userInput);
            double area = width * length;
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}
