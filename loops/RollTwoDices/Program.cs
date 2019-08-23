using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTwoDices
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum = 9;
            Console.WriteLine("disired Sum {0}", sum);
            Random rand = new Random();

            while (true)
            {
                int a = rand.Next(1, 6);
                int b = rand.Next(1, 6);
                int c = a + b;
                Console.WriteLine("{0} and {1} = {2}", a, b, c);
                if (c == sum)
                    break;
            }
            Console.Read();
        }
    }
}
