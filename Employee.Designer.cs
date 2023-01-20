
namespace SperMarktManagementSystem
{
    partial class Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EmpDob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.EmpPos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EmpEdu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.EmpGen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EmpName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpAdd = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmpID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnhome = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label9.ForeColor = System.Drawing.Color.OrangeRed;
            label9.Location = new System.Drawing.Point(3, 178);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(150, 19);
            label9.TabIndex = 22;
            label9.Text = "Employee Gender";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.EmpDGV);
            this.panel1.Controls.Add(this.btnhome);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.EmpDob);
            this.panel1.Controls.Add(this.EmpPos);
            this.panel1.Controls.Add(this.EmpEdu);
            this.panel1.Controls.Add(this.EmpGen);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.EmpName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.EmpPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.EmpAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmpID);
            this.panel1.Location = new System.Drawing.Point(-2, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 523);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGV.EnableHeadersVisualStyles = false;
            this.EmpDGV.GridColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.Location = new System.Drawing.Point(413, 34);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersVisible = false;
            this.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDGV.Size = new System.Drawing.Size(738, 355);
            this.EmpDGV.TabIndex = 27;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.EmpDGV.ThemeStyle.ReadOnly = false;
            this.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpDGV.ThemeStyle.RowsStyle.Height = 22;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Coral;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.OrangeRed;
            this.label8.Location = new System.Drawing.Point(214, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Employee Date Of BirthS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(214, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Employee Education";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.OrangeRed;
            this.label6.Location = new System.Drawing.Point(3, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Employee Position";
            // 
            // EmpDob
            // 
            this.EmpDob.Checked = true;
            this.EmpDob.CheckedState.Parent = this.EmpDob;
            this.EmpDob.FillColor = System.Drawing.Color.White;
            this.EmpDob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpDob.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpDob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.EmpDob.HoverState.Parent = this.EmpDob;
            this.EmpDob.Location = new System.Drawing.Point(218, 204);
            this.EmpDob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.EmpDob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.EmpDob.Name = "EmpDob";
            this.EmpDob.ShadowDecoration.Parent = this.EmpDob;
            this.EmpDob.Size = new System.Drawing.Size(187, 36);
            this.EmpDob.TabIndex = 18;
            this.EmpDob.Value = new System.DateTime(2021, 12, 13, 22, 6, 0, 815);
            // 
            // EmpPos
            // 
            this.EmpPos.BackColor = System.Drawing.Color.Transparent;
            this.EmpPos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpPos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPos.FocusedState.Parent = this.EmpPos;
            this.EmpPos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.EmpPos.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPos.HoverState.Parent = this.EmpPos;
            this.EmpPos.ItemHeight = 30;
            this.EmpPos.Items.AddRange(new object[] {
            "Manager",
            "Senior deverloper",
            "Janior developer",
            "Accounting",
            "Resptins"});
            this.EmpPos.ItemsAppearance.Parent = this.EmpPos;
            this.EmpPos.Location = new System.Drawing.Point(7, 288);
            this.EmpPos.Name = "EmpPos";
            this.EmpPos.ShadowDecoration.Parent = this.EmpPos;
            this.EmpPos.Size = new System.Drawing.Size(187, 36);
            this.EmpPos.TabIndex = 17;
            // 
            // EmpEdu
            // 
            this.EmpEdu.BackColor = System.Drawing.Color.Transparent;
            this.EmpEdu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpEdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpEdu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpEdu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpEdu.FocusedState.Parent = this.EmpEdu;
            this.EmpEdu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.EmpEdu.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpEdu.HoverState.Parent = this.EmpEdu;
            this.EmpEdu.ItemHeight = 30;
            this.EmpEdu.Items.AddRange(new object[] {
            "BTeach",
            "MTeach",
            "BBA",
            "BCA",
            "MBA",
            "BCom",
            "Mcom"});
            this.EmpEdu.ItemsAppearance.Parent = this.EmpEdu;
            this.EmpEdu.Location = new System.Drawing.Point(218, 288);
            this.EmpEdu.Name = "EmpEdu";
            this.EmpEdu.ShadowDecoration.Parent = this.EmpEdu;
            this.EmpEdu.Size = new System.Drawing.Size(187, 36);
            this.EmpEdu.TabIndex = 16;
            // 
            // EmpGen
            // 
            this.EmpGen.BackColor = System.Drawing.Color.Transparent;
            this.EmpGen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpGen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpGen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpGen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpGen.FocusedState.Parent = this.EmpGen;
            this.EmpGen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpGen.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpGen.HoverState.Parent = this.EmpGen;
            this.EmpGen.ItemHeight = 30;
            this.EmpGen.Items.AddRange(new object[] {
            "Mail",
            "Fmail"});
            this.EmpGen.ItemsAppearance.Parent = this.EmpGen;
            this.EmpGen.Location = new System.Drawing.Point(7, 204);
            this.EmpGen.Name = "EmpGen";
            this.EmpGen.ShadowDecoration.Parent = this.EmpGen;
            this.EmpGen.Size = new System.Drawing.Size(187, 36);
            this.EmpGen.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(214, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Employee Name";
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
            this.EmpName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpName.FocusedState.Parent = this.EmpName;
            this.EmpName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpName.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpName.HoverState.Parent = this.EmpName;
            this.EmpName.Location = new System.Drawing.Point(218, 60);
            this.EmpName.Name = "EmpName";
            this.EmpName.PasswordChar = '\0';
            this.EmpName.PlaceholderText = "";
            this.EmpName.SelectedText = "";
            this.EmpName.ShadowDecoration.Parent = this.EmpName;
            this.EmpName.Size = new System.Drawing.Size(187, 22);
            this.EmpName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(214, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Employee Phone";
            // 
            // EmpPhone
            // 
            this.EmpPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPhone.DefaultText = "";
            this.EmpPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPhone.DisabledState.Parent = this.EmpPhone;
            this.EmpPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPhone.FocusedState.Parent = this.EmpPhone;
            this.EmpPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpPhone.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpPhone.HoverState.Parent = this.EmpPhone;
            this.EmpPhone.Location = new System.Drawing.Point(218, 133);
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.PasswordChar = '\0';
            this.EmpPhone.PlaceholderText = "";
            this.EmpPhone.SelectedText = "";
            this.EmpPhone.ShadowDecoration.Parent = this.EmpPhone;
            this.EmpPhone.Size = new System.Drawing.Size(187, 26);
            this.EmpPhone.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(3, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Employee Address";
            // 
            // EmpAdd
            // 
            this.EmpAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpAdd.DefaultText = "";
            this.EmpAdd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmpAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmpAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAdd.DisabledState.Parent = this.EmpAdd;
            this.EmpAdd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmpAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAdd.FocusedState.Parent = this.EmpAdd;
            this.EmpAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpAdd.ForeColor = System.Drawing.Color.OrangeRed;
            this.EmpAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmpAdd.HoverState.Parent = this.EmpAdd;
            this.EmpAdd.Location = new System.Drawing.Point(7, 133);
            this.EmpAdd.Name = "EmpAdd";
            this.EmpAdd.PasswordChar = '\0';
            this.EmpAdd.PlaceholderText = "";
            this.EmpAdd.SelectedText = "";
            this.EmpAdd.ShadowDecoration.Parent = this.EmpAdd;
            this.EmpAdd.Size = new System.Drawing.Size(187, 22);
            this.EmpAdd.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Employee ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.EmpID.Location = new System.Drawing.Point(7, 60);
            this.EmpID.Name = "EmpID";
            this.EmpID.PasswordChar = '\0';
            this.EmpID.PlaceholderText = "";
            this.EmpID.SelectedText = "";
            this.EmpID.ShadowDecoration.Parent = this.EmpID;
            this.EmpID.Size = new System.Drawing.Size(187, 26);
            this.EmpID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage Employee";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SperMarktManagementSystem.Properties.Resources.multiply_24px;
            this.pictureBox2.Location = new System.Drawing.Point(1113, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SperMarktManagementSystem.Properties.Resources.employee_50px;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnhome.Location = new System.Drawing.Point(137, 409);
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
            this.btnDel.ButtonText = "Delet";
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDel.IdleBorderThickness = 1;
            this.btnDel.IdleCornerRadius = 20;
            this.btnDel.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnDel.IdleForecolor = System.Drawing.Color.White;
            this.btnDel.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnDel.Location = new System.Drawing.Point(259, 342);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 47);
            this.btnDel.TabIndex = 25;
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnEdit.ButtonText = "Edit";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.IdleBorderThickness = 1;
            this.btnEdit.IdleCornerRadius = 20;
            this.btnEdit.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.IdleForecolor = System.Drawing.Color.White;
            this.btnEdit.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnEdit.Location = new System.Drawing.Point(137, 342);
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
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.IdleForecolor = System.Drawing.Color.White;
            this.btnAdd.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.btnAdd.Location = new System.Drawing.Point(15, 342);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 47);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Employee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker EmpDob;
        private Guna.UI2.WinForms.Guna2ComboBox EmpPos;
        private Guna.UI2.WinForms.Guna2ComboBox EmpEdu;
        private Guna.UI2.WinForms.Guna2ComboBox EmpGen;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox EmpName;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox EmpPhone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox EmpAdd;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox EmpID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnhome;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView EmpDGV;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}