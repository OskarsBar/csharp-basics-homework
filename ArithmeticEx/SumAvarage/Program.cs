using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAvarage
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNum = 7;
            int highNum = 10;

            Console.WriteLine(SumAvarage(lowNum, highNum));
            Console.WriteLine(SumFormul(lowNum, highNum));
            Console.WriteLine(SumRek(lowNum, highNum));
            Console.Read();
        }

        private static double SumRek(double low, double high)
        {
            if (low == high)
                return low;
            else
                return high + SumRek(low, high - 1);
        }

        private static double SumFormul(double low, double high)
        {
            return (((low + high) / 2) * (high - low + 1));
        }

        private static double SumAvarage(double low, double high)
        {
            return (low + high) / 2;
        }
    }
}

