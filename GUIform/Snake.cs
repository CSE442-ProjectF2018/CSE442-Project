﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    //snake movement
    public enum direction { up, down, left, right }

    public class SnakeNode
    {
        //grid position for slice of snake
        public int x;
        public int y;

        //next moves towards the tail
        public SnakeNode next;
        //prev moves towads the head
        public SnakeNode prev;

    }

    public class Snake
    {
        //head is the part that looks like it moves
        public SnakeNode Head;
        //tail is what actually moves
        public SnakeNode Tail;

        //record of previous direction
        public direction dir;

        //keeps track of snake length
        //just incase we want to use it for something
        private int length = 2;

        //unemplemented
        public int speed;

        //this builds the snake
        public void spawn(int gridx, int gridy, int len=2)
        {
            //entire snake begins in one grid space

            //start with at least two nodes
            //one for the head
            Head = new SnakeNode();
            Head.x = gridx;
            Head.y = gridy;
            //one for the tail
            Tail = new SnakeNode();
            Tail.x = gridx;
            Tail.y = gridy;

            //if a longer snake is desired
            //this loop adds them
            SnakeNode tempnode;
            tempnode = Head;
            for (int i = 2; i < len; i++)
            {
                tempnode.next = new SnakeNode();
                tempnode.next.x = gridx;
                tempnode.next.y = gridy;
                tempnode.next.prev = tempnode;
                tempnode = tempnode.next;
                tempnode.next = Tail;
                Tail.prev = tempnode;
                length = length + 1;

            }

        }

        //check for collisions first
        public void slither(direction d)
        {

            //move tail to head
            Tail.x = Head.x;
            Tail.y = Head.y;

            switch(d)
            {
                case direction.up:
                    Tail.y += 1;
                    break;

                case direction.down:
                    Tail.y -= 1;
                    break;

                case direction.left:
                    Tail.x -= 1;
                    break;

                case direction.right:
                    Tail.x += 1;
                    break;
            }

            //update node order
            Tail.prev.next = null;
            Tail.next = Head;
            Head = Tail;
            Tail = Tail.prev;

        }

        public void consume(int gridx, int gridy)
        {

        }

        public void perish()
        {

        }

    }

}