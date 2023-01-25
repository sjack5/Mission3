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
        public void BoardPrint(char[] arr)
        {
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| {0} | {1} | {2} |", arr[0], arr[1], arr[2]);
            Console.WriteLine("|___________|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| {0} | {1} | {2} |", arr[3], arr[4], arr[5]);
            Console.WriteLine("|___________|");
            Console.WriteLine("|   |   |   |");
            Console.WriteLine("| {0} | {1} | {2} |", arr[6], arr[7], arr[8]);

        }

        //Contain a method that receives the game board array as input and returns if there is a winner and who it was
        public char Winner(char[] arr)
        {
            for (int i = 0; i <= 8; i++)
            {
                //check rows
                if (arr[0] == arr[1] && arr[1] == arr[2])
                {
                    return (arr[0]);
                }
                if (arr[3] == arr[4] && arr[4] == arr[5])
                {
                    return (arr[3]);

                }
                if (arr[6] == arr[7] && arr[7] == arr[8])
                {
                    return (arr[6]);

                }
                //check diagonals
                if (arr[0] == arr[4] && arr[4] == arr[8])
                { 
                    return (arr[0]);

                }
                if (arr[2] == arr[4] && arr[4] == arr[6])
                {
                    return (arr[2]);

                }
                //check columns
                if (arr[0] == arr[3] && arr[3] == arr[6])
                {
                    return (arr[0]);
                }
                if (arr[1] == arr[4] && arr[4] == arr[7])
                {
                    return (arr[1]);

                }
                if (arr[2] == arr[5] && arr[5] == arr[8])
                {
                    return (arr[2]);

                }

                return "N";
                    
            }
            
        }
    }
}
