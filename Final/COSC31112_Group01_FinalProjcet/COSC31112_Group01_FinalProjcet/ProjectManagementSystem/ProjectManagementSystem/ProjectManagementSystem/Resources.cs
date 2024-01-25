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
    public partial class Resources : Form
    {
        public Resources()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Resources ar1 = new Add_Resources();
            ar1.ShowDialog();
        }

        private void Resources_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select SUM(Qty) From Resources", conn);
            int rsCount = (int)cmd1.ExecuteScalar();
            total.Text = rsCount.ToString();

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resources_Details rd1 = new Resources_Details();
            rd1.ShowDialog();
        }
    }
}
