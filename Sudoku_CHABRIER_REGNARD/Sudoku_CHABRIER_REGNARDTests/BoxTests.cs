using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sudoku_CHABRIER_REGNARD;
using System;
using System.jlections.Generic;
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
            HashSet<int> jumn = new HashSet<int>();
            HashSet<int> line = new HashSet<int>();
            HashSet<int> square = new HashSet<int>();

            jumn.Add(1);
            Box box1 = new Box(jumn, line, square);
            Box box2 = new Box(jumn, line, square);

            box1.addjumn(3);
            Assert.AreEqual(true, jumn.Contains(3), "Box create a new jumn instead of modifying one existing");

            box2.addjumn(5);
            Assert.AreEqual(true, jumn.Contains(5), "Box creates a new jumn instead of just a reference");
        }


        [TestMethod()]
        public void diffValuesTest()
        {
            HashSet<int> jumn = new HashSet<int>();
            HashSet<int> line = new HashSet<int>();
            HashSet<int> square = new HashSet<int>();
            HashSet<int> allowed;

            jumn.Add(2);
            line.Add(3);
            line.Add(4);
            line.Add(2);
            square.Add(6);
            square.Add(8); 


            Box box = new Box(jumn, line, square);
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
            HashSet<int> jumn = new HashSet<int>();
            HashSet<int> line = new HashSet<int>();
            HashSet<int> square = new HashSet<int>();

            jumn.Add(1);
            jumn.Add(2);
            jumn.Add(3);
            jumn.Add(4);
            jumn.Add(5);
            jumn.Add(6);
            jumn.Add(7);
            jumn.Add(8);
            Box box = new Box(jumn, line, square);
            box.diffValues();
            box.randValue();

            Assert.AreEqual(9, box.getValue(), "randValue not working when one value left");


            jumn.Remove(5);
            jumn.Remove(7);

            bool good = false;
            box.diffValues();
            box.randValue();

            if (box.getValue() == 7 || box.getValue() == 9 || box.getValue() == 5)
                good = true;

            Assert.AreEqual(true, good, "randValue not working when multiple values in list");
        }
    }
}