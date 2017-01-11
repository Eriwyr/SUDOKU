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
        private List<HashSet<int>> columns; //9 columns
        private List<HashSet<int>> lines; //9 lines
        private List<HashSet<int>> squares; //9 squares
        private Grid grid; //Grid complete
        private Grid gridToSolve; //Grid with missing boxes => will be played on
        private Solver solver;
        private int level;

        public Sudoku()
        {
            columns = new List<HashSet<int>>();
            lines = new List<HashSet<int>>();
            squares = new List<HashSet<int>>();
            grid = new Grid();
            gridToSolve = new Grid();
            level = 10;
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
            if (grid.isLast()) //If we generated every box
            {
                return; //We stop
            }
            Box tmpBox = grid.getCurrentBox(); 

            if (tmpBox.getValue() != 0)
            {
                tmpBox.remove();
            }

            tmpBox.diffValues(); //Listing possible values for the current box
            int nb;
            if (!tmpBox.isEmpty()) //If we have possible values
            {

                nb = tmpBox.randValue(); //Return a random values in the allowed values.

                tmpBox.setValue(nb); //We set the value of the box
                tmpBox.addAll(nb); //We make sure it's added in the corresponding line, column, square
                tmpBox.addForbidden(nb); //We add it to the forbidden so that when we go back (backtrack)
                                         // We do not check this value again

                //Recursive call on the next box
                grid.next(); //We iterate on our grid
                generateGrid();

            }

            else //Otherwise if no possible values, we have to go back !!!! (88 miles/h)
            {

                tmpBox.setValue(0); //We remove the value
                tmpBox.resetForbidden(); //We remove the forbidden values
                grid.previous(); //We iterate back
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
            generateGrid(); //create the complete grid

            gridToSolve.setFromGrid(grid); //Copy the complete grid
            solver = new Solver(gridToSolve);
        }

        public void hideCells(int level) //hide as many cells as passed in parameters
        {
            for(int i = 0; i < level; i++)
            {
                solver.removeBox();
            }
        }

        public void launchGame()
        {
            this.generation();
            this.displayGrid();
            this.hideCells(level);

        }

        public bool checkAnswer() //When we validate the grid, we compare both of them.
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

        public void setLevel(int level)
        {
            this.level = level;
        }

    }
}
