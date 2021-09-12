using System;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class Game : UserControl
    {
        private const int GRID_SIZE = 9;

        private int numberOfMistakes = 0;
        private int numberOfTips = 0;

        private bool gameContinue = true;

        private long time = 0;

        Main main;

        public Game(int level)
        {
            InitializeComponent();
            initGame();

            timer_gameTime.Start();

            GameLogic.generateGrid(level);
            BlockUtil.fillTextBoxGrid(GameLogic.Grid, getTextBoxGrid(), true);
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
                       if (char.IsDigit(e.KeyChar) && tb_block.Text.Length == 0)
                       {
                           int number = Int32.Parse(e.KeyChar.ToString());
                           int X = BlockUtil.getXYOfBlock(tb_block)[0];
                           int Y = BlockUtil.getXYOfBlock(tb_block)[1];
                           int[] loc = GameLogic.locationInGrid(number, X, Y);

                           if (loc[0] != -1)
                           {
                               tb_block.ForeColor = Color.Red;
                               tb_block.Tag = "wrong";
                               numberOfMistakes++;
                               lbl_numberOfMistakes.Text = "Mistakes: " + numberOfMistakes;
                           }
                           else
                           {
                               tb_block.ForeColor = Color.Blue;
                               tb_block.Tag = "right";
                           }
                       }
                   });

                    tb_block.KeyUp += new KeyEventHandler(delegate (Object o, KeyEventArgs e)
                    {
                        //It writes number in textbox to grid
                        GameLogic.Grid = BlockUtil.convertTextBoxGridToIntGrid(getTextBoxGrid());

                        //It checks game is finished or not
                        TextBox[,] textBoxGrid = getTextBoxGrid();
                        if (GameLogic.isGameFinished(textBoxGrid))
                        {
                            timer_gameTime.Stop();

                            btn_play.Enabled = false;
                            btn_tip.Enabled = false;
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

        private void btn_tip_Click(object sender, EventArgs e)
        {
            numberOfTips++;
            lbl_numberOfTips.Text = "Tips: " + numberOfTips;

            GameLogic.getTip();

            BlockUtil.fillTextBoxGrid(GameLogic.Grid, getTextBoxGrid(), false);

            if (GameLogic.isGameFinished(getTextBoxGrid()))
            {
                timer_gameTime.Stop();

                btn_play.Enabled = false;
                btn_tip.Enabled = false;
            }
        }
    }
}
