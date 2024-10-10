using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class AdvancedPlayer : Player
    {
        public AdvancedPlayer(string userId) : base(userId)
        {

        }

        public override int takePins(Board board)
        {
            int pins = board.getNoPins();
            if(pins % 2 != 0)
            {
                board.takePins(1);
                Console.WriteLine($"I take: 1 pin");
            }
            else
            {
                board.takePins(2);
                Console.WriteLine($"I take: 2 pins");
            }
                                             
            
            
            return board.getNoPins();
        }
    }
}
