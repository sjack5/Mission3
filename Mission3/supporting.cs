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
            Console.WriteLine('|   |   |   |');
            Console.WriteLine('|   |   |   |');
        }

         //Contain a method that receives the game board array as input and returns if there is a winner and who it was
         public static void Winner()
        {
            flag = 0;
            while flag =! 1
            {
                if array[0] == array[1] && array[1] == array[2]
                {
                    flag = 1;
                    Console.WriteLine(array[0] + ' is the winner!')
                }
                if array[3] == array[4] && array[4] == array[5]
                {
                    flag = 1;
                    Console.WriteLine(array[3] + ' is the winner!')
                }
                if array[6] == array[7] && array[7] == array[8]
                {
                    flag = 1;
                    Console.WriteLine(array[6] + ' is the winner!')
                }
                if array[0] == array[4] && array[4] == array[8]
                {
                    flag = 1;
                    Console.WriteLine(array[0] + ' is the winner!')
                }
                if array[2] == array[4] && array[4] == array[6]
                {
                    flag = 1;
                    Console.WriteLine(array[2] + ' is the winner!')
                }
            }
        }
    }
}
