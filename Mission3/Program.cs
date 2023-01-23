using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe with group 1-3!");

            char[] board = new char[9];

            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Where would player 1 like to go? (Pick a number between 0-8)");
                    int player1Choice = Convert.ToInt32(Console.ReadLine());

                    board[player1Choice] = 'X';
                }
                else
                {
                    Console.WriteLine("Where would player 2 like to go? (Pick a number between 0-8)");
                    int player2Choice = Convert.ToInt32(Console.ReadLine());

                    board[player2Choice] = 'O';
                }
            }
        }
    }
}
