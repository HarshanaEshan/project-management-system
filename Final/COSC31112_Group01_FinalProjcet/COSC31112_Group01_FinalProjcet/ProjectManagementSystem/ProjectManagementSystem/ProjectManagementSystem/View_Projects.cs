using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementSystem
{
    public partial class View_Projects : Form
    {
        public View_Projects()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Projects ap1 = new Add_Projects();
            ap1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Projects p1 = new Projects();
            this.Hide();
            p1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void View_Projects_Load(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(this.projectsSet1.Projects);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Search_Project sp1 = new Search_Project();
            sp1.ShowDialog();
        }
    }
}
