using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        Queue<Tuple<int, int>> hiddenList;


        public gamePlay(gameMain g, int size, int mode)
        {
            score = 0;
            timer = 30;
            n = size;
            init_board(n, g);
            //g.label_Score.Text = score.ToString();
            ///g.label_timer.Text = timer.ToString();
            randX = 0;
            randY = 2;
            n = (int)Math.Sqrt(n);
            rand = new Random();
            count = rand.Next(randX, randY); //get random tile wait time
            hiddenList = new Queue<Tuple<int, int>>();

        }

        private void init_board(int size, gameMain g) //Creates a size X size grid of tiles 
        {
            board = new tileClass[size, size];

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    board[i, j] = new tileClass();
                    board[i, j].tile.Size = new System.Drawing.Size(100, 100);
                    board[i, j].tile.Location = new System.Drawing.Point(i * 200 + 5, j * 100 + 5);
                    //g.panel_tileHolder.Controls.Add(board[i, j].tile);

                }
            }

        }

        public void gameTick()
        {
            count--;
            if (hiddenList.Count >= 2)
            {

                var temp = hiddenList.Dequeue();
                board[int.Parse(temp.Item1.ToString()), int.Parse(temp.Item2.ToString())].tile.Show();
            }

            if (count == 0)
            {
                int i = rand.Next(n + 1);
                int j = rand.Next(n + 1);
                hiddenList.Enqueue(Tuple.Create(i, j));
                board[i, j].tile.Hide();
                count = rand.Next(randX, randY); //get random tile wait time
            }
        }
    }
}
