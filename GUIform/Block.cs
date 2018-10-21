using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    
    public class Block
    {
        public BType bt;
        public int x, y;

        //snake related properties
        public Block next;
        public Block prev;
        public direction d;



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
        public void extend(Stack<Block> stack)
        {
            Block tail = new Block(BType.snake);

        }
    }
}
