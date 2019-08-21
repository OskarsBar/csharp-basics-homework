using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfTen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int replaceNum = -7;
            int[] firstArray=new int[10];
            int[] secondArray=new int[10];

            initializeArray(firstArray,rand);
            Console.WriteLine(string.Join(" ", firstArray));
            copyAndReplace(firstArray, secondArray, replaceNum, secondArray.Length-1);
            Console.WriteLine(string.Join(" ", secondArray));
            Console.Read();
        }

        private static void copyAndReplace(int[] firstArray, int[] secondArray, int replaceNum, int index)
        {
            for(int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i];
            }
            secondArray[index] = replaceNum;
        }

        private static void initializeArray(int[] array,Random rand)
        {
            for(int i=0; i<array.Length;i++)
            {
                array[i] = rand.Next(1, 100);
            }
        }
    }
}
