using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIform
{
    public partial class Game1 : Form
    {
        Snake snek;
        public Game1()
        {
            InitializeComponent();
            snek = new Snake();
        }

        private void GamePlane_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Up)
            {
                direction d = direction.up;
                snek.changeDirection(d);
                Console.Write(e.KeyValue);
                Console.Write("Up");
            }
            if (e.KeyValue == (char)Keys.Down)
            {

            }
            if (e.KeyValue == (char)Keys.Left)
            {

            }
            if (e.KeyValue == (char)Keys.Right)
            {

            }
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Game1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void GamePlane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GamePlane_Click(object sender, EventArgs e)
        {

        }

        private void updateVisuals(object sender, PaintEventArgs e)
        {

        }

        private void GamePlane_MouseEnter(object sender, EventArgs e)
        {
            
        }
    }
}
