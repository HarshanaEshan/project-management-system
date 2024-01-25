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
    public partial class Labour_Details : Form
    {
        public Labour_Details()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Labours al1 = new Add_Labours();
            al1.ShowDialog();
        }

        private void Labour_Details_Load(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(this.laboursSet1.Labours);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
