using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(test(a, b));

            Console.Read();
        }
        static bool test(int a, int b)
        {
            if (a == 15 || b == 15 || a - b == 15 || a + b == 15)
                return true;
            else
                return false;
        }
    }
}
