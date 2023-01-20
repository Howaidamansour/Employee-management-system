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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-3RV0S3S;Initial Catalog=EmployeesDB;Integrated Security=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(EmpID.Text=="" || EmpName.Text=="" || EmpAdd.Text=="" || EmpPhone.Text=="" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string  query = "insert into EmployeeTb1 values('"+EmpID.Text+"','"+EmpName.Text+"','"+EmpAdd.Text+"','"+EmpPos.SelectedItem.ToString()+"','"+ EmpDob.Value.Date+"','"+EmpPhone.Text+"','" +EmpGen.SelectedItem.ToString()+"','"+ EmpEdu.SelectedItem.ToString()+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Employee Successfully Aded");
                    con.Close();
                    populator();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
        public void populator()
        {
            con.Open();
            string query = "SELECT *  FROM EmployeeTb1 ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populator();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from EmployeeTb1 where empID='" + EmpID.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Deleted Aded");
                    con.Close();
                    populator();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EmpID.Text = EmpDGV.SelectedRows[0].Cells[0].Value.ToString();
            EmpName.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpAdd.Text = EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpPhone.Text = EmpDGV.SelectedRows[0].Cells[5].Value.ToString();
            EmpPos.Text = EmpDGV.SelectedRows[0].Cells[3].Value.ToString();
            EmpEdu.Text = EmpDGV.SelectedRows[0].Cells[7].Value.ToString();
            EmpGen.Text = EmpDGV.SelectedRows[0].Cells[6].Value.ToString();
            EmpDob.Text = EmpDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (EmpID.Text == "" || EmpName.Text == "" || EmpAdd.Text == "" || EmpPhone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update EmployeeTb1 set empName='" +EmpName.Text + "', empAdd=  '"+EmpAdd.Text +"', empPos = '"+EmpPos.SelectedItem.ToString() + "',empDOB = '"+ EmpDob.Value.Date + "',empPhone ='"+ EmpPhone.Text + "',empGender ='"+ EmpGen.SelectedItem.ToString() + "',empEdu = '" + EmpEdu.SelectedItem.ToString() + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated Successfully ");
                    con.Close();
                    populator();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.ShowDialog();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
