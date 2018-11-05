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
        //depth NOT Initialized! Must be set elsewhere!
        public int depth;

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

        public bool _snakeDeath;

        public Path _head;
        public Path _tail;
        Path _trav;

        public int _apples = 3;


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
            _snakeDeath = false;
        }

        public void updateSnakePath()
        {
            //Reset apple flag to false when new path is calculated.
            _appleGet = false;
            
            //North = 0
            //East = 1
            //South = 2
            //West = 3
            int currentDirection;

            //Longest path (by DPS) to apple.
            Path deepestApple;

            //Furthest away (by DPS) deadend.
            Path deepestDeadEnd;

            //Traversal stack for DPS.
            Stack<Path> DPS = new Stack<Path>();

            //2D array same size as map for checking if a tile has been visited.
            bool[,] visited = new bool[16, 16];

            _trav = new Path(_snakeLocation.X, _snakeLocation.Y);
            _trav.depth = 0;
            visited[_trav.X, _trav.Y] = true;

            DPS.Push(_trav);

            while (true)
            {
                //Check Children
                //North
                
            }
            


        }

        private bool validChild(int x, int y)
        {
            if(x < 0 || y < 0)
            {
                return false;
            }else if(15 < x || 15 < y)
            {
                return false;
            }else if(info[x,y].getType() == 2 || info[x,y].getType() == 3)
            {
                return false;
            }
            else
            {
                return true;
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
            }else if(info[_snakeLocation.X, _snakeLocation.Y].getType() == 3)
            {
                _snakeDeath = true;
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
