using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(sum);
            Console.Read();
        }
    }
}
