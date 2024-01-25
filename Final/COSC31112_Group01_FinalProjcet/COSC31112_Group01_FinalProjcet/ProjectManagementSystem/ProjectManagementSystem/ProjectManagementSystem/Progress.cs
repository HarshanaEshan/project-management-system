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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectManagementSystem
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projects p1 = new Projects();
            this.Hide();
            p1.ShowDialog();
            this.Close();
        }

        private void Progress_Load(object sender, EventArgs e)
        {
        
            // Create a series
            Series series = new Series("Data Series");
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);

            // Connect to the database
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProjectId, Status FROM Projects", connection);

                // Read data from the database and add data points to the series
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    string Id = reader1["ProjectId"].ToString();
                    int value = 0;

                    switch (reader1["Status"].ToString())
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
                reader1.Close();



            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("Select ProjectId From Projects", conn);
            List<string> ProjIds = new List<string>();

            using (SqlDataReader reader1 = cmd1.ExecuteReader())
            {
                while (reader1.Read())
                {
                    string projId = reader1["ProjectId"].ToString(); // Assuming ProjectId is a string
                    ProjIds.Add(projId);
                }
            }

            // Convert the list to an array if needed
            string[] empIdsArray = ProjIds.ToArray();

            // Populate a ListBox or another control with the array
            comboBox1.Items.AddRange(empIdsArray);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Series series = new Series("Data Series");
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Clear();
            chart1.Series.Add(series);

            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select ProjectId,Name,Status from Projects where ProjectId=@id", conn);
            cmd.Parameters.AddWithValue("id", comboBox1.Text);
            
            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                string Id = reader1["ProjectId"].ToString();
                ProjName.Text = reader1["Name"].ToString();

                int value = 0;

                switch (reader1["Status"].ToString())
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
            reader1.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            ProjName.Text = " ";
            chart1.Series.Clear();
            Series series = new Series("Data Series");
            series.ChartType = SeriesChartType.Column;
            chart1.Series.Add(series);

            // Connect to the database
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=PMSDB;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProjectId, Status FROM Projects", connection);

                // Read data from the database and add data points to the series
                SqlDataReader reader1 = cmd.ExecuteReader();
                while (reader1.Read())
                {
                    string Id = reader1["ProjectId"].ToString();
                    int value = 0;

                    switch (reader1["Status"].ToString())
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
                reader1.Close();

            }
        }
    }
}
