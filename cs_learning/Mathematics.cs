using System;

namespace cs_learning
{
    class Mathematics
    {
        public static ulong Factorial(uint number)
        {
            // An overflow occurs if i >= 21.
            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        public static void PrintFactorial(uint number)
        {
            Console.WriteLine("Factorial of {0}: {1}", number, Factorial(number));
        }

        public static void RunFunctions()
        {
            for(int i=0; i<=20; i++)
            {
                PrintFactorial((uint) i);
            }
        }
    }
}
