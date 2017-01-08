using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    class Solver
    {
        private Grid grid;
        private Tracker indexes;

        public Solver(Grid grid)
        {
            this.grid = grid;
            indexes = new Tracker();
        }

        public void removeBox()
        {
            int nbSol = 0;
            int i, j;
            int value;
            Random rd = new Random();
          
            nbSol = 0;
            do
            {

                i = rd.Next(0, 9);
                j = rd.Next(0, 9);
            } while (grid.getBoxIJ(i, j).WasTested || grid.getBoxIJ(i, j).getValue() == 0);

            Box tmpBox = grid.getBoxIJ(i, j);
            value = tmpBox.getValue();

            tmpBox.remove();
            tmpBox.diffValues();
          

            if (!tmpBox.isUnique())
            {
                
                List<int> values = tmpBox.getAllowed().ToList();
                foreach(int val in values)
                {
                    tmpBox.setValue(val);
                    tmpBox.addAll(val);
                    
                    if (solve(indexes.pop()))
                        nbSol++;
                    
                  

                    tmpBox.remove();
                    tmpBox.setValue(0);
                }

            } else
            {
                nbSol = 1;
            }

            tmpBox.WasTested = true;

            if( nbSol == 1)
            {
                tmpBox.remove();
                tmpBox.setValue(0);
                indexes.push(new Index(i, j));
            }
           


        }

        public bool solve(Index curInd)
        {

            if (curInd == null)
                return true;           
            Box tmpBox = grid.getBoxIJ(curInd.getI(), curInd.getJ());
            tmpBox.diffValues();
          
            if(indexes.isFirst())
            {
                tmpBox.remove(); //We delete the box to make sure the grid go back to its previous state
                tmpBox.resetForbidden();
                tmpBox.setValue(0);
                indexes.push(curInd);
                if (tmpBox.isEmpty())
                    return false;
                else
                    return true;
            }

            if (tmpBox.isEmpty()) //At whatever point, if we cannot find a value, there is no solution
            {
                return false;
            }

            int nb = tmpBox.randValue();
            tmpBox.setValue(nb);
            tmpBox.addAll(nb);
            tmpBox.addForbidden(nb);

            bool ret = solve(indexes.pop());
            tmpBox.remove();
            tmpBox.resetForbidden();
            tmpBox.setValue(0);
            indexes.push(curInd);

            return ret;

            
        }
    }
}


