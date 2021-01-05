using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name ");

            var fullName = Console.ReadLine();
            var today = "January 5th 2021";

            Console.WriteLine("\n");
            Console.WriteLine($"Hello {fullName}, the date is {today}, how many cups of coffee have you had today?");

            var numberOfCupsOfCoffee = Console.ReadLine();
            var cupsOfCoffee = int.Parse(numberOfCupsOfCoffee);

            Console.WriteLine("\n");
            Console.WriteLine($"On {today} you had {cupsOfCoffee} cups of coffee {fullName}, how many more do you plan on having?");

            var moreCups = Console.ReadLine();
            var moreCupsOfCoffee = int.Parse(moreCups);
            var sum = int.Parse(moreCups) + int.Parse(numberOfCupsOfCoffee);
            var difference = int.Parse(numberOfCupsOfCoffee) - int.Parse(moreCups);
            var product = (sum) * 2;
            var quotient = int.Parse(numberOfCupsOfCoffee) / int.Parse(moreCups);
            var remainder = int.Parse(numberOfCupsOfCoffee) % int.Parse(moreCups);

            Console.WriteLine("\n");
            Console.WriteLine($"On {today} you plan on having {sum} cups of coffee");
            Console.WriteLine("\n");
            Console.WriteLine($"The difference between {numberOfCupsOfCoffee} and {moreCups} is {difference}");
            Console.WriteLine("\n");
            Console.WriteLine($"{sum} doubled is {product}");
            Console.WriteLine("\n");
            Console.WriteLine($"{numberOfCupsOfCoffee} divided by {moreCups} is {quotient} with a remainder of {remainder}");
            Console.WriteLine("\n");

        }
    }
}
