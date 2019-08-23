using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piggy
{
    class Program
    {
        static void Main(string[] args)
        {
            string play;
            int a = 5;
            int poits = 0;
            Random rand = new Random();
            int digit = 0;
            while (a == 5)
            {
                Console.WriteLine("continue ?");
                play=Console.ReadLine();
                if (play == "y")
                    break;
                digit =rand.Next(1, 7);

                if (digit == 1)
                {
                    Console.WriteLine("its 1 you lose");
                    poits = 0;
                    break;
                }
                else
                {
                    poits =poits +digit;
                    Console.WriteLine("You have {0} points",poits);
                }
                
            }
            Console.WriteLine("you win with {0} points", poits);
            Console.Read();
        }
    }
}
