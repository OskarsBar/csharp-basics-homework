using System;

namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];

        private static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int xOro = 0;
            InitBoard();
            DisplayBoard();
            Console.WriteLine("==================================-");
            while (true)
            {
                xOro++;
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                if (board[x, y] == 'x' || board[x, y] == 'o')
                {
                    Console.WriteLine("already taken");
                    xOro--;
                }
                else
                {
                    if (xOro % 2 == 0)
                        board[x, y] = 'x';
                    else
                        board[x, y] = 'o';
                    
                }
                DisplayBoard();
                if (board[x, y] == 'x' && board[x, y + 1] == 'x' && board[x, y + 2] == 'x')
                    Console.WriteLine("you win");


            }

            Console.Read();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
            
        }

        private static void DisplayBoard()
        {
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}
