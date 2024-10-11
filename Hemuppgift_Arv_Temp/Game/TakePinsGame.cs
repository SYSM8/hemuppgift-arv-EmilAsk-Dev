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
            //menyval för användare om svårighet
            Console.WriteLine("Choose difficulty");
            Console.WriteLine("[1]Easy difficulty");
            Console.WriteLine("[2]Hard difficulty");
            Console.WriteLine("[3]Impossible difficulty");
            //tar användarens input
            int input = Convert.ToInt32(Console.ReadLine());
            Player computer;

            switch (input)
            {
                case 1:
                    //om man vill köra easy
                    computer = new ComputerPlayer("Ai"); // skapar en enkel spelare
                    break;
                case 2:
                    //om man vill köra hard
                    computer = new HardPlayer("Ai"); //skapar en svår spelare
                    break;
                case 3:
                    //om man vill köra impossible
                    computer = new AdvancedPlayer("Ai"); // skapar en advanced player
                    break;
                default:
                    throw new ArgumentException("Invalid difficulty selected");
            }
            Board game = new Board(); //skapar board objekt             
            Player human = new HumanPlayer("Human"); //skapar Människo spelarn             



            game.SetUp(20); //sätter upp spelet med 20 pins
            bool isPlayer = true; //skapar en variabel för att hålla koll på vilken tur det är 

            //gör en while loop för spelet där jag genför om antalet pins är större än 0
            while (game.getNoPins() > 0)
            {
                //gör en try catch ifall användaren skriver in en bokstav
                try
                {
                    if (isPlayer) // kollar om det är spelarns tur eller datorn tur (standard "isPlayer = true" användaren kommer börja)
                    {
                        human.takePins(game); //Metod för att ta pins
                        Console.Clear(); //tar bort allt i consolen för att den ska bli lite mer clean
                    }
                    else
                    {
                        computer.takePins(game); //om isPlayer = false är det datorn tur att ta pins
                    }

                    isPlayer = !isPlayer; // cyklar mellan true och false mellan varje runda

                    Console.WriteLine($"Pins left:{game.getNoPins()}"); // utskrift för att kolla hur många pins är kvar
                }
                catch
                {
                    //om input är en bokstav
                    Console.WriteLine("Wrong input");
                }
            }
            //kollar vem som var spelade sist och gör den andra till vinnare
            if (!isPlayer)
            {
                Console.WriteLine("Player have won");
            }
            else
            {
                Console.WriteLine("Computer have won");
            }
        }
    }
}


















            