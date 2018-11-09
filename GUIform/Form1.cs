using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;
using WMPLib;

namespace GUIform
{
    enum BType { apple, snake, wall, free };
    
    

    public partial class Game : Form
    {

        //sound stuff
        SoundPlayer s_PlayButton = new SoundPlayer(Properties.Resources.apple_crunch);
        SoundPlayer s_TitleScreen = new SoundPlayer(Properties.Resources.BGM1);
        SoundPlayer s_AppleGET = new SoundPlayer(Properties.Resources.apple_chew);
        SoundPlayer s_snakeDIE = new SoundPlayer(Properties.Resources.Scream);
        SoundPlayer s_BGM_1 = new SoundPlayer(Properties.Resources.GameBGM1);
        SoundPlayer s_BGM_2 = new SoundPlayer(Properties.Resources.GameBGM2);

        //time stuff
        
        Timer blink_timer = new Timer();
        Timer t_time = new Timer();
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        int time = 0;
        int _userScore = 0;
        Map _m;
        bool _yourTurn = true;
        int _moveCounter = 0;
        string s_directory = Environment.CurrentDirectory + "/Assets/Audio/";



        public Game()
        {
            InitializeComponent();

            setPanel(titleScreen);
            //Excahnges the current screen/panel.
           

            //Loads the sound ahead of time, in attempt to play it.
            s_PlayButton.Load();
            s_AppleGET.LoadAsync();
            s_TitleScreen.PlayLooping();

            
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);

            blink_timer.Tick += new EventHandler(blinkTimer_Tick);
        }


        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //Plays apple crunch sound.
            s_PlayButton.Play();
            
            //Generates a new default map.

            //Exchanges the current screen panel.
            reset_to_gameScreen();


        }
        private void snake_game_over_reset_CLick(object sender, EventArgs e)
        {

            
            reset_to_gameScreen();

        }
        private void apple_game_over_reset_Click(object sender, EventArgs e)
        {
            
            reset_to_gameScreen();
        }
        private void instruction_button_Click(object sender, EventArgs e)
        {
            if (instructions.Visible == false)
            {
                instructions.Visible = true;
                instructions.Text = "Welcome to Snec Snacc!" + Environment.NewLine;
                instructions.Text += "A snake who dreams of flight has gone back in time ";
                instructions.Text += "to prevent gravity from being invented." + Environment.NewLine;
                instructions.Text += "The only answer is EXTERMINATION!" + Environment.NewLine;
                instructions.Text += "You have a limited amount of apples," + Environment.NewLine;
                instructions.Text += "Kill the snake before you run out!" + Environment.NewLine;
                instruction_button.Text = "Back";
            }
            else
            {
                instructions.Visible = false;
                instruction_button.Text = "How to Play";
            }
            
        }
        
        private void updateMap()
        {
            System.Windows.Forms.Panel sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y);
            sTail.BackgroundImage = null;
            sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            //sTail.Update();

            sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 255, 0);
            sTail.BackgroundImageLayout = ImageLayout.Stretch;
            sTail.BackgroundImage = Properties.Resources.snake_body;


            System.Windows.Forms.Panel sHead = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y);
            
            sHead.BackColor = System.Drawing.Color.FromArgb(0, 0, 255, 0);
            sHead.BackgroundImageLayout = ImageLayout.Stretch;
            sHead.BackgroundImage = Properties.Resources.snake_body;

            //sHead.Update();
            turnIcon_StyleChanged();
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
                _m._apples--;
                _yourTurn = false;

                _m.updateSnakePath();
                dispatcherTimer.Start();
            }
            
        }
        private void titleScreen_Click(object sender, EventArgs e)
        {
            
            blink.Dock = DockStyle.Fill;
            blink.Visible = true;
            blink_timer.Interval = 250;
            blink_timer.Start();
            Console.WriteLine(Environment.CurrentDirectory + "\\Assets\\Audio\\BGM1.wav");
        }

        
        //Timer functions
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
                turnIcon_StyleChanged();
                if(_m._apples == 0)
                {
                    BGM1.Ctlcontrols.stop();
                    gameScreen.Visible = false;
                    apple_game_over.Visible = true;
                    t_time.Stop();
                    dispatcherTimer.Stop();
                    
                    

                }

                dispatcherTimer.Stop();
            }else if (_m._snakeDeath)
            {
                BGM1.Ctlcontrols.stop();
                t_time.Stop();
                s_snakeDIE.Play();
                gameScreen.Visible = false;
                snake_game_over.Visible = true;


                
                dispatcherTimer.Stop();
            }
            else
            {
                updateMap();

                _moveCounter++;
            }

        }
        private void t_timer_Tick(object sender, EventArgs e)
        {
            time += 1;
            time_value.Text = time.ToString();
        }
        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            blink.Dock = DockStyle.None;
            blink.Visible = false;
            blink_timer.Stop();
        }

        
       

       //Other 
        private void reset_to_gameScreen()
        {
            
            _m = new Map();
            gameScreen.Controls.Add(snakeGrid);
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
            _yourTurn = true;
            PlayerScore.Text = _userScore.ToString();
            BGM1.URL = s_directory + "GameBGM1.wav";

            BGM1.settings.volume += 500;
            BGM1.Ctlcontrols.play();



            initializeTimeCounter();

            setPanel(gameScreen);
        }
        private void initializeTimeCounter()
        {
            time = 0;
            t_time = new Timer();
            t_time.Interval = 1000;
            t_time.Tick += new EventHandler(t_timer_Tick);
            t_time.Start();
        }
        private void RESET_BUTTON_Click(object sender, EventArgs e)
        {
            _m = new Map();
            gameScreen.Controls.Add(snakeGrid);
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
        private void setPanel(Panel p)
        {
            foreach(Panel q in this.Controls){
                if (q != p) q.Visible = false;
            }
            p.Visible = true;
        }

        private void turnIcon_StyleChanged()
        {
            if (_yourTurn)
            {
                turnIcon.BackgroundImage = Properties.Resources.appleturn;
                turnLabel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 128);
                turnLabel.Text = "Your Turn";
            }
            else
            {
                turnIcon.BackgroundImage = Properties.Resources.snekturn;
                turnLabel.BackColor = System.Drawing.Color.FromArgb(255, 128, 255, 255);
                turnLabel.Text = "Snec's Turn";
            }
        }

        private void toggleAppleRock(object sender, EventArgs e)
        {
            _m._toggleAR = !_m._toggleAR;
        }
    }
}
