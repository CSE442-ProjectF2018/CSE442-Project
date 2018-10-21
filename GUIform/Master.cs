using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GUIform
{
    public enum BType { apple, snake, wall, free };
    public enum direction { left, right, up, down };

    public partial class Game : Form
    {

        //Timer related stuff
        Timer tt = new Timer();     //Time count timer
        Timer mt = new Timer();     //movetimer
        Timer blinkt = new Timer();  //blink timer for the thing where snake blinks on title screen
        

        //Apple related stuff
        int apples = 1; //How many apples can we place at a time?
        public Block apple;
        
        
        //Map related stuff
        public int dim = 16;
        public Block[,] map_16;

        //Snake object
        List<Block> snake = new List<Block>();
        direction d = direction.right;

        //Coordinate related stuff
        int posx = 40;
        int posy = 40;
        int apple_position_x = -100;  //mouse x
        int apple_position_y = -100;  //mouse y 

        //sound stuff
        SoundPlayer s_PlayButton = new SoundPlayer(Properties.Resources.apple_crunch);
        SoundPlayer s_gotApple = new SoundPlayer(Properties.Resources.apple_crunch2);
        SoundPlayer Title_BGM = new SoundPlayer(Properties.Resources.BGM1);

        //Other game variables
        int time = 0;
        int score = 0;

        public Game()
        {
            //Initialization
            initializeMap(dim);
            InitializeComponent();
            TimeValue.Text = time.ToString();

           

            //Snake initialization
            //The snakes head is atually at the end of the list
            Block body = new Block(BType.snake, 8, 6);
            snake.Add(body);
            body = new Block(BType.snake, 8, 7);
            snake.Add(body);
            Block head = new Block(BType.snake, 8, 8);
            snake.Add(head);

            //Make sure title screen is first screen we see
            GameScreen.Visible = false;
            HomeSreen.Visible = true;
            
            //Play BGM
            Title_BGM.PlayLooping();
        }

        //Buttons
        private void playButton_Click(object sender, EventArgs e)
        {
            //switch visibility of title screen and game screen
            HomeSreen.Visible = false;
            GameScreen.Visible = true;

            Title_BGM.Stop();
            s_PlayButton.Play();

            tt.Interval = 1000;
            tt.Tick += new EventHandler(Timer_Counter_Tick);
            tt.Start();

            mt.Interval = 500;
            mt.Tick += new EventHandler(MoveTimer_Tick);
            mt.Start();

           
        }
        private void HomeSreen_Click(object sender, EventArgs e)
        {
            blinkt.Interval = 250;
            blinkt.Tick += new EventHandler(Blink_Timer_Tick);
            blinkt.Start();
            HomeSreen.BackgroundImage = Properties.Resources.snek_blink;
        }

        //Timers
        private void Timer_Counter_Tick(object sender, EventArgs e)
        {
            time++;
            TimeValue.Text = time.ToString();
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {

            if (snake[snake.Count - 1].x >= dim - 1) d = direction.left;
            else if (snake[snake.Count - 1].x <= 0) d = direction.right;

            //The following is snake movement
            //rest of snake update


            //head update
            switch (d)
            {
                case direction.up:
                    if (!check_For_Apple(snake[snake.Count - 1].x, snake[snake.Count - 1].y - 1))
                    {
                        updateSnakeBody();
                        snake[snake.Count - 1].y -= 1;
                    }
                    else
                    {
                        extend(snake[snake.Count - 1].x, snake[snake.Count - 1].y - 1);
                    }
                    break;
                case direction.down:
                    if (!check_For_Apple(snake[snake.Count - 1].x, snake[snake.Count - 1].y + 1))
                    {
                        updateSnakeBody();
                        snake[snake.Count - 1].y += 1;
                    }
                    else
                    {
                        extend(snake[snake.Count - 1].x, snake[snake.Count - 1].y + 1);
                    }
                    break;
                case direction.left:
                    if (!check_For_Apple(snake[snake.Count - 1].x - 1, snake[snake.Count - 1].y))
                    {
                        updateSnakeBody();
                        snake[snake.Count - 1].x -= 1;
                    }
                    else
                    {
                        extend(snake[snake.Count - 1].x - 1, snake[snake.Count - 1].y);
                    }
                    break;
                case direction.right:
                    if (!check_For_Apple(snake[snake.Count - 1].x + 1, snake[snake.Count - 1].y))
                    {
                        updateSnakeBody();
                        snake[snake.Count - 1].x += 1;
                    }
                    else
                    {
                        extend(snake[snake.Count - 1].x + 1, snake[snake.Count - 1].y);
                    }
                    break;
            }
            Grid.Refresh();
        }
        private void Blink_Timer_Tick(object sender, EventArgs e)
        {
            HomeSreen.BackgroundImage = Properties.Resources.snek;
            blinkt.Stop();
        }


        //Grid Functioms
        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            for (int i = (snake.Count - 1); i >= 0; i--)
            {
                posx = snake[i].x * 40;
                posy = snake[i].y * 40;

                e.Graphics.FillRectangle(Brushes.Green, posx, posy, 40, 40);
            }
            e.Graphics.FillRectangle(Brushes.Red, apple_position_x, apple_position_y, 40, 40);
        }
        private void Grid_Click(object sender, EventArgs e)
        {
            if(apples > 0)
            {
                MouseEventArgs mE = e as MouseEventArgs;

                /*When we receive click coordinates they wont be multiples of 40
                 So we divide by 40 (The remainder is negligible) and remultiply by 40 to get multiple 
                 We want coordinates to be multiples of 40 so they allign with the grid when placed
                 */
                apple_position_x = mE.X;
                apple_position_y = mE.Y;

                //This block translates the mouse click position to a coordinate to be stored on the map.
                int apple_x_actual = apple_position_x / 40;
                int apple_y_actual = apple_position_y / 40;
                placeApple(apple_x_actual, apple_y_actual);

                //This block translates the coordinates back to be displayed on the grid
                apple_position_x = (apple_x_actual) * 40;
                apple_position_y = (apple_y_actual) * 40;
                Grid.Refresh();
                apples = 0; //expend our apple, so that only one can be placed until snake eats it
            }
            
        }

        //Other defined Funcions

        //Makes sre that when we start out, all spaces by default are considered free spaces
        public void initializeMap(int dim)
        {
            map_16 = new Block[dim, dim];  //Map keeping track of what is placed


            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    Block b = new Block(BType.free);
                    map_16[i, j] = b;
                }
            }
        }
        public void placeApple(int x, int y)
        {
            apple = new Block(BType.apple);
            map_16[x, y] = apple;
        }
        public bool check_For_Apple(int x, int y)
        {
            if (map_16[x, y].bt == BType.apple)
            {
                s_gotApple.Play();
                apple_position_x = -100;
                apple_position_y = -100;
                Grid.Refresh();

                map_16[x, y].bt = BType.free;
                apples = 1;
                score += 100;
                ScoreValue.Text = score.ToString();
                return true;
            }
            return false;
        }
        public void updateSnakeBody()
        {
            for (int i = 0; i < snake.Count - 1; i++)
            {
                snake[i].x = snake[i + 1].x;
                snake[i].y = snake[i + 1].y;
            }
        }
        public void extend(int x, int y)
        {
            Block head = new Block(BType.snake, x, y);
            snake.Add(head);
        }

        
    }

        
}


