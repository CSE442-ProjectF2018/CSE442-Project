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
            if(Master.Apples > 0)
            {
                x = i;
                y = j;
                Master.Apples--;
            }
            return;
        }
    }


}
