using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuGame
{
    class GameLogic
    {
        private const int GRID_SIZE = 9;

        private static int[,] grid = new int[GRID_SIZE, GRID_SIZE];
        private static int[,] solvedGrid = new int[GRID_SIZE, GRID_SIZE];

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
                for (int j = beginColumn; j < beginColumn + 3; j++)
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

        public static int[] locationInGrid(int number, int row, int column)
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

        public static bool isGameFinished(TextBox[,] textBoxGrid)
        {
            for (int row = 0; row < GRID_SIZE; row++)
                for (int column = 0; column < GRID_SIZE; column++)
                    if (grid[row, column] == 0 || (textBoxGrid[row, column].Tag != null
                        && textBoxGrid[row, column].Tag.Equals("wrong")))
                        return false;


            for (int row = 0; row < GRID_SIZE; row++)
                for (int column = 0; column < GRID_SIZE; column++)
                    textBoxGrid[row, column].ForeColor = Color.Green;

            return true;
        }

        //Power recognizes level of game. 0 - easy, 1 - middle, 2 - hard
        public static void generateGrid(int power)
        {
            //initialize grid
            for (int row = 0; row < GRID_SIZE; row++)
                for (int column = 0; column < GRID_SIZE; column++)
                    grid[row, column] = 0;

            //generate solved grid
            for (int row = 0; row < GRID_SIZE; row++)
            {
                HashSet<int> randomNumbers = new HashSet<int>();
                Random random = new Random();
                while (randomNumbers.Count < GRID_SIZE)
                    randomNumbers.Add(random.Next(1, GRID_SIZE + 1));

                int indexOfRandom = 0;
                int column = 0;
                while (column < GRID_SIZE)
                {
                    if (locationInGrid(randomNumbers.ElementAt(indexOfRandom), row, column)[0] == -1)
                    {
                        grid[row, column] = randomNumbers.ElementAt(indexOfRandom);
                        column++;
                    }
                    else
                        indexOfRandom++;

                    indexOfRandom %= 9;
                }
            }

            Array.Copy(grid, solvedGrid, grid.Length);

            //clear some blocks in grid
            int minHole = 1 + power * 3;
            Random randomNumberOfHoles = new Random(Guid.NewGuid().GetHashCode());//it gives random seed
            HashSet<int> randomHoleSet = new HashSet<int>();
            while (randomHoleSet.Count <= GRID_SIZE - minHole)
                randomHoleSet.Add(randomNumberOfHoles.Next(minHole, 10));

            List<int> randomHoleList = randomHoleSet.ToList();
            for (int i = 1; i < minHole; i++)
                randomHoleList.Add(randomNumberOfHoles.Next(minHole, 10));

            for (int row = 0; row < GRID_SIZE; row++)
            {
                Random randomColumn = new Random(Guid.NewGuid().GetHashCode());
                HashSet<int> randomColumnSet = new HashSet<int>();
                while (randomColumnSet.Count < randomHoleList.ElementAt(row))
                    randomColumnSet.Add(randomColumn.Next(0, GRID_SIZE));

                for (int hole = 0; hole < randomHoleList.ElementAt(row); hole++)
                    grid[row, randomColumnSet.ElementAt(hole)] = 0;
            }
        }

        public static void getTip()
        {
            while (true)
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int row = random.Next(0, GRID_SIZE);
                int column = random.Next(0, GRID_SIZE);
                if (grid[row, column] == 0)
                {
                    grid[row, column] = solvedGrid[row, column];
                    break;
                }
            }
        }
    }
}
