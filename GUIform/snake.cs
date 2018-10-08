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

        public void spawn()
        {
            Head = new SnakeNode();
            Head.x = 0;
            Head.y = 0;
            Tail = new SnakeNode();
            Tail.x = 0;
            Tail.y = 0;
            Head.next = Tail;
            Tail.prev = Head;
        }

        public void slither( direction d )
        {

        }

        public void consume()
        {

        }

        public void perish()
        {

        }

    }

}