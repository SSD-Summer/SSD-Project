using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Timer;


namespace Mustashe_ic
{
    class buttonTiming: tileClass
    {
        /*This class holds a list of timers for the buttons.
         * Randomizes duration for each timer 
         * Resets duration at a new random duration when previous reaches 0
         * 
         * */
        static System.Windows.Forms.Timer bTimer = new System.Windows.Forms.Timer();
        protected List<System.Windows.Forms.Button> buttonTime;

        //Constructor
        public buttonTiming()
        {
           buttonTime = new List<System.Windows.Forms.Button>();
        }
        /*public buttonTiming(int tile)
        {

        }*/

        //Deconstructor
        public ~buttonTiming()
        {

        }

        //Randomizes each duration in list
        public void randomTime()
        {
            Random randTime = new Random(0);

        }
    }
}
