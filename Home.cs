using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SperMarktManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ViewEmp ve = new ViewEmp();
            ve.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ShowDialog();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.ShowDialog();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ViewEmp ve = new ViewEmp();
            ve.ShowDialog();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.ShowDialog();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Salary sal = new Salary();
            sal.ShowDialog();
            this.Hide();
        }
    }
}
