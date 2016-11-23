using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku_CHABRIER_REGNARD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sudoku_CHABRIER_REGNARD;
using System.Diagnostics;

namespace Sudoku_CHABRIER_REGNARD.Tests
{
    [TestClass()]
    public class BoxTests
    {
        [TestMethod()]
        public void SameSetsTest()
        {
            HashSet<int> column = new HashSet<int>();
            HashSet<int> line = new HashSet<int>();
            HashSet<int> square = new HashSet<int>();

            column.Add(1);
            Box box1 = new Box(column, line, square);
            Box box2 = new Box(column, line, square);

            box1.addColumn(3);
            Assert.AreEqual(true, column.Contains(3), "Box create a new column instead of modifying one existing");

            box2.addColumn(5);
            Assert.AreEqual(true, column.Contains(5), "Box creates a new column instead of just a reference");
        }


        [TestMethod()]
        public void diffValuesTest()
        {
            HashSet<int> column = new HashSet<int>();
            HashSet<int> line = new HashSet<int>();
            HashSet<int> square = new HashSet<int>();
            HashSet<int> allowed;

            column.Add(2);
            line.Add(3);
            line.Add(4);
            line.Add(2);
            square.Add(6);
            square.Add(8); 


            Box box = new Box(column, line, square);
            box.diffValues();

            allowed = box.getAllowed();
           

            Assert.AreEqual(true, allowed.Contains(1), "Function diff is not working 1");
            Assert.AreEqual(true, allowed.Contains(5), "Function diff is not working 5");
            Assert.AreEqual(true, allowed.Contains(7), "Function diff is not working 7");
            Assert.AreEqual(true, allowed.Contains(9), "Function diff is not working 9");

            Assert.AreEqual(false, allowed.Contains(2), "function diff is not working 2");
            Assert.AreEqual(false, allowed.Contains(3), "function diff is not working 3");
            Assert.AreEqual(false, allowed.Contains(4), "function diff is not working 4");
            Assert.AreEqual(false, allowed.Contains(6), "function diff is not working 6");
            Assert.AreEqual(false, allowed.Contains(8), "function diff is not working 8");

        }

        [TestMethod()]
        public void randValueTest()
        {
            HashSet<int> column = new HashSet<int>();
            HashSet<int> line = new HashSet<int>();
            HashSet<int> square = new HashSet<int>();

            column.Add(1);
            column.Add(2);
            column.Add(3);
            column.Add(4);
            column.Add(5);
            column.Add(6);
            column.Add(7);
            column.Add(8);
            Box box = new Box(column, line, square);
            box.diffValues();
            box.randValue();

            Assert.AreEqual(9, box.getValue(), "randValue not working when one value left");


            column.Remove(5);
            column.Remove(7);

            bool good = false;
            box.diffValues();
            box.randValue();

            if (box.getValue() == 7 || box.getValue() == 9 || box.getValue() == 5)
                good = true;

            Assert.AreEqual(true, good, "randValue not working when multiple values in list");
        }
    }
}