using System;

namespace MethodExersice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is x?");
            //var inputX = Convert.ToInt32(Console.ReadLine());  type.parse checks if string input can convert to that certain type
            var inputX = double.Parse(Console.ReadLine());
            Console.WriteLine("What is y?");
            //var inputY = Convert.ToInt32(Console.ReadLine());   "       "
            var inputY = double.Parse(Console.ReadLine());
            Console.WriteLine("What is z?");
            var inputZ = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Add(inputX, inputY));
            Console.WriteLine(Add(inputX, inputY, inputZ));
            Console.WriteLine(Multiply(inputX, inputY));
            Console.WriteLine(Subtract(inputX, inputY));
            Console.WriteLine(Divide(inputX, inputY));
            Console.WriteLine(Add(1, 2, true));
        }

        public static double Add(double x, double y)
        {
            return (x + y);
        }
        public static double Add(double x, double y, double z)
        {
            return (x + y + z);
        }
        public static string Add(int x, int y, bool isTrue)
        {
            if (isTrue)
            {
                return (x + y) + " Dollar(s)";
            }
            else return "System Error";
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
