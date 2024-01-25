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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace ProjectManagementSystem
{
    public partial class Employee_Details : Form
    {
        public Employee_Details()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from EmpTemp where EmployeeId=@id", conn);
            cmd.Parameters.AddWithValue("id", txtId.Text);
            SqlDataReader reader1;
            reader1 = cmd.ExecuteReader();
            if (reader1.Read())
            {
                empName.Text = reader1["EmpName"].ToString();
                roleBox.Text = reader1["Role"].ToString();
                empAge.Text = reader1["Age"].ToString();
                empGender.Text = reader1["Gender"].ToString();
                Salary.Text = reader1["Salary"].ToString();

                
            }
            else
            {
                MessageBox.Show("Invalid Employee ID Check Again..", "Data Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            reader1.Close();
            conn.Close();
            if (roleBox.Text == "Manager")
            {
                pictureBox1.Visible = false;
                // Create a series
                Series series = new Series("Data Series");
                series.ChartType = SeriesChartType.Column;
                chart1.Series.Add(series);

                // Connect to the database
                string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd1 = new SqlCommand("SELECT ProjectId, Status FROM Projects Where Responsible=@eId", connection);
                    cmd1.Parameters.AddWithValue("eId", txtId.Text);

                    // Read data from the database and add data points to the series
                    SqlDataReader reader2 = cmd1.ExecuteReader();
                    while (reader2.Read())
                    {
                        string Id = reader2["ProjectId"].ToString();
                        int value = 0;

                        switch (reader2["Status"].ToString())
                        {
                            case "Planned":
                                value = 10;
                                break;
                            case "Analyzed":
                                value = 35;
                                break;
                            case "Started":
                                value = 60;
                                break;
                            case "Completed":
                                value = 80;
                                break;
                            case "Closed":
                                value = 100;
                                break;
                                // Handle other statuses as needed
                        }

                        // Add data points based on the "Name" column value
                        series.Points.AddXY(Id, value);

                        // Label the X-axis directly
                        chart1.ChartAreas[0].AxisX.Title = "Project";

                        // Label the Y-axis directly
                        chart1.ChartAreas[0].AxisY.Title = "Progress";

                        // Refresh the chart to display the changes
                        chart1.Refresh();
                        
                    }
                    
                }
            }
            else
            {
                pictureBox1.Visible = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update EmpTemp set Role=@Role Where EmployeeId=@id ", conn);
            cmd.Parameters.AddWithValue("id", txtId.Text);
            cmd.Parameters.AddWithValue("@Role", roleBox.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Updated Successfully", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtId.Clear();
            empName.Text = "";
            empAge.Text = "";
            empGender.Text = "";
            roleBox.Text = "";
            Salary.Text = "";
            pictureBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            empName.Text = "";
            empAge.Text = "";
            empGender.Text = "";
            roleBox.Text = "";
            Salary.Text = "";
            pictureBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            View_Employees ve1 = new View_Employees();
            ve1.ShowDialog();
        }
    }
}
