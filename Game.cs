using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadder
{
    internal class Game
    {
        public void SnakeLadder()
        {
            int Start = 0;
            Console.Write("\n--------------------- \nSnake and Ladder Game \n"
                + "---------------------\n" +
                "Player is at Start position " + Start);
            Random random = new Random();
            int dice = random.Next(1, 7);
            Console.WriteLine("\n Player got dice number " + dice);
        }
    }
}
