using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    class BlockUtil
    {
        //This class contains some methods that helps operate operations in TextBoxes which is our blocks

        private const int GRID_SIZE = 9;

        public static void fillTextBoxGrid(int[,] grid, TextBox[,] textBoxGrid, bool beginGame)
        {
            for (int i = 0; i < GRID_SIZE; i++)
                for (int j = 0; j < GRID_SIZE; j++)
                    if (grid[i, j] != 0)
                    {
                        textBoxGrid[i, j].Text = grid[i, j].ToString();
                        if (beginGame)
                        {
                            textBoxGrid[i, j].ForeColor = Color.Black;
                            textBoxGrid[i, j].Tag = "native";
                            textBoxGrid[i, j].ReadOnly = true;
                            textBoxGrid[i, j].BackColor = Color.White;
                        }
                        if (textBoxGrid[i, j].Tag != null && textBoxGrid[i, j].Tag.Equals("native"))
                            textBoxGrid[i, j].ForeColor = Color.Black;
                        else if (textBoxGrid[i, j].Tag != null && textBoxGrid[i, j].Tag.Equals("right"))
                            textBoxGrid[i, j].ForeColor = Color.Blue;
                    }
        }

        public static void clearTextBoxGrid(TextBox[,] textBoxGrid)
        {
            for (int i = 0; i < GRID_SIZE; i++)
                for (int j = 0; j < GRID_SIZE; j++)
                    textBoxGrid[i, j].Clear();
        }

        public static int[,] convertTextBoxGridToIntGrid(TextBox[,] textBoxGrid)
        {
            int[,] grid = new int[GRID_SIZE, GRID_SIZE];

            for (int row = 0; row < GRID_SIZE; row++)
                for (int column = 0; column < GRID_SIZE; column++)
                {
                    if (textBoxGrid[row, column].Text.Length == 0)
                        grid[row, column] = 0;
                    else
                        grid[row, column] = Int32.Parse(textBoxGrid[row, column].Text);
                }

            return grid;
        }

        public static int[] getXYOfBlock(TextBox textBox)
        {
            int orderX = Int32.Parse(textBox.Name.ToCharArray().ElementAt(textBox.Name.Length - 2).ToString());
            int orderY = Int32.Parse(textBox.Name.ToCharArray().ElementAt(textBox.Name.Length - 1).ToString());

            int X = (orderX / 3) * 3 + orderY / 3;
            int Y = (orderX % 3) * 3 + orderY % 3;

            return new int[] { X, Y };
        }
    }
}
