using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n,a;
            i = 2;
            a = 2;
            Console.WriteLine("Input number of terms : ");

            n = Convert.ToInt32(Console.ReadLine());

            
            //todo - complete loop to multiply i with itself n times, it is NOT allowed to use Math.Pow()
            for (int x=0;x<n;x++) {
                a =a*i ;
              Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
