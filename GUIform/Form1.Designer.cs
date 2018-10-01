namespace GUIform
{
    partial class TitleScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreen));
            this.HomeSreen = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.GameScreen = new System.Windows.Forms.Panel();
            this.Score = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.PictureBox();
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
            this.HomeSreen.Name = "HomeSreen";
            this.HomeSreen.Size = new System.Drawing.Size(642, 671);
            this.HomeSreen.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.Yellow;
            this.PlayButton.Font = new System.Drawing.Font("Minerva", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(23, 323);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(141, 128);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Minerva", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(214, 35);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(192, 47);
            this.Title.TabIndex = 0;
            this.Title.Text = "Snecc Snak";
            // 
            // GameScreen
            // 
            this.GameScreen.Controls.Add(this.Score);
            this.GameScreen.Controls.Add(this.ScoreLabel);
            this.GameScreen.Controls.Add(this.Grid);
            this.GameScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GameScreen.Location = new System.Drawing.Point(0, 0);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(642, 671);
            this.GameScreen.TabIndex = 1;
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(71, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(23, 25);
            this.Score.TabIndex = 1;
            this.Score.Text = "0";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Minerva", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(3, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(62, 25);
            this.ScoreLabel.TabIndex = 0;
            this.ScoreLabel.Text = "Score:";
            // 
            // Grid
            // 
            this.Grid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Grid.BackgroundImage")));
            this.Grid.Location = new System.Drawing.Point(0, 28);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(640, 640);
            this.Grid.TabIndex = 2;
            this.Grid.TabStop = false;
            // 
            // TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 671);
            this.Controls.Add(this.HomeSreen);
            this.Controls.Add(this.GameScreen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TitleScreen";
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
    }
}

