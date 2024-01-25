using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectManagementSystem
{
    public partial class Add_Labours : Form
    {
        public Add_Labours()
        {
            InitializeComponent();
        }

        private void Add_Labours_Load(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                textCountBox.Visible = false;
            }
            else
            {
                textCountBox.Visible = true;
            }

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select LabourType From Labours", conn);
            List<string> LabourTypes = new List<string>();

            using (SqlDataReader reader1 = cmd1.ExecuteReader())
            {
                while (reader1.Read())
                {
                    string labourType = reader1["LabourType"].ToString(); 
                    LabourTypes.Add(labourType);
                }
            }

            string[] labourTypeArray = LabourTypes.ToArray();

            comboBox1.Items.AddRange(labourTypeArray);

            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtCount.Text = "";
            txtSalary.Text = "";
            comboBox1.Text = "";
            textCountBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Labours where LabourType=@type", conn);
            cmd.Parameters.AddWithValue("type", comboBox1.Text);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                txtId.Text = reader1["LabourTypeId"].ToString();
                txtSalary.Text = reader1["Salary"].ToString();
                txtCount.Text = reader1["Count"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid Labour Check Again..", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            SqlCommand cmd = new SqlCommand("UPDATE Labours SET Count=@Count WHERE LabourTypeId=@id", conn);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@Count", int.Parse(txtCount.Text) + int.Parse(textCountBox.Text));
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Labours Added Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Text = "";
            txtCount.Text = "";
            txtSalary.Text = "";
            comboBox1.Text = "";
            textCountBox.Clear();
        }
    }
}
