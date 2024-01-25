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
    public partial class Labour : Form
    {
        public Labour()
        {
            InitializeComponent();
        }

        private void Labour_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select SUM(Count) From Labours", conn);
            int lbrCount = (int)cmd1.ExecuteScalar();
            total.Text = lbrCount.ToString();

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Labours ae1 = new Add_Labours();
            ae1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Labour_Details ld1 = new Labour_Details();
            ld1.ShowDialog();
        }
    }
}
