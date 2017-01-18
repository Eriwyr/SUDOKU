using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    class Index
    {
        private int i;
        private int j;

        private Index prev; //Link for tracking.

        public Index(int i, int j)
        {
            this.i = i;
            this.j = j;
            prev = null;
        }

        public bool equals(Index i)
        {
            return (this.i == i.i && this.j == i.j);
        }

        public int getI()
        {
            return i;
        }

        public int getJ()
        {
            return j;
        }

        public Index Prev
        {
            get; set;
        }
    }
}
