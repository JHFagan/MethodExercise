using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's Your Name?");
            var name = Console.ReadLine();
            Console.WriteLine("What's Your Favorite Color?");
            var favColor = Console.ReadLine();
            Console.WriteLine("What's Your Favorite Animal?");
            var favAnimal = Console.ReadLine();
            Console.WriteLine("What's Your Favorite Band's Name?");
            var favBand = Console.ReadLine();

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite Color: {favColor}");
            Console.WriteLine($"Favorite Animal: {favAnimal}");
            Console.WriteLine($"Favorite Band: {favBand}");
        }
    }
}
