using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{


    public class Apple
    {
        //Apple has x and y coordinates
        public int x = 0;
        public int y = 0;

        public void placeA(int i, int j)
        {
            if(Master.Apples > 0)   //Apples suser has left
            {
                x = i;
                y = j;
                Master.Apples--;
            }
            return;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public System.Drawing.Color selectColor(System.Drawing.Color color)
        {
            return color;
        }
    }


}
