using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    abstract internal class Player
    {
        string userId { get; set; }

        public Player(string userId)
        {
            this.userId = userId;
        }

        public string getUserId()
        {
            return userId;
        }

        abstract public int takePins(Board board);
        
    }
}
