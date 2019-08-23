using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double weightInKg = 80;
            double highInM = 1.86;
            Bmi(weightInKg, highInM);
            Console.Read();
        }

        private static void Bmi(double weightInKg, double highInM)
        {
            double highInInch;
            double weighInPound;
            weighInPound = weightInKg * 2.20462262;
            highInInch = highInM * 39.3700787;

            double bmi = (weighInPound * 703) / (highInInch * highInInch);
            Console.WriteLine("Your BMI is {0}", bmi);
        }
    }
}
