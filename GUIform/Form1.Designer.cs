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
            this.button1 = new System.Windows.Forms.Button();
            this.snakeGrid = new System.Windows.Forms.TableLayoutPanel();
            this.titleScreen = new System.Windows.Forms.Panel();
            this.playButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gameScreen.SuspendLayout();
            this.snakeGrid.SuspendLayout();
            this.titleScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameScreen
            // 
            this.gameScreen.Controls.Add(this.button1);
            this.gameScreen.Controls.Add(this.snakeGrid);
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(625, 322);
            this.gameScreen.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(415, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // snakeGrid
            // 
            this.snakeGrid.BackColor = System.Drawing.Color.DarkGray;
            this.snakeGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snakeGrid.ColumnCount = 15;
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.Controls.Add(this.button2, 4, 7);
            this.snakeGrid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.snakeGrid.Location = new System.Drawing.Point(12, 12);
            this.snakeGrid.Name = "snakeGrid";
            this.snakeGrid.RowCount = 15;
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.snakeGrid.Size = new System.Drawing.Size(297, 297);
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
            this.titleScreen.Size = new System.Drawing.Size(625, 322);
            this.titleScreen.TabIndex = 0;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Yellow;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playButton.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(231, 268);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(165, 51);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY!";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(14, 14);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(624, 321);
            this.Controls.Add(this.gameScreen);
            this.Controls.Add(this.titleScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Snek Snak";
            this.gameScreen.ResumeLayout(false);
            this.snakeGrid.ResumeLayout(false);
            this.titleScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel titleScreen;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel gameScreen;
        private System.Windows.Forms.TableLayoutPanel snakeGrid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

