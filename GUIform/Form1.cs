using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GUIform
{
    public enum BType { apple, snake, wall, free };
    enum direction { left, right, up, down };
    

    public partial class Game : Form
    {
        Timer tt = new Timer();
        Timer mt = new Timer();
        int time = 0;
        int score = 0;

        public BType[,] map_16 = new BType[16, 16];  //Map keeping track of what is placed

        int posx = 40;
        int posy = 40;
        int mx = -100;  //mouse x
        int my = -100;  //mouse y 

        //sound stuff
        SoundPlayer s_PlayButton = new SoundPlayer(Properties.Resources.apple_crunch);
        SoundPlayer s_gotApple = new SoundPlayer(Properties.Resources.apple_crunch2);
        SoundPlayer Title_BGM = new SoundPlayer(Properties.Resources.BGM1);

        public Game()
        {
            initializeMap();
            InitializeComponent();
            GameScreen.Visible = false;
            HomeSreen.Visible = true;
            TimeValue.Text = time.ToString();
            Title_BGM.PlayLooping();
        }


        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            HomeSreen.Visible = false;
            GameScreen.Visible = true;

            Title_BGM.Stop();
            s_PlayButton.Play();

            tt.Interval = 1000;
            tt.Tick += new EventHandler(timer1_Tick);
            tt.Start();

            mt.Interval = 500;
            mt.Tick += new EventHandler(MoveTimer_Tick);
            mt.Start();

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            TimeValue.Text = time.ToString();
        }

        private void Grid_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Green, posx, posy, 40, 40);
            e.Graphics.FillRectangle(Brushes.Red, mx, my, 40, 40);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            if ((posx / 40) < (16 - 1)) posx += 40;
            else posx -= 40;
            checkPosition(posx/40, posy/40);
            Grid.Refresh();
        }

        private void Grid_Click(object sender, EventArgs e)
        {
            MouseEventArgs mE = e as MouseEventArgs;
            /*When we receive click coordinates they wont be multiples of 32
             So we divide by 32 (The remainder is negligible) and remultiply by 32 to get multiple 
             We want coordinates to be multiples of 32 so they allign with the grid when placed
             */
            mx = mE.X;
            my = mE.Y;
            int coordx = mx / 40;
            int coordy = my / 40;
            placeApple(coordx, coordy);

            mx = (coordx) * 40;
            my = (coordy) * 40;
            Grid.Refresh();
        }

        //Makes sre that when we start out, all spaces by default are considered free spaces
        public void initializeMap()
        {
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    map_16[i, j] = BType.free;
                }
            }
        }

        public void placeApple(int x, int y)
        {
            map_16[x, y] = BType.apple;
        }
        public void checkPosition(int x, int y)
        {
            if(map_16[x,y] == BType.apple)
            {
                mx = -100;
                my = -100;
                map_16[x, y] = BType.free;
                score += 100;
                ScoreValue.Text = score.ToString();
                s_gotApple.Play();
            }
        }
    }
}
