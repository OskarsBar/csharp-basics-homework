using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int num = rand.Next(1, 100);
            string guess;
            int guessnum;
            Console.WriteLine("guess number");
            guess = Console.ReadLine();
            Console.WriteLine(guess);
            guessnum = int.Parse(guess);
            if (num == guessnum)
                Console.WriteLine("you are write");
            else if (num > guessnum)
                Console.WriteLine("Too low");
            else
                Console.WriteLine("Too hight");
            Console.WriteLine(num);
            Console.WriteLine(guessnum);
            Console.Read();


        }
    }
}
