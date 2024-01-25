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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Coral;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Cyan;
            button5.BackColor = Color.Cyan;
            pictureBox2.Visible = false;
            Employees e1 = new Employees();
            e1.MdiParent = this;
            e1.Dock = DockStyle.Fill;
            e1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Coral;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Cyan;
            button5.BackColor = Color.Cyan;
            pictureBox2.Visible = false;
            Projects p1 = new Projects();
            p1.MdiParent = this;
            p1.Dock = DockStyle.Fill;
            p1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Cyan;
            button5.BackColor = Color.Coral;
            pictureBox2.Visible = false;
            Progress p2 = new Progress();
            p2.MdiParent = this;
            p2.Dock = DockStyle.Fill;
            p2.Show();
        }

        public void timer5_Tick(object sender, EventArgs e)
        {
            // Update the label with the current date and time
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Coral;
            button4.BackColor = Color.Cyan;
            button5.BackColor = Color.Cyan;
            pictureBox2.Visible = false;
            Labour l1 = new Labour();
            l1.MdiParent = this;
            l1.Dock = DockStyle.Fill;
            l1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Cyan;
            button2.BackColor = Color.Cyan;
            button3.BackColor = Color.Cyan;
            button4.BackColor = Color.Coral;
            button5.BackColor = Color.Cyan;
            pictureBox2.Visible = false;
            Resources r1 = new Resources();
            r1.MdiParent = this;
            r1.Dock = DockStyle.Fill;
            r1.Show();
        }
    }
}
