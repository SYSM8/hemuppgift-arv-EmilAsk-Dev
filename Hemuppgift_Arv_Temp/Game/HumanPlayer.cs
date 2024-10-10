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
            //skriver en menu för att ta en eller 2 
            Console.WriteLine("Hur många Pins vill du ta");
            Console.WriteLine("[1]");
            Console.WriteLine("[2]");
            //tar in input
            int input = Convert.ToInt32(Console.ReadLine());


            //kollar så att nummret inte är större än 2 och mindre än 1
            if(input > 2 || input < 1)
            {
                //skriver ut fel medellenade
                Console.WriteLine("input a number between 1-2");
                throw new Exception("input a number between 1-2");                    
            }            
            else if(board.getNoPins() < input) // kollar så att man inte tar fler än vad som finns
            {
                // felmeddelande
                throw new Exception("Cant pick more pins then is available");
            }
            //tar antalet pins
            board.takePins(input);
            //returnerar antalet pins 
            return board.getNoPins();
            
            
        }
    }
}
