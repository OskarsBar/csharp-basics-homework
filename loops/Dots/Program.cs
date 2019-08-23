using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dots
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1="tadaa";
            string word2 = "tajjkidaa";
            Console.Write(word1);
            for(int i = 0; i < 30 - (word1.Length + word2.Length); i++)
            {
                Console.Write(".");
            }
            Console.Write(word2);
            Console.Read();
        }
    }
}
