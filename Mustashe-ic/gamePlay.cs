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

        public gamePlay(gamePlayForm g, int size, int mode)
        {
            score = 0;
            timer = 30;
            init_board(size, g);
            g.label_score.Text = score.ToString();
            g.label_time.Text = timer.ToString();


        }

        private void init_board(int size, gamePlayForm g)
        {
            board = new tileClass[size,size];

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    board[i, j] = new tileClass();
                    board[i, j].tile.Size = new System.Drawing.Size(100, 100);
                    board[i, j].tile.Location = new System.Drawing.Point(i * 100 + 5, j * 100 + 5);
                    g.panel_tilePanel.Controls.Add(board[i, j].tile);
                    
                }
            }
        }

        private void gameLoop()
        {
            while(timer > 0)
            {

            }
        }

    }
}
