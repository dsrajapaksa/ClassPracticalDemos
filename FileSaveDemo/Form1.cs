using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSaveDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string filePath = "";
            saveFileDialog1.DefaultExt = ".txt";

            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;

                File.WriteAllText(filePath + ".txt", richTextBox1.Text);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string filePath = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;

                richTextBox1.Text= File.ReadAllText(filePath );
            }
        }
    }
}
