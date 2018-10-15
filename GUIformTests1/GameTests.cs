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
            Game g = new Game();
            int x = 3;
            int y = 5;
            g.placeApple(x,y);
            Assert.AreEqual(BType.apple,g.map_16[x,y]);
        }
    }
}