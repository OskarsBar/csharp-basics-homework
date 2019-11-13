using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSquere
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            Console.WriteLine("min number");
            min = Convert.ToInt32( Console.ReadLine());
            int max;
            Console.WriteLine("Max number");
            max = Convert.ToInt32(Console.ReadLine());
            int num = min-1;
            bool ifMax = false;
            bool noAdd = false;

            Console.WriteLine("Result");
            if (min > max)
                Console.WriteLine("Make sure that Min is smalerThen Max");
            
            for (int y = min - 1; y < max; y++)
            {
                for (int x = min - 1; x < max; x++)
                {

                    Console.Write("{0} ",num%max+1);
                    if (num % max == max-1)
                        ifMax = true;
                    noAdd = true;
                    if (ifMax)
                    {
                        num += min;
                        ifMax = false;
                    }

                    else
                        num++;
                }
                Console.WriteLine();
                if(!noAdd)
                    num +=min;
                else
                {
                    num++;
                    noAdd = false;
                }
            }
            Console.Read();
        }
    }
}
