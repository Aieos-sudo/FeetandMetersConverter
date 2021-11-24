using System;

namespace FeetandMetersConverter
{
    internal class Program
    {
        static void Title()
        {
            Console.WriteLine("Feet and Meters Converter");
            Main();
        }
        static void Main(string[] args)
        {
            string confirmation;
            string conversion;
            do
            {
                Console.WriteLine("Conversions Menu:");
                Console.WriteLine("a. Feet to Meters");
                Console.WriteLine("b. Meters to Feet");
                Console.Write("Select a conversion (a/b): ");
                conversion = Console.ReadLine();
            }
            while (confirmation == "y");
        }
    }
}
