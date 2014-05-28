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

        public tileClass()
        {
            timeAlive = DateTime.Now.Second;
            correctObject = false;
            tile = new System.Windows.Forms.Button();
        }


    }
}
