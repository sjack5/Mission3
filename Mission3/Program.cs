using System;

namespace Mission3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe with group 1-3!");

            //Create new instance of our supporting program and empty char array
            supporting otherTeam = new supporting();
            char[] board = new char[9];

            //Loops through our array to fill the 9 possible spots a player can place their piece
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Where would player 1 like to go? (Pick a number between 0-8)");
                    int player1Choice = Convert.ToInt32(Console.ReadLine());

                    board[player1Choice] = 'X';

                    //Passing our array to the supporting program
                    otherTeam.BoardPrint(board);

                    char test = otherTeam.Winner(board);

                    //Whoever won would be printed here and end the loop
                    if (test == 'X')
                    {
                        i = 10;
                        Console.WriteLine("Congrats! Player 1 won!");
                    }
                }
                else
                {
                    //Loops through our array to fill the 9 possible spots a player can place their piece
                    Console.WriteLine("Where would player 2 like to go? (Pick a number between 0-8)");
                    int player2Choice = Convert.ToInt32(Console.ReadLine());

                    board[player2Choice] = 'O';

                    //Passing our array to the supporting program
                    otherTeam.BoardPrint(board);
                    char test = otherTeam.Winner(board);

                    //Whoever won would be printed here and end the loop
                    if (test == 'O')
                    {
                        i = 10;
                        Console.WriteLine("Congrats! Player 2 won!");
                    }
                }
            }
        }
    }
}
