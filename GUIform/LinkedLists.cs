using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIform
{
    public class Letter
    {
        public Letter next;
        public Letter prev;
        public char c;

        public Letter(char C)
        {
            c = C;
        }
    }



    class LinkedLists
    {
    }
}
