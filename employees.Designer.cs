namespace WindowsFormsApp1
{
    partial class employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employees));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EmpNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DailySalTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GenCb = new System.Windows.Forms.ComboBox();
            this.DepCb = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.DOBTb = new Guna.UI.WinForms.GunaDateTimePicker();
            this.JData = new Guna.UI.WinForms.GunaDateTimePicker();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EmployeeList = new Guna.UI.WinForms.GunaDataGridView();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1253, 139);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "employee M S Version 1.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(593, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage Employees";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(140, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "employee name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTb.Location = new System.Drawing.Point(145, 289);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(240, 30);
            this.EmpNameTb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(140, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "employee gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(140, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "date of birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(140, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "employee department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(140, 649);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "employee daliy salary";
            // 
            // DailySalTb
            // 
            this.DailySalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailySalTb.Location = new System.Drawing.Point(145, 677);
            this.DailySalTb.Name = "DailySalTb";
            this.DailySalTb.Size = new System.Drawing.Size(240, 30);
            this.DailySalTb.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(140, 575);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "join date";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Teal;
            this.flowLayoutPanel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 802);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1253, 42);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // GenCb
            // 
            this.GenCb.FormattingEnabled = true;
            this.GenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenCb.Location = new System.Drawing.Point(145, 372);
            this.GenCb.Name = "GenCb";
            this.GenCb.Size = new System.Drawing.Size(240, 33);
            this.GenCb.TabIndex = 24;
            // 
            // DepCb
            // 
            this.DepCb.FormattingEnabled = true;
            this.DepCb.Location = new System.Drawing.Point(145, 445);
            this.DepCb.Name = "DepCb";
            this.DepCb.Size = new System.Drawing.Size(240, 33);
            this.DepCb.TabIndex = 25;
            // 
            // DOBTb
            // 
            this.DOBTb.BackColor = System.Drawing.Color.Teal;
            this.DOBTb.BaseColor = System.Drawing.Color.White;
            this.DOBTb.BorderColor = System.Drawing.Color.Silver;
            this.DOBTb.CustomFormat = null;
            this.DOBTb.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DOBTb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DOBTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DOBTb.ForeColor = System.Drawing.Color.Black;
            this.DOBTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBTb.Location = new System.Drawing.Point(145, 519);
            this.DOBTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DOBTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DOBTb.Name = "DOBTb";
            this.DOBTb.OnHoverBaseColor = System.Drawing.Color.White;
            this.DOBTb.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DOBTb.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DOBTb.OnPressedColor = System.Drawing.Color.Black;
            this.DOBTb.Size = new System.Drawing.Size(240, 41);
            this.DOBTb.TabIndex = 27;
            this.DOBTb.Text = "1/25/2023";
            this.DOBTb.Value = new System.DateTime(2023, 1, 25, 20, 6, 32, 729);
            this.DOBTb.ValueChanged += new System.EventHandler(this.gunaDateTimePicker1_ValueChanged);
            // 
            // JData
            // 
            this.JData.BackColor = System.Drawing.Color.Teal;
            this.JData.BaseColor = System.Drawing.Color.White;
            this.JData.BorderColor = System.Drawing.Color.Silver;
            this.JData.CustomFormat = null;
            this.JData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.JData.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.JData.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JData.ForeColor = System.Drawing.Color.Black;
            this.JData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.JData.Location = new System.Drawing.Point(145, 603);
            this.JData.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.JData.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.JData.Name = "JData";
            this.JData.OnHoverBaseColor = System.Drawing.Color.White;
            this.JData.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.JData.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.JData.OnPressedColor = System.Drawing.Color.Black;
            this.JData.Size = new System.Drawing.Size(240, 41);
            this.JData.TabIndex = 28;
            this.JData.Text = "1/25/2023";
            this.JData.Value = new System.DateTime(2023, 1, 25, 20, 6, 32, 729);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(145, 713);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(111, 45);
            this.AddBtn.TabIndex = 29;
            this.AddBtn.Text = "add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.UpdateBtn.Location = new System.Drawing.Point(274, 713);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(111, 45);
            this.UpdateBtn.TabIndex = 30;
            this.UpdateBtn.Text = "update";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(967, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 25);
            this.label9.TabIndex = 68;
            this.label9.Text = "logout";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(895, 143);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 67;
            this.pictureBox4.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(792, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 66;
            this.label10.Text = "salary";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(720, 143);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(63, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(594, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "departments";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(522, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Teal;
            this.label12.Location = new System.Drawing.Point(419, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 25);
            this.label12.TabIndex = 62;
            this.label12.Text = "employee";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(347, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 61;
            this.pictureBox2.TabStop = false;
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeList.BackgroundColor = System.Drawing.Color.White;
            this.EmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeeList.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeeList.EnableHeadersVisualStyles = false;
            this.EmployeeList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeList.Location = new System.Drawing.Point(424, 320);
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.RowHeadersVisible = false;
            this.EmployeeList.RowHeadersWidth = 51;
            this.EmployeeList.RowTemplate.Height = 24;
            this.EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeList.Size = new System.Drawing.Size(587, 406);
            this.EmployeeList.TabIndex = 69;
            this.EmployeeList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeeList.ThemeStyle.HeaderStyle.Height = 25;
            this.EmployeeList.ThemeStyle.ReadOnly = false;
            this.EmployeeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeList.ThemeStyle.RowsStyle.Height = 24;
            this.EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(663, 703);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(111, 45);
            this.DeleteBtn.TabIndex = 70;
            this.DeleteBtn.Text = "delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1253, 844);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.JData);
            this.Controls.Add(this.DOBTb);
            this.Controls.Add(this.DepCb);
            this.Controls.Add(this.GenCb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DailySalTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "employees";
            this.Text = "employees";
            this.Load += new System.EventHandler(this.employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DailySalTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox GenCb;
        private System.Windows.Forms.ComboBox DepCb;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Guna.UI.WinForms.GunaDateTimePicker DOBTb;
        private Guna.UI.WinForms.GunaDateTimePicker JData;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI.WinForms.GunaDataGridView EmployeeList;
        private System.Windows.Forms.Button DeleteBtn;
    }
}