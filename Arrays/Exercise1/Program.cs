using System;
namespace Exercise1
{
    class Program
    {
        //TODO: Write a C# program to sort a numeric array and a string array.
        private static void Main(string[] args)
        {
            int[] myArray1 = {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            string[] myArray2 = {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };
            Console.WriteLine("Original number");
            printArray(myArray1);
            Array.Sort(myArray1);
            Console.WriteLine("Sorted  number");
            printArray(myArray1);

            Console.WriteLine("Original words");
            printArray(myArray2);
            Array.Sort(myArray2);
            Console.WriteLine("Sorted  sorted");
            printArray(myArray2);

            Console.Read();
            /*
            fixme
            Console.WriteLine("Original numeric array : " + .........);
            ........... //Sort array
            Console.WriteLine("Sorted numeric array : " + .........);
    
            Console.WriteLine("Original string array : " + .........);
            ......... //Sort array
            Console.WriteLine("Sorted string array : " + .........);
            */
        }

        private static void printArray(string[] myArray1)
        {
            foreach (var year in myArray1)
            {
                Console.WriteLine(year);
            }
        }
        private static void printArray(int[] myArray1)
        {
            foreach (var year in myArray1)
            {
                Console.WriteLine(year);
            }
        }
    }
}
