using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustashe_ic
{
    class tileClass
    {
        public int timeAlive { get; private set; }
        public bool correctObject {get; private set;}
        public System.Windows.Forms.Button tile {get;set;}
        static Random rand = new Random();
        static int min = 10, max = 20;
        public tileClass()
        {
            timeAlive = DateTime.Now.Second;
            correctObject = false;
            tile = new System.Windows.Forms.Button();
            timeAlive = ranNum();
        }
        public static int ranNum()
        {
            return rand.Next(min, max);
        }

        public void checkTime()
        {
            if (timeAlive == 0)
            {
                //Reinitalize the tile with a new picture
                //simulate fade in and out
                tile.Hide();
                timeAlive = ranNum();
            }
            else
                tile.Show();
                timeAlive--;
        }
    }
}
