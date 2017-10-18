using System;
using System.Drawing;
using System.Windows.Forms;

namespace picture_box_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Handler for timer tick events
        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbx1.BackColor == Color.Black)
            {
                pbx1.BackColor = Color.Red;
                pbx2.BackColor = Color.Black;
            }
            else
            {
                pbx1.BackColor = Color.Black;
                pbx2.BackColor = Color.Red;
            }
        }
    }
}
