using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUIform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform.Tests
{
    [TestClass()]
    public class GameTests
    {
        [TestMethod()]
        public void placeAppleTest()
        {
            //This test if the apple was placed where we want it.
            Game g = new Game();
            int x = 3;
            int y = 5;
            g.placeApple(x,y);
            bool expected = true;
            bool actual;
            if (g.map_16[x,y].bt == BType.apple) actual = true;
            else actual = false;
            Assert.AreEqual(actual,expected);
        }
        [TestMethod()]
        public void placeAppleTest2()
        {
            //this tests that we cannot place more than 1 apple at a time
            Game g = new Game();
            int x = 3;
            int y = 5;
            g.placeApple(x, y);
            x = 1;
            y = 4;
            g.placeApple(x, y);
            bool expected = true;
            bool actual;
            if (g.map_16[x, y].bt == BType.apple) actual = true;
            else actual = false;
            Assert.AreEqual(actual, expected);
        }
    }
}