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
            int Start = 0, Option = 0;
            Console.Write("\n--------------------- \nSnake and Ladder Game \n"
                 + "---------------------\n" +
                 "Player is at Start position " + Start);
            while (Start != 100)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("\n Player got dice number " + dice);

                Option = random.Next(1, 4);
                Console.WriteLine("Option = " + Option);
                switch (Option)
                {
                    case 1:
                        Console.Write("No Play");
                        break;
                    case 2:
                        Console.Write("Ladder: Move up by " + dice);
                        Start += dice;
                        if(Start > 100)
                        {
                            Start -= Start - dice;
                        }
                        break;
                    case 3:
                        Console.Write("Snake: Move down by " + dice);
                        Start -= dice;
                        break;
                    default:
                        break;
                }
                if(Start < 0)
                {
                    Start = 0;
                }
            }
            Console.Write("\n Player reached at the end of game");
        }
    }
}
