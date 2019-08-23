using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 347;
            Check(a);
            Console.Read();
        }

        private static void Check(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("evennn");
            else
                Console.WriteLine("addddd");
            Console.WriteLine("byeee");

        }
    }
}
