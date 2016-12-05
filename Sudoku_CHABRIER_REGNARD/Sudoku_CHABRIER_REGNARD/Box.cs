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

        private int value;

        public Box(HashSet<int> column, HashSet<int> line, HashSet<int> square)
        {
            this.column = column;
            this.line = line;
            this.square = square;

            allowedValues = new HashSet<int>();
            for(int i =1; i<=9; i++)
            {
                allowedValues.Add(i);
            }
            value = 0;
        }

        public void diffValues()
        {
            allowedValues.ExceptWith(column);
            allowedValues.ExceptWith(line);
            allowedValues.ExceptWith(square);

        }


        public void randValue()
        {
            Random rand = new Random();
            int index = rand.Next(0, allowedValues.Count);
            List < int > list = allowedValues.ToList();
            Console.WriteLine(index);
            if(list.Count > 0 )
             value = list[index];

        } 
        
        public int getValue()
        {
            return value;
        } 

        public HashSet<int> getAllowed()
        {
            return allowedValues;
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
    }
}
