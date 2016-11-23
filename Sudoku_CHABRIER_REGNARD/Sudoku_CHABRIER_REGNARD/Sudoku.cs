using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    public class Sudoku
    {
        private Box[,] grid;

        public Sudoku()
        {
        }

        public void generateGrid()
        {
            for(int i = 0; i< 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    grid[i, j].diffValues();
                    grid[i, j].randValue();
                }
            }
        }

    }


}
