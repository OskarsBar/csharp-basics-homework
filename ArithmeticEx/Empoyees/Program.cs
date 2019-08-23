using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empoyees
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Salary(7.50, 35));
            Console.WriteLine(Salary(10.00, 50));
            Console.WriteLine(Salary(10.00, 73));
            Console.Read();
        }

        private static string Salary(double hourPay, int hours)
        {
            double minHourPay = 8.00;
            double overTimePay = 1.5;
            double maxHours = 60;
            double overtimeStart = 40;

            if (hourPay < minHourPay)
                return ("error");
            else if (hours > maxHours)
                return ("error");
            else
            {
                if (hours <= overtimeStart)
                    return Convert.ToString(hourPay * hours);
                else
                    return Convert.ToString((hourPay * hours) + ((hours - 40) * (hourPay * 0.5)));
            }

        }
    }
}
