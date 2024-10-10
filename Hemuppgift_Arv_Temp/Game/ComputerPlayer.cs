using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class ComputerPlayer : Player
    {
        public ComputerPlayer(string userId) : base(userId)
        {

        }

        public override int takePins(Board board)
        {
            Random rand = new Random();

            int pins = rand.Next(1, 3);

            board.takePins(pins);

            Console.WriteLine($"I take: {pins} {(pins > 1 ? "pins" : "pin")}");
            
            return board.getNoPins();
        }
    }
}
