using System;

namespace GUIform
{
    public enum direction { up, down, left, right }
    
    public class SnakeNode
    {
        int x;
        int y;
        SnakeNode* next;
        SnakeNode* prev;

    }

    public class Snake
    {
        SnakeNode* Head;
        SnakeNode* Tail;
        int speed;
        direction dir;
        int length = 2;

        public void spawn( int gridx, int gridy, int len )
        {
            Head = new SnakeNode();
            Head.x = gridx;
            Head.y = gridy;
            Tail = new SnakeNode();
            Tail.x = gridx;
            Tail.y = gridy;

            SnakeNode* tempnode;
            tempnode = Head;

            for (int i = 2; i < len; i++)
            {
                tempnode.next = new SnakeNode();
                tempnode.next.x = gridx;
                tempnode.next.y = gridy;
                tempnode.next.prev = tempnode;
                tempnode = tempnode.next;
                tempnode.next = Tail;
                Tail.prev = tempnode;
                length = length + 1;

            }

        }

        public void slither( direction d )
        {

        }

        public void consume( int gridx, int gridy )
        {

        }

        public void perish()
        {

        }

    }

}