using System;

namespace cs_learning
{
    class Mathematics
    {
        public static ulong Factorial(uint number)
        {
            // An overflow occurs if i >= 21.
            if(number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }

        public static uint GreatestCommonDivisor(int number1, int number2)
        {
            // This function executes the Euclidean algorithm.
            number1 = Math.Abs(number1);
            number2 = Math.Abs(number2);

            while(number2 > 0)
            {
                int remainder = number1 % number2;
                number1 = number2;
                number2 = remainder;
            }

            return (uint) number1;
        }

        private static void PrintFactorial(uint number)
        {
            Console.WriteLine("Factorial of {0}: {1}",
                number, Factorial(number));
        }

        private static void PrintGcd(int number1, int number2)
        {
            Console.WriteLine("GCD({0}, {1}): {2}",
                number1, number2, GreatestCommonDivisor(number1, number2));
        }

        private static void PrintSwappedIntegers(int number1, int number2)
        {
            Console.WriteLine("Integers before swap: {0}; {1}", number1, number2);
            unsafe
            {
                SwapIntegers(&number1, &number2);
            }
            Console.WriteLine("Integers after swap: {0}; {1}", number1, number2);
        }

        public static void RunFunctions()
        {
            for(int i=0; i<=20; i++)
            {
                PrintFactorial((uint) i);
            }

            Console.WriteLine();

            PrintGcd(7, 0);
            PrintGcd(19, 7);
            PrintGcd(42, 56);
            PrintGcd(720, 96);

            Console.WriteLine();

            PrintSwappedIntegers(49, 53);
        }

        public static unsafe void SwapIntegers(int* number1, int* number2)
        {
            int temporary = *number1;
            *number1 = *number2;
            *number2 = temporary;
        }
    }
}
