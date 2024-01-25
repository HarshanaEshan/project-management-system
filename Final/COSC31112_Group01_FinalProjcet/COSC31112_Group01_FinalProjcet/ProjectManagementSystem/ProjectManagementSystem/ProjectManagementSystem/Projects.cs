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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void projCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Projects_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select Count(ProjectId) From Projects", conn);
            int projectCount = (int)cmd1.ExecuteScalar(); 
            total.Text = projectCount.ToString();

            SqlCommand cmd2 = new SqlCommand("Select Count(ProjectId) From Projects Where (Status = 'Completed' or Status = 'Closed')", conn);
            int CompleteCount = (int)cmd2.ExecuteScalar();
            complete.Text = CompleteCount.ToString();
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            this.Hide();
            h1.ShowDialog();
            this.Close();
        }

        private void viewAllProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void serchProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchProjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Projects ap1 = new Add_Projects();
            ap1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View_Projects vp = new View_Projects();
            vp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search_Project sp = new Search_Project();
            sp.ShowDialog();
        }
    }
}
