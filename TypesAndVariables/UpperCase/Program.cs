using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string word;
            word = Console.ReadLine();
            foreach (char leter in word)
            {
                counter++;
                if (Char.IsUpper(leter))
                {

                    Console.WriteLine("Uper case leter is {1} and it is {0} letter", counter, leter);
                }


            }
            Console.Read();
        }
    }
}
