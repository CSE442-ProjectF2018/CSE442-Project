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

        /// set the x coordinate for a SnakeNode
        [TestMethod()]
        public void CheckSnakeNodeX()
        {
            int x = 0;

            SnakeNode chunk = new SnakeNode();
            chunk.x = x;

            int expected = x;
            int actual = chunk.x;
            Assert.AreEqual(expected, actual);

        }

        /// set the y coordinate for a SnakeNode
        [TestMethod()]
        public void CheckSnakeNodeY()
        {
            int y = 0;

            SnakeNode chunk = new SnakeNode();
            chunk.y = y;

            int expected = y;
            int actual = chunk.y;
            Assert.AreEqual(expected, actual);

        }

        /// set next node for a SnakeNode
        [TestMethod()]
        public void CheckSnakeNodeNext()
        {
            SnakeNode chunk = new SnakeNode();
            SnakeNode temp = new SnakeNode();
            chunk.next = temp;

            SnakeNode expected = temp;
            SnakeNode actual = chunk.next;
            Assert.AreEqual(expected, actual);

        }

        /// set prev node for a SnakeNode
        [TestMethod()]
        public void CheckSnakeNodePrev()
        {
            SnakeNode chunk = new SnakeNode();
            SnakeNode temp = new SnakeNode();
            chunk.prev = temp;

            SnakeNode expected = temp;
            SnakeNode actual = chunk.prev;
            Assert.AreEqual(expected, actual);

        }

        /// set the spawn coords and length for a Snake
        [TestMethod()]
        public void CheckSpawnLength()
        {
            Snake snek = new Snake();
            int x = 0;
            int y = 0;
            int len = 5;
            snek.spawn(x, y, len);

            int expected = len;
            int actual = snek.length;
            Assert.AreEqual(expected, actual);
        }

        /// set the spawn coords and length for a Snake
        [TestMethod()]
        public void CheckSpawnX()
        {
            Snake snek = new Snake();
            int x = 0;
            int y = 0;
            int len = 5;
            snek.spawn(x, y, len);

            int expected = x;
            int actual = snek.Head.x;
            Assert.AreEqual(expected, actual);
        }
        /// set the spawn coords and length for a Snake
        [TestMethod()]
        public void CheckSpawnY()
        {
            Snake snek = new Snake();
            int x = 0;
            int y = 0;
            int len = 5;
            snek.spawn(x, y, len);

            int expected = y;
            int actual = snek.Head.y;
            Assert.AreEqual(expected, actual);
        }


    }
}