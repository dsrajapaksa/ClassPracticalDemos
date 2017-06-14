using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        List<Student> stdList;
        public Form1()
        {
            InitializeComponent();
            stdList = new List<Student>();
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student std = new Student()
            {
                id = Convert.ToInt16(textBox1.Text),
                name = textBox2.Text,
                city = textBox3.Text,
                school = textBox4.Text
            };

            stdList.Add(std);

            refresh();
        }

        private void refresh()
        {
            dataGridView1.DataSource = stdList;
        }
    }
}
