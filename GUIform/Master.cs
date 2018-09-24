using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    
    public class Master
    {
        private static int apples = 1;
        public static int Apples
        {
            get { return apples; }
            set { apples = value; }
        }

        public int speed;       //speed of game that will be implement at some point im sure.

    }
}
