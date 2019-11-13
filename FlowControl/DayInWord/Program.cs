using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            if (day < 1 || day > 7)
                Console.WriteLine("no days");
            else
            {
                switch (day)
                {
                    case 1:
                        Console.WriteLine("Pirmdiena");
                        break;
                    case 2:
                        Console.WriteLine("Otrdiena");
                        break;
                    case 3:
                        Console.WriteLine("Treshdiena");
                        break;
                    case 4:
                        Console.WriteLine("Ceturdiena");
                        break;
                    case 5:
                        Console.WriteLine("Piektdiena");
                        break;
                    case 6:
                        Console.WriteLine("Sesdienadiena");
                        break;
                    case 7:
                        Console.WriteLine("Svetdinadiena");
                        break;
                    default:
                        Console.WriteLine("nav tadas dienas");
                        break;


                }
            }
            Console.Read();
        }
    }
}
