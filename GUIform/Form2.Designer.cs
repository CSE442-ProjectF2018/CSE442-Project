namespace GUIform
{
    partial class Game1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game1));
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ScoreValue = new System.Windows.Forms.Label();
            this.GamePlane = new System.Windows.Forms.PictureBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GamePlane)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            resources.ApplyResources(this.ScoreLabel, "ScoreLabel");
            this.ScoreLabel.ForeColor = System.Drawing.Color.Black;
            this.ScoreLabel.Name = "ScoreLabel";
            // 
            // ScoreValue
            // 
            resources.ApplyResources(this.ScoreValue, "ScoreValue");
            this.ScoreValue.Name = "ScoreValue";
            // 
            // GamePlane
            // 
            resources.ApplyResources(this.GamePlane, "GamePlane");
            this.GamePlane.Cursor = System.Windows.Forms.Cursors.Default;
            this.GamePlane.Name = "GamePlane";
            this.GamePlane.TabStop = false;
            this.GamePlane.Click += new System.EventHandler(this.GamePlane_Click);
            this.GamePlane.Paint += new System.Windows.Forms.PaintEventHandler(this.updateVisuals);
            this.GamePlane.MouseEnter += new System.EventHandler(this.GamePlane_MouseEnter);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Game1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.GamePlane);
            this.Controls.Add(this.ScoreValue);
            this.Controls.Add(this.ScoreLabel);
            this.DoubleBuffered = true;
            this.Name = "Game1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GamePlane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label ScoreValue;
        private System.Windows.Forms.PictureBox GamePlane;
        private System.Windows.Forms.Timer updateTimer;
    }
}