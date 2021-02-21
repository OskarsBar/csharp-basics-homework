using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;

            word = Console.ReadLine();
            foreach (char e in word)
            {
                switch (e)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        Console.Write("1");
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        Console.Write("2");
                        break;
                    case 'g':
                    case 'h':
                    case 'i':
                        Console.Write("3");
                        break;

                }
            }
        }
    }
}
