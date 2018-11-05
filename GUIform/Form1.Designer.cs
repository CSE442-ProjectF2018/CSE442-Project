namespace GUIform
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.snake_game_over = new System.Windows.Forms.Panel();
            this.Enter_Initials = new System.Windows.Forms.Label();
            this.snake_game_over_reset = new System.Windows.Forms.Button();
            this.gameScreen = new System.Windows.Forms.Panel();
            this.BGM1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.time_value = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.RESET_BUTTON = new System.Windows.Forms.Button();
            this.snakeGrid = new GUIform.DBLayoutPanel(this.components);
            this.titleScreen = new System.Windows.Forms.Panel();
            this.instructions = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.instruction_button = new System.Windows.Forms.Button();
            this.blink = new System.Windows.Forms.PictureBox();
            this.apple_game_over = new System.Windows.Forms.Panel();
            this.apple_game_over_reset = new System.Windows.Forms.Button();
            this.game_over_label = new System.Windows.Forms.Label();
            this.Adocalypse = new System.Windows.Forms.Label();
            this.t_timer = new System.Windows.Forms.Timer(this.components);
            this.snake_game_over.SuspendLayout();
            this.gameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGM1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.titleScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blink)).BeginInit();
            this.apple_game_over.SuspendLayout();
            this.SuspendLayout();
            // 
            // snake_game_over
            // 
            this.snake_game_over.BackgroundImage = global::GUIform.Properties.Resources.Snek_Game_Over;
            this.snake_game_over.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snake_game_over.Controls.Add(this.Enter_Initials);
            this.snake_game_over.Controls.Add(this.snake_game_over_reset);
            this.snake_game_over.Cursor = System.Windows.Forms.Cursors.Default;
            this.snake_game_over.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snake_game_over.Location = new System.Drawing.Point(0, 0);
            this.snake_game_over.Name = "snake_game_over";
            this.snake_game_over.Size = new System.Drawing.Size(1136, 609);
            this.snake_game_over.TabIndex = 2;
            // 
            // Enter_Initials
            // 
            this.Enter_Initials.AutoSize = true;
            this.Enter_Initials.BackColor = System.Drawing.Color.Transparent;
            this.Enter_Initials.Font = new System.Drawing.Font("Minerva", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Initials.ForeColor = System.Drawing.SystemColors.Window;
            this.Enter_Initials.Location = new System.Drawing.Point(440, 16);
            this.Enter_Initials.Name = "Enter_Initials";
            this.Enter_Initials.Size = new System.Drawing.Size(248, 41);
            this.Enter_Initials.TabIndex = 1;
            this.Enter_Initials.Text = "Enter your initials";
            // 
            // snake_game_over_reset
            // 
            this.snake_game_over_reset.BackColor = System.Drawing.Color.Yellow;
            this.snake_game_over_reset.Font = new System.Drawing.Font("Minerva", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snake_game_over_reset.Location = new System.Drawing.Point(468, 480);
            this.snake_game_over_reset.Name = "snake_game_over_reset";
            this.snake_game_over_reset.Size = new System.Drawing.Size(173, 50);
            this.snake_game_over_reset.TabIndex = 0;
            this.snake_game_over_reset.Text = "Play Again";
            this.snake_game_over_reset.UseVisualStyleBackColor = false;
            this.snake_game_over_reset.Click += new System.EventHandler(this.snake_game_over_reset_CLick);
            // 
            // gameScreen
            // 
            this.gameScreen.BackgroundImage = global::GUIform.Properties.Resources.BG_grassy;
            this.gameScreen.Controls.Add(this.BGM1);
            this.gameScreen.Controls.Add(this.time_value);
            this.gameScreen.Controls.Add(this.time_label);
            this.gameScreen.Controls.Add(this.axWindowsMediaPlayer1);
            this.gameScreen.Controls.Add(this.ScoreLabel);
            this.gameScreen.Controls.Add(this.PlayerScore);
            this.gameScreen.Controls.Add(this.RESET_BUTTON);
            this.gameScreen.Controls.Add(this.snakeGrid);
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1136, 610);
            this.gameScreen.TabIndex = 1;
            // 
            // BGM1
            // 
            this.BGM1.Enabled = true;
            this.BGM1.Location = new System.Drawing.Point(979, 16);
            this.BGM1.Name = "BGM1";
            this.BGM1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGM1.OcxState")));
            this.BGM1.Size = new System.Drawing.Size(136, 94);
            this.BGM1.TabIndex = 7;
            this.BGM1.Visible = false;
            // 
            // time_value
            // 
            this.time_value.AutoSize = true;
            this.time_value.BackColor = System.Drawing.Color.Transparent;
            this.time_value.Font = new System.Drawing.Font("Minerva", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_value.ForeColor = System.Drawing.SystemColors.Window;
            this.time_value.Location = new System.Drawing.Point(914, 12);
            this.time_value.Name = "time_value";
            this.time_value.Size = new System.Drawing.Size(34, 37);
            this.time_value.TabIndex = 6;
            this.time_value.Text = "0";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("Minerva", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_label.Location = new System.Drawing.Point(782, -1);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(106, 50);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "Time:";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1126, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Minerva", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ScoreLabel.Location = new System.Drawing.Point(2, -1);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(121, 50);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "SCORE:";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.Font = new System.Drawing.Font("Minerva", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerScore.Location = new System.Drawing.Point(12, 49);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(31, 35);
            this.PlayerScore.TabIndex = 2;
            this.PlayerScore.Text = "0";
            // 
            // RESET_BUTTON
            // 
            this.RESET_BUTTON.BackColor = System.Drawing.Color.DimGray;
            this.RESET_BUTTON.Location = new System.Drawing.Point(921, 235);
            this.RESET_BUTTON.Name = "RESET_BUTTON";
            this.RESET_BUTTON.Size = new System.Drawing.Size(91, 68);
            this.RESET_BUTTON.TabIndex = 1;
            this.RESET_BUTTON.Text = "RESET";
            this.RESET_BUTTON.UseVisualStyleBackColor = false;
            this.RESET_BUTTON.Click += new System.EventHandler(this.RESET_BUTTON_Click);
            // 
            // snakeGrid
            // 
            this.snakeGrid.BackColor = System.Drawing.Color.DarkGray;
            this.snakeGrid.BackgroundImage = global::GUIform.Properties.Resources.BG_wooden;
            this.snakeGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snakeGrid.ColumnCount = 16;
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.snakeGrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.snakeGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.snakeGrid.Location = new System.Drawing.Point(188, 5);
            this.snakeGrid.Name = "snakeGrid";
            this.snakeGrid.RowCount = 16;
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.snakeGrid.Size = new System.Drawing.Size(592, 592);
            this.snakeGrid.TabIndex = 0;
            this.snakeGrid.Click += new System.EventHandler(this.snakeGrid_Click);
            // 
            // titleScreen
            // 
            this.titleScreen.BackgroundImage = global::GUIform.Properties.Resources.snek2;
            this.titleScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.titleScreen.Controls.Add(this.instructions);
            this.titleScreen.Controls.Add(this.Title);
            this.titleScreen.Controls.Add(this.playButton);
            this.titleScreen.Controls.Add(this.instruction_button);
            this.titleScreen.Controls.Add(this.blink);
            this.titleScreen.Location = new System.Drawing.Point(-1, -1);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(1137, 611);
            this.titleScreen.TabIndex = 0;
            this.titleScreen.Click += new System.EventHandler(this.titleScreen_Click);
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.SystemColors.Window;
            this.instructions.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(355, 118);
            this.instructions.Multiline = true;
            this.instructions.Name = "instructions";
            this.instructions.ReadOnly = true;
            this.instructions.Size = new System.Drawing.Size(451, 386);
            this.instructions.TabIndex = 4;
            this.instructions.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Minerva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(146, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(310, 75);
            this.Title.TabIndex = 1;
            this.Title.Text = "Snec Snacc";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Yellow;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Minerva", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(418, 510);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(308, 88);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instruction_button
            // 
            this.instruction_button.BackColor = System.Drawing.Color.Yellow;
            this.instruction_button.Font = new System.Drawing.Font("Minerva", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_button.Location = new System.Drawing.Point(3, 574);
            this.instruction_button.Name = "instruction_button";
            this.instruction_button.Size = new System.Drawing.Size(121, 38);
            this.instruction_button.TabIndex = 3;
            this.instruction_button.Text = "How to Play";
            this.instruction_button.UseVisualStyleBackColor = false;
            this.instruction_button.Click += new System.EventHandler(this.instruction_button_Click);
            // 
            // blink
            // 
            this.blink.BackgroundImage = global::GUIform.Properties.Resources.snek_blink;
            this.blink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blink.Location = new System.Drawing.Point(1036, 0);
            this.blink.Name = "blink";
            this.blink.Size = new System.Drawing.Size(100, 50);
            this.blink.TabIndex = 5;
            this.blink.TabStop = false;
            this.blink.Visible = false;
            // 
            // apple_game_over
            // 
            this.apple_game_over.BackgroundImage = global::GUIform.Properties.Resources.Apple_Game_Over;
            this.apple_game_over.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apple_game_over.Controls.Add(this.apple_game_over_reset);
            this.apple_game_over.Controls.Add(this.game_over_label);
            this.apple_game_over.Controls.Add(this.Adocalypse);
            this.apple_game_over.Dock = System.Windows.Forms.DockStyle.Fill;
            this.apple_game_over.Location = new System.Drawing.Point(0, 0);
            this.apple_game_over.Name = "apple_game_over";
            this.apple_game_over.Size = new System.Drawing.Size(1136, 609);
            this.apple_game_over.TabIndex = 3;
            // 
            // apple_game_over_reset
            // 
            this.apple_game_over_reset.BackColor = System.Drawing.Color.Yellow;
            this.apple_game_over_reset.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apple_game_over_reset.Location = new System.Drawing.Point(1019, 573);
            this.apple_game_over_reset.Name = "apple_game_over_reset";
            this.apple_game_over_reset.Size = new System.Drawing.Size(117, 38);
            this.apple_game_over_reset.TabIndex = 2;
            this.apple_game_over_reset.Text = "Play Again";
            this.apple_game_over_reset.UseVisualStyleBackColor = false;
            this.apple_game_over_reset.Click += new System.EventHandler(this.apple_game_over_reset_Click);
            // 
            // game_over_label
            // 
            this.game_over_label.AutoSize = true;
            this.game_over_label.BackColor = System.Drawing.Color.Transparent;
            this.game_over_label.Font = new System.Drawing.Font("Minerva", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over_label.Location = new System.Drawing.Point(408, 4);
            this.game_over_label.Name = "game_over_label";
            this.game_over_label.Size = new System.Drawing.Size(335, 75);
            this.game_over_label.TabIndex = 1;
            this.game_over_label.Text = "Game Over!";
            // 
            // Adocalypse
            // 
            this.Adocalypse.AutoSize = true;
            this.Adocalypse.BackColor = System.Drawing.Color.Transparent;
            this.Adocalypse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adocalypse.Location = new System.Drawing.Point(84, 533);
            this.Adocalypse.Name = "Adocalypse";
            this.Adocalypse.Size = new System.Drawing.Size(804, 24);
            this.Adocalypse.TabIndex = 0;
            this.Adocalypse.Text = "Doctors are appearing everywhere, here\'s how you can prepare for the Adocalypse.." +
    ".";
            // 
            // t_timer
            // 
            this.t_timer.Tick += new System.EventHandler(this.t_timer_Tick);
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.apple_game_over);
            this.Controls.Add(this.titleScreen);
            this.Controls.Add(this.snake_game_over);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Snek Snak";
            this.snake_game_over.ResumeLayout(false);
            this.snake_game_over.PerformLayout();
            this.gameScreen.ResumeLayout(false);
            this.gameScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BGM1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.titleScreen.ResumeLayout(false);
            this.titleScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blink)).EndInit();
            this.apple_game_over.ResumeLayout(false);
            this.apple_game_over.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel titleScreen;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label Title;
        private DBLayoutPanel snakeGrid;
        private System.Windows.Forms.Button RESET_BUTTON;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Panel gameScreen;
        private System.Windows.Forms.Panel snake_game_over;
        private System.Windows.Forms.Button snake_game_over_reset;
        private System.Windows.Forms.Label Enter_Initials;
        private System.Windows.Forms.Panel apple_game_over;
        private System.Windows.Forms.Label Adocalypse;
        private System.Windows.Forms.Label game_over_label;
        private System.Windows.Forms.Button apple_game_over_reset;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Label time_value;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer t_timer;
        private System.Windows.Forms.Button instruction_button;
        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.PictureBox blink;
        private AxWMPLib.AxWindowsMediaPlayer BGM1;
    }
}

