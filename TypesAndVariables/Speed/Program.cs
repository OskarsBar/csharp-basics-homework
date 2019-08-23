using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = 2500;
            double hours = 5;
            double minutes = 56;
            double seconds = 23;

            speed(distance, hours, minutes, seconds);
            Console.Read();
        }

        private static void speed(double distance, double hours, double minutes, double seconds)
        {
            double minInHour = 60;
            double sekInMin = 60;
            double mInKm = 1000;
            double mInMile = 1609; // is ok ??

            double totalSeconds;
            double mPerSec;
            double kmPerHour;
            double milesPerHour;

            totalSeconds = seconds + (minutes * minInHour) + (hours * sekInMin * minInHour);
            mPerSec = distance / totalSeconds;
            Console.WriteLine(Math.Round(mPerSec, 8));
            kmPerHour = (distance / mInKm) / ((totalSeconds / sekInMin) / minInHour);
            Console.WriteLine(Math.Round(kmPerHour, 9));
            milesPerHour = (distance / mInMile) / ((totalSeconds / sekInMin) / minInHour);
            Console.WriteLine(Math.Round(milesPerHour, 9));
        }
    }
}
