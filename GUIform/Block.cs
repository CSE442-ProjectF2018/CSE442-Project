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

        //Temporary type checking until Apple and Snake classes are ready.
        private string tempType = "None";

        //Default contructor
        public Block()
        {

        }
        //Constructor where we immediately assign Btype
        public Block(BType b)
        {
            bt = b;
        }

        //Constructor to test out type checking until Apple and Snake classes are ready.
        public Block(string T)
        {
            tempType = T;
        }
        public string getType()
        {
            return tempType;
        }
        public void setType(string s)
        {
            tempType = s;
        }
    }
}
