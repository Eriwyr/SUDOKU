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

        public void removeBox() //Remove a box, and foreach values possible in the box, we count the number of solutiosn
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
            } while (grid.getBoxIJ(i, j).WasTested || grid.getBoxIJ(i, j).getValue() == 0); //Random grid picking

            Box tmpBox = grid.getBoxIJ(i, j);
            value = tmpBox.getValue();

            tmpBox.remove();
            tmpBox.diffValues(); //We list the allowed values
          

            if (!tmpBox.isUnique())
            {
                
                List<int> values = tmpBox.getAllowed().ToList();
                foreach(int val in values) //foreach value, we set it
                {
                    tmpBox.setValue(val);
                    tmpBox.addAll(val);
                    
                    if (solve(indexes.pop())) //We check if the gird is solvable
                        nbSol++;
                    
                  

                    tmpBox.remove(); // We remove it to make sure we can set another one
                    tmpBox.setValue(0);
                }

            } else //If there was only one possible value, then it's not necessary to test it.
            {
                nbSol = 1;
            }

            tmpBox.WasTested = true;

            if( nbSol == 1) //If the total number of solutions is 1 then
            {
                tmpBox.remove(); //We remove it, because it's not necessary
                tmpBox.setValue(0);
                indexes.push(new Index(i, j)); //We add it in the stack to keep track.
            }
           


        }

        public bool solve(Index curInd) //Recursive function, checks if the grid is solvable by solving it
        {

            if (curInd == null) //No more item to check
                return true;           
            Box tmpBox = grid.getBoxIJ(curInd.getI(), curInd.getJ()); //We get the current box
            tmpBox.diffValues();
          
            if(indexes.isFirst()) //First element, then nothing else to do
            {
                tmpBox.remove(); //We delete the box to make sure the grid go back to its previous state
                tmpBox.resetForbidden();
                tmpBox.setValue(0);
                indexes.push(curInd); //We put it back in the tracker
                if (tmpBox.isEmpty())
                    return false; //If we do not have possible values here, the grid is not solvable
                else
                    return true; //It's solvable
            }

            if (tmpBox.isEmpty()) //At whatever point, if we cannot find a value, there is no solution
            {
                return false;
            }

            int nb = tmpBox.randValue(); //We put a value so we can test other boxes
            tmpBox.setValue(nb);
            tmpBox.addAll(nb);
            tmpBox.addForbidden(nb);

            bool ret = solve(indexes.pop()); //Recursive call on the previous box that was removed
            tmpBox.remove(); //We remove the box after the recursive call because it was not set at the begining
            tmpBox.resetForbidden();
            tmpBox.setValue(0);
            indexes.push(curInd);

            return ret;

            
        }
    }
}


