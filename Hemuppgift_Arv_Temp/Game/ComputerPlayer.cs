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
        // detta är den enkla ain

        public override int takePins(Board board)
        {
            
            Random rand = new Random(); //skapar en random klass

            int pins = rand.Next(1, 3); //slumpar ett tal mellan 1,2

            board.takePins(pins); // tar antal pins 

            Console.WriteLine($"I take: {pins} {(pins > 1 ? "pins" : "pin")}"); // skirver ut hur många pins roboten tar
            
            return board.getNoPins(); // returnar hur många pins som finns kvar
        }
    }
}
