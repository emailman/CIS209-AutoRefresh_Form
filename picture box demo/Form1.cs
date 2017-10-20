using System;
using System.Drawing;
using System.Windows.Forms;

namespace picture_box_demo
{
    public partial class Form1 : Form
    {
        // Declare a class level array
        // of Picture Boxes
        PictureBox[] boxArray;

        public Form1()
        {
            InitializeComponent();

            // Put the picture boxes in an array
            boxArray = new PictureBox[] { pbx1, pbx2};
        }

        // Handler for timer tick events
        private void timer_Tick(object sender, EventArgs e)
        {
            if (boxArray[0].BackColor == Color.Black)
            {
                boxArray[0].BackColor = Color.Red;
                boxArray[1].BackColor = Color.Black;
            }
            else
            {
                boxArray[0].BackColor = Color.Black;
                boxArray[1].BackColor = Color.Red;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            foreach (PictureBox each in boxArray)
                each.BackColor = Color.Black;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
