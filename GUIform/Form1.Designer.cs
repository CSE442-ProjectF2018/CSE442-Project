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
            this.HomeSreen = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.GameScreen = new System.Windows.Forms.Panel();
            this.TimeValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.PictureBox();
            this.TimeCounter = new System.Windows.Forms.Timer(this.components);
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeSreen.SuspendLayout();
            this.GameScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeSreen
            // 
            this.HomeSreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeSreen.BackgroundImage")));
            this.HomeSreen.Controls.Add(this.PlayButton);
            this.HomeSreen.Controls.Add(this.Title);
            this.HomeSreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeSreen.Location = new System.Drawing.Point(0, 0);
            this.HomeSreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HomeSreen.Name = "HomeSreen";
            this.HomeSreen.Size = new System.Drawing.Size(482, 545);
            this.HomeSreen.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Yellow;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(17, 262);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(106, 104);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(160, 28);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(174, 36);
            this.Title.TabIndex = 0;
            this.Title.Text = "Snecc Snak";
            // 
            // GameScreen
            // 
            this.GameScreen.Controls.Add(this.TimeValue);
            this.GameScreen.Controls.Add(this.label1);
            this.GameScreen.Controls.Add(this.Score);
            this.GameScreen.Controls.Add(this.ScoreLabel);
            this.GameScreen.Controls.Add(this.Grid);
            this.GameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameScreen.Location = new System.Drawing.Point(0, 0);
            this.GameScreen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(482, 545);
            this.GameScreen.TabIndex = 1;
            // 
            // TimeValue
            // 
            this.TimeValue.AutoSize = true;
            this.TimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeValue.Location = new System.Drawing.Point(412, 0);
            this.TimeValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeValue.Name = "TimeValue";
            this.TimeValue.Size = new System.Drawing.Size(18, 20);
            this.TimeValue.TabIndex = 4;
            this.TimeValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time:";
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(53, 0);
            this.Score.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(18, 20);
            this.Score.TabIndex = 1;
            this.Score.Text = "0";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(2, 0);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(61, 20);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score:";
            // 
            // Grid
            // 
            this.Grid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grid.BackgroundImage")));
            this.Grid.Location = new System.Drawing.Point(0, 23);
            this.Grid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(480, 520);
            this.Grid.TabIndex = 2;
            this.Grid.TabStop = false;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
            // 
            // TimeCounter
            // 
            this.TimeCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MoveTimer
            // 
            this.MoveTimer.Tick += new System.EventHandler(this.MoveTimer_Tick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 545);
            this.Controls.Add(this.GameScreen);
            this.Controls.Add(this.HomeSreen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Game";
            this.Text = "Snekk Snacc";
            this.Load += new System.EventHandler(this.TitleScreen_Load);
            this.HomeSreen.ResumeLayout(false);
            this.HomeSreen.PerformLayout();
            this.GameScreen.ResumeLayout(false);
            this.GameScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HomeSreen;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel GameScreen;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.PictureBox Grid;
        private System.Windows.Forms.Label TimeValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimeCounter;
        private System.Windows.Forms.Timer MoveTimer;
    }
}

