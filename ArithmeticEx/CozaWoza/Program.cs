using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozaWoza
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 11; y++)
                {
                    num++;
                    if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
                        Console.Write("CozaLozaWoza ");
                    else if (num % 3 == 0 && num % 5 == 0)
                        Console.Write("CozaLoza ");
                    else if (num % 3 == 0 && num % 7 == 0)
                        Console.Write("CozaWoza ");
                    else if (num % 5 == 0 && num % 7 == 0)
                        Console.Write("LozaWoza ");
                    else if (num % 3 == 0)
                        Console.Write("Coza ");
                    else if (num % 5 == 0)
                        Console.Write("Loza ");
                    else if (num % 7 == 0)
                        Console.Write("Woza ");
                    else
                        Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
