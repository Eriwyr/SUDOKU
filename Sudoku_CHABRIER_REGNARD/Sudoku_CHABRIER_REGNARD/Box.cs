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
        
        private HashSet<int> column; //This is a HashSet containing the values in the column
        private HashSet<int> line; //This is a HashSet containing the values in the line
        private HashSet<int> square; //This is a HashSet containing the values in the square

        private HashSet<int> allowedValues; //This will contain the allowed values in this box
        private HashSet<int> forbiddenValues; //This will contain restrained values ( for the recursive algorithm )

        private bool wasTested; //Boolean to know if it was tested or not


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

        public void resetAllowed() //By default, every value is allowed
        {
            for (int i = 1; i <= 9; i++)
            {
                allowedValues.Add(i);
            }
        }

        public bool isUnique() //We check if the allowed value is unique
        {
            return allowedValues.Count == 1;
        }

        public bool checkAllowed(int value) //Checks if the value is allowed
        {
            return allowedValues.Contains(value);
        }

        public void diffValues() //Remove values from allowed values ( by hashset differences)
        {

            resetAllowed();
            allowedValues.ExceptWith(column);
            allowedValues.ExceptWith(line);
            allowedValues.ExceptWith(square);
            allowedValues.ExceptWith(forbiddenValues);

        }


        public int randValue() //Give a random value among the allowed ones.
        {
            Random rand = new Random();
            int index = rand.Next(0, allowedValues.Count);
            List < int > list = allowedValues.ToList();

            return list[index];

        } 

        public void addAll(int value) //Add in line, column, square the value
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
