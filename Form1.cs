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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        int startpoint = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            myPrograss.Value = startpoint;
            if(myPrograss.Value==100)
            {
                myPrograss.Value = 0;
                timer2.Stop();
                this.Hide();
                Login log = new Login();
                log.ShowDialog();
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }
    }
}
