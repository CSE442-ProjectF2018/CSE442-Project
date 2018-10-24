using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GUIform
{
    public class Path
    {
        public Path next;
        public Path prev;
        public int X;
        public int Y;
        public Path(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class Map
    {
        //Default dimension is 16x16.
        private int dimension = 16;
        //Default map type(empty). Int: for use with switch statement.
        private int mapType = 0;

        public Snake _currentSnake;

        //Location of apple.
        public Point _appleLocation;

        //Location of snake's _head.
        public Point _snakeLocation;

        public bool _appleGet;

        public Path _head;
        public Path _tail;
        Path _trav;
        

        private Block[,] info;
        
        //If no arguments given, use default arguments.
        public Map()
        {
            info = new Block[dimension, dimension];
            buildMap();

            initSnake();

            _head = new Path(_snakeLocation.X, _snakeLocation.Y);
            _tail = _head;
            _tail.prev = _head;
            _trav = _head;

        }

        //Parameter d refers to dimension(s) of the grid. It's a square so only one number is needed.
        public Map(int d, int mt)
        {

            //MUST BE UPDATED. DO NOT USE.
            dimension = d;
            mapType = mt;

            buildMap();
        }

        public Block getBlockAt(int i, int j)
        {
            return info[i, j];
        }

        public void setBlockAt(int i, int j, Block t)
        {
            info[i, j] = t;
            if(t.getType() == 1)
            {
                _appleLocation.X = i;
                _appleLocation.Y = j;
            }
        }

        public void initSnake()
        {
            //Spawn new snake at location 7,7 with length of 3.
            _currentSnake = new Snake();
            
            _snakeLocation = new Point(7, 7);
        }

        public void updateSnakePath()
        {
            _appleGet = false;
            
            //North = 0
            //East = 1
            //South = 2
            //West = 3
            int currentDirection;

            //Is apple East or West?
            if(_snakeLocation.X < _appleLocation.X)
            {
                currentDirection = 1;
            }else if(_snakeLocation.X > _appleLocation.X)
            {
                currentDirection = 3;
            }
            else
            {
                //Is apple North or South?
                if(_snakeLocation.Y < _appleLocation.Y)
                {
                    currentDirection = 2;
                }
                else
                {
                    currentDirection = 0;
                }
            }

            _head = new Path(_snakeLocation.X, _snakeLocation.Y);
            _tail = _head;
            _tail.prev = _head;
            _trav = _head;

            Path trav = _head;
            Path temp;
            bool targetReached = false;
            while (!targetReached)
            {
                switch (currentDirection)
                {
                    case 0:
                        temp = new Path(_tail.X, _tail.Y - 1);
                        break;
                    case 1:
                        temp = new Path(_tail.X + 1, _tail.Y);
                        break;
                    case 2:
                        temp = new Path(_tail.X, _tail.Y + 1);
                        break;
                    case 3:
                        temp = new Path(_tail.X - 1, _tail.Y);
                        break;
                    default:
                        temp = new Path(0, 0);
                        break;
                }
                temp.prev = _tail;
                _tail.next = temp;
                _tail = temp;

                //Is apple East or West?
            if(_tail.X < _appleLocation.X)
            {
                currentDirection = 1;
            }else if(_tail.X > _appleLocation.X)
            {
                currentDirection = 3;
            }
            else
            {
                //Is apple North or South?
                if(_tail.Y < _appleLocation.Y)
                {
                    currentDirection = 2;
                }else if(_tail.Y > _appleLocation.Y)
                    {
                        currentDirection = 0;
                    }
                    else
                    {
                        targetReached = !targetReached;
                        continue;
                    }
            }



                if (_tail.X >= 16 || _tail.Y >= 16)
                {
                    MessageBox.Show("OUT OF BOUNDS IN PATHFINDING");
                }

                continue;
            }


        }

        public void moveSnake()
        {
            _trav = _trav.next;

            int nextDirection;

            //Is apple East or West?
            if (_trav.X < _snakeLocation.X)
            {
                nextDirection = 3;
            }
            else if (_trav.X > _snakeLocation.X)
            {
                nextDirection = 1;
            }
            else
            {
                //Is apple North or South?
                if (_trav.Y < _snakeLocation.Y)
                {
                    nextDirection = 0;
                }
                else
                {
                    nextDirection = 2;
                }
            }
            info[_currentSnake._Tail.X, _currentSnake._Tail.Y] = new Block(0);

            _currentSnake.slither(nextDirection);

            _snakeLocation.X = _currentSnake._Head.X;
            _snakeLocation.Y = _currentSnake._Head.Y;

            if(info[_snakeLocation.X, _snakeLocation.Y].getType() == 1)
            {
                _appleGet = true;
                _currentSnake.consume(5);
            }

            info[_currentSnake._Tail.X, _currentSnake._Tail.Y] = new Block(3);
            info[_currentSnake._Head.X, _currentSnake._Head.Y] = new Block(3);


        }

        

        public void buildMap()
        {
            for(int i = 0; i < dimension; ++i)
            {
                for(int j = 0; j < dimension; ++j)
                {
                    info[i, j] = new Block();
                }
            }
        }
    }
}
