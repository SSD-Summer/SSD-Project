using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mustashe_ic
{
    public partial class gamePlayForm : Form
    {
        gamePlay game;

        System.Windows.Forms.Timer Timer;
        int count;
        //DateTime endTime;

        public gamePlayForm()
        {
            count = 30;
            InitializeComponent();
            game = new gamePlay(this, 4, 1);
            //endTime = DateTime.Now.AddSeconds(30);
            Timer = new System.Windows.Forms.Timer();
            Timer.Tick += new EventHandler(tick);
            Timer.Interval = 1000;
            Timer.Start();
            
        }    

        private void tick(object sender, EventArgs e)
        {
            count--;
            if(count<=0)
            {
                Timer.Stop();
            }
            game.gameTick();
            label_time.Text = count.ToString();
        }
    }
}
