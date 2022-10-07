using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class UC6_CountingTheNumTimesDicePlayed
    {
     public static void CountingTheNumTimesDicePlayed()
        {
        Console.WriteLine("Enter playername:");
        // Create a string variable and get user input from the keyboard and store it in the variable
        string Player1 = Console.ReadLine();
        // Print the value of the variable (Player1), which will display the input value
        Console.WriteLine("Player Name is: " + Player1);
        int position1 = 0;
        Console.WriteLine("Starting position of Player1(" + Player1 + ") is: " + position1);
        int final = 100;
        int count = 1;
        int frequency = 0;
        while (position1 < final)
        {
            Random random = new Random();
            int die1num = random.Next(1, 7);
            position1 = position1 + die1num;
            if (position1 > final)
            {
                position1 = position1 - die1num;
            }
            else if (position1 == 4)
            {
                position1 = 14;
            }
            else if (position1 == 9)
            {
                position1 = 31;
            }
            else if (position1 == 20)
            {
                position1 = 38;
            }
            else if (position1 == 28)
            {
                position1 = 84;
            }
            else if (position1 == 40)
            {
                position1 = 59;
            }
            else if (position1 == 51)
            {
                position1 = 67;
            }
            else if (position1 == 63)
            {
                position1 = 81;
            }
            else if (position1 == 71)
            {
                position1 = 90;
            }
            else if (position1 == 17)
            {
                position1 = 7;
            }
            else if (position1 == 54)
            {
                position1 = 34;

            }
            else if (position1 == 62)
            {
                position1 = 19;
            }
            else if (position1 == 64)
            {
                position1 = 60;
            }
            else if (position1 == 87)
            {
                position1 = 24;
            }
            else if (position1 == 93)
            {
                position1 = 73;
            }
            else if (position1 == 95)
            {
                position1 = 75;
            }
            else if (position1 == 99)
            {
                position1 = 78;
            }
            else
            {
                position1 = position1;
            }
            Console.WriteLine("Die Frequency : " + count + " Position of Player1 (" + Player1 + ") is : " + position1);
            count += 1;
            frequency += 1;
        }
        Console.WriteLine("Numbe of times dice played " + frequency);
        Console.ReadKey();
    }
}
    



