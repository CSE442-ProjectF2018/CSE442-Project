using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GUIform
{
    enum BType { apple, snake, wall, free };
    
    

    public partial class Game : Form
    {
        
        //sound stuff
        SoundPlayer s_PlayButton = new SoundPlayer(Properties.Resources.apple_crunch);
        SoundPlayer s_TitleScreen = new SoundPlayer(Properties.Resources.BGM1);
        SoundPlayer s_AppleGET = new SoundPlayer(Properties.Resources.apple_chew);


        Map _m;
        

        public Game()
        {
            InitializeComponent();

            //Excahnges the current screen/panel.
            titleScreen.Visible = true;
            gameScreen.Visible = false;

            //Loads the sound ahead of time, in attempt to play it.
            s_PlayButton.Load();

            s_TitleScreen.PlayLooping();


            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
        }


        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Plays apple crunch sound.
            s_PlayButton.Play();

            //Generates a new default map.
            _m = new Map();

            //Exchanges the current screen panel.
            titleScreen.Visible = false;
            gameScreen.Visible = true;

            
            
        }

        private bool sm = false;
        System.Windows.Forms.Panel testPanel = new System.Windows.Forms.Panel();
        

        private void RESET_BUTTON_Click(object sender, EventArgs e)
        {
            _m = new Map();
            snakeGrid.Controls.Clear();
            _userScore = 0;
            PlayerScore.Text = _userScore.ToString();
        }

        private void updateMap()
        {
            snakeGrid.Controls.Remove(snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y));

            System.Windows.Forms.Panel snakeTail = new System.Windows.Forms.Panel();
            snakeGrid.Controls.Add(snakeTail, _m._currentSnake._Tail.X, _m._currentSnake._Tail.Y);
            snakeTail.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);
            snakeTail.Margin = new System.Windows.Forms.Padding(0);

            System.Windows.Forms.Panel snakeHead = new System.Windows.Forms.Panel();
            snakeGrid.Controls.Add(snakeHead, _m._currentSnake._Head.X, _m._currentSnake._Head.Y);
            snakeHead.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);
            snakeHead.Margin = new System.Windows.Forms.Padding(0);

        }

        private void snakeGrid_Click(object sender, EventArgs e)
        {
            Point p = snakeGrid.PointToClient(MousePosition);

            p.X = (int)(((double)16 / snakeGrid.Size.Width) * p.X);
            p.Y = (int)(((double)16 / snakeGrid.Size.Height) * p.Y);

            //Add Apple def to backing map.
            Block newApple = new Block(1);
            _m.setBlockAt(p.X, p.Y, newApple);

            //Add Apple to GUI
            System.Windows.Forms.Panel applePanel = new System.Windows.Forms.Panel();
            snakeGrid.Controls.Add(applePanel, p.X, p.Y);
            applePanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            applePanel.BackgroundImage = Properties.Resources.apple;
            applePanel.BackgroundImageLayout = ImageLayout.Stretch;
            applePanel.Margin = new System.Windows.Forms.Padding(0);

            //Create a path for the snake towards the apple.
            _m.updateSnakePath();

            
            dispatcherTimer.Start();
        }

        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        int _userScore = 0;
        int _moveCounter = 0;

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            
            snakeGrid.Controls.Remove(snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y));

            _m.moveSnake();

            if (_m._appleGet == true)
            {
                s_AppleGET.Play();
                _userScore += _moveCounter * 10;
                PlayerScore.Text = _userScore.ToString();
                _moveCounter = 0;
                snakeGrid.Controls.Remove(snakeGrid.GetControlFromPosition(_m._appleLocation.X, _m._appleLocation.Y));
                updateMap();
                dispatcherTimer.Stop();
            }
            else
            {
                updateMap();

                _moveCounter++;
            }

        }

    }
}
