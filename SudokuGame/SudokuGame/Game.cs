using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class Game : UserControl
    {
        private const int GRID_SIZE = 9;

        private bool gameContinue = true;

        private long time = 0;

        Main main;

        public Game()
        {
            InitializeComponent();
            initGame();

            timer_gameTime.Start();

            int[,] grid = {
                {9, 3, 0, 2, 7, 0, 0, 5, 0},
                {0, 8, 0, 0, 3, 5, 9, 2, 0},
                {6, 0, 5, 0, 0, 1, 4, 7, 3},
                {7, 4, 0, 1, 9, 0, 5, 0, 0},
                {5, 0, 0, 8, 6, 0, 0, 4, 2},
                {3, 0, 0, 0, 2, 0, 1, 0, 7},
                {0, 1, 3, 0, 4, 9, 0, 8, 0},
                {0, 0, 9, 0, 0, 0, 7, 0, 0},
                {0, 0, 0, 0, 0, 0, 2, 0, 0}
            };

            int[,] grid2 = {
                { 9, 3, 4, 2, 7, 6, 8, 5, 1},
                { 1, 8, 7, 4, 3, 5, 9, 2, 6},
                { 6, 2, 5, 9, 8, 1, 4, 7, 3},
                { 7, 4, 2, 1, 9, 2, 5, 6, 8},
                { 5, 9, 1, 8, 6, 7, 3, 4, 2},
                { 3, 6, 8, 5, 2, 4, 1, 9, 7},
                { 2, 1, 3, 7, 4, 9, 6, 8, 5},
                { 8, 5, 9, 6, 1, 2, 7, 3, 4},
                { 4, 7, 6, 3, 5, 8, 2, 0, 0}
            };

            GameLogic.Grid = grid2;
            BlockUtil.fillTextBoxGrid(grid2, getTextBoxGrid(), true);
        }

        private void initGame()
        {
            for (int i = 0; i < GRID_SIZE; i++)
            {
                FlowLayoutPanel flp_box = new FlowLayoutPanel();
                flp_box.BackColor = Color.Transparent;
                flp_box.Margin = new Padding(2, 2, 2, 2);
                flp_box.Size = new Size(131, 131);
                flp_box.Name = "flp_box" + i;

                for (int j = 0; j < GRID_SIZE; j++)
                {
                    TextBox tb_block = new TextBox();
                    tb_block.Margin = new Padding(4, 4, 4, 4);
                    tb_block.Size = new Size(35, 35);
                    tb_block.Font = new Font("Microsoft Sans Serif", 21);
                    tb_block.BorderStyle = BorderStyle.None;
                    tb_block.TextAlign = HorizontalAlignment.Center;
                    tb_block.Name = "tb_block" + i + j;
                    tb_block.MaxLength = 1;
                    tb_block.ForeColor = Color.Blue;

                    tb_block.KeyPress += new KeyPressEventHandler(delegate (Object o, KeyPressEventArgs e)
                   {
                       //It allows in textbox only number characters
                       if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                       {
                           e.Handled = true;
                       }

                       //It checks there is that value in row, column and box or not
                       if (char.IsDigit(e.KeyChar))
                       {
                           int number = Int32.Parse(e.KeyChar.ToString());
                           int X = BlockUtil.getXYOfBlock(tb_block)[0];
                           int Y = BlockUtil.getXYOfBlock(tb_block)[1];
                           int[] loc = GameLogic.locationInGrid(number, X, Y);

                           if (loc[0] != -1)
                           {
                               tb_block.ForeColor = Color.Red;
                               tb_block.Tag = "wrong";
                           }
                           else
                           {
                               tb_block.ForeColor = Color.Blue;
                               tb_block.Tag = "right";
                           }
                       }
                   });

                    //It writes number in textbox to gri
                    tb_block.KeyUp += new KeyEventHandler(delegate (Object o, KeyEventArgs e)
                    {
                        GameLogic.Grid = BlockUtil.convertTextBoxGridToIntGrid(getTextBoxGrid());

                        if (GameLogic.isGameFinished())
                        {
                            timer_gameTime.Stop();

                            TextBox[,] textBoxGrid = getTextBoxGrid();
                            for (int row = 0; row < GRID_SIZE; row++)
                                for (int column = 0; column < GRID_SIZE; column++)
                                    textBoxGrid[row, column].ForeColor = Color.Green;
                        }
                    });

                    flp_box.Controls.Add(tb_block);
                }

                flp_sudokuTemplate.Controls.Add(flp_box);
            }
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (gameContinue)
            {
                gameContinue = false;
                timer_gameTime.Stop();
                btn_play.BackgroundImage = Image.FromFile(@"images/Play.png");
                BlockUtil.clearTextBoxGrid(getTextBoxGrid());
            }
            else
            {
                gameContinue = true;
                timer_gameTime.Start();
                btn_play.BackgroundImage = Image.FromFile(@"images/Pause.png");
                BlockUtil.fillTextBoxGrid(GameLogic.Grid, getTextBoxGrid(), false);
            }
        }

        private void btn_play_MouseEnter(object sender, EventArgs e)
        {
            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.FlatAppearance.BorderSize = 0;
        }

        private void timer_gameTime_Tick(object sender, EventArgs e)
        {
            time++;

            TimeSpan t = TimeSpan.FromSeconds(time);
            lbl_time.Text = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                    t.Hours,
                                    t.Minutes,
                                    t.Seconds);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer_gameTime.Stop();

            StartScreen end = new StartScreen();
            end.Main = main;
            end.time = lbl_time.Text;

            main.Controls.Clear();
            main.Controls.Add(end);
        }

        public Main mainObject
        {
            set { this.main = value; }
        }

        private TextBox[,] getTextBoxGrid()
        {
            TextBox[,] blocks = new TextBox[GRID_SIZE, GRID_SIZE];


            int boxIndex = 0;
            int blockY = 0;
            foreach (Control box in flp_sudokuTemplate.Controls)
            {
                if (boxIndex % 3 == 0)
                    blockY = boxIndex;

                int blockInBoxIndex = 0;
                int blockX = (boxIndex % 3) * 3;
                foreach (Control block in box.Controls)
                {
                    if (blockInBoxIndex % 3 == 0)
                        blockX = (boxIndex % 3) * 3;

                    if (blockInBoxIndex < 3)
                    {
                        blocks[blockY, blockX] = block as TextBox;
                        blockX++;
                        blockInBoxIndex++;
                    }
                    else if (blockInBoxIndex < 6)
                    {
                        blocks[blockY + 1, blockX] = block as TextBox;
                        blockX++;
                        blockInBoxIndex++;
                    }
                    else
                    {
                        blocks[blockY + 2, blockX] = block as TextBox;
                        blockX++;
                        blockInBoxIndex++;
                    }
                }

                boxIndex++;
            }

            return blocks;
        }
    }
}
