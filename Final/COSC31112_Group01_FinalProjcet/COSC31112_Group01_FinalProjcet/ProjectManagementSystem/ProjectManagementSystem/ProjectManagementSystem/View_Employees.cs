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
    public partial class View_Employees : Form
    {
        public View_Employees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Employee ae1 = new Add_Employee();
            ae1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_Details ed1 = new Employee_Details();
            ed1.ShowDialog();
        }

        private void View_Employees_Load(object sender, EventArgs e)
        {
            this.sqlDataAdapter1.Fill(this.employeeSet.EmpTemp);
        }
    }
}
