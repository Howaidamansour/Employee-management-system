using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SperMarktManagementSystem
{
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3RV0S3S;Initial Catalog=EmployeesDB;Integrated Security=True");
        private void featchdata()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeTb1 WHERE empID='" + EmpID.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                
                EmpName.Text = dr["empName"].ToString();
                
                EmpPos.Text = dr["empPos"].ToString();
            }

            con.Close();

        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h2 = new Home();
            h2.ShowDialog();
            this.Hide();
        }
        int Dailybase, Total;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(EmpPos.Text=="")
            {
                MessageBox.Show("Select A Employee Position");
            }
            else if(EmpWD.Text==""||Convert.ToInt32(EmpWD.Text)>28)
            {
                MessageBox.Show("Enter A Valid Number Of Days");
            }
            else
            {
                if (EmpPos.Text == "Manager")
                    Dailybase = 1200;
                else if (EmpPos.Text == "Senior deverloper")
                    Dailybase = 1000;
                else if (EmpPos.Text == "Janior developer")
                    Dailybase = 800;
                else if (EmpPos.Text == "Accounting")
                    Dailybase = 600;
                else
                    Dailybase = 400;
                Total = Dailybase * Convert.ToInt32(EmpWD.Text);
                string s = "Employee ID: " + EmpID.Text + "\n \n" + "Employee Name: " + EmpName.Text + "\n \n" + "Employee Position: " + EmpPos.Text + "\n \n" + "Employee Worked Days: " + EmpWD.Text + "\n \n Total Salary: " + Total;
                ritchsalary.Text = s;

            }
            
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            featchdata();
        }

        private void EmpAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            featchdata();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====SALARY DOCUMENT=====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(160, 10));
            e.Graphics.DrawString("Employee ID: " + EmpID.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 130));
            e.Graphics.DrawString("Employee Name: " + EmpName.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 180));
            e.Graphics.DrawString("Employee Position: " + EmpPos.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 230));
            e.Graphics.DrawString("Worked Days: " + EmpWD.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 280));
            e.Graphics.DrawString("Total Salary: " + Total, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 330));
           
            e.Graphics.DrawString("=====EmpiSoft=====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(160, 550));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
