using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Factorial with recursion {FactorialWithRecursion(5)}");
            Console.WriteLine($"Factorial with iteration {FactorialWithIteration(5)}");
            Console.ReadLine();
        }

        public static int FactorialWithRecursion(int number)
        {
            if (number == 0) return 1;
            
            return number * FactorialWithRecursion(number - 1);
        }

        public static int FactorialWithIteration(int number)
        {
            var factorial = 1;

            for (var i = number -1 ; i>=1; i--)
            {
                factorial += factorial * i;
            }

            return factorial;
        }
    }
}
