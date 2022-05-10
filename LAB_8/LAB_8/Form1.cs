using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_8
{
    public partial class playarea : Form
    {
        Bone mybone;
        Paddle player1;
        Paddle player2;
        Graphics g;
        int points = 0;
        bool UptoDown = false;
        public playarea()
        {
            InitializeComponent();
            
            
        }

        private void playarea_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
        }

        private void PlayArea_Paint(object sender, PaintEventArgs e)
        {
            mybone.Display(g);
            player1.Display(g);
            player2.Display(g);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mybone.MoveBall();
            // Collison Detection ( Wall Collision , Paddle Collision)
            

            //this.Invalidate();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
