using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            StartScreen startScreen = new StartScreen();
            startScreen.Main = this;
            this.Controls.Add(startScreen);
        }
    }
}
