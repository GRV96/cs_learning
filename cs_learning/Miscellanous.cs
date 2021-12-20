using System;

namespace cs_learning
{
    class Miscellanous
    {
        public static bool IsLeapYear(int year)
        {
            if(year == 0)
            {
                throw new ArgumentException("Year 0 does not exist.");
            }

            return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
        }

        private static void PrintIsLeapYear(int year)
        {
            try
            {
                Console.WriteLine("{0} is a leap year: {1}", year, IsLeapYear(year));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static void PrintSwappedData(dynamic data1, dynamic data2)
        {
            Console.WriteLine("Data before swap: {0}; {1}", data1, data2);
            SwapData(ref data1, ref data2);
            Console.WriteLine("Data after swap: {0}; {1}", data1, data2);
        }

        public static void RunFunctions()
        {
            double Pi = 3.1459;
            String PiAsStr = "pi";
            double Phi = 2.618;
            PrintSwappedData(Pi, Phi);
            Console.WriteLine();
            PrintSwappedData(Pi, PiAsStr);

            Console.WriteLine();

            PrintIsLeapYear(2004);
            PrintIsLeapYear(2000);
            PrintIsLeapYear(1996);
            PrintIsLeapYear(1904);
            PrintIsLeapYear(1900);
            PrintIsLeapYear(1896);
            PrintIsLeapYear(1895);
            PrintIsLeapYear(0);
            PrintIsLeapYear(-1);
            PrintIsLeapYear(-4);
        }

        public static void SwapData(ref dynamic data1, ref dynamic data2)
        {
            dynamic temporary = data1;
            data1 = data2;
            data2 = temporary;
        }
    }
}
