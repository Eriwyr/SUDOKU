using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    class Grid
    {
        private Box[,] grid;
        private int currentI;
        private int currentJ;

        //Uses Iterator-like way of iterrating through the grid.

        public Grid()
        {
            grid = new Box[9, 9];

            currentI = 0;
            currentJ = 0;
        }


        public Box getBoxIJ(int i, int j)
        {
            return grid[i, j];
        }

        public void setBoxIJ(int i, int j, Box box)
        {
            grid[i, j] = box;
        }

        public Box getCurrentBox()
        {
            return grid[currentI,currentJ];
        }

        public int getCurrentI()
        {
            return currentI;
        }

        public int getCurrentJ()
        {
            return currentJ;
        }
        public void next()
        {
            // i = current index of lines
            // j = current index of columns

            if(currentJ == 8) // we are at the end of the line
            {
                currentI++;
                currentJ = 0;

            }
            else
            {
                currentJ++;
            }


        }


        public void next(int i, int j)
        {
            currentI = i;
            currentJ = j;
        }
        
         
        public void previous() //Change the indexes to go to the previous element.
        {
            if (currentJ > 0)
            {
                currentJ--;
            }
            else if(currentI>0)
            {
                currentI--;
            }
        }


        public void clearAll()
        {
            foreach(Box box in grid)
            {
                box.remove();
                box.resetForbidden();
                box.resetAllowed();
            }
        }

        public Boolean isLast()
        {
            return currentI == 9;
        }


        public bool isValid() //Check if the grid is valid
        {
            currentI = 0;
            currentJ = 0;
            clearAll();
            foreach(Box box in grid)
            {
                box.diffValues();
                if (box.isAllowed(box.getValue()))
                {
                    box.addAll(box.getValue());
                } else
                {
                    return false;
                }
            }

            return true;
        }

        public void setFromGrid(Grid g)//Copy the grid values.
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j].setValue(g.grid[i, j].getValue());
                }
            }
        }

    }
}
