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
            refreshandGetData();
        }

        public void refreshandGetData()
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

        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            iDTextBox.Text = ID.ToString();
            fNAMETextBox.Text = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DBAccess.deleteDataFromTable(ID.ToString());
                refreshandGetData();

        }
    }
}
