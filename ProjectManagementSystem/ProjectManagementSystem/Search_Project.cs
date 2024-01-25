using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ProjectManagementSystem
{
    public partial class Search_Project : Form
    {
        public Search_Project()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Projects where ProjectId=@id", conn);
            cmd.Parameters.AddWithValue("id", txtId.Text);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if(reader1.Read())
            {
                txtName.Text = reader1["Name"].ToString();
                Responsible.Text = reader1["Responsible"].ToString();
                CustomerId.Text = reader1["CustomerId"].ToString();
                StartDate.Text = reader1["StartDate"].ToString();
                EndDate.Text = reader1["EndDate"].ToString();
                LaborCount.Text = reader1["LaborCount"].ToString();
                statusBox.Text = reader1["Status"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Project ID Check Again..", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Text = "";
            Responsible.Text = "";
            CustomerId.Text = "";
            StartDate.Text = "";
            EndDate.Text = "";
            LaborCount.Text = "";
            statusBox.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update Projects set Status=@Status Where ProjectId=@id ", conn);
            cmd.Parameters.AddWithValue("id", txtId.Text);
            cmd.Parameters.AddWithValue("@Status", statusBox.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Updated Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            txtName.Text = "";
            Responsible.Text = "";
            CustomerId.Text = "";
            StartDate.Text = "";
            EndDate.Text = "";
            LaborCount.Text = "";
            statusBox.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Projects vp1 = new View_Projects();
            this.Hide();
            vp1.ShowDialog();
            this.Close();
        }
    }
}
