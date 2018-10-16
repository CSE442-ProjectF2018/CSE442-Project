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
            this.gameScreen.SuspendLayout();
            this.titleScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameScreen
            // 
            this.gameScreen.Controls.Add(this.button1);
            this.gameScreen.Controls.Add(this.snakeGrid);
            this.gameScreen.Location = new System.Drawing.Point(0, 0);
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1136, 610);
            this.gameScreen.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(883, 217);
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
            this.Controls.Add(this.titleScreen);
            this.Controls.Add(this.gameScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Snek Snak";
            this.gameScreen.ResumeLayout(false);
            this.titleScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Panel titleScreen;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Panel gameScreen;
        private System.Windows.Forms.TableLayoutPanel snakeGrid;
        private System.Windows.Forms.Button button1;
    }
}

