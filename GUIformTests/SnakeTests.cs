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
    public class SnakeTests
    {
        [TestMethod()]
        public void changeDirectionTest1()
        {
            Snake snek = new Snake();
            snek.x = 0;
            snek.y = 0;
            snek.d = direction.right;
            snek.changeDirection(direction.left);
            direction expected = direction.right;
            direction actual = snek.d;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void changeDirectionTest2()
        {
            Snake snek = new Snake();
            snek.d = direction.right;
            snek.changeDirection(direction.up);
            direction expected = direction.up;
            direction actual = snek.d;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void addSpeedTest2()
        {
            Snake snek = new Snake();
            snek.speed = 3;
            snek.addSpeed(3);
            int expected = 9;
            int actual = snek.speed;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void placeAppleTest1()
        {
            Apple a = new Apple();
            a.placeA(2, 3);
            int expectedy = 3;
            int actualy = a.y;
            Assert.AreEqual(expectedy, actualy);
        }
        [TestMethod()]
        public void placeAppleTest2()
        {
            Apple a = new Apple();
            a.placeA(2, 3);
            int expected = 0;
            int actual = Master.Apples;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void placeAppleTest3()
        {
            Apple a = new Apple();
            a.placeA(2, 3);
            int expectedy = 3;
            a.placeA(3, 4);
            int actualy = a.y;
            Assert.AreEqual(expectedy, actualy);
        }
    }
}