using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    internal class Board
    {
        private int noPins {  get; set; }
        
        public void SetUp(int noPins)
        {
            this.noPins = noPins;
        }

        public void takePins(int pins)
        {
            noPins -= pins;
        }

        public int getNoPins() 
        {
            return noPins;
        }
    }
}
