using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuGame
{
    class GameLogic
    {
        private const int GRID_SIZE = 9;

        private static int[,] grid;

        public static int[,] Grid
        {
            set { grid = value; }
            get { return grid; }
        }

        private static int[] locationInBox(int number, int row, int column)
        {
            int beginRow = row - (row % 3);
            int beginColumn = column - (column % 3);

            for (int i = beginRow; i < beginRow + 3; i++)
                for (int j = beginColumn; j < beginColumn; j++)
                    if (grid[i, j] == number)
                        return new int[] { i, j };

            return new int[] { -1, -1 };
        }

        private static int[] locationInRow(int number, int row)
        {
            for (int i = 0; i < GRID_SIZE; i++)
                if (grid[row, i] == number)
                    return new int[] { row, i };

            return new int[] { -1, -1 };
        }

        private static int[] locationInColumn(int number, int column)
        {
            for (int i = 0; i < GRID_SIZE; i++)
                if (grid[i, column] == number)
                    return new int[] { i, column };

            return new int[] { -1, -1 };
        }

        public static int[] locationInGrid (int number, int row, int column)
        {
            int[] loc = locationInRow(number, row);
            if (loc[0] != -1)
                return loc;

            loc = locationInColumn(number, column);
            if (loc[0] != -1)
                return loc;

            loc = locationInBox(number, row, column);
            if (loc[0] != -1)
                return loc;

            return loc;
        }

        public static bool isGameFinished ()
        {
            for (int row = 0; row < GRID_SIZE; row++)
                for (int column = 0; column < GRID_SIZE; column++)
                {
                    if (locationInGrid(grid[row, column], row, column)[0] != -1)
                        return false;
                    if (grid[row, column] == 0)
                        return false;
                }

            return true;
        }
    }
}
