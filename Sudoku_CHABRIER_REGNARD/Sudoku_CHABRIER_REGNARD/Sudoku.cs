using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    public class Sudoku
    {
        private List<HashSet<int>> columns;
        private List<HashSet<int>> lines;
        private List<HashSet<int>> squares;
        private Box[,] grid;

        public Sudoku()
        {
            columns = new List<HashSet<int>>();
            lines = new List<HashSet<int>>();
            squares = new List<HashSet<int>>();
            grid = new Box[9, 9];

            for(int i = 0; i < 9; i++)
            {
                columns.Add(new HashSet<int>());
                lines.Add(new HashSet<int>());
                squares.Add(new HashSet<int>());
            }

            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    grid[i, j] = new Box(columns[i], lines[j], squares[(int)(Math.Floor((double)j / 3)) + (int)(3 * Math.Floor((double)i / 3))]);
                    //for each box, for 9 turns the column is the same, but the line change each time.
                    //The square stays the same for 3 turn then increment, the formula is to give the position of the square in function of i and j.
                }
            }

            generateGrid();
            displayGrid();
        }

        public void generateGrid()
        {
            for(int i = 0; i< 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[j, i].diffValues();
                    grid[j, i].randValue();
                    grid[j, i].addColumn(grid[j, i].getValue());
                    grid[j, i].addLine(grid[j, i].getValue());
                    grid[j, i].addSquare(grid[j, i].getValue());
                }
            }
        }

        public void displayGrid()
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    Console.Write(grid[j, i].getValue());
                }
                Console.WriteLine();
            }
        }

    }


}
