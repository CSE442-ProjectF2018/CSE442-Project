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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameScreen = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.PlayerScore = new System.Windows.Forms.Label();
            this.RESET_BUTTON = new System.Windows.Forms.Button();
            //this.snakeGrid = new System.Windows.Forms.TableLayoutPanel();
            this.snakeGrid = new DBLayoutPanel();
            this.titleScreen = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.gameScreen.SuspendLayout();
            this.titleScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameScreen
            // 
            this.gameScreen.Controls.Add(this.ScoreLabel);
            this.gameScreen.Controls.Add(this.PlayerScore);
            this.gameScreen.Controls.Add(this.RESET_BUTTON);
            this.gameScreen.Controls.Add(this.snakeGrid);
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1136, 610);
            this.gameScreen.TabIndex = 1;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(12, 26);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(138, 37);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "SCORE:";
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.Location = new System.Drawing.Point(23, 72);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(24, 26);
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
            this.snakeGrid.BackgroundImage = global::GUIform.Properties.Resources.Grid;
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
            this.titleScreen.Controls.Add(this.playButton);
            this.titleScreen.Location = new System.Drawing.Point(-1, -1);
            this.titleScreen.Name = "titleScreen";
            this.titleScreen.Size = new System.Drawing.Size(1137, 611);
            this.titleScreen.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Yellow;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(418, 510);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(308, 88);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(1136, 609);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.titleScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Snek Snak";
            this.gameScreen.ResumeLayout(false);
            this.gameScreen.PerformLayout();
            this.titleScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel titleScreen;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel gameScreen;
        //private System.Windows.Forms.TableLayoutPanel snakeGrid;
        private DBLayoutPanel snakeGrid;
        private System.Windows.Forms.Button RESET_BUTTON;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label PlayerScore;
    }
}

