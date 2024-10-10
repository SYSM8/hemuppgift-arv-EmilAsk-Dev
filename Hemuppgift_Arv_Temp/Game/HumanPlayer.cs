using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string userId) : base(userId) 
        {

        }

        public override int takePins(Board board)
        {
            
            Console.WriteLine("Hur många Pins vill du ta");
            Console.WriteLine("[1]");
            Console.WriteLine("[2]");
            
            int input = Convert.ToInt32(Console.ReadLine());

            if(input > 2 || input < 1)
            {
                Console.WriteLine("input a number between 1-2");
                throw new Exception("input a number between 1-2");                    
            }            
            else if(board.getNoPins() < input)
            {
                throw new Exception("Cant pick more pins then is available");
            }
            board.takePins(input);
            
            return board.getNoPins();
            
            
        }
    }
}
