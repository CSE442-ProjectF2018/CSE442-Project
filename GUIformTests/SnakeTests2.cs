using Microsoft.VisualStudio.TestTools.UnitTesting;
using GUIform;
using GUIform.Snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform.Tests
{
    [TestClass()]
    public class SnakeTests2
    {

        /// set the x coordinate for a SnakeNode
        [TestMethod()]
        public void checkSnakeNodeX()
        {
            int x = 0;

            SnakeNode* chunk = new SnakeNode();
            chunk.x = x;

            int expected = x;
            int actual = chunk.x;
            Assert.AreEqual(expected, actual);

        }

        /// set the y coordinate for a SnakeNode
        [TestMethod()]
        public void checkSnakeNodeY()
        {
            int y = 0;

            SnakeNode* chunk = new SnakeNode();
            chunk.y = y;

            int expected = y;
            int actual = chunk.y;
            Assert.AreEqual(expected, actual);

        }

        /// set next node for a SnakeNode
        [TestMethod()]
        public void checkSnakeNodeNext()
        {
            SnakeNode* chunk = new SnakeNode();
            SnakeNode* temp = new SnakeNode();
            chunk.next = temp;

            SnakeNode* expected = temp;
            SnakeNode* actual = chunk.next;
            Assert.AreEqual(expected, actual);

        }

        /// set prev node for a SnakeNode
        [TestMethod()]
        public void checkSnakeNodeNext()
        {
            SnakeNode* chunk = new SnakeNode();
            SnakeNode* temp = new SnakeNode();
            chunk.prev = temp;

            SnakeNode* expected = temp;
            SnakeNode* actual = chunk.prev;
            Assert.AreEqual(expected, actual);

        }

        /// set the spawn coords and length for a Snake
        [TestMethod()]
        public void checkSpawnLength()
        {
            Snake* snek = new Snake();
            int x = 0;
            int y = 0;
            int len = 5;
            snek.spawn(x, y, len);

            SnakeNode* tempnode = snek.Head.next;

            int expected = length;
            int actual = 5;
            Assert.AreEqual(expected, actual);
        }

    }
}