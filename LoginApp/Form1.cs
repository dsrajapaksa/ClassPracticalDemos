﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "Amal", password = "12345";

            if (userNameTxt.Text == user && passwordTxt.Text == password)
            {
                Dashboard dsh = new Dashboard(user);

                this.Hide();
                dsh.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("User name or Password Incorrect !");
            }
        }
    }
}
