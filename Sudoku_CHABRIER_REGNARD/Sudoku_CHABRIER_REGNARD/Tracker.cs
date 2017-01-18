using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    class Tracker
    {
        private Index head;


        //Add an new index at the top of the stack
        public void push(Index i)
        {

        
            Index toAdd = new Index(i.getI(), i.getJ());

            toAdd.Prev = head;
            head = toAdd;

          
        }

        //Say if it's first element or not
        public bool isFirst()
        {
            if (head != null)
                return head.Prev == null;
            else
                return true;
        }

        //Return element on top of the stack
        public Index pop()
        {
            Index toPop = head;
            if (isFirst())
                head = null;
            else head = head.Prev;

            return toPop;
        }
    }
}
