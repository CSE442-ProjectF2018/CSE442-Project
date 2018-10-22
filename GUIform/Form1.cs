﻿using System;
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

        private void rescanMap()
        {
            Block currentBlock;
            snakeGrid.Controls.Clear();
            for(int i = 0; i < 16; ++i)
            {
                for(int j = 0; j < 16; ++j)
                {
                    currentBlock = _m.getBlockAt(i, j);

                    if(currentBlock.getType() == 1)
                    {
                        System.Windows.Forms.Panel test = new System.Windows.Forms.Panel();
                        snakeGrid.Controls.Add(test, i, j);
                        //test.BackColor = System.Drawing.Color.FromArgb(255, 255, 0, 0);
                        test.BackgroundImage = Properties.Resources.apple;
                        test.BackgroundImageLayout = ImageLayout.Stretch;
                        test.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                        test.Margin = new System.Windows.Forms.Padding(0);
                        //MessageBox.Show(string.Format("Apple reached in scan"));
                    }else if(currentBlock.getType() == 3)
                    {
                        System.Windows.Forms.Panel test = new System.Windows.Forms.Panel();
                        snakeGrid.Controls.Add(test, i, j);
                        test.BackColor = System.Drawing.Color.FromArgb(255, 0, 255, 0);
                        //test.BackgroundImage = Properties.Resources.apple;
                        //test.BackgroundImageLayout = ImageLayout.Stretch;
                        //test.BackColor = System.Drawing.Color.FromArgb(0, 255, 255, 255);
                        test.Margin = new System.Windows.Forms.Padding(0);
                    }
                }
            }
        }

        private void snakeGrid_Click(object sender, EventArgs e)
        {
            Point p = snakeGrid.PointToClient(MousePosition);
            //MessageBox.Show(string.Format("X: {0} Y: {1}", p.X, p.Y));

            p.X = (int)(((double)16 / 592) * p.X);
            p.Y = (int)(((double)16 / 592) * p.Y);

            Block test = new Block(1);

            _m.setBlockAt(p.X, p.Y, test);
            rescanMap();

            _m.updateSnakePath();

            
            dispatcherTimer.Start();
        }

        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        int _userScore = 0;
        int _moveCounter = 0;

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            _m.moveSnake();
            //MessageBox.Show("timer tick");
            //rescanMap();
            _moveCounter++;

            if (_m._appleGet == true)
            {
                s_AppleGET.Play();
                _userScore += _moveCounter * 10;
                PlayerScore.Text = _userScore.ToString();
                _moveCounter = 0;
                rescanMap();
                dispatcherTimer.Stop();
            }

        }

    }
}
