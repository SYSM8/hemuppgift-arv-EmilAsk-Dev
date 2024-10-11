using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class AdvancedPlayer : Player
    {
        //kollar om det är första rundan i spelet
        private bool firstRound = false; 

        public AdvancedPlayer(string userId) : base(userId)
        {
        }

        //en function för att ta pins ifrån totala antalet
        public override int takePins(Board board)
        {
            
            int pins = board.getNoPins(); //kollar vad antalet pins är
            int pinsToTake; //skapar variabel för att senare kolla hur många pins användaren vill ta

            //kollar om det är första rundan eller inte
            if (!firstRound)
            {
                
                pinsToTake = 2;  //tar 2 pins
                Console.WriteLine("I take: 2 pins"); //Skriver ut
                firstRound = true; //ändrar Firstround variablen
            }
            else
            {
                if (pins == 2) // om pins är 2
                {
                    
                    pinsToTake = 2; // ta 2 pins
                    Console.WriteLine("I take: 2 pins"); // skriv ut
                }
                else if (pins % 3 == 0) // om antalet pins är delbart med 3
                {
                    
                    pinsToTake = 1; //tar en pin
                    Console.WriteLine("I take: 1 pin"); // skriver ut
                }
                else
                {

                    // Beräkna hur många pinnar som ska tas för att lämna ett multipel av 3 till spelaren.
                    pinsToTake = pins % 3;
                    
                    //kontrollerar villkoret om pinsToTake är större än 1.
                    // Om så är fallet, lägg till "s" till "pin" för att göra det plural (t.ex. "pins").
                    Console.WriteLine($"I take: {pinsToTake} pin{(pinsToTake > 1 ? "s" : "")}");
                }
            }

            
            board.takePins(pinsToTake); //tar bort pins
            return board.getNoPins(); // returnerar hur många pins i board
        }
    }
}
