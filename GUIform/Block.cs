using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    
    class Block
    {
        public BType bt;
        public int x, y;

        //Default contructor
        public Block()
        {

        }
        //Constructor where we immediately assign Btype
        public Block(BType b)
        {
            bt = b;
        }
        public Block(BType b, int x_in, int y_in)
        {
            bt = b;
            x = x_in;
            y = y_in;
        }
    }
}
