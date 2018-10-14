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
        
        //sound stuff
        SoundPlayer s_PlayButton = new SoundPlayer(Properties.Resources.apple_crunch);
        

        public Game()
        {
            InitializeComponent();

            titleScreen.Visible = true;
            gameScreen.Visible = false;
            s_PlayButton.Load();

        }


        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            
            s_PlayButton.Play();

            titleScreen.Visible = false;
            gameScreen.Visible = true;

            
            snakeGrid.Controls.Add(testPanel, 5, 8);
            testPanel.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);
            testPanel.Margin = new System.Windows.Forms.Padding(0);
        }

        private bool sm = false;
        System.Windows.Forms.Panel testPanel = new System.Windows.Forms.Panel();
        

        private void button1_Click(object sender, EventArgs e)
        {
            

            switch (sm)
            {
                case true:
                    snakeGrid.Controls.Remove(testPanel);
                    snakeGrid.Controls.Add(testPanel, 5, 8);
                    sm = !sm;

                    break;
                case false:
                    snakeGrid.Controls.Remove(testPanel);
                    snakeGrid.Controls.Add(testPanel, 8, 5);
                    sm = !sm;

                    break;
            }


        }

        private void snakeGrid_Click(object sender, EventArgs e)
        {
            Point p = snakeGrid.PointToClient(MousePosition);
            //MessageBox.Show(string.Format("X: {0} Y: {1}", p.X, p.Y));
            p = new Point(p.X % 15, p.Y % 15);
            MessageBox.Show(string.Format("X: {0} Y: {1}", p.X, p.Y));
            snakeGrid.Controls.Remove(testPanel);
            
            
            snakeGrid.Controls.Add(testPanel, p.X, p.Y);
        }
    }
}
