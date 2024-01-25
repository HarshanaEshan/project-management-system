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
    public partial class Add_Resources : Form
    {
        public Add_Resources()
        {
            InitializeComponent();
        }

        private void Add_Resources_Load(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                textCountBox.Visible = false;
            }
            else
            {
                textCountBox.Visible = true;
            }

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select ResourceTypeName From Resources", conn);
            List<string> ResourceTypes = new List<string>();

            using (SqlDataReader reader1 = cmd1.ExecuteReader())
            {
                while (reader1.Read())
                {
                    string ResourceType = reader1["ResourceTypeName"].ToString();
                    ResourceTypes.Add(ResourceType);
                }
            }

            string[] ResourceTypeArray = ResourceTypes.ToArray();

            comboBox1.Items.AddRange(ResourceTypeArray);

            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Resources where ResourceTypeName=@type", conn);
            cmd.Parameters.AddWithValue("type", comboBox1.Text);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                txtId.Text = reader1["ResourceTypeId"].ToString();
                txtPrice.Text = reader1["UnitPrice"].ToString();
                txtCount.Text = reader1["Qty"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Resources Check Again..", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtId.Text == String.Empty)
            {
                textCountBox.Visible = false;
            }
            else
            {
                textCountBox.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Resources SET Qty=@Qty WHERE ResourceTypeId=@id", conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@Qty", int.Parse(txtCount.Text) + int.Parse(textCountBox.Text));
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Resources Added Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Text = "";
            txtCount.Text = "";
            txtPrice.Text = "";
            comboBox1.Text = "";
            textCountBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtCount.Text = "";
            txtPrice.Text = "";
            comboBox1.Text = "";
            textCountBox.Clear();
        }
    }
}
