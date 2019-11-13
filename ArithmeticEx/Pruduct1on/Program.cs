using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruduct1on
{
    class Program
    {
        static void Main(string[] args)
        {
            int low = 1;
            int high = 10;
            Console.WriteLine(Fraction(low, high));
            Console.Read();
        }
        private static double Fraction(double low, double high)
        {
            if (low == high)
                return low;
            else
                return high * Fraction(low, high - 1);
        }
    }
}
