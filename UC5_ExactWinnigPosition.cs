using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SnakesAndLaddersSinglePlayer
{
    class UC5_ExactWinnigPosition
    {
    public static void ExactWinnigPosition()
        {
            Console.WriteLine("Enter playername:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string Player1 = Console.ReadLine();
            // Print the value of the variable (Player1), which will display the input value
            Console.WriteLine("Player Name is: " + Player1);
            int position1 = 0;
            Console.WriteLine("Starting position of Player1(" + Player1 + ") is: " + position1);
            int final = 100;
            int count = 0;
            while (position1 < 100)
            {
                Random random = new Random();
                int die1num = random.Next(1, 7);
                position1 = position1 + die1num;
                if (position1 > final)
                {
                    position1 = position1 - die1num;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 4)
                {
                    position1 = 14;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 9)
                {
                    position1 = 31;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 20)
                {
                    position1 = 38;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 28)
                {
                    position1 = 84;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 40)
                {
                    position1 = 59;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 51)
                {
                    position1 = 67;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 63)
                {
                    position1 = 81;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 71)
                {
                    position1 = 90;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 17)
                {
                    position1 = 7;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 54)
                {
                    position1 = 34;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 62)
                {
                    position1 = 19;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 64)
                {
                    position1 = 60;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 87)
                {
                    position1 = 24;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 93)
                {
                    position1 = 73;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 95)
                {
                    position1 = 75;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else if (position1 == 99)
                {
                    position1 = 78;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
                else
                {
                    position1 = position1;
                    Console.WriteLine("Position of Player1(" + Player1 + ") is: " + position1);
                }
            }
            Console.ReadKey();
        }
    }
}
