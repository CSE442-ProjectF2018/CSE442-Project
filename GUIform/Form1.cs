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

        bool _yourTurn = true;
        

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

            snakeGrid.SuspendLayout();
            for(int i = 0; i < 16; ++i)
            {
                for(int j = 0; j < 16; ++j)
                {
                    System.Windows.Forms.Panel test = new System.Windows.Forms.Panel();
                    test.Margin = new System.Windows.Forms.Padding(0);
                    test.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                    test.Click += new System.EventHandler(this.snakeGrid_Click);
                    snakeGrid.Controls.Add(test, i, j);
                }
            }
            snakeGrid.ResumeLayout();
            
            
        }

        private void RESET_BUTTON_Click(object sender, EventArgs e)
        {
            _m = new Map();
            snakeGrid.Controls.Clear();
            snakeGrid.SuspendLayout();
            for (int i = 0; i < 16; ++i)
            {
                for (int j = 0; j < 16; ++j)
                {
                    System.Windows.Forms.Panel test = new System.Windows.Forms.Panel();
                    test.Margin = new System.Windows.Forms.Padding(0);
                    test.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                    test.Click += new System.EventHandler(this.snakeGrid_Click);
                    snakeGrid.Controls.Add(test, i, j);
                }
            }
            snakeGrid.ResumeLayout();
            _userScore = 0;
            PlayerScore.Text = _userScore.ToString();
        }

        private void updateMap()
        {
            System.Windows.Forms.Panel sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y);
            sTail.BackgroundImage = null;
            sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            //sTail.Update();

            sTail.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);

            System.Windows.Forms.Panel sHead = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y);
            
            sHead.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);
            //sHead.Update();
            snakeGrid.Update();
        }

        private void snakeGrid_Click(object sender, EventArgs e)
        {
            

            if (_yourTurn)
            {
                Point p = snakeGrid.PointToClient(MousePosition);
                p.X = (int)(((double)16 / snakeGrid.Size.Width) * p.X);
                p.Y = (int)(((double)16 / snakeGrid.Size.Height) * p.Y);

                //Add Apple def to backing map.
                Block newApple = new Block(1);
                _m.setBlockAt(p.X, p.Y, newApple);

                System.Windows.Forms.Panel applePanel = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(p.X, p.Y);
                applePanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                applePanel.BackgroundImage = Properties.Resources.apple;
                applePanel.BackgroundImageLayout = ImageLayout.Stretch;
                applePanel.Update();

                _yourTurn = false;

                _m.updateSnakePath();

                dispatcherTimer.Start();
            }
            
        }

        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        int _userScore = 0;
        int _moveCounter = 0;

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y);
            sTail.BackgroundImage = null;
            sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            //sTail.Update();

            _m.moveSnake();

            if (_m._appleGet == true)
            {
                s_AppleGET.Play();
                _userScore += _moveCounter * 10;
                PlayerScore.Text = _userScore.ToString();
                _moveCounter = 0;

                sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._appleLocation.X, _m._appleLocation.Y);
                sTail.BackgroundImage = null;
                sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                //sTail.Update();

                updateMap();

                _yourTurn = true;

                dispatcherTimer.Stop();
            }else if (_m._snakeDeath)
            {
                s_PlayButton.Play();
                MessageBox.Show("SNEK IS DED! GAM OVR!");
                _m = new Map();
                snakeGrid.Controls.Clear();
                snakeGrid.SuspendLayout();
                for (int i = 0; i < 16; ++i)
                {
                    for (int j = 0; j < 16; ++j)
                    {
                        System.Windows.Forms.Panel test = new System.Windows.Forms.Panel();
                        test.Margin = new System.Windows.Forms.Padding(0);
                        test.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                        test.Click += new System.EventHandler(this.snakeGrid_Click);
                        snakeGrid.Controls.Add(test, i, j);
                    }
                }
                snakeGrid.ResumeLayout();
                _userScore = 0;
                PlayerScore.Text = _userScore.ToString();

                _yourTurn = true;
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
