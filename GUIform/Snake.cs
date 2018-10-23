using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    
    public class SnakeNode
    {
        //grid position for slice of snake
        public int X;
        public int Y;

        //next moves towards the tail
        public SnakeNode next;
        //prev moves towads the head
        public SnakeNode prev;

        public SnakeNode(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Snake
    {
        //North = 0
        //East = 1
        //South = 2
        //West = 3
        int _currentDirection;

        //head is the part that looks like it moves
        public SnakeNode _Head;
        
        //tail is what actually moves
        public SnakeNode _Tail;

        //record of previous direction
        public int _dirPrev;

        //keeps track of snake length
        //just incase we want to use it for something
        public int _length;

        //Default Constructor
        public Snake()
        {
            //Snake Moves right by default.
            _currentDirection = 1;

            _dirPrev = _currentDirection;

            //Spawn snake at 7,7.
            _Head = new SnakeNode(7, 7);

            //At the beginning, Head and Tail occupy same space.
            _Tail = _Head;
            _Tail.next = _Head;
            _Head.prev = _Tail;

            //Initial Length unless otherwise specified.
            _length = 3;

            SnakeNode trav = _Tail;
            for(int i = 0; i < (3 - 2); ++i)
            {
                SnakeNode temp = trav;
                temp.prev = trav;
                temp.next = _Head;

                trav.next = temp;
                _Head.prev = temp;

                trav = temp;               

            }


        }

        //A D V A N C E D   Constructor
        public Snake(int x, int y, int initLength, int initDirection)
        {
            //Snake Moves right by default.
            _currentDirection = initDirection;

            _dirPrev = _currentDirection;

            //Spawn snake at 7,7.
            _Head = new SnakeNode(x, y);

            //At the beginning, Head and Tail occupy same space.
            _Tail = _Head;

            //Initial Length unless otherwise specified.
            _length = initLength;

            if(_length > 2)
            {
                SnakeNode trav = _Tail;
                for (int i = 0; i < (3 - 2); ++i)
                {
                    SnakeNode temp = trav;
                    temp.prev = trav;
                    temp.next = _Head;

                    trav.next = temp;
                    _Head.prev = temp;

                    trav = temp;

                }
            }
        }

        //Move Snake in a given direction.
        //This is directed from the pathfinding algo.
        public void slither(int direction)
        {
            //Take in new direction.
            _currentDirection = direction;

            //Move snake tail coords to head coords.
            _Tail.X = _Head.X;
            _Tail.Y = _Head.Y;

            //Move Tail to adjacent tile in new direction.
            //North = 0
            //East = 1
            //South = 2
            //West = 3
            switch (_currentDirection)
            {
                case 0:
                    _Tail.Y--;
                    break;
                case 1:
                    _Tail.X++;
                    break;
                case 2:
                    _Tail.Y++;
                    break;
                case 3:
                    _Tail.X--;
                    break;
            }

            //Tail becomes new head.
            _Head.next = _Tail;
            _Tail.prev = _Head;

            SnakeNode temp = _Tail.next;
            temp.prev = null;
            _Tail.next = null;

            _Head = _Tail;
            _Tail = temp;

        }

        //Add length to snake upon consumption of an Apple.
        //Amount of length to add is passed as an argument.
        public void consume(int incBy)
        {
            for(int i = 0; i < incBy; ++i)
            {
                SnakeNode temp = _Tail;
                temp.next = _Tail;
                _Tail.prev = temp;
                _Tail = temp;

                _length++;
            }
            
        }

        public void perish()
        {

        }

    }

}