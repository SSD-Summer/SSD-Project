using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mustashe_ic
{
    class tileClass
    {

        public bool correctObject {get; private set;}
        public System.Windows.Forms.Button tile {get;set;}
  
        public tileClass()
        {
            correctObject = false;
            tile = new System.Windows.Forms.Button();
        }

        public tileClass(bool val)
        {
            correctObject = val;
            tile = new System.Windows.Forms.Button();
        }

        public void refreshTile()
        {
            //change tile image
            //sim fade in and out
        }

        public void hideTile()
        {
            this.tile.Hide();
        }
    }
}
