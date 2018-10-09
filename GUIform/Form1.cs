using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GUIform
{
    enum BType { apple, snake, wall, free };
    enum direction { left, right, up, down };
    

    public partial class Game : Form
    {
        Timer tt = new Timer();
        Timer mt = new Timer();
        int time = 0;

        int posx = 32;
        int posy = 32;
        int mx = -100;  //mouse x
        int my = -100;  //mouse y 

        //sound stuff
        SoundPlayer s_PlayButton = new SoundPlayer(Properties.Resources.apple_crunch);
        

        public Game()
        {
            InitializeComponent();
            GameScreen.Visible = false;
            HomeSreen.Visible = true;
            TimeValue.Text = time.ToString();
        }


        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            HomeSreen.Visible = false;
            GameScreen.Visible = true;

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
            e.Graphics.FillRectangle(Brushes.Green, posx, posy, 32, 32);
            e.Graphics.FillRectangle(Brushes.Red, mx, my, 32, 32);
        }

        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            posx += 32;
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
            mx = (mx / 32) * 32;
            my = (my / 32) * 32;
            Grid.Refresh();
        }
    }
}
