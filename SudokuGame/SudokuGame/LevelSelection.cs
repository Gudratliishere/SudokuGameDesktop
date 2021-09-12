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
    public partial class LevelSelection : UserControl
    {
        private Main main;

        public LevelSelection()
        {
            InitializeComponent();
        }

        public Main Main
        {
            set { main = value; }
        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            Game game = new Game(0);
            game.mainObject = main;
            main.Controls.Clear();
            main.Controls.Add(game);
        }

        private void btn_middle_Click(object sender, EventArgs e)
        {
            Game game = new Game(1);
            game.mainObject = main;
            main.Controls.Clear();
            main.Controls.Add(game);
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            Game game = new Game(2);
            game.mainObject = main;
            main.Controls.Clear();
            main.Controls.Add(game);
        }
    }
}
