using System;
namespace Exercise3
{
    class Program
    {
        //TODO: Write a C# program to calculate the average value of array elements.
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};
            int sum=0;
            double avarage = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine("Sum of numbers is {0}", sum);
            avarage = (double)sum / numbers.Length;
            Console.WriteLine("avarage is {0}", avarage);
            /*
            fixme - calculate sum of all array elements 
            int sum = 0;
            for (?){
                
            }
            */

            /*
            fixme - calculate average value 
            Console.Write-Line("Average value of the array elements is : " + average);
            */
        }
    }
}
