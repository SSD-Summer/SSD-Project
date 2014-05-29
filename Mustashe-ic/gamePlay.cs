using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Mustashe_ic
{
    class gamePlay
    {
        tileClass[,] board;
        int n; //nXn
        int score;
        public int timer { set; get; }
        int count;
        int randX, randY;
        Random rand;
        
        public gamePlay(gamePlayForm g, int size, int mode)
        {
            score = 0;
            timer = 30;
            n = size;
            init_board(n, g);
            g.label_score.Text = score.ToString();
            g.label_time.Text = timer.ToString();
            randX = 1;
            randY = 5;
            n = (int)Math.Sqrt(n);
            rand = new Random();
            count = rand.Next(randX, randY); //get random tile wait time

        }

        private void init_board(int size, gamePlayForm g) //Creates a size X size grid of tiles 
        {
            board = new tileClass[size,size];

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    board[i, j] = new tileClass();  
                    board[i, j].tile.Size = new System.Drawing.Size(100, 100); 
                    board[i, j].tile.Location = new System.Drawing.Point(i * 200 + 5, j * 100 + 5);
                    g.panel_tilePanel.Controls.Add(board[i, j].tile);
                    
                }
            }
           
        }

        //public void gameLoopStart(System.Windows.Forms.Label label)
        //{
        //    timer = 30;
        //    StopTime = DateTime.Now.AddSeconds(30); //set timer
        //    Timer = new System.Threading.Timer(gameTick, null, 0, 1000);
        //    count = rand.Next(randX, randY); //get random tile wait time
        //    label.Text = timer.ToString();
            
        //}

        public void gameTick()
        {     
            count--;
            
            if(count == 0)
            {
                int i = rand.Next(n);
                int j = rand.Next(n);
                board[i, j].tile.Hide();
                count = rand.Next(randX, randY); //get random tile wait time
            }
        }
    }
}
