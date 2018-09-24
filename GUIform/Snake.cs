using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace GUIform
{
    public enum direction {up, down, left, right};

    public class Snake
    {
        //snek has x and y coordinates
        public int x;
        public int y;
        public int speed;

        //an enumeration for snake direction, possible values include our 4 primary directions
        public direction d;

        
        public Snake()
        {
            x = 0;
            y = 0;
            speed = 32;
        }
        public void changeDirection(direction nD)
        {
            if (nD == d) return;
            if (d == direction.right && nD == direction.left || d == direction.left && nD == direction.right) return;
            if (d == direction.up && nD == direction.down || d == direction.down && nD == direction.up) return;

            d = nD;
            return;
        }
        public void addSpeed(int s)
        {
            speed += s;
            return;
        }

        public void spawn()
        {

        }

        public void eatapple()
        {

        }

        public void death()
        {

        }

    }
}
