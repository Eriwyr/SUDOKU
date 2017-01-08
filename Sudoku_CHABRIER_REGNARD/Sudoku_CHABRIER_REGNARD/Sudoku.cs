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
        private Grid grid;
        private Grid gridToSolve;
        private Solver solver;

        public Sudoku()
        {
            columns = new List<HashSet<int>>();
            lines = new List<HashSet<int>>();
            squares = new List<HashSet<int>>();
            grid = new Grid();
            gridToSolve = new Grid();
            for (int i = 0; i < 9; i++)
            {
                columns.Add(new HashSet<int>());
                lines.Add(new HashSet<int>());
                squares.Add(new HashSet<int>());
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid.setBoxIJ(i, j, new Box(columns[i], lines[j], squares[(int)(Math.Floor((double)j / 3)) + (int)(3 * Math.Floor((double)i / 3))]));
                    gridToSolve.setBoxIJ(i, j, new Box(columns[i], lines[j], squares[(int)(Math.Floor((double)j / 3)) + (int)(3 * Math.Floor((double)i / 3))]));
                    //for each box, for 9 turns the column is the same, but the line change each time.
                    //The square stays the same for 3 turn then increment, the formula is to give the position of the square in function of i and j.
                }
            }


        }

        public void generateGrid()
        {
            if (grid.isLast())
            {
                return;
            }
            Box tmpBox = grid.getCurrentBox();

            if (tmpBox.getValue() != 0)
            {
                tmpBox.remove();
            }

            tmpBox.diffValues();
            int nb;
            if (!tmpBox.isEmpty())
            {

                nb = tmpBox.randValue(); //Return a random values in the allowed values.

                tmpBox.setValue(nb);
                tmpBox.addAll(nb);
                tmpBox.addForbidden(nb);

                //REcursive call on the next box
                grid.next();
                generateGrid();

            }

            else
            {

                tmpBox.setValue(0);
                tmpBox.resetForbidden();
                grid.previous();
                generateGrid();
            }



        }

        public int getValueIJ(int i, int j)
        {
            return gridToSolve.getBoxIJ(i, j).getValue();
        }

        public void displayGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grid.getBoxIJ(i, j).getValue());
                }
                Console.WriteLine();
            }
        }

        public void generation()
        {
            generateGrid();

            gridToSolve.setFromGrid(grid);
            solver = new Solver(gridToSolve);
        }

        public void hideCells(int n)
        {
            for(int i = 0; i < n; i++)
            {
                solver.removeBox();
            }
        }

        public void launchGame()
        {
            this.generation();
            this.displayGrid();
            this.hideCells(1);

        }

        public bool checkAnswer()
        {
            bool correct = true;

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (gridToSolve.getBoxIJ(i, j).getValue() != grid.getBoxIJ(i, j).getValue())
                    {
                        correct = false;
                        break;
                    }
                }
            }

            return correct; 
        }

        public void setIJ(int i, int j, int value)
        {
            gridToSolve.getBoxIJ(i, j).setValue(value);
        }

    }
}
