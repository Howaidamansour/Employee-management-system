
namespace SperMarktManagementSystem
{
    partial class Salary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ritchsalary = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpPos = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpWD = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmpName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnhome = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.OrangeRed;
            label9.Location = new System.Drawing.Point(25, 267);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(109, 19);
            label9.TabIndex = 22;
            label9.Text = "Worked Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(110, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Salary";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ritchsalary);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.EmpWD);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmpID);
            this.panel1.Location = new System.Drawing.Point(-3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 523);
            this.panel1.TabIndex = 10;
            // 
            // ritchsalary
            // 
            this.ritchsalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ritchsalary.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ritchsalary.ForeColor = System.Drawing.Color.Navy;
            this.ritchsalary.Location = new System.Drawing.Point(561, 49);
            this.ritchsalary.Name = "ritchsalary";
            this.ritchsalary.Size = new System.Drawing.Size(560, 355);
            this.ritchsalary.TabIndex = 27;
            this.ritchsalary.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(25, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Employee Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Employee Name";
            // 
            // EmpPos
            // 
            this.EmpPos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPos.DefaultText = "";
            this.EmpPos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpPos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpPos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPos.DisabledState.Parent = this.EmpPos;
            this.EmpPos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPos.Enabled = false;
            this.EmpPos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPos.FocusedState.Parent = this.EmpPos;
            this.EmpPos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpPos.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPos.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPos.HoverState.Parent = this.EmpPos;
            this.EmpPos.Location = new System.Drawing.Point(24, 225);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.PasswordChar = '\0';
            this.EmpPos.PlaceholderText = "";
            this.EmpPos.SelectedText = "";
            this.EmpPos.ShadowDecoration.Parent = this.EmpPos;
            this.EmpPos.Size = new System.Drawing.Size(228, 26);
            this.EmpPos.TabIndex = 13;
            this.EmpPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EmpWD
            // 
            this.EmpWD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpWD.DefaultText = "";
            this.EmpWD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpWD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpWD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpWD.DisabledState.Parent = this.EmpWD;
            this.EmpWD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpWD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpWD.FocusedState.Parent = this.EmpWD;
            this.EmpWD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpWD.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpWD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpWD.HoverState.Parent = this.EmpWD;
            this.EmpWD.Location = new System.Drawing.Point(24, 298);
            this.EmpWD.Name = "EmpWD";
            this.EmpWD.PasswordChar = '\0';
            this.EmpWD.PlaceholderText = "";
            this.EmpWD.SelectedText = "";
            this.EmpWD.ShadowDecoration.Parent = this.EmpWD;
            this.EmpWD.Size = new System.Drawing.Size(228, 26);
            this.EmpWD.TabIndex = 11;
            // 
            // EmpName
            // 
            this.EmpName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpName.DefaultText = "";
            this.EmpName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpName.DisabledState.Parent = this.EmpName;
            this.EmpName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpName.Enabled = false;
            this.EmpName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpName.FocusedState.Parent = this.EmpName;
            this.EmpName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpName.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpName.HoverState.Parent = this.EmpName;
            this.EmpName.Location = new System.Drawing.Point(23, 148);
            this.EmpName.Name = "EmpName";
            this.EmpName.PasswordChar = '\0';
            this.EmpName.PlaceholderText = "";
            this.EmpName.SelectedText = "";
            this.EmpName.ShadowDecoration.Parent = this.EmpName;
            this.EmpName.Size = new System.Drawing.Size(228, 26);
            this.EmpName.TabIndex = 9;
            this.EmpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.EmpName.TextChanged += new System.EventHandler(this.EmpAdd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            // 
            // EmpID
            // 
            this.EmpID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpID.DefaultText = "";
            this.EmpID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpID.DisabledState.Parent = this.EmpID;
            this.EmpID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpID.FocusedState.Parent = this.EmpID;
            this.EmpID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpID.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpID.HoverState.Parent = this.EmpID;
            this.EmpID.Location = new System.Drawing.Point(23, 75);
            this.EmpID.Margin = new System.Windows.Forms.Padding(4);
            this.EmpID.Name = "EmpID";
            this.EmpID.PasswordChar = '\0';
            this.EmpID.PlaceholderText = "";
            this.EmpID.SelectedText = "";
            this.EmpID.ShadowDecoration.Parent = this.EmpID;
            this.EmpID.Size = new System.Drawing.Size(228, 26);
            this.EmpID.TabIndex = 7;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnhome
            // 
            this.btnhome.ActiveBorderThickness = 1;
            this.btnhome.ActiveCornerRadius = 20;
            this.btnhome.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnhome.ActiveForecolor = System.Drawing.Color.White;
            this.btnhome.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnhome.BackColor = System.Drawing.Color.White;
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.ButtonText = "Home";
            this.btnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnhome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnhome.IdleBorderThickness = 1;
            this.btnhome.IdleCornerRadius = 20;
            this.btnhome.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnhome.IdleForecolor = System.Drawing.Color.White;
            this.btnhome.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnhome.Location = new System.Drawing.Point(23, 378);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(110, 47);
            this.btnhome.TabIndex = 26;
            this.btnhome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnDel
            // 
            this.btnDel.ActiveBorderThickness = 1;
            this.btnDel.ActiveCornerRadius = 20;
            this.btnDel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDel.ActiveForecolor = System.Drawing.Color.White;
            this.btnDel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDel.BackColor = System.Drawing.Color.White;
            this.btnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDel.BackgroundImage")));
            this.btnDel.ButtonText = "Fetch Data";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDel.IdleBorderThickness = 1;
            this.btnDel.IdleCornerRadius = 20;
            this.btnDel.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnDel.IdleForecolor = System.Drawing.Color.White;
            this.btnDel.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnDel.Location = new System.Drawing.Point(342, 49);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 47);
            this.btnDel.TabIndex = 25;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.ActiveBorderThickness = 1;
            this.btnEdit.ActiveCornerRadius = 20;
            this.btnEdit.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.btnEdit.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ButtonText = "Print";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.IdleForecolor = System.Drawing.Color.White;
            this.btnEdit.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.Location = new System.Drawing.Point(783, 424);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 47);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "View";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnAdd.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.Location = new System.Drawing.Point(142, 378);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 47);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SperMarktManagementSystem.Properties.Resources.multiply_24px;
            this.pictureBox2.Location = new System.Drawing.Point(1112, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SperMarktManagementSystem.Properties.Resources.salary_male_24px;
            this.pictureBox1.Location = new System.Drawing.Point(21, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Salary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Salary";
            this.Text = "Salary";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnhome;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox EmpPos;
        private Guna.UI2.WinForms.Guna2TextBox EmpWD;
        private Guna.UI2.WinForms.Guna2TextBox EmpName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox EmpID;
        private System.Windows.Forms.RichTextBox ritchsalary;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}