using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public Dashboard(string name)
        {
            InitializeComponent();
            //label1.Text = "Hi " + name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show
                ("Date they start: " + monthCalendar1.SelectionStart.ToShortDateString());

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipTitle = "Hello FROM This !";
            notifyIcon1.BalloonTipText = "Hey, you just clicked it !";
            notifyIcon1.ShowBalloonTip(1000);
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        int i = 10;
        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = i;
            i=i + 10;
        }
    }
}
