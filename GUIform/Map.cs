using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

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
        //
        //Points
        //

        //Total Points for the game.
        public int _points_total;

        //Inital starting points for each turn.
        public int _points_turn;

        //Point value of each coin.
        int _coinValue;

        //Maximum Coins allowed on grid.
        int _maxCoins;

        //Amount of coins collected on that turn.
        int _collectedCoins;

        //Cost of each rock placed by user
        int _rockCost;

        //Rocks placed by user. Number of.
        public int _activeRocks;

        //Cost of each apple placed by user
        int _appleCost;

        //
        //MISC
        //

        //Grid location of apple.
        public Point _appleLocation;

        //Hath thou fairest apple been retrieved?
        public bool _appleGet;

        //A coin was retrieved
        public bool _coinGet;

        //A trap was foolishly stumbled upon.
        public bool _trapHit;

        //Is there a path to the apple available at the moment?
        bool _applePathOpen;

        //Locations of traps on the grid.
        public List<Point> _trapLocations;

        public List<Point> _coinLocations;

        //Maximum amount of traps allowed on grid.
        int _maxTraps;

        //2D matrix representing map info.
        public int[,] _info;

        //Location of current snake's head.
        Point _snakeLocation;

        //Current Snake Object;
        public Snake _currentSnake;

        //Snake Death Flag.
        public bool _snakeDeath;

        //Path variables need to be global because
        Path _head;
        Path _tail;
        Path _trav;


        //Default Constructor
        public Map()
        {
            //Points
            _points_total = 0;
            _points_turn = 1000;
            _coinValue = 500;
            _rockCost = 50;
            _appleCost = 250;

            //MISC
            _maxCoins = 10;
            _maxTraps = 3;
            _activeRocks = 0;
            _trapLocations = new List<Point>();
            _coinLocations = new List<Point>();

            Random rnd = new Random();

            mapGen(rnd.Next(5));
            initSnake();
        }

        public bool partialScoreMod(int t)
        {
            switch (t)
            {
                default:
                    return false;
                    break;
                case 1:
                    if (_points_turn >= _appleCost)
                    {
                        _points_turn -= _appleCost;
                        return true;
                    }
                    return false;
                    break;
                case 2:
                    if (_points_turn >= _rockCost)
                    {
                        _points_turn -= _rockCost;
                        return true;
                    }
                    return false;
                    break;
                case 4:
                    _points_turn += _collectedCoins * _coinValue;
                    return true;
                    break;
                case 5:
                    _points_turn = 0;
                    return true;
                    break;
                case 6:
                    _points_turn += _rockCost;
                    return true;
                    break;
            }
        }

        //Generate grid. Maptype, t.
        public void mapGen(int t)
        {
            switch (t)
            {
                //Default, empty map. No traps, no rocks, initially.
                default:
                case 0:
                    _info = new int[16, 16];
                    for (int i = 0; i < 16; ++i)
                    {
                        for (int j = 0; j < 16; ++j)
                        {
                            _info[i, j] = 0;
                        }
                    }
                    break;
                //Rock Pattern 1. 'X'.
                case 1:
                    _info = new int[16, 16]
                    {
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,6,0,0,0,0,0,0,0,0,0,0,0,0,6,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,6,0,0,0,0,0,0,0,0,6,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,6,0,0,0,0,0,0,0,0,6,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,6,0,0,0,0,0,0,0,0,0,0,0,0,6,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                    };
                    break;
                //Rock Pattern 2. '+'.
                case 2:
                    _info = new int[16, 16]
                    {
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,6,6,6,6,6,0,0,6,6,6,6,6,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,6,6,6,6,6,0,0,6,6,6,6,6,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,6,0,0,6,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                    };
                    break;
                //Rock Pattern 3. Fat '+'.
                case 3:
                    _info = new int[16, 16]
                    {
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,6,6,6,6,0,0,0,0,6,6,6,6,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,6,6,6,6,0,0,0,0,6,6,6,6,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,6,0,0,0,0,6,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                    };
                    break;
                //Rock Pattern 4. Is this loss?
                case 4:
                    _info = new int[16, 16]
                    {
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,6,0,0,0,0,0,0,0,6,0,0,0,0,0},
                        {0,0,6,0,0,0,0,0,0,0,6,0,0,6,0,0},
                        {0,0,6,0,0,0,0,0,0,0,6,0,0,6,0,0},
                        {0,0,6,0,0,0,0,0,0,0,6,0,0,6,0,0},
                        {0,0,6,0,0,0,0,0,0,0,6,0,0,6,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,6,0,0,6,0,0,0,6,0,0,0,0,0,0},
                        {0,0,6,0,0,6,0,0,0,6,0,0,0,0,0,0},
                        {0,0,6,0,0,6,0,0,0,6,0,0,0,0,0,0},
                        {0,0,6,0,0,6,0,0,0,6,0,0,0,0,0,0},
                        {0,0,6,0,0,6,0,0,0,6,6,6,6,6,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
                    };
                    //
                    for (int i = 0; i < 16; ++i)
                    {
                        for (int j = 0; j < 16; ++j)
                        {
                            int temp = _info[i, j];
                            _info[i, j] = _info[j, i];
                            _info[j, i] = temp;
                        }
                    }
                    //
                    break;

            }

            trapGen(_maxTraps);
            coinGen(_maxCoins);
        }

        //Auto place a fixed number of traps on map at random.
        public void trapGen(int maxTraps)
        {
            while (maxTraps != 0)
            {
                Random rnd = new Random();
                int i = rnd.Next(16);
                int j = rnd.Next(16);

                //Adjacent Traps - Check the 8 tiles surrounding the location for existing traps.
                bool adjTrap = false;

                for (int a_i = i - 1; a_i <= i + 1; ++a_i)
                {
                    for (int a_j = j - 1; a_j <= j + 1; ++a_j)
                    {
                        if ((a_i >= 0 && a_i < 16) && (a_j >= 0 && a_j < 16))
                        {
                            if (_info[a_i, a_j] == 5)
                            {
                                adjTrap = true;
                                break;
                            }
                        }
                    }
                    if (adjTrap)
                    {
                        break;
                    }
                }

                if (!adjTrap && _info[i, j] == 0)
                {
                    _info[i, j] = 5;
                    _trapLocations.Add(new Point(i, j));
                    --maxTraps;
                }

            }
        }

        //Coin Generator - Places Coins in groups of 3 on map at random in accordance with Coin Max.
        public void coinGen(int coinLimit)
        {
            while (coinLimit > 0)
            {
                //New Coin location on map.
                Random rnd = new Random();
                int i = rnd.Next(16);
                int j = rnd.Next(16);

                //Is this location empty?
                if (_info[i, j] != 0)
                {
                    continue;
                }

                //Check horizontal states.
                //O__
                //_O_
                //__O
                if (i + 2 < 16)
                {
                    if (_info[i + 2, j] == 0 && _info[i + 1, j] == 0)
                    {
                        int c = 0;
                        while (c < 3 && coinLimit > 0)
                        {
                            _info[i + c, j] = 4;
                            _coinLocations.Add(new Point(i + c, j));
                            --coinLimit;
                            ++c;
                        }
                        continue;
                    }
                    else { continue; }
                }
                else if (i + 1 < 16 && i - 1 >= 0)
                {
                    if (_info[i + 1, j] == 0 && _info[i - 1, j] == 0)
                    {
                        int c = -1;
                        while (c < 2 && coinLimit > 0)
                        {
                            _info[i + c, j] = 4;
                            _coinLocations.Add(new Point(i + c, j));
                            --coinLimit;
                            ++c;
                        }
                        continue;
                    }
                    else { continue; }
                }
                else if (i - 2 >= 0)
                {
                    if (_info[i - 2, j] == 0 && _info[i - 1, j] == 0)
                    {
                        int c = -2;
                        while (c < 1 && coinLimit > 0)
                        {
                            _info[i + c, j] = 4;
                            _coinLocations.Add(new Point(i + c, j));
                            --coinLimit;
                            ++c;
                        }
                        continue;
                    }
                    else { continue; }
                }
                else

               //Check vertical states.
               //  O   _   _
               //  _   O   _
               //  _   _   O
               if (j + 2 < 16)
                {
                    if (_info[j + 2, i] == 0 && _info[j + 1, i] == 0)
                    {
                        int c = 0;
                        while (c < 3 && coinLimit > 0)
                        {
                            _info[j + c, i] = 4;
                            _coinLocations.Add(new Point(i + c, j));
                            --coinLimit;
                            ++c;
                        }
                        continue;
                    }
                    else { continue; }
                }
                else if (j + 1 < 16 && j - 1 >= 0)
                {
                    if (_info[j + 1, i] == 0 && _info[j - 1, i] == 0)
                    {
                        int c = -1;
                        while (c < 2 && coinLimit > 0)
                        {
                            _info[j + c, i] = 4;
                            _coinLocations.Add(new Point(i + c, j));
                            --coinLimit;
                            ++c;
                        }
                        continue;
                    }
                    else { continue; }
                }
                else if (j - 2 >= 0)
                {
                    if (_info[j - 2, i] == 0 && _info[j - 1, i] == 0)
                    {
                        int c = -2;
                        while (c < 1 && coinLimit > 0)
                        {
                            _info[j + c, i] = 4;
                            _coinLocations.Add(new Point(i + c, j));
                            --coinLimit;
                            ++c;
                        }
                        continue;
                    }
                    else { continue; }
                }
                else { continue; }
            }
            _collectedCoins = _maxCoins - _coinLocations.Count;
        }

        //Returns block information at given coordinates.
        public int getBlockAt(int i, int j)
        {
            return _info[i, j];
        }

        //Sets Block type at given coordinates.
        public void setBlockAt(int i, int j, int t)
        {
            _info[i, j] = t;
            switch (t)
            {
                default:
                case 0:
                    break;
                case 1:
                    _appleLocation.X = i;
                    _appleLocation.Y = j;
                    
                    break;
                case 2:
                    ++_activeRocks;

                    break;
            }
        }

        //Initializes snake at default coordinates.
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
            Path deepestApple = null;

            //Furthest away (by DPS) deadend.
            Path deepestDeadEnd = null;

            //Chose at random between Depth and Breadth.
            Random rnd = new Random();
            int travMethod = rnd.Next(2);

            //Traversal stack for DPS.
            Stack<Path> DPS = new Stack<Path>();

            Queue<Path> BPS = new Queue<Path>();

            //2D array same size as map for checking if a tile has been visited.
            bool[,] visited = new bool[16, 16];

            _head = new Path(_snakeLocation.X, _snakeLocation.Y);
            _head.depth = 0;
            _tail = new Path(_snakeLocation.X, _snakeLocation.Y);
            _tail.depth = 0;
            _trav = _head;
            visited[_trav.X, _trav.Y] = true;

            DPS.Push(_trav);
            BPS.Enqueue(_trav);

            while (true)
            {
                //Get top node.
                if (travMethod == 0)
                {
                    _trav = DPS.Pop();
                }
                else
                {
                    _trav = BPS.Dequeue();
                }


                //Check if Apple.
                if (_info[_trav.X, _trav.Y] == 1)
                {
                    if (deepestApple == null)
                    {
                        deepestApple = _trav;
                    }
                    else if (_trav.depth < deepestApple.depth)
                    {
                        deepestApple = _trav;
                    }
                }


                //Check if DeadEnd.
                int badDirectionCount = 0;

                //Check Children
                //North
                if (validChild(_trav.X, _trav.Y - 1))
                {
                    if (!visited[_trav.X, _trav.Y - 1])
                    {
                        Path currentChild = new Path(_trav.X, _trav.Y - 1);
                        currentChild.prev = _trav;
                        currentChild.depth = currentChild.prev.depth + 1;
                        visited[currentChild.X, currentChild.Y] = true;

                        if (travMethod == 0)
                        {
                            DPS.Push(currentChild);
                        }
                        else
                        {
                            BPS.Enqueue(currentChild);
                        }
                    }
                    else
                    {
                        ++badDirectionCount;
                    }
                }
                else
                {
                    ++badDirectionCount;
                }

                //Check Children
                //East
                if (validChild(_trav.X + 1, _trav.Y))
                {
                    if (!visited[_trav.X + 1, _trav.Y])
                    {
                        Path currentChild = new Path(_trav.X + 1, _trav.Y);
                        currentChild.prev = _trav;
                        currentChild.depth = currentChild.prev.depth + 1;
                        visited[currentChild.X, currentChild.Y] = true;

                        if (travMethod == 0)
                        {
                            DPS.Push(currentChild);
                        }
                        else
                        {
                            BPS.Enqueue(currentChild);
                        }
                    }
                    else
                    {
                        ++badDirectionCount;
                    }
                }
                else
                {
                    ++badDirectionCount;
                }

                //Check Children
                //South
                if (validChild(_trav.X, _trav.Y + 1))
                {
                    if (!visited[_trav.X, _trav.Y + 1])
                    {
                        Path currentChild = new Path(_trav.X, _trav.Y + 1);
                        currentChild.prev = _trav;
                        currentChild.depth = currentChild.prev.depth + 1;
                        visited[currentChild.X, currentChild.Y] = true;

                        if (travMethod == 0)
                        {
                            DPS.Push(currentChild);
                        }
                        else
                        {
                            BPS.Enqueue(currentChild);
                        }
                    }
                    else
                    {
                        ++badDirectionCount;
                    }
                }
                else
                {
                    ++badDirectionCount;

                }

                //Check Children
                //West
                if (validChild(_trav.X - 1, _trav.Y))
                {
                    if (!visited[_trav.X - 1, _trav.Y])
                    {
                        Path currentChild = new Path(_trav.X - 1, _trav.Y);
                        currentChild.prev = _trav;
                        currentChild.depth = currentChild.prev.depth + 1;
                        visited[currentChild.X, currentChild.Y] = true;

                        if (travMethod == 0)
                        {
                            DPS.Push(currentChild);
                        }
                        else
                        {
                            BPS.Enqueue(currentChild);
                        }
                    }
                    else
                    {
                        ++badDirectionCount;
                    }
                }
                else
                {
                    ++badDirectionCount;
                }

                //Check if deadEnd
                if (badDirectionCount == 4)
                {
                    if (deepestDeadEnd == null)
                    {
                        deepestDeadEnd = _trav;
                    }
                    else if (_trav.depth > deepestDeadEnd.depth)
                    {
                        deepestDeadEnd = _trav;
                    }

                    if (travMethod == 0)
                    {
                        if (DPS.Count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (BPS.Count == 0)
                        {
                            break;
                        }
                    }
                }
            }

            if (deepestApple != null)
            {
                _applePathOpen = true;

                _tail = deepestApple;
                _trav = _tail;

                while (_trav != _head)
                {
                    _trav.prev.next = _trav;
                    _trav = _trav.prev;
                }
            }
            else
            {
                _applePathOpen = false;

                _tail = deepestDeadEnd;
                _trav = _tail;

                while (_trav != _head)
                {
                    _trav.prev.next = _trav;
                    _trav = _trav.prev;
                }
            }
        }

        //To be used with the updateSnakePath() function.
        //Checks if the next tile in the sequence to be checked is valid.
        private bool validChild(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                return false;
            }
            else if (15 < x || 15 < y)
            {
                return false;
            }
            else if (_info[x, y] == 2 || _info[x, y] == 3 || _info[x, y] == 6)
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
            if (_trav.next == _tail)
            {
                updateSnakePath();
            }
            else if (_trav.next == null)
            {
                _snakeDeath = true;
                return;
            }

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
            _info[_currentSnake._Tail.X, _currentSnake._Tail.Y] = 0;

            _currentSnake.slither(nextDirection);

            _snakeLocation.X = _currentSnake._Head.X;
            _snakeLocation.Y = _currentSnake._Head.Y;

            if (_info[_snakeLocation.X, _snakeLocation.Y] == 1)
            {
                _appleGet = true;
                _currentSnake.consume(1);
                _points_total += _points_turn;
                _points_turn = 1000 - (_activeRocks * _rockCost);
                coinGen(_collectedCoins);
            }
            else if (_info[_snakeLocation.X, _snakeLocation.Y] == 3)
            {
                _snakeDeath = true;
            }
            else if (_info[_snakeLocation.X, _snakeLocation.Y] == 4)
            {
                _coinGet = true;
                ++_collectedCoins;
                foreach(Point p in _coinLocations)
                {
                    if(p.X == _snakeLocation.X && p.Y == _snakeLocation.Y)
                    {
                        _coinLocations.Remove(p);
                        break;
                    }
                }
                partialScoreMod(4);
            }
            else if (_info[_snakeLocation.X, _snakeLocation.Y] == 5)
            {
                _trapHit = true;
                partialScoreMod(5);
            }

            _info[_currentSnake._Tail.X, _currentSnake._Tail.Y] = 3;
            _info[_currentSnake._Head.X, _currentSnake._Head.Y] = 3;
        }

    }
}