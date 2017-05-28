using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstGUIApp
{
    public partial class Form123 : Form
    {
        public Form123()
        {
            InitializeComponent();
            
        }

        private void myBtn_Click(object sender, EventArgs e)
        {
           // myLabel.Text = "Hello World !";
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            int height = 97, width = 100;

           pictureBox1.Size = new Size(width + trackBar.Value,height + trackBar.Value);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            int point1 = 24, point2 = 63;
            pictureBox1.Location = new Point(point1+ trackBar1.Value, point2 + trackBar1.Value);
        }
    }
}
