using System;

namespace FeetandMetersConverter
{
    internal class Program
    {
        static void Title()
        {
            Console.WriteLine("Feet and Meters Converter\n");
        }
        static void Main(string[] args)
        {
            string confirmation;
            string feet;
            string meters;
            do
            {
                Title();
                string conversionSelection = Menu();
                if (conversionSelection == "a")
                {
                    Console.Write("Enter feet: ");
                    feet = Console.ReadLine();
                    //Can make a double if changing conversionFeet to return to a double. Console.WriteLine() will convert double to string automatically
                    string stringMeters = ConversionFeet(feet);
                    Console.WriteLine(stringMeters + " meters");
                }
                else if (conversionSelection == "b")
                {
                    Console.Write("Enter meters: ");
                    meters = Console.ReadLine();
                    //Can make a double if changing conversionMeters to return to a double. Console.WriteLine() will convert double to string automatically
                    string stringFeet = ConversionMeters(meters);
                    Console.WriteLine(stringFeet + " feet");
                }
                Console.WriteLine();
                Console.Write("Would you like to perform another conversion? (y/n): ");
                confirmation = Console.ReadLine();
                Console.WriteLine();
            }
            while (confirmation == "y");
            Console.WriteLine("Thanks, bye!");
        }

        static string Menu()
        {
            string conversionSelection;
            Console.WriteLine("Conversions Menu:");
            Console.WriteLine("a. Feet to Meters");
            Console.WriteLine("b. Meters to Feet");
            Console.Write("Select a conversion (a/b): ");
            //good method chaining
            conversionSelection = Console.ReadLine().ToLower();
            Console.WriteLine();
            //assuming they return either a or b, just return conversionSelection
            //return conversionSelection;
            if (conversionSelection == "a")
            {
                return "a";
            }
            else if (conversionSelection == "b")
            {
                return "b";
            }
            else
            {
                conversionSelection = Menu();
                return conversionSelection;
            }
        }
        static string ConversionMeters(string meters)
        {
            double doubleMeters = Convert.ToDouble(meters);
            double feet = Math.Round(doubleMeters / 0.3048,2);
            //Can leave this as returning a double and just return feet.
            string stringFeet = Convert.ToString(feet);
            return stringFeet;
        }   
        static string ConversionFeet(string feet)
        {
            double doubleFeet = Convert.ToDouble(feet);
            double meters = Math.Round(doubleFeet * .3048,2);
            //Can leave this as returning a double and just return meters.
            string stringMeters = Convert.ToString(meters);
            return stringMeters;
        }
    }
}
