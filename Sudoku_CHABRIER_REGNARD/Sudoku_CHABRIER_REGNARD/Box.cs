using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_CHABRIER_REGNARD
{
    public class Box
    {
        
        private HashSet<int> column;
        private HashSet<int> line;
        private HashSet<int> square;

        private HashSet<int> allowedValues;
        private HashSet<int> forbiddenValues;

        private bool wasTested;


        private int value;

        public Box(HashSet<int> column, HashSet<int> line, HashSet<int> square)
        {
            this.column = column;
            this.line = line;
            this.square = square;
            wasTested = false;
            allowedValues = new HashSet<int>();
            forbiddenValues = new HashSet<int>();
            resetAllowed();
            value = 0;
        }

        public bool WasTested
        {
            get; set;
        }

        public void resetAllowed()
        {
            for (int i = 1; i <= 9; i++)
            {
                allowedValues.Add(i);
            }
        }

        public bool isUnique()
        {
            return allowedValues.Count == 1;
        }

        public bool checkAllowed(int value)
        {
            return allowedValues.Contains(value);
        }

        public void diffValues()
        {

            resetAllowed();
            allowedValues.ExceptWith(column);
            allowedValues.ExceptWith(line);
            allowedValues.ExceptWith(square);
            allowedValues.ExceptWith(forbiddenValues);

        }


        public int randValue()
        {
            Random rand = new Random();
            int index = rand.Next(0, allowedValues.Count);
            List < int > list = allowedValues.ToList();

            return list[index];

        } 

        public void addAll(int value)
        {
            addColumn(value);
            addLine(value);
            addSquare(value);
        }
        
        public int getValue()
        {
            return value;
        } 

        public void setValue(int value)
        {
            this.value = value;
        }

        public HashSet<int> getAllowed()
        {
            return allowedValues;
        }

        public bool isAllowed(int value)
        {
            return allowedValues.Contains(value);
        }
        
        public void addColumn(int value)
        {
            column.Add(value);
        }

        public void addLine(int value)
        {
            line.Add(value);
        }

        public void addSquare(int value)
        {
            square.Add(value);
        }

        public void addForbidden(int value)
        {
            forbiddenValues.Add(value);
        }

        public void remove()
        {
            column.Remove(value);
            line.Remove(value);
            square.Remove(value);
        }

        public void resetForbidden()
        {
            forbiddenValues = new HashSet<int>();
        }

        public bool isEmpty()
        {
            return allowedValues.Count() == 0;      
        }


        public void displayAllowed()
        {
            List<int> list = allowedValues.ToList();
            for(int i =0; i< list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
