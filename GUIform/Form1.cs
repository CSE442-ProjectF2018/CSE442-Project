using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Media;
using System.Windows.Forms;
using System.Windows.Threading;

namespace GUIform
{
    
    public partial class Game : Form
    {
        //core variables
        int time = 0;
        
        Map _m;
        bool _yourTurn = true;
        int _moveCounter = 0;
        int _tool_selection = 0;
        
        
        //
        //IF YOU'RE ON CAMPUS, SET TRUE.
        //SET FALSE OTHERWISE.
        //THIS DISABLES DATABASE CONECTIVITY.
        //
        bool DB_OnCampus = true;
        //
        //
        //


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
        DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();

        

        //Asset directiory
        private string c_asset_pack = "default"; //Current asset pack
        private string[] assetPacks;
        private string s_directory;
        private string i_directory;
        private string sp_directory;
        

        //sound effects
        SoundPlayer s_PlayButton;
        SoundPlayer s_AppleGET;
        SoundPlayer s_snakeDIE;
        SoundPlayer s_Player;
        SoundPlayer s_CoinGet;


        //gif image related
        //private Image image_coin;
        private PictureBox coin_pic;
        private Image image_coin;
        private FrameDimension fdim;
        private int frames;
        private int cf = -1;
        //Timer c_anim = new Timer();

        Image i_hover;
        Image i_trap;
        Image i_rock;
        Image i_apple;
        Image i_wall;
        //options
        //tool selection 0 = apple, 1 = rock, 2 = pickaxe
        
        //map selection 0 = randy, 1 = +, 2 = X, 3 = that other one
        public int _map_selection = -1;

        public Game()
        {
            InitializeComponent();

            setPanel(titleScreen);
            //Excahnges the current screen/panel.
            scan_Asset_Directory();
            initialize_Asset_Pack(c_asset_pack);
            initialize_EventHandlers();
            //Loads the sound ahead of time, in attempt to play it.
            play_BGM("BGM1.wav");

            letterListBuilder();
            _l1 = _head;
            _l2 = _head;
            _l3 = _head;

            HS_Init1.AutoSize = false;
            HS_Init2.AutoSize = false;
            HS_Init3.AutoSize = false;

            //timer

            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(100);
            
            
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
                Point p = snakeGrid.PointToClient(MousePosition);
                p.X = (int)(((double)16 / snakeGrid.Size.Width) * p.X);
                p.Y = (int)(((double)16 / snakeGrid.Size.Height) * p.Y);

                switch (_tool_selection)
                {
                    default:
                    case 0:
                        if(_m.getBlockAt(p.X,p.Y) != 0)
                        {
                            return;
                        }
                        bool creditCheck0 = _m.partialScoreMod(1);
                        if (creditCheck0)
                        {
                            _m.setBlockAt(p.X, p.Y, 1);

                            System.Windows.Forms.Panel applePanel = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(p.X, p.Y);
                            applePanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                            applePanel.BackgroundImage = Image.FromFile(sp_directory + "apple.png");
                            applePanel.BackgroundImageLayout = ImageLayout.Stretch;
                            PartialPoints.Text = _m._points_turn.ToString();
                            PlayerScore.Text = _m._points_total.ToString();

                            _yourTurn = false;

                            _m.updateSnakePath();
                        }
                        break;
                    case 1:
                        if (_m.getBlockAt(p.X, p.Y) != 0)
                        {
                            return;
                        }
                        bool creditCheck1 = _m.partialScoreMod(2);
                        if (creditCheck1)
                        {
                            //Place a Rock
                            _m.setBlockAt(p.X, p.Y, 2);

                            System.Windows.Forms.Panel applePanel = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(p.X, p.Y);
                            applePanel.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);

                            applePanel.BackgroundImage = Image.FromFile(sp_directory + "rock.png");
                            applePanel.BackgroundImageLayout = ImageLayout.Stretch;

                            PartialPoints.Text = _m._points_turn.ToString();
                            PlayerScore.Text = _m._points_total.ToString();

                            play_SFX("object_place.wav");
                        }
                        break;
                    case 2:
                        if (_m.getBlockAt(p.X, p.Y) == 2)
                        {
                            _m.setBlockAt(p.X, p.Y, 0);
                            --_m._activeRocks;
                            snakeGrid.GetControlFromPosition(p.X, p.Y).BackgroundImage = null;
                            play_SFX("break.wav");
                            _m.partialScoreMod(6);

                            PartialPoints.Text = _m._points_turn.ToString();
                            PlayerScore.Text = _m._points_total.ToString();
                        }
                        break;
                }
            }
        }

        private void titleScreen_Click(object sender, EventArgs e)
        {

            
        }
        private void apple_game_over_reset_Click(object sender, EventArgs e)
        {
            reset_to_gameScreen();
        }
        private void snake_game_over_reset_CLick(object sender, EventArgs e)
        {

            setPanel(titleScreen);
            play_BGM("BGM1.wav");
            _m = null;

        }

        private void RESET_BUTTON_Click(object sender, EventArgs e)
        {
            if (!_yourTurn)
            {
                BGM_Player.Ctlcontrols.stop();
                play_SFX2("scream.wav");
                setPanel(snake_game_over);
                _l1 = _head;
                _l2 = _head;
                _l3 = _head;
                HS_PlayerScore.Text = _m._points_total.ToString();

                play_BGM("GameOverBGM.wav");
                dispatcherTimer.Stop();
            }
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
                instructions.Text += "-----------------------------" + Environment.NewLine;
                instructions.Text += "Apple Tool: place an apple to guide snake" + Environment.NewLine;
                instructions.Text += "Rock Tool: place to block undesirable snake paths, but decreases your score." + Environment.NewLine;
                instructions.Text += "Pickaxe Tool: use to desproy rocks you have placed." + Environment.NewLine;
                instructions.Text += "Bear Trap: Resets points gained during a turn to 0." + Environment.NewLine;
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

            if (!_yourTurn)
            {
                System.Windows.Forms.Panel sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Tail.X, _m._currentSnake._Tail.Y);
                sTail.BackgroundImage = null;
                sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                //sTail.Update();

                _m.moveSnake();

                if (_m._appleGet == true)
                {
                    s_AppleGET.Play();


                    sTail = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._appleLocation.X, _m._appleLocation.Y);
                    sTail.BackgroundImage = null;
                    sTail.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                    //sTail.Update();

                    PartialPoints.Text = _m._points_turn.ToString();
                    PlayerScore.Text = _m._points_total.ToString();


                    foreach (Point p in _m._coinLocations)
                    {
                        coin_pic = new PictureBox();
                        image_coin = Image.FromFile(sp_directory + "coin.gif");
                        fdim = new FrameDimension(image_coin.FrameDimensionsList[0]);
                        frames = image_coin.GetFrameCount(fdim);
                        coin_pic.Image = image_coin;
                        coin_pic.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                        snakeGrid.GetControlFromPosition(p.X, p.Y).Controls.Clear();
                        snakeGrid.GetControlFromPosition(p.X, p.Y).Controls.Add(coin_pic);
                    }

                    foreach (Point p in _m._trapLocations)
                    {
                        System.Windows.Forms.Panel pan = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(p.X, p.Y);
                        pan.Controls.Clear();
                        pan.BackgroundImage = i_trap;
                        pan.BackgroundImageLayout = ImageLayout.Stretch;

                    }

                    updateMap();

                    _yourTurn = true;
                    turnIcon_StyleChanged();
                    
                }
                else if (_m._snakeDeath)
                {
                    BGM_Player.Ctlcontrols.stop();
                    play_SFX2("scream.wav");
                    setPanel(snake_game_over);
                    _l1 = _head;
                    _l2 = _head;
                    _l3 = _head;
                    HS_PlayerScore.Text = _m._points_total.ToString();

                    play_BGM("GameOverBGM.wav");
                    dispatcherTimer.Stop();
                }
                else if (_m._coinGet)
                {
                    s_CoinGet.LoadAsync();
                    s_CoinGet.Play();

                    System.Windows.Forms.Panel target = (System.Windows.Forms.Panel)snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y);

                    target.Controls.Clear();
                    target.BackgroundImage = Image.FromFile(sp_directory + "snake_body.png");
                    target.BackgroundImageLayout = ImageLayout.Stretch;
                    _m.setBlockAt(_m._currentSnake._Head.X, _m._currentSnake._Head.Y, 0);

                    for (int i = 0; i < _m._coinLocations.Count; ++i)
                    {
                        if (_m._coinLocations[i].X == _m._currentSnake._Head.X && _m._coinLocations[i].Y == _m._currentSnake._Head.Y)
                        {
                            _m._coinLocations.RemoveAt(i);
                            break;
                        }
                    }

                    /*
                    foreach(Point p in _m._coinLocations)
                    {
                        if(p.X == _m._currentSnake._Head.X && p.Y == _m._currentSnake._Head.Y)
                        {
                            _m._coinLocations.Remove(p);
                            break;
                        }
                    }
                    */

                    PartialPoints.Text = _m._points_turn.ToString();

                    _m._coinGet = false;
                }
                else if (_m._trapHit)
                {
                    snakeGrid.GetControlFromPosition(_m._currentSnake._Head.X, _m._currentSnake._Head.Y).BackgroundImage =
                        Image.FromFile(sp_directory + "snake_body.png");
                    play_SFX("oof.wav");
                    //_m.is_happy = 0;
                    PartialPoints.Text = _m._points_turn.ToString();
                    _m._trapHit = false;
                }

                else
                {
                    updateMap();

                    _moveCounter++;
                }
            }
            cf += 1;
            if (cf >= frames) cf = 0;
            coin_pic.Image.SelectActiveFrame(fdim, cf);

            coin_pic.Image = (Image)coin_pic.Image.Clone();


        }
        
        
        
        private void c_anim_Tick(object sender, EventArgs e)
        {
            

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
            
            /*
            if (_m.nextDirection == 3) sHead.BackgroundImage = Image.FromFile(sp_directory + "snake_head_l.png");
            else if (_m.nextDirection == 1) sHead.BackgroundImage = Image.FromFile(sp_directory + "snake_head_r.png");
            else if (_m.nextDirection == 0) sHead.BackgroundImage = Image.FromFile(sp_directory + "snake_head_u.png");
            else if (_m.nextDirection == 2) sHead.BackgroundImage = Image.FromFile(sp_directory + "snake_head_d.png");
            */

            //sHead.Update();
            turnIcon_StyleChanged();
            snakeGrid.Update();
        }

        private void reset_to_gameScreen()
        {
            
            _m = new Map(_map_selection);
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
                    switch (_m._info[i, j])
                    {
                        default:
                            test.BackgroundImageLayout = ImageLayout.Stretch;
                            snakeGrid.Controls.Add(test, i, j);
                            break;
                        case 2:
                            test.BackgroundImage = i_rock;
                            test.BackgroundImageLayout = ImageLayout.Stretch;
                            snakeGrid.Controls.Add(test, i, j);
                            break;
                        case 4:
                            coin_pic = new PictureBox();
                            image_coin = Image.FromFile(sp_directory + "coin.gif");
                            fdim = new FrameDimension(image_coin.FrameDimensionsList[0]);
                            frames = image_coin.GetFrameCount(fdim);
                            coin_pic.Image = image_coin;
                            coin_pic.BackColor = System.Drawing.Color.FromArgb(0, 0, 0, 0);
                            test.Controls.Add(coin_pic);
                            snakeGrid.Controls.Add(test, i, j);
                            break;
                        case 5:
                            test.BackgroundImage = i_trap;
                            test.BackgroundImageLayout = ImageLayout.Stretch;
                            snakeGrid.Controls.Add(test, i, j);
                            break;
                        case 6:
                            test.BackgroundImage = i_wall;
                            test.BackgroundImageLayout = ImageLayout.Stretch;
                            snakeGrid.Controls.Add(test, i, j);
                            break;
                    }
                    
                }
            }
            snakeGrid.ResumeLayout();
            
            _yourTurn = true;
            PlayerScore.Text = _m._points_total.ToString();
            PartialPoints.Text = _m._points_turn.ToString();

            if (!DB_OnCampus)
            {
                HighScoreDB data = new HighScoreDB();
                Tuple<string, string>[] top5 = data.getTop5();
                data.closeConnection();
                if (top5[0] != null) { HS_1.Text = "" + top5[0].Item1 + ": " + top5[0].Item2; };
                if (top5[1] != null) { HS_2.Text = "" + top5[1].Item1 + ": " + top5[1].Item2; };
                if (top5[2] != null) { HS_3.Text = "" + top5[2].Item1 + ": " + top5[2].Item2; };
                if (top5[3] != null) { HS_4.Text = "" + top5[3].Item1 + ": " + top5[3].Item2; };
                if (top5[4] != null) { HS_5.Text = "" + top5[4].Item1 + ": " + top5[4].Item2; };
            }

            play_BGM("GameBGM1.wav");


            //c_anim.Start();
            dispatcherTimer.Start();
            setPanel(gameScreen);
            //rando_Map();
        }
        private void initialize_Asset_Pack(string pack)
        {
            s_directory = Environment.CurrentDirectory + "\\Assets\\" + pack + "\\Audio\\";
            i_directory = Environment.CurrentDirectory + "\\Assets\\" + pack + "\\Images\\";
            sp_directory = Environment.CurrentDirectory + "\\Assets\\" + pack + "\\Sprites\\";

            //sound stuff

            BGM_Player.settings.setMode("loop", true);

            s_PlayButton = new SoundPlayer(s_directory + "apple_crunch.wav");
            s_AppleGET = new SoundPlayer(s_directory + "apple_chew.wav");
            s_snakeDIE = new SoundPlayer(s_directory + "Scream.wav");
            s_CoinGet = new SoundPlayer(s_directory + "coin_get.wav");
            

            //Imagery 
            titleScreen.BackgroundImage = Image.FromFile(i_directory + "title.png");
            gameScreen.BackgroundImage = Image.FromFile(i_directory + "BG_park_1.png");
            snakeGrid.BackgroundImage = Image.FromFile(i_directory + "BG_sewer.png");
            snake_game_over.BackgroundImage = Image.FromFile(i_directory + "snec_game_over.png");
            //loading_screen.BackgroundImage = Image.FromFile(i_directory + "loading.png");
            //blink.BackgroundImage = Image.FromFile(i_directory + "snek_blink.png");
            turnIcon.BackgroundImage = Image.FromFile(i_directory + "appleturn.png");
            map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_random.png");

            options.BackgroundImage = Image.FromFile(sp_directory + "options.png");
            tool_apple.BackgroundImage = Image.FromFile(sp_directory + "apple.png");
            tool_rock.BackgroundImage = Image.FromFile(sp_directory + "rock.png");
            tool_pickaxe.BackgroundImage = Image.FromFile(sp_directory + "pickaxe.png");

            //sprites
            i_hover = Image.FromFile(sp_directory + "X.png");
            i_trap = Image.FromFile(sp_directory + "trap.png");
            i_rock = Image.FromFile(sp_directory + "rock.png");
            i_apple = Image.FromFile(sp_directory + "apple.png");
            i_wall = Image.FromFile(sp_directory + "wall.png");
            HS_Init1_Down.BackgroundImage = Image.FromFile(sp_directory + "arrow_down.png");
            HS_Init1_Up.BackgroundImage = Image.FromFile(sp_directory + "arrow_up.png");
            HS_Init2_Down.BackgroundImage = Image.FromFile(sp_directory + "arrow_down.png");
            HS_Init2_Up.BackgroundImage = Image.FromFile(sp_directory + "arrow_up.png");
            HS_Init3_Down.BackgroundImage = Image.FromFile(sp_directory +"arrow_down.png");
            HS_Init3_Up.BackgroundImage = Image.FromFile(sp_directory + "arrow_up.png");
            /*
            c_anim.Tick += new EventHandler(c_anim_Tick);
            c_anim.Interval = 100;
            */

        }

        private void scan_Asset_Directory()
        {
            assetPacks = Directory.GetDirectories(Environment.CurrentDirectory + "\\Assets\\");
            int i = 0;
            foreach(string s in assetPacks)
            {
                asset_Pack_List.Items.Add(System.IO.Path.GetFileName(s));
            }
        }
        private void initialize_EventHandlers()
        {
            //Universal behavior for all buttons added to game
            foreach (Panel p in this.Controls)
            {
                foreach (var b in p.Controls)
                {
                    if (b.GetType() == typeof(Button))
                    {
                        Button bee = (Button)b;
                        bee.MouseEnter += new EventHandler(button_Mouse_Enter);
                        bee.MouseLeave += new EventHandler(button_Mouse_Leave);
                        bee.FlatStyle = FlatStyle.Flat;
                    }
                    
                }
            }
            tool_apple.Click += new EventHandler(tool_Click);
            tool_rock.Click += new EventHandler(tool_Click);
            tool_pickaxe.Click += new EventHandler(tool_Click);
            
        }

        //others

            //object placement
       
        
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
        /*
        private void toggleAppleRock(object sender, EventArgs e)
        {
            _m._toggleAR = !_m._toggleAR;
            if(!_m._toggleAR)tool_pickaxe.BackgroundImage = Image.FromFile(sp_directory + "rock.png");
            else tool_pickaxe.BackgroundImage = Image.FromFile(sp_directory + "apple.png");
        }
        */
        private void button_Mouse_Enter(object sender, EventArgs e)
        {
            play_SFX("mouse_enter.wav");
            Button BOI = (Button)sender;
           // BOI.FlatAppearance.BorderColor = Color.Black;
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
        private void play_SFX2(string sfx)
        {
            
             SFX_Player.URL = s_directory + sfx;
             SFX_Player.settings.volume = 500;
             SFX_Player.Ctlcontrols.play();
             
        }

        private void HS_Enter_Click(object sender, EventArgs e)
        {
            if (!DB_OnCampus)
            {
                string s = "" + _l1.c + _l2.c + _l3.c;
                HighScoreDB data = new HighScoreDB();
                data.insert(s, _m._points_total);
                data.closeConnection();

            }

            reset_to_gameScreen();
        }

        private void HS_Init1_Down_Click(object sender, EventArgs e)
        {
            _l1 = _l1.next;
            HS_Init1.Text = _l1.c.ToString(); 
        }

        private void HS_Init2_Down_Click(object sender, EventArgs e)
        {
            _l2 = _l2.next;
            HS_Init2.Text = _l2.c.ToString();
        }

        private void HS_Init3_Down_Click(object sender, EventArgs e)
        {
            _l3 = _l3.next;
            HS_Init3.Text = _l3.c.ToString();
        }

        private void HS_Init1_Up_Click(object sender, EventArgs e)
        {
            _l1 = _l1.prev;
            HS_Init1.Text = _l1.c.ToString();
        }

        private void HS_Init2_Up_Click(object sender, EventArgs e)
        {
            _l2 = _l2.prev;
            HS_Init2.Text = _l2.c.ToString();
        }

        private void HS_Init3_Up_Click(object sender, EventArgs e)
        {
            _l3 = _l3.prev;
            HS_Init3.Text = _l3.c.ToString();
        }

        private void tool_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            foreach(var v in gameScreen.Controls)
            {
                if(v.GetType() == typeof(Button))
                {
                    Button bee = (Button)v;
                    if(bee.Name != b.Name)
                    {
                        bee.FlatAppearance.BorderColor = Color.Gray;
                    }
                }
            }
            b.FlatAppearance.BorderColor = Color.Yellow;
            b.FlatAppearance.BorderSize = 5;
            if(b.Name == "tool_apple")
            {
                _tool_selection = 0;
            }
            else if (b.Name == "tool_rock")
            {
                _tool_selection = 1;
            }
            else if (b.Name == "tool_pickaxe")
            {
                _tool_selection = 2;
            }
            play_SFX("pop.wav");
        }

        private void options_Click(object sender, EventArgs e)
        {
            if (!optionsPanel.Visible)
            {
                optionsPanel.Visible = true;
            }
            else if (optionsPanel.Visible)
            {
                optionsPanel.Visible = false;
            }
            play_SFX("pop.wav");
        }

        private void o_mapSel_right_Click(object sender, EventArgs e)
        {
            _map_selection++;
            o_mapSel_label.Text = _map_selection.ToString();
            if(_map_selection > -2) o_mapSel_left.Visible = true;
            else if(_map_selection == 4) o_mapSel_right.Visible = false;

            switch (_map_selection)
            {
                
                case -1:
                    o_mapSel_label.Text = "R";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_random.png");
                    o_mapSel_left.Visible = true;
                    break;
                case 0:
                    o_mapSel_label.Text = "0";
                    map_preview.BackgroundImage = null;
                    break;
                case 1:
                    o_mapSel_label.Text = "1";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_1.png");
                    break;
                case 2:
                    o_mapSel_label.Text = "2";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_2.png");
                    break;
                case 3:
                    o_mapSel_label.Text = "3";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_1.png");
                    break;
                case 4:
                    o_mapSel_label.Text = "4";
                    map_preview.BackgroundImage = null;
                    o_mapSel_right.Visible = false;
                    break;
            }
            
        }

        private void o_mapSel_left_Click(object sender, EventArgs e)
        {
            _map_selection--;
            o_mapSel_label.Text = _map_selection.ToString();
            if (_map_selection == -2) o_mapSel_left.Visible = false;
            else if (_map_selection < 4) o_mapSel_right.Visible = true;

            switch (_map_selection)
            {
                case -2:
                    o_mapSel_label.Text = "C";
                    map_preview.BackgroundImage = null;
                    o_mapSel_left.Visible = false;
                    break;
                case -1:
                    o_mapSel_label.Text = "R";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_random.png");
                    break;
                case 0:
                    o_mapSel_label.Text = "0";
                    map_preview.BackgroundImage = null;
                    break;
                case 1:
                    o_mapSel_label.Text = "1";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_1.png");
                    break;
                case 2:
                    o_mapSel_label.Text = "2";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_2.png");
                    
                    break;
                case 3:
                    o_mapSel_label.Text = "3";
                    map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_3.png");
                    o_mapSel_right.Visible = true;
                    break;
            }
        }

        private void asset_Pack_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_asset_pack = asset_Pack_List.GetItemText(asset_Pack_List.SelectedItem);
            Console.WriteLine("{0}", c_asset_pack);
        }

        private void o_RSP_Apply_Click(object sender, EventArgs e)
        {
            initialize_Asset_Pack(c_asset_pack);
            _map_selection = -1;
            o_mapSel_label.Text = "R";
            map_preview.BackgroundImage = Image.FromFile(i_directory + "p_map_random.png");
            o_mapSel_left.Visible = true;
            o_mapSel_right.Visible = true;
        }
    }
}
