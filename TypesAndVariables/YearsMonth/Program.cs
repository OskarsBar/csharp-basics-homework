using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearsMonth
{
    class Program
    {
        static void Main(string[] args)
        {
            double minutes;
            minutes = Convert.ToDouble(Console.ReadLine());
            minutesToYear(minutes);
            Console.Read();
        }

        private static void minutesToYear(double minutes)
        {
            double averageDaysInYear = 365.2425;
            double minInHour = 60;
            double hourInDay = 24;
            double daysInMonth = 30;
            double year;
            double month;
            year = (((minutes / minInHour) / hourInDay) / averageDaysInYear);
            month = ((((minutes / minInHour) / hourInDay) - (Math.Floor(year) * averageDaysInYear)) / daysInMonth);
            Console.WriteLine(" {1} minutes is the same as {0} years and {2} month ", Math.Floor(year), minutes, Math.Floor(month));

        }
    }
}
