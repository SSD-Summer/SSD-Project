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
        int score;
        int timer;
        Random rand = new Random();
        public gamePlay(gamePlayForm g, int size, int mode)
        {
            score = 0;
            timer = 30;
            init_board(size, g);
            g.label_score.Text = score.ToString();
            g.label_time.Text = timer.ToString();
            gameLoop();

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

        private void gameLoop()
        {
            timer = 30;
            while(timer > 0)
            {
                Timer countDown = new Timer(30000); //1000 == 1sec  //Start game time
                countDown.Elapsed += new ElapsedEventHandler(gameTick);
                countDown.Interval = 1000;
                countDown.Start();
            }
            
        }
        private void gameTick(object sender, ElapsedEventArgs e)
        {
            timer--;
            for(int x = 0; x < Math.Sqrt(this.board.Length); ++x)
            {
                for(int y = 0; y < Math.Sqrt(this.board.Length);++y)
                {
                    this.board[x, y].checkTime();
                }
            }
        }
    }
}
