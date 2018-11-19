using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GUIform
{
    enum BType { apple, snake, wall, free };
    
    
    

    public partial class Game : Form
    {
        //core variables
        int time = 0;
        
        Map _m;
        bool _yourTurn = true;
        int _moveCounter = 0;

        
        Letter _head;
        Letter _l1;
        Letter _l2;
        Letter _l3;

        //Alphabet for Highscore entree
        public void letterListBuilder()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            _head = new Letter(alphabet[0]);
            Letter trav = _head;
            for(int i = 1; i < 26; ++i)
            {
                Letter temp = new Letter(alphabet[i]);
                trav.next = temp;
                temp.prev = trav;
                trav = temp;
            }
            trav.next = _head;
            _head.prev = trav;
        }
        


        //time stuff

        Timer blink_timer = new Timer();
        Timer t_time = new Timer();
        Timer h_timer = new Timer();
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        

        //Asset directiory
        private string c_asset_pack = "default\\"; //Current asset pack
        private string s_directory;
        private string i_directory;
        private string sp_directory;

        //sound effects
        SoundPlayer s_PlayButton;
        SoundPlayer s_AppleGET;
        SoundPlayer s_snakeDIE;
        SoundPlayer s_Player;
        SoundPlayer s_hover;


        //gif image related
        //private Image image_coin;
        private PictureBox coin_pic;
        private Image image_coin;
        private FrameDimension fdim;
        private int frames;
        private int cf = -1;
        Timer c_anim = new Timer();

        Image i_hover;
        Image i_trap;
        Image i_rock;
        Image i_apple;

        public Game()
        {
            InitializeComponent();

            setPanel(titleScreen);
            //Excahnges the current screen/panel.
            initialize_Asset_Pack(c_asset_pack);


            //Loads the sound ahead of time, in attempt to play it.
            play_BGM("BGM1.wav");

            letterListBuilder();
            _l1 = _head;
            _l2 = _head;
            _l3 = _head;

            //timer
            
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
            blink_timer.Tick += new EventHandler(blinkTimer_Tick);
            
        }


        private void TitleScreen_Load(object sender, EventArgs e)
        {

        }
        //Click functions
        private void playButton_Click(object sender, EventArgs e)
        {
            //Plays apple crunch sound.

            s_PlayButton.Load();
            s_PlayButton.Play();
            
            //Generates a new default map.

            //Exchanges the current screen panel.
            reset_to_gameScreen();


        }

        private void snakeGrid_Click(object sender, EventArgs e)
        {
            if (_yourTurn)
            {
                
                if(_m._toggleAR)
                {
                    //Place an apple
                    play_SFX("object_place.wav");
                    Point p = snakeGrid.PointToClient(MousePosition);
                    p.X = (int)(((double)16 / snakeGrid.Size.Width) * p.X);
                    p.Y = (int)(((double)16 / snakeGrid.Size.Height) * p.Y);

                    //Add Apple def to backing map.
                    Block newApple = new Block(1);
                    _m.setBlockAt(p.X, p.Y, newApple);

                    System.Windows.Forms.Panel applePanel = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(p.X, p.Y);
                    applePanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);


                    applePanel.BackgroundImage = Image.FromFile(sp_directory + "apple.png");
                    applePanel.BackgroundImageLayout = ImageLayout.Stretch;
                    //applePanel.Update();
                    _m._apples--;
                    _yourTurn = false;

                    _m.updateSnakePath();
                    dispatcherTimer.Start();
                }
                else if(_m._score_credit > 0)
                {
                    //Place a Rock
                    Point p = snakeGrid.PointToClient(MousePosition);
                    p.X = (int)(((double)16 / snakeGrid.Size.Width) * p.X);
                    p.Y = (int)(((double)16 / snakeGrid.Size.Height) * p.Y);

                    //Add Rock def to backing map.
                    place_rock(p.X, p.Y);
                    _m._score_credit -= 100;
                    play_SFX("object_place.wav");

                }
            }
        }

        private void titleScreen_Click(object sender, EventArgs e)
        {
            
            blink.Dock = DockStyle.Fill;
            blink.Visible = true;
            blink_timer.Interval = 250;
            blink_timer.Start();
        }
        private void apple_game_over_reset_Click(object sender, EventArgs e)
        {

            reset_to_gameScreen();
        }
        private void snake_game_over_reset_CLick(object sender, EventArgs e)
        {


            reset_to_gameScreen();

        }

        private void RESET_BUTTON_Click(object sender, EventArgs e)
        {
            reset_to_gameScreen();
        }
        private void instruction_button_Click(object sender, EventArgs e)
        {
            if (instructions.Visible == false)
            {
                instructions.Visible = true;
                instructions.Text = "Welcome to Snec Snacc!" + Environment.NewLine;
                instructions.Text += "Place apples by clicking on the game board." + Environment.NewLine;
                instructions.Text += "Guide the snake into coins to increase your score." + Environment.NewLine;
                instructions.Text += "Make sure to avoid traps!." + Environment.NewLine;
                instructions.Text += "Try to avoid killing the snake to achieve higher scores" + Environment.NewLine;
                instructions.Text += "How long will you survive?" + Environment.NewLine;
                instruction_button.Text = "Back";
            }
            else
            {
                instructions.Visible = false;
                instruction_button.Text = "How to Play";
            }
            play_SFX("pop.wav");
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
                _m._playerScore += _moveCounter * 10;
                PlayerScore.Text = _m._playerScore.ToString();
                _moveCounter = 0;

                sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._appleLocation.X, _m._appleLocation.Y);
                sTail.BackgroundImage = null;
                sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                //sTail.Update();
                _m.add_Score();
                PlayerScore.Text = _m._score_total.ToString();

                updateMap();
                
                _yourTurn = true;
                turnIcon_StyleChanged();
                /*
                if(_m._apples == 0)
                {
                    BGM_Player.Ctlcontrols.stop();
                    gameScreen.Visible = false;
                    apple_game_over.Visible = true;
                    t_time.Stop();
                    dispatcherTimer.Stop();
                    
                }
                */
                dispatcherTimer.Stop();
            }
            else if (_m._snakeDeath)
            {
                BGM_Player.Ctlcontrols.stop();
                t_time.Stop();
                s_snakeDIE.Play();
                gameScreen.Visible = false;
                snake_game_over.Visible = true;
                _l1 = _head;
                _l2 = _head;
                _l3 = _head;
                HS_PlayerScore.Text = _m._playerScore.ToString();


                
                dispatcherTimer.Stop();
            }
            else if (_m._coinGet)
            {
                play_SFX("coin_get.wav");
                snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y).Controls.RemoveAt(0);
                snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y).BackgroundImage = Image.FromFile(sp_directory + "snake_body.png");
                snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y).BackgroundImageLayout = ImageLayout.Stretch;
                _m.setBlockAt(_m._currentSnake._Head.X, _m._currentSnake._Head.Y, new Block(0));
                _m._coins_collected++;
                _m._coinGet = false;
            }
            else if (_m._trapHit)
            {
                play_SFX("oof.wav");
                _m.is_happy = 0;
                _m._trapHit = false;
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
        private void c_anim_Tick(object sender, EventArgs e)
        {
            cf += 1;
            if (cf >= frames) cf = 0;
            coin_pic.Image.SelectActiveFrame(fdim, cf);

            coin_pic.Image = (Image)coin_pic.Image.Clone();

        }

        //Important
        private void updateMap()
        {
            System.Windows.Forms.Panel sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y);
            sTail.BackgroundImage = null;
            sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
            //sTail.Update();

            sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 255, 0);
            sTail.BackgroundImageLayout = ImageLayout.Stretch;
            sTail.BackgroundImage = Image.FromFile(sp_directory + "snake_body.png");


            System.Windows.Forms.Panel sHead = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y);

            sHead.BackColor = System.Drawing.Color.FromArgb(0, 0, 255, 0);
            sHead.BackgroundImageLayout = ImageLayout.Stretch;
            sHead.BackgroundImage = Image.FromFile(sp_directory + "snake_body.png");

            //sHead.Update();
            turnIcon_StyleChanged();
            snakeGrid.Update();
        }

        private void reset_to_gameScreen()
        {
            //Controls.Add(loading_screen);
            //gameScreen.Controls.Remove(loading_screen);


           
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
                    test.MouseEnter += new EventHandler(GP_Enter);
                    test.MouseLeave += new EventHandler(GP_Leave);
                    test.Click += new System.EventHandler(this.snakeGrid_Click);
                    test.BackgroundImageLayout = ImageLayout.Stretch;
                    snakeGrid.Controls.Add(test, i, j);
                }
            }
            snakeGrid.ResumeLayout();
            _m._playerScore = 0;
            _yourTurn = true;
            PlayerScore.Text = _m._playerScore.ToString();

            HighScoreDB data = new HighScoreDB();
            Tuple<string, string>[] top5 = data.getTop5();
            data.closeConnection();
            if (top5[0] != null) { HS_1.Text = top5[0].ToString(); }
            if (top5[1] != null) { HS_2.Text = top5[1].ToString(); }
            if (top5[2] != null) { HS_3.Text = top5[2].ToString(); }
            if (top5[3] != null) { HS_4.Text = top5[3].ToString(); }
            if (top5[4] != null) { HS_5.Text = top5[4].ToString(); }

            play_BGM("GameBGM1.wav");

            initializeTimeCounter();
            place_Coin(5, 5);
            place_Coin(1, 1);
            place_Coin(2, 2);
            place_Coin(0, 10);
            place_Coin(0, 15);
            place_Trap(15, 15);
            place_Coin(15, 0);
            c_anim.Start();
            setPanel(gameScreen);
            rando_Map();
        }

        //others
        private void place_Coin(int x, int y)
        {
            if(_m.getBlockAt(x,y).getType() == 0)
            {
                //places coin object on map
                _m.setBlockAt(x, y, new Block(4));

                //sets the coins image to a gif and sets up all the other bullshit that makes it work.
                coin_pic = new PictureBox();
                image_coin = Image.FromFile(sp_directory + "coin.gif");
                fdim = new FrameDimension(image_coin.FrameDimensionsList[0]);
                frames = image_coin.GetFrameCount(fdim);
                coin_pic.Image = image_coin;

                //places coin image on GUI
                snakeGrid.GetControlFromPosition(x, y).Controls.Add(coin_pic);
            }
            
        }
        private void place_Trap(int x, int y)
        {
            if (_m.getBlockAt(x, y).getType() == 0)
            {
                _m.setBlockAt(x, y, new Block(5));
                snakeGrid.GetControlFromPosition(x, y).BackgroundImage = i_trap;
            }
            
        }
        private void place_rock(int x, int y)
        {
            if(_m.getBlockAt(x,y).getType() == 0)
            {
                _m.setBlockAt(x, y, new Block(2));
                snakeGrid.GetControlFromPosition(x, y).BackgroundImage = i_rock;
                
            }
            
        }
        private void rando_Map()
        {
            Random randy = new Random();
            int r_map = randy.Next(1,100);
            if(r_map <= 33)
            {
                int x1 = 3;
                int y1 = 8;
                while (x1 < 7)
                {
                    place_rock(x1, y1);
                    place_rock(x1, y1 - 2);
                    place_rock(15 - x1, y1);
                    place_rock(15 - x1, y1- 2);
                    x1++;
                }
                while(y1 < 12)
                {
                    place_rock(x1, y1);
                    place_rock(x1 + 2, y1);
                    place_rock(x1, 15 - y1 - 1);
                    place_rock(x1 + 2, 15 - y1 -1);
                    y1++;
                }
            }
            else if(r_map > 33 && r_map < 66)
            {
                int x = 2;
                int y = 4;
                for(int i = 0; i < 4; i++)
                {
                    place_rock(x+i, y-i);
                    place_rock(15 - (x+i), y-i);
                    place_rock(x+i,15 - (y-i));
                    place_rock(15 - (x+i),15 - (y-i));
                }
                
            }
            else if(r_map >= 66)
            {
                int x = 3;
                int y = 3;
                for (int i = 0; i < 4; i++)
                {
                    place_rock(x + i, y + i);
                    place_rock(15 - (x + i), y + i);
                    place_rock(x + i, 15 - (y + i));
                    place_rock(15 - (x + i), 15 - (y + i));
                }
            }
        }

        private void initializeTimeCounter()
        {
            time = 0;
            t_time = new Timer();
            t_time.Interval = 1000;
            t_time.Tick += new EventHandler(t_timer_Tick);
            t_time.Start();
        }
        private void setPanel(Panel p)
        {
            foreach(Panel q in this.Controls){
                if (q != p) q.Visible = false;
            }
            p.Dock = DockStyle.Fill;
            p.Visible = true;
            
        }

        private void turnIcon_StyleChanged()
        {
            if (_yourTurn)
            {
                turnIcon.BackgroundImage = Image.FromFile(i_directory + "appleturn.png");
                turnLabel.BackColor = System.Drawing.Color.FromArgb(255, 255, 255, 128);
                turnLabel.Text = "Your Turn";
            }
            else
            {
                turnIcon.BackgroundImage = Image.FromFile(i_directory + "snecturn.png");
                turnLabel.BackColor = System.Drawing.Color.FromArgb(255, 128, 255, 255);
                turnLabel.Text = "Snec's Turn";
            }
        }

        private void toggleAppleRock(object sender, EventArgs e)
        {
            _m._toggleAR = !_m._toggleAR;
            if(!_m._toggleAR)togAppleRock.BackgroundImage = Image.FromFile(sp_directory + "rock.png");
            else togAppleRock.BackgroundImage = Image.FromFile(sp_directory + "apple.png");
        }
        private void initialize_Asset_Pack(string pack)
        {
            s_directory = Environment.CurrentDirectory + "\\Assets\\" + pack + "Audio\\";
            i_directory = Environment.CurrentDirectory + "\\Assets\\" + pack + "Images\\";
            sp_directory = Environment.CurrentDirectory + "\\Assets\\" + pack + "Sprites\\";

            //sound stuff
            
            BGM_Player.settings.setMode("loop",true);
            
            s_PlayButton = new SoundPlayer(s_directory + "apple_crunch.wav");
            s_AppleGET = new SoundPlayer(s_directory + "apple_chew.wav");
            s_snakeDIE = new SoundPlayer(s_directory + "Scream.wav");

            //Imagery 
            //image_coin = Image.FromFile(sp_directory + "coin.gif");
            titleScreen.BackgroundImage = Image.FromFile(i_directory + "title.png");
            gameScreen.BackgroundImage = Image.FromFile(i_directory + "BG_grassy2.png");
            snakeGrid.BackgroundImage = Image.FromFile(i_directory + "BG_wooden.png");
            snake_game_over.BackgroundImage = Image.FromFile(i_directory + "snec_game_over.png");
            //loading_screen.BackgroundImage = Image.FromFile(i_directory + "loading.png");

            //sprites
            i_hover = Image.FromFile(sp_directory + "X.png");
            i_trap = Image.FromFile(sp_directory + "trap.png");
            i_rock = Image.FromFile(sp_directory + "rock.png");

            c_anim.Tick += new EventHandler(c_anim_Tick);
            c_anim.Interval = 100;
            playButton.MouseEnter += new EventHandler(button_Mouse_Enter);
            playButton.MouseLeave += new EventHandler(button_Mouse_Leave);
            instruction_button.MouseEnter += new EventHandler(button_Mouse_Enter);
            instruction_button.MouseLeave += new EventHandler(button_Mouse_Leave);
            
            
        }
        private void button_Mouse_Enter(object sender, EventArgs e)
        {
            play_SFX("mouse_enter.wav");
            Button BOI = (Button)sender;
            BOI.FlatAppearance.BorderColor = Color.Yellow;
            BOI.FlatAppearance.BorderSize = 5;

        }
        private void button_Mouse_Leave(object sender, EventArgs e)
        {
            play_SFX("mouse_leave.wav");
            Button BOI = (Button)sender;
            BOI.FlatAppearance.BorderSize = 1;

        }
        private void GP_Enter(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;
            if (_yourTurn)
            {
                //play_SFX("panel.wav");
                if (p.BackgroundImage == null) p.BackgroundImage = i_hover;
            }
        }
        private void GP_Leave(object sender, EventArgs e)
        {
            Panel p = (Panel)sender;

            if(p.BackgroundImage == i_hover) p.BackgroundImage = null;
        }

        private void play_BGM(string bgm)
        {
            BGM_Player.URL = s_directory + bgm;
            BGM_Player.settings.volume = 500;
            BGM_Player.Ctlcontrols.play();
        }
        private void play_SFX(string sfx)
        {
            s_Player = new SoundPlayer(s_directory + sfx);
            s_Player.Play();
        }

        private void HS_Enter_Click(object sender, EventArgs e)
        {
            string s = "" + _l1.c + _l2.c + _l3.c;
            HighScoreDB data = new HighScoreDB();
            data.insert(s, _m._playerScore);
            data.closeConnection();
            reset_to_gameScreen();
        }
    }
}
