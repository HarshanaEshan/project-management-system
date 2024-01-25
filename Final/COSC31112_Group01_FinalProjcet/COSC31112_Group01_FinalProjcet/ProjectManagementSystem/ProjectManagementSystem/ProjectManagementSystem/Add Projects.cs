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
    public partial class Add_Projects : Form
    {
        public Add_Projects()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Projects p1 = new Projects();
            this.Hide();
            p1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Insert into Projects values (@ProjectId,@Name,@StartDate,@EndDate,@Responsible,@CustomerId,@LaborCount,@Status)", conn);
            cmd.Parameters.AddWithValue("@ProjectId", txtId.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@StartDate", DateTime.Parse(date1.Text));
            cmd.Parameters.AddWithValue("@EndDate", DateTime.Parse(date2.Text));
            cmd.Parameters.AddWithValue("@Responsible", resBox.Text);
            cmd.Parameters.AddWithValue("@CustomerId", customerBox.Text);
            cmd.Parameters.AddWithValue("@LaborCount", int.Parse(txtLabor.Text));
            cmd.Parameters.AddWithValue("@Status", statusBox.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Project Added Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtName.Clear();
            date1.Text = DateTime.Now.ToString();
            date2.Text = DateTime.Now.ToString();
            resBox.Text = "";
            customerBox.Text = "";
            txtLabor.Clear();
            statusBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            date1.Text = DateTime.Now.ToString();
            date2.Text = DateTime.Now.ToString();
            resBox.Text = "";
            customerBox.Text = "";
            txtLabor.Clear();
            statusBox.Text = "";
        }

        private void Add_Projects_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select EmployeeId From EmpTemp Where Role = 'Manager'", conn);
            List<string> EmpIds = new List<string>();

            using (SqlDataReader reader1 = cmd1.ExecuteReader())
            {
                while (reader1.Read())
                {
                    string empId = reader1["EmployeeId"].ToString(); // Assuming ProjectId is a string
                    EmpIds.Add(empId);
                }
            }

            // Convert the list to an array if needed
            string[] empIdsArray = EmpIds.ToArray();

            // Populate a ListBox or another control with the array
            resBox.Items.AddRange(empIdsArray);


            SqlCommand cmd2 = new SqlCommand("Select CustomerId From Customer", conn);
            List<string> custIds = new List<string>();

            using (SqlDataReader reader2 = cmd2.ExecuteReader())
            {
                while (reader2.Read())
                {
                    string custId = reader2["CustomerId"].ToString(); // Assuming ProjectId is a string
                    custIds.Add(custId);
                }
            }

            // Convert the list to an array if needed
            string[] custIdsArray = custIds.ToArray();

            // Populate a ListBox or another control with the array
            customerBox.Items.AddRange(custIdsArray);

            conn.Close();
        }
    }
}
