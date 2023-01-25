using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    public class supporting
    {
        //Receive the “board” array from the driver class

        //Contain a method that prints the board based on the information passed in
        public static void BoardPrint()
        {
            Console.WriteLine('|   |   |   |');
            Console.WriteLine('| {1} | {2} | {3} |', board[0], board[1], board[2]);
            Console.WriteLine('|___________|');
            Console.WriteLine('|   |   |   |');
            Console.WriteLine('| {1} | {2} | {3} |', board[3], board[4], board[5]);
            Console.WriteLine('|___________|');
            Console.WriteLine('|   |   |   |');
            Console.WriteLine('| {1} | {2} | {3} |', board[6], board[7], board[8]);

        }

        //Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public static void Winner()
        {
            flag = 0;
            while flag =! 1
            {
                if array[0] == board[1] && board[1] == board[2]
                {
                    flag = 1;
                    Console.WriteLine(board[0] + ' is the winner!')
                }
                if board[3] == board[4] && board[4] == board[5]
                {
                    flag = 1;
                    Console.WriteLine(board[3] + ' is the winner!')
                }
                if board[6] == board[7] && board[7] == board[8]
                {
                    flag = 1;
                    Console.WriteLine(board[6] + ' is the winner!')
                }
                if board[0] == board[4] && board[4] == board[8]
                {
                    flag = 1;
                    Console.WriteLine(board[0] + ' is the winner!')
                }
                if board[2] == board[4] && board[4] == board[6]
                {
                    flag = 1;
                    Console.WriteLine(board[2] + ' is the winner!')
                }
            }
        }
    }
}
