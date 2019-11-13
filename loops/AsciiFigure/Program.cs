using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsciiFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            string left = "//// ";
            string midle = "**** ";
            string right = @"\\\\ ";

            int castleSize = 9;

            int leftCount = castleSize-1;
            int midleCount = 0;
            int rightCount = castleSize-1;
            
                Console.WriteLine("tadaa");

                for (int x = 0; x < castleSize; x++) 
            {
                for (int y = 0; y < (castleSize-1) * 2; y++)
                {
                    if (y < leftCount)
                        Console.Write(left);
                    else if (y >= leftCount && y < rightCount)
                        Console.Write(midle);
                    else
                        Console.Write(right);
                }
                leftCount -= 1;
                rightCount += 1;
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
