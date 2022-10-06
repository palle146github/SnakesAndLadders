using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SnakesAndLadders
{
    class UC1_SnakesAndLaddersStarting1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snakes And Ladders Game");
            Console.WriteLine("Enter playername:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string Player1 = Console.ReadLine();
            // Print the value of the variable (Player1), which will display the input value
            Console.WriteLine("Player Name is: " + Player1);
            int position1 = 0;
            Console.WriteLine("Starting position of Player1(" + Player1 + ") is: " + position1);
            Console.ReadKey();
        }
    }
}


