﻿namespace GUIform
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
            this.SFX_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.BGM_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.togAppleRock = new System.Windows.Forms.Button();
            this.turnLabel = new System.Windows.Forms.Label();
            this.turnIcon = new System.Windows.Forms.PictureBox();
            this.time_value = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.RESET_BUTTON = new System.Windows.Forms.Button();
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
            this.snakeGrid = new GUIform.DBLayoutPanel(this.components);
            this.snake_game_over.SuspendLayout();
            this.gameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFX_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGM_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnIcon)).BeginInit();
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
            this.Enter_Initials.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Initials.ForeColor = System.Drawing.SystemColors.Window;
            this.Enter_Initials.Location = new System.Drawing.Point(440, 16);
            this.Enter_Initials.Name = "Enter_Initials";
            this.Enter_Initials.Size = new System.Drawing.Size(267, 38);
            this.Enter_Initials.TabIndex = 1;
            this.Enter_Initials.Text = "Enter your initials";
            // 
            // snake_game_over_reset
            // 
            this.snake_game_over_reset.BackColor = System.Drawing.Color.Yellow;
            this.snake_game_over_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.snake_game_over_reset.Location = new System.Drawing.Point(468, 480);
            this.snake_game_over_reset.Name = "snake_game_over_reset";
            this.snake_game_over_reset.Size = new System.Drawing.Size(193, 50);
            this.snake_game_over_reset.TabIndex = 0;
            this.snake_game_over_reset.Text = "Play Again";
            this.snake_game_over_reset.UseVisualStyleBackColor = false;
            this.snake_game_over_reset.Click += new System.EventHandler(this.snake_game_over_reset_CLick);
            // 
            // gameScreen
            // 
            this.gameScreen.BackgroundImage = global::GUIform.Properties.Resources.BG_grassy;
            this.gameScreen.Controls.Add(this.SFX_Player);
            this.gameScreen.Controls.Add(this.BGM_Player);
            this.gameScreen.Controls.Add(this.togAppleRock);
            this.gameScreen.Controls.Add(this.turnLabel);
            this.gameScreen.Controls.Add(this.turnIcon);
            this.gameScreen.Controls.Add(this.time_value);
            this.gameScreen.Controls.Add(this.time_label);
            this.gameScreen.Controls.Add(this.ScoreLabel);
            this.gameScreen.Controls.Add(this.PlayerScore);
            this.gameScreen.Controls.Add(this.RESET_BUTTON);
            this.gameScreen.Controls.Add(this.snakeGrid);
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1136, 610);
            this.gameScreen.TabIndex = 1;
            // 
            // SFX_Player
            // 
            this.SFX_Player.Enabled = true;
            this.SFX_Player.Location = new System.Drawing.Point(1057, -1);
            this.SFX_Player.Name = "SFX_Player";
            this.SFX_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SFX_Player.OcxState")));
            this.SFX_Player.Size = new System.Drawing.Size(79, 74);
            this.SFX_Player.TabIndex = 4;
            this.SFX_Player.Visible = false;
            // 
            // BGM_Player
            // 
            this.BGM_Player.Enabled = true;
            this.BGM_Player.Location = new System.Drawing.Point(975, -1);
            this.BGM_Player.Name = "BGM_Player";
            this.BGM_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BGM_Player.OcxState")));
            this.BGM_Player.Size = new System.Drawing.Size(85, 76);
            this.BGM_Player.TabIndex = 4;
            this.BGM_Player.Visible = false;
            // 
            // togAppleRock
            // 
            this.togAppleRock.BackColor = System.Drawing.Color.White;
            this.togAppleRock.BackgroundImage = global::GUIform.Properties.Resources.apple;
            this.togAppleRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.togAppleRock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togAppleRock.Location = new System.Drawing.Point(17, 523);
            this.togAppleRock.Name = "togAppleRock";
            this.togAppleRock.Size = new System.Drawing.Size(135, 73);
            this.togAppleRock.TabIndex = 10;
            this.togAppleRock.Text = "Toggle\r\nApple/Rock";
            this.togAppleRock.UseVisualStyleBackColor = true;
            this.togAppleRock.Click += new System.EventHandler(this.toggleAppleRock);
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.turnLabel.Location = new System.Drawing.Point(840, 441);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(72, 17);
            this.turnLabel.TabIndex = 9;
            this.turnLabel.Text = "Your Turn";
            // 
            // turnIcon
            // 
            this.turnIcon.BackgroundImage = global::GUIform.Properties.Resources.appleturn;
            this.turnIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turnIcon.Location = new System.Drawing.Point(821, 411);
            this.turnIcon.Name = "turnIcon";
            this.turnIcon.Size = new System.Drawing.Size(272, 185);
            this.turnIcon.TabIndex = 8;
            this.turnIcon.TabStop = false;
            // 
            // time_value
            // 
            this.time_value.AutoSize = true;
            this.time_value.BackColor = System.Drawing.Color.Transparent;
            this.time_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_value.ForeColor = System.Drawing.SystemColors.Window;
            this.time_value.Location = new System.Drawing.Point(914, 12);
            this.time_value.Name = "time_value";
            this.time_value.Size = new System.Drawing.Size(32, 36);
            this.time_value.TabIndex = 6;
            this.time_value.Text = "0";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.BackColor = System.Drawing.Color.Transparent;
            this.time_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.time_label.Location = new System.Drawing.Point(782, -1);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(119, 46);
            this.time_label.TabIndex = 5;
            this.time_label.Text = "Time:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.ScoreLabel.Location = new System.Drawing.Point(2, -1);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(174, 46);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "SCORE:";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.SystemColors.Window;
            this.PlayerScore.Location = new System.Drawing.Point(12, 49);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(31, 32);
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
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.Location = new System.Drawing.Point(146, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(344, 69);
            this.Title.TabIndex = 1;
            this.Title.Text = "$nec $nacc";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Yellow;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.instruction_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.instruction_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instruction_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction_button.Location = new System.Drawing.Point(3, 561);
            this.instruction_button.Name = "instruction_button";
            this.instruction_button.Size = new System.Drawing.Size(150, 51);
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
            this.apple_game_over_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.game_over_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game_over_label.Location = new System.Drawing.Point(408, 4);
            this.game_over_label.Name = "game_over_label";
            this.game_over_label.Size = new System.Drawing.Size(366, 69);
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
            ((System.ComponentModel.ISupportInitialize)(this.SFX_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGM_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnIcon)).EndInit();
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
        private System.Windows.Forms.Label time_value;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Timer t_timer;
        private System.Windows.Forms.Button instruction_button;
        private System.Windows.Forms.TextBox instructions;
        private System.Windows.Forms.PictureBox blink;
        private System.Windows.Forms.PictureBox turnIcon;
        private System.Windows.Forms.Label turnLabel;
        private System.Windows.Forms.Button togAppleRock;
        private AxWMPLib.AxWindowsMediaPlayer BGM_Player;
        private AxWMPLib.AxWindowsMediaPlayer SFX_Player;
    }
}

