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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(userID.Text==""||pass.Text=="")
            {
                MessageBox.Show("Enter User Name Or Password!");
            }
            else if(userID.Text=="Admin"&&pass.Text=="Admin123")
            {
                this.Hide();
                Home hom = new Home();
                hom.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong User Name Or Password");
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            userID.Clear();
            pass.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
