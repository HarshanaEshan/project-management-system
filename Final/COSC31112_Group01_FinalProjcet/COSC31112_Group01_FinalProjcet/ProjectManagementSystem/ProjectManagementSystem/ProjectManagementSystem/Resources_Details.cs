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
    public partial class Resources_Details : Form
    {
        public Resources_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Resources ar1 = new Add_Resources();
            ar1.ShowDialog();
        }

        private void Resources_Details_Load(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(this.resourceSet1.Resources);
        }
    }
}
