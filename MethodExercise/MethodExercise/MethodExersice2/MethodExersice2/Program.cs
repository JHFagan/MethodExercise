using System;

namespace MethodExersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(15, 25));
            Console.WriteLine(Multiply(15, 25));
            Console.WriteLine("What is x?");
            //var inputX = Convert.ToInt32(Console.ReadLine());  type.parse checks if string input can convert to that certain type
            var inputX = double.Parse(Console.ReadLine());
            Console.WriteLine("What is y?");
            //var inputY = Convert.ToInt32(Console.ReadLine());   "       "
            var inputY = double.Parse(Console.ReadLine());
            Console.WriteLine(Add(inputX, inputY));
            Console.WriteLine(Multiply(inputX, inputY));
            Console.WriteLine(Subtract(inputX, inputY));
            Console.WriteLine(Divide(inputX, inputY));
        }

        public static double Add(double x, double y)
        {
            return (x + y);
        }
        public static double Multiply(double x, double y)
        {
            return (x * y);
        }
        public static double Subtract(double x, double y)
        {
            return (x - y);
        }
        public static double Divide(double x, double y)
        {
            return (x / y);
        }
         

        

    }
}
