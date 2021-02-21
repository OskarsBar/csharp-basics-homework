using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabulas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+------------------------------------+");
            for (int i = 0;  i < 5;i++) {
                drawTab("oskars", "majas", "lsdkfjghd");
            }
            Console.WriteLine("+------------------------------------+");
            Console.Read();
            
        }

        private static void drawTab(string v1, string v2, string v3)
        {
            Console.WriteLine(String.Format("|{0,10}|{1,12}|{2,12}|", v1, v2, v3));

        }
    }
}
