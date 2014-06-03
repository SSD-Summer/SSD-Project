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
        int n; //Defines the board as an N by N 
        int score;
        public int timer { set; get; } //Probably will change to helper class
        int count; //This is the variable used to keep track of how often to hide a tile 
        int randX, randY; //ints used as random vars
        Random rand; //Random generator - Will probably move 
        Queue<Tuple<int, int>> hiddenList; //Used as holder for hidden tiles - Stores x and y coordinate of tile in tuple

        System.Windows.Forms.Label label_lives, label_timer, label_score;
        System.Windows.Forms.Panel panel_tile_holder;


        public gamePlay(gameMain g, int size, int mode)
        {
            score = 0; //beginning score to zero
            timer = 30; // Starting time 30 secs
            n = size; //size of tile board - nxn
            init_board(n, g); //initializes the boar
            randX = 0;
            randY = 2; //Both used for random number generation
            rand = new Random();  //needed for random generation
            count = rand.Next(randX, randY); //get random tile wait time
            hiddenList = new Queue<Tuple<int, int>>(); //initalizes queue to hold the hidden tiles
            
            //Lives label generation 
            label_lives = new System.Windows.Forms.Label();
            label_lives.Text = "Number of lives";
            label_lives.AutoSize = true;
            label_lives.Location = new System.Drawing.Point(5, 5);
            label_lives.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //timer label generation
            label_timer = new System.Windows.Forms.Label();
            label_timer.Text = timer.ToString();
            label_timer.Location = new System.Drawing.Point(230, 5);
            label_timer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //score label generation
            label_score = new System.Windows.Forms.Label();
            label_score.Text = score.ToString();
            label_score.Location = new System.Drawing.Point(450, 5);
            label_score.Anchor = System.Windows.Forms.AnchorStyles.Top;



        }

        private void init_board(int size, gameMain g) //Creates a size X size grid of tiles 
        {
            board = new tileClass[size, size];

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)    // This is where I print the gameboard into the panel 
                {
                    board[i, j] = new tileClass();
                    board[i, j].tile.Size = new System.Drawing.Size(100, 100);
                    board[i, j].tile.Location = new System.Drawing.Point(i * 200 + 5, j * 100 + 5);
                    //g.panel_tileHolder.Controls.Add(board[i, j].tile); this is where I added the tiles to the holder panel

                }
            }

        }

        

        public void gameTick() //Ran each sec for the alloted time 
        {
            count--; //decremete counter for hiding tile 
            if (hiddenList.Count >= 2) //if there are 1 or more hidden tiles unhide one
            {
                //Would like to add a way to randomize the queue if we countine with this method in the future
                var temp = hiddenList.Dequeue();
                board[int.Parse(temp.Item1.ToString()), int.Parse(temp.Item2.ToString())].tile.Show();
            }

            if (count == 0)
            { 
                //when the count is 0 its tile to hide a tile 
                int i = rand.Next(n + 1);
                int j = rand.Next(n + 1);  //Gather random i and j values 
                hiddenList.Enqueue(Tuple.Create(i, j));  //add them to the queue
                board[i, j].tile.Hide();  //hide the associated tile 
                count = rand.Next(randX, randY); //get random tile wait time
            }
        }
    }
}
