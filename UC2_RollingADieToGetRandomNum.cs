using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SnakesAndLaddersSinglePlayer
{
    public class UC2_RollingADieToGetRandomNum
    {
        public static void RollingADie()
        {
            Random random = new Random();
            int die1num = random.Next(1, 7);
            Console.WriteLine(die1num);
        }
    }
}
