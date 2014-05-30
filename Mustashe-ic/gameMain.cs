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
    public partial class gameMain : Form
    {

        System.Windows.Forms.Button button_worldsMode;
        System.Windows.Forms.Button button_endlessMode;
        public gameMain()
        {
            InitializeComponent();
            gamePlay game = new gamePlay(this, 4, 1);

        }

        private void button_start_Click(object sender, EventArgs e)
        {

            //On Start click - Hide everything currently active on the form
            button1.Hide();
            button2.Hide();
            label_GameTitleLabel.Hide();
            
            //Start mode button drawing
            button_worldsMode = new Button();
            button_worldsMode.Text = "Worlds";
            button_worldsMode.Size = new Size(250, 390);
            button_worldsMode.AutoSize = true;
            button_worldsMode.Location = new Point(5, 5);
            button_worldsMode.Click += new System.EventHandler(worldButton_Click); //Bind button click event to worldButton_click function
            this.Controls.Add(button_worldsMode);


            button_endlessMode = new Button();
            button_endlessMode.Text = "Endless";
            button_endlessMode.Size = new Size(250, 390);
            button_endlessMode.AutoSize = true;
            button_endlessMode.Location = new Point(255, 5);
            this.Controls.Add(button_endlessMode);            
        }

        private void worldButton_Click(object sender, EventArgs e) //Maybe this will be the event that starts the game or 
        {

        }
       


    }
}
