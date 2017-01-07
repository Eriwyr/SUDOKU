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

        public void push(Index i)
        {

        
            Index toAdd = new Index(i.getI(), i.getJ());

            toAdd.Prev = head;
            head = toAdd;

          
        }

        public bool isFirst()
        {
            return head.Prev == null;
        }

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
