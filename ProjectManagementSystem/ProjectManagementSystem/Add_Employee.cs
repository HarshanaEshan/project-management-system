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
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            roleBox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            age.Clear();
            empSalary.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into EmpTemp values (@EmployeeId,@EmpName,@Role,@Age,@Gender,@Salary)", conn);
            cmd.Parameters.AddWithValue("@EmployeeId", txtId.Text);
            cmd.Parameters.AddWithValue("@EmpName", txtName.Text);
            cmd.Parameters.AddWithValue("@Role", roleBox.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(age.Text));
            if (radioButton1.Checked)
            {
                cmd.Parameters.AddWithValue("@Gender", "Male");
            }
            if (radioButton2.Checked)
            {
                cmd.Parameters.AddWithValue("@Gender", "Female");
            }
            cmd.Parameters.AddWithValue("@Salary", int.Parse(empSalary.Text));
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Employee Added Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtName.Clear();
            roleBox.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            age.Clear();
            empSalary.Clear();

            this.Refresh();
        }

        private void txtLabor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
