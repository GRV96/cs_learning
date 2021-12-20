using System;

namespace cs_learning
{
    class Miscellanous
    {
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
        }

        public static void SwapData(ref dynamic data1, ref dynamic data2)
        {
            dynamic temporary = data1;
            data1 = data2;
            data2 = temporary;
        }
    }
}
