using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUIform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GUIform.Tests
{
    [TestClass()]
    public class MapTests
    {
        [TestMethod()]
        public void updateSnakePathTest()
        {
            Map myMap = new Map();
            Block currentBlock = new Block(1);
            myMap.setBlockAt(2, 3, currentBlock);
            myMap.updateSnakePath();
            Point tailLoc = new Point(myMap._tail.X,myMap._tail.Y);
            Point headLoc = new Point(myMap._head.X, myMap._head.Y);
            Assert.AreEqual(tailLoc,myMap._appleLocation);
            Assert.AreEqual(headLoc, myMap._snakeLocation);
            
        }
    }
}