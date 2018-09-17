using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    class Snake
    {
        //snek has x and y coordinates
        public int x;
        public int y;

        //an enumeration for snake direction, possible values include our 4 primary directions
        public enum direction{left, right, up, down};
    }
}
