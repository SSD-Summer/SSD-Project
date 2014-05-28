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

        public gamePlay(gamePlayForm g)
        {
            board = new tileClass[4, 4];

            for(int i = 0; i < 4; ++i)
            {
                for(int j = 0; j < 4; ++j)
                {
                    board[i, j] = new tileClass();
                    board[i, j].tile.Size = new System.Drawing.Size(100, 100);
                    board[i, j].tile.Location = new System.Drawing.Point(i * 100 + 5, j * 100 + 5);
                    g.Controls.Add(board[i, j].tile);
                }
            }

            
        }

    }
}
