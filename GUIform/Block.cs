using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIform
{
    //Block Types
    //0 is None.
    //1 is Apple.
    //2 is Obstacle.
    //3 is Snake.
    //4 is Coin

    public class Block
    {
        //Set Blocktype to None by default.
        private int _blockType = 0;

        //Default contructor
        public Block()
        {

        }
        
        //Constructor where we immediately assign Btype
        public Block(int inputType)
        {
            if(inputType >= 0 && inputType <= 5)
            {
                _blockType = inputType;
            }
            else
            {
                MessageBox.Show(string.Format("Not Valid Block Type; Block init type error"));
            }
            
        }

        //Get a block's type
        public int getType()
        {
            return _blockType;
        }

        //Set block type after creation.
        public void setType(int newType)
        {
            if (newType >= 0 && newType <= 4)
            {
                _blockType = newType;
            }
            else
            {
                MessageBox.Show(string.Format("Not Valid Block Type; Block SET type error"));
            }
        }
    }
}
