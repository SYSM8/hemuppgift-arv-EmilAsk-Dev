using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class TakePinsGame
    {
        static public void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.Clear();


            Board game = new Board();            
            Player human = new HumanPlayer("Emil");
            Player computer = new AdvancedPlayer("Ai");

            game.SetUp(20);
            bool isPlayer = true;    


            while (game.getNoPins() > 0)
            {
                try
                {
                    if (isPlayer)
                    {
                        human.takePins(game);
                        Console.Clear();
                    }
                    else
                    {
                        computer.takePins(game);
                    }

                    isPlayer = !isPlayer;

                    Console.WriteLine($"Pins left:{game.getNoPins()}");
                }
                catch
                {
                    Console.WriteLine("Wrong input");
                }                
            }

            if(!isPlayer)
            {
                Console.WriteLine("Player have won");
            }
            else
            {
                Console.WriteLine("Computer have won");
            }


            Console.WriteLine("Gameover");



            //take one or two pins 
        }
    }
}
