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
    public partial class ViewEmp : Form
    {
        public ViewEmp()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3RV0S3S;Initial Catalog=EmployeesDB;Integrated Security=True");
        private void featchdata()
        {
            con.Open();
            string query = "SELECT * FROM EmployeeTb1 WHERE empID='"+txtID.Text+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                EmpID.Text = dr["empID"].ToString();
                EmployeeName.Text = dr["empName"].ToString();
                EmpAdd.Text = dr["empAdd"].ToString();
                EmpPos.Text = dr["empPos"].ToString();
                EmpGen.Text = dr["empGender"].ToString();
                EmpDOFB.Text = dr["empDOB"].ToString();
                EmpPhone.Text = dr["empPhone"].ToString();
                EmpEdu.Text = dr["empEdu"].ToString();   

                EmpID.Visible = true;
                EmployeeName.Visible= true;
                EmpAdd.Visible = true;
                EmpPos.Visible = true;
                EmpGen.Visible = true;
                EmpDOFB.Visible = true;
                EmpPhone.Visible = true;
                EmpEdu.Visible = true;


            }
            
            con.Close();
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmpPhone_Click(object sender, EventArgs e)
        {

        }

        //private void btnAdd_Click(object sender, EventArgs e)
        //{
        //    featchdata();
        //}

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Hide();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            featchdata();
            //MessageBox.Show(EmpID.Text);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=====Employee Sumary=====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(160, 10));
            e.Graphics.DrawString("Employee ID: " + EmpID.Text  , new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 70));
            e.Graphics.DrawString("Employee Name: " + EmployeeName.Text ,  new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 130));
            e.Graphics.DrawString("Employee Phone: " + EmpPhone.Text,  new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 180));
            e.Graphics.DrawString("Employee Address: " + EmpAdd.Text , new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 230));
            e.Graphics.DrawString("Employee Date Of Pirth: " + EmpDOFB.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 280));
            e.Graphics.DrawString("Employee Gender: " + EmpGen.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 330));
            e.Graphics.DrawString("Employee Education: " + EmpEdu.Text , new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 380));
            e.Graphics.DrawString("Employee Position: " + EmpPos.Text, new Font("Century Gothic", 22, FontStyle.Regular), Brushes.Blue, new Point(20, 430));
            e.Graphics.DrawString("=====EmpiSoft=====", new Font("Century Gothic", 25, FontStyle.Bold), Brushes.Red, new Point(160, 570));

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewEmp_Load(object sender, EventArgs e)
        {

        }
    }
}
