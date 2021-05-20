namespace MARKSCARDMANAGEMENT
{
    partial class Frm_MarksCard
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
            this.cmb_sem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_Regno = new System.Windows.Forms.TextBox();
            this.txtbx_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.txtbx_max_mks = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbx_gtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbx_gtotal_words = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbx_result = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_sgpa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_per = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtbx_coursename = new System.Windows.Forms.TextBox();
            this.btn_clearall = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbx_year = new System.Windows.Forms.TextBox();
            this.chkbx_year = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_sem
            // 
            this.cmb_sem.FormattingEnabled = true;
            this.cmb_sem.Items.AddRange(new object[] {
            "I",
            "II",
            "III",
            "IV",
            "V",
            "VI"});
            this.cmb_sem.Location = new System.Drawing.Point(1047, 88);
            this.cmb_sem.Name = "cmb_sem";
            this.cmb_sem.Size = new System.Drawing.Size(50, 21);
            this.cmb_sem.TabIndex = 1;
            this.cmb_sem.SelectedIndexChanged += new System.EventHandler(this.cmb_sem_SelectedIndexChanged);
            this.cmb_sem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_sem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "USN / Reg. No :";
            // 
            // txtbx_Regno
            // 
            this.txtbx_Regno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbx_Regno.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Regno.Location = new System.Drawing.Point(121, 88);
            this.txtbx_Regno.Name = "txtbx_Regno";
            this.txtbx_Regno.Size = new System.Drawing.Size(186, 24);
            this.txtbx_Regno.TabIndex = 0;
            this.txtbx_Regno.TextChanged += new System.EventHandler(this.txtbx_Regno_TextChanged);
            // 
            // txtbx_name
            // 
            this.txtbx_name.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_name.Location = new System.Drawing.Point(410, 88);
            this.txtbx_name.Name = "txtbx_name";
            this.txtbx_name.ReadOnly = true;
            this.txtbx_name.Size = new System.Drawing.Size(221, 24);
            this.txtbx_name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(352, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(973, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Semester :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(664, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(29, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1267, 256);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sl. No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.Location = new System.Drawing.Point(1197, 529);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // txtbx_max_mks
            // 
            this.txtbx_max_mks.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_max_mks.Enabled = false;
            this.txtbx_max_mks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_max_mks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_max_mks.Location = new System.Drawing.Point(146, 556);
            this.txtbx_max_mks.Name = "txtbx_max_mks";
            this.txtbx_max_mks.ReadOnly = true;
            this.txtbx_max_mks.Size = new System.Drawing.Size(134, 21);
            this.txtbx_max_mks.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Max. Marks : ";
            // 
            // txtbx_gtotal
            // 
            this.txtbx_gtotal.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_gtotal.Enabled = false;
            this.txtbx_gtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_gtotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_gtotal.Location = new System.Drawing.Point(382, 556);
            this.txtbx_gtotal.Name = "txtbx_gtotal";
            this.txtbx_gtotal.ReadOnly = true;
            this.txtbx_gtotal.Size = new System.Drawing.Size(134, 21);
            this.txtbx_gtotal.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(304, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Grand Total : ";
            // 
            // txtbx_gtotal_words
            // 
            this.txtbx_gtotal_words.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_gtotal_words.Enabled = false;
            this.txtbx_gtotal_words.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_gtotal_words.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_gtotal_words.Location = new System.Drawing.Point(146, 583);
            this.txtbx_gtotal_words.Name = "txtbx_gtotal_words";
            this.txtbx_gtotal_words.ReadOnly = true;
            this.txtbx_gtotal_words.Size = new System.Drawing.Size(672, 21);
            this.txtbx_gtotal_words.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Grand Total (words) : ";
            // 
            // txtbx_result
            // 
            this.txtbx_result.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_result.Enabled = false;
            this.txtbx_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_result.Location = new System.Drawing.Point(382, 610);
            this.txtbx_result.Name = "txtbx_result";
            this.txtbx_result.ReadOnly = true;
            this.txtbx_result.Size = new System.Drawing.Size(134, 21);
            this.txtbx_result.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(330, 615);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Result : ";
            // 
            // txtbx_sgpa
            // 
            this.txtbx_sgpa.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_sgpa.Enabled = false;
            this.txtbx_sgpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_sgpa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_sgpa.Location = new System.Drawing.Point(146, 610);
            this.txtbx_sgpa.Name = "txtbx_sgpa";
            this.txtbx_sgpa.ReadOnly = true;
            this.txtbx_sgpa.Size = new System.Drawing.Size(134, 21);
            this.txtbx_sgpa.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "SGPA : ";
            // 
            // txtbx_per
            // 
            this.txtbx_per.BackColor = System.Drawing.Color.Honeydew;
            this.txtbx_per.Enabled = false;
            this.txtbx_per.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_per.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtbx_per.Location = new System.Drawing.Point(660, 610);
            this.txtbx_per.Name = "txtbx_per";
            this.txtbx_per.ReadOnly = true;
            this.txtbx_per.Size = new System.Drawing.Size(134, 21);
            this.txtbx_per.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(583, 615);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Percentage : ";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1197, 558);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancle.Location = new System.Drawing.Point(1116, 558);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_cancle.TabIndex = 5;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(539, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "INSERT MARKS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(280, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Subsidiary Subjects (Not Added To Total Marks)";
            // 
            // txtbx_coursename
            // 
            this.txtbx_coursename.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_coursename.Location = new System.Drawing.Point(728, 88);
            this.txtbx_coursename.Name = "txtbx_coursename";
            this.txtbx_coursename.ReadOnly = true;
            this.txtbx_coursename.Size = new System.Drawing.Size(202, 24);
            this.txtbx_coursename.TabIndex = 31;
            // 
            // btn_clearall
            // 
            this.btn_clearall.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearall.Location = new System.Drawing.Point(1035, 558);
            this.btn_clearall.Name = "btn_clearall";
            this.btn_clearall.Size = new System.Drawing.Size(75, 23);
            this.btn_clearall.TabIndex = 32;
            this.btn_clearall.Text = "Clear All";
            this.btn_clearall.UseVisualStyleBackColor = true;
            this.btn_clearall.Click += new System.EventHandler(this.btn_clearall_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(29, 433);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1267, 86);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView2_EditingControlShowing);
            this.dataGridView2.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView2_RowPostPaint_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Sl. No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // txtbx_year
            // 
            this.txtbx_year.Location = new System.Drawing.Point(1155, 119);
            this.txtbx_year.Name = "txtbx_year";
            this.txtbx_year.Size = new System.Drawing.Size(75, 20);
            this.txtbx_year.TabIndex = 35;
            this.txtbx_year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_year_KeyPress);
            // 
            // chkbx_year
            // 
            this.chkbx_year.AutoSize = true;
            this.chkbx_year.BackColor = System.Drawing.Color.Transparent;
            this.chkbx_year.Location = new System.Drawing.Point(1236, 122);
            this.chkbx_year.Name = "chkbx_year";
            this.chkbx_year.Size = new System.Drawing.Size(48, 17);
            this.chkbx_year.TabIndex = 36;
            this.chkbx_year.Text = "Year";
            this.chkbx_year.UseVisualStyleBackColor = false;
            this.chkbx_year.CheckedChanged += new System.EventHandler(this.chkbx_year_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Status :-";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(64, 4);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 16);
            this.label_status.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(-1, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1361, 24);
            this.panel1.TabIndex = 33;
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(1316, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(44, 33);
            this.btn_Close.TabIndex = 37;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(1197, 558);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 38;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Frm_MarksCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::MARKSCARDMANAGEMENT.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(1360, 674);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.chkbx_year);
            this.Controls.Add(this.txtbx_year);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clearall);
            this.Controls.Add(this.txtbx_coursename);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtbx_per);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbx_result);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbx_sgpa);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_gtotal_words);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbx_gtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbx_max_mks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbx_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_Regno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_sem);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_MarksCard";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_MarksCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_sem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_Regno;
        private System.Windows.Forms.TextBox txtbx_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox txtbx_max_mks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbx_gtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbx_gtotal_words;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbx_result;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_sgpa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_per;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtbx_coursename;
        private System.Windows.Forms.Button btn_clearall;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TextBox txtbx_year;
        private System.Windows.Forms.CheckBox chkbx_year;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_update;
    }
}