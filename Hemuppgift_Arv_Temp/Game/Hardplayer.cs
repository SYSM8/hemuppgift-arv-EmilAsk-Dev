using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class HardPlayer : Player
    {
        public HardPlayer(string userId) : base(userId)
        {
        }

        // En funktion för att ta pins ifrån totala antalet
        public override int takePins(Board board)
        {
            int pins = board.getNoPins(); // Kollar vad antalet pins är
            int pinsToTake; // Skapar variabel för att senare kolla hur många pins användaren vill ta

            if (pins == 2) // Om pins är 2
            {
                pinsToTake = 2; // Ta 2 pins
                Console.WriteLine("I take: 2 pins"); // Skriv ut
            }
            else if (pins % 3 == 0) // Om antalet pins är delbart med 3
            {
                pinsToTake = 1; // Tar en pin
                Console.WriteLine("I take: 1 pin"); // Skriver ut
            }
            else
            {
                pinsToTake = 2; // Tar 2 pins om inget annat gäller
                Console.WriteLine("I take: 2 pins"); // Skriv ut
            }

            board.takePins(pinsToTake); // Tar bort pins
            return board.getNoPins(); // Returnerar hur många pins i board
        }
    }
}
