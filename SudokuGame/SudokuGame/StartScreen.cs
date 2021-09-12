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
    public partial class StartScreen : UserControl
    {
        private Main main;

        public StartScreen()
        {
            InitializeComponent();
        }

        public Main Main
        {
            set { main = value; }
        }

        private void btn_start_MouseEnter(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.Blue;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.BackColor = Color.Transparent;
        }

        private void btn_quit_MouseEnter(object sender, EventArgs e)
        {
            btn_quit.BackColor = Color.Red;
        }

        private void btn_quit_MouseLeave(object sender, EventArgs e)
        {
            btn_quit.BackColor = Color.Transparent;
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public String time
        {
            set
            {
                lbl_time.Text = value;
                pnl_timeTemplate.Visible = true;

                btn_start.Text = "New game";
                btn_start.Size = new Size(169, 41);
                btn_start.Location = new Point(310, 167);
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            main.Controls.Clear();

            LevelSelection lvl = new LevelSelection();
            lvl.Main = main;
            main.Controls.Add(lvl);
        }
    }
}
