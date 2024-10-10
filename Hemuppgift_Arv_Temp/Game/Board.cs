using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp.Game
{
    //skapar en klass som heter board för att kunna förända spelet
    internal class Board
    {
        //skapar en privat variabler för antalet pins
        private int noPins {  get; set; }
        
        //setup function för antalet pins/ Start pins
        public void SetUp(int noPins)
        {
            this.noPins = noPins;
        }

        //function som kallas när pins ska försvinna ifrån noPins 
        public void takePins(int pins)
        {
            //tar in pins och subtraherar det med noPins
            noPins -= pins;
        }

        //function för att kalla antalet pins som är kvar
        public int getNoPins() 
        {
            return noPins;
        }
    }
}
