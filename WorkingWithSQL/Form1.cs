using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkingWithSQL.Connection;

namespace WorkingWithSQL
{
    public partial class Form1 : Form
    {
       
        SqlCommand cmd;
        SqlDataAdapter adapt;
        int ID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT * FROM Student";

            employeeDataGridView.DataSource = DBAccess.getTableData(sqlQuery);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student std = new Student();

            std.id = Convert.ToInt16(iDTextBox.Text);
            std.fname = fNAMETextBox.Text;
            std.lname = lNAMETextBox.Text;
            std.gender = gENDERTextBox.Text;
            std.city = cITYTextBox.Text;
            std.address = aDDRESSTextBox.Text;
            std.age = Convert.ToInt16(aGETextBox.Text);
            std.datejoined = dATEJOINEDDateTimePicker.Text;
            std.phone = Convert.ToInt16( tELTextBox.Text);

            DBAccess.putDataToTable(std);

        }
    }
}
