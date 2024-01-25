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

namespace ProjectManagementSystem
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(EmployeeId) From EmpTemp", conn);
            int empCount = (int)cmd1.ExecuteScalar();
            total.Text = empCount.ToString();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Employee ae1 = new Add_Employee();
            ae1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_Details ed1 = new Employee_Details();
            ed1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Employees ve1 = new View_Employees();
            ve1.ShowDialog();
        }
    }
}
