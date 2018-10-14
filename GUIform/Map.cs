using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    class Map
    {
        //Default dimension is 16x16.
        private int dimension = 15;
        //Default map type(empty). Int: for use with switch statement.
        private int mapType = 0;

        private Block[,] info;
        
        //If no arguments given, use default arguments.
        public Map()
        {
            info = new Block[dimension, dimension];
            buildMap();
        }
        
        //Parameter d refers to dimension(s) of the grid. It's a square so only one number is needed.
        public Map(int d, int mt)
        {
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
