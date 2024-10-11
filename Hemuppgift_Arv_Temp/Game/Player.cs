using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    abstract internal class Player
    {

        //gör ett userid till användaren 
        string userId { get; set; }

        //konsturktur för userId
        public Player(string userId)
        {
            this.userId = userId;
        }

        //en function för att hämta id 
        public string getUserId()
        {
            //retunar userId
            return userId;
        }
        //template för takepins
        abstract public int takePins(Board board);
        
    }
}
