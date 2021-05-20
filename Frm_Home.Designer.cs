namespace MARKSCARDMANAGEMENT
{
    partial class Frm_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSubjectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_qck_srch = new System.Windows.Forms.Button();
            this.btn_qck_clear = new System.Windows.Forms.Button();
            this.picbx = new System.Windows.Forms.PictureBox();
            this.lbl_qck_regno = new System.Windows.Forms.Label();
            this.lbl_qck_name = new System.Windows.Forms.Label();
            this.lbl_qck_dob = new System.Windows.Forms.Label();
            this.lbl_qck_gender = new System.Windows.Forms.Label();
            this.lbl_qck_phno = new System.Windows.Forms.Label();
            this.lbl_qck_fname = new System.Windows.Forms.Label();
            this.lbl_qck_crs = new System.Windows.Forms.Label();
            this.lbl_qck_adhaar = new System.Windows.Forms.Label();
            this.lbl_qck_dob_display = new System.Windows.Forms.Label();
            this.lbl_qck_gender_display = new System.Windows.Forms.Label();
            this.lbl_qck_name_display = new System.Windows.Forms.Label();
            this.lbl_qck_regno_display = new System.Windows.Forms.Label();
            this.lbl_qck_adhaar_display = new System.Windows.Forms.Label();
            this.lbl_qck_crs_display = new System.Windows.Forms.Label();
            this.lbl_qck_fname_display = new System.Windows.Forms.Label();
            this.lbl_qck_phno_display = new System.Windows.Forms.Label();
            this.cmb_qck_srch = new System.Windows.Forms.ComboBox();
            this.lbl_qck_studetails = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.studentToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.courseToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.subjectMappingToolStripMenuItem,
            this.registerToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 22);
            this.toolStripMenuItem1.Text = "Create";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.courseToolStripMenuItem.Text = "New Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.subjectToolStripMenuItem.Text = "New Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // subjectMappingToolStripMenuItem
            // 
            this.subjectMappingToolStripMenuItem.Name = "subjectMappingToolStripMenuItem";
            this.subjectMappingToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.subjectMappingToolStripMenuItem.Text = "Subject Mapping";
            this.subjectMappingToolStripMenuItem.Click += new System.EventHandler(this.subjectMappingToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.registerToolStripMenuItem.Text = "New  Student";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click_1);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertMarksToolStripMenuItem,
            this.viewMarksToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.studentToolStripMenuItem.Text = "Report Card";
            // 
            // insertMarksToolStripMenuItem
            // 
            this.insertMarksToolStripMenuItem.Name = "insertMarksToolStripMenuItem";
            this.insertMarksToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.insertMarksToolStripMenuItem.Text = "Insert Marks";
            this.insertMarksToolStripMenuItem.Click += new System.EventHandler(this.insertMarksToolStripMenuItem_Click);
            // 
            // viewMarksToolStripMenuItem
            // 
            this.viewMarksToolStripMenuItem.Name = "viewMarksToolStripMenuItem";
            this.viewMarksToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.viewMarksToolStripMenuItem.Text = "View Marks";
            this.viewMarksToolStripMenuItem.Click += new System.EventHandler(this.viewMarksToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSubjectToolStripMenuItem,
            this.viewSubjectToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.viewStudentToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // viewSubjectToolStripMenuItem
            // 
            this.viewSubjectToolStripMenuItem.Name = "viewSubjectToolStripMenuItem";
            this.viewSubjectToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewSubjectToolStripMenuItem.Text = "View Course";
            this.viewSubjectToolStripMenuItem.Click += new System.EventHandler(this.viewSubjectToolStripMenuItem_Click_1);
            // 
            // viewSubjectToolStripMenuItem1
            // 
            this.viewSubjectToolStripMenuItem1.Name = "viewSubjectToolStripMenuItem1";
            this.viewSubjectToolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.viewSubjectToolStripMenuItem1.Text = "View Subject";
            this.viewSubjectToolStripMenuItem1.Click += new System.EventHandler(this.viewSubjectToolStripMenuItem1_Click_1);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem2.Text = "View Mapping";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // viewStudentToolStripMenuItem
            // 
            this.viewStudentToolStripMenuItem.Name = "viewStudentToolStripMenuItem";
            this.viewStudentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.viewStudentToolStripMenuItem.Text = "View Student";
            this.viewStudentToolStripMenuItem.Click += new System.EventHandler(this.viewStudentToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.aboutToolStripMenuItem.Text = "Home";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.homeToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help !";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Tai Le", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lbl_name.Location = new System.Drawing.Point(360, 43);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(593, 45);
            this.lbl_name.TabIndex = 4;
            this.lbl_name.Text = "STUDENT MANAGEMENT SYSTEM";
            // 
            // btn_qck_srch
            // 
            this.btn_qck_srch.BackColor = System.Drawing.SystemColors.Control;
            this.btn_qck_srch.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qck_srch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_qck_srch.Location = new System.Drawing.Point(514, 257);
            this.btn_qck_srch.Name = "btn_qck_srch";
            this.btn_qck_srch.Size = new System.Drawing.Size(125, 37);
            this.btn_qck_srch.TabIndex = 10;
            this.btn_qck_srch.Text = "SMS Search";
            this.btn_qck_srch.UseVisualStyleBackColor = false;
            this.btn_qck_srch.Click += new System.EventHandler(this.btn_qck_srch_Click);
            // 
            // btn_qck_clear
            // 
            this.btn_qck_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_qck_clear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_qck_clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_qck_clear.Location = new System.Drawing.Point(659, 257);
            this.btn_qck_clear.Name = "btn_qck_clear";
            this.btn_qck_clear.Size = new System.Drawing.Size(127, 37);
            this.btn_qck_clear.TabIndex = 12;
            this.btn_qck_clear.Text = "Clear";
            this.btn_qck_clear.UseVisualStyleBackColor = false;
            this.btn_qck_clear.Click += new System.EventHandler(this.btn_qck_clear_Click);
            // 
            // picbx
            // 
            this.picbx.Image = ((System.Drawing.Image)(resources.GetObject("picbx.Image")));
            this.picbx.Location = new System.Drawing.Point(588, 104);
            this.picbx.Name = "picbx";
            this.picbx.Size = new System.Drawing.Size(129, 79);
            this.picbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbx.TabIndex = 13;
            this.picbx.TabStop = false;
            // 
            // lbl_qck_regno
            // 
            this.lbl_qck_regno.AutoSize = true;
            this.lbl_qck_regno.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_regno.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_regno.Location = new System.Drawing.Point(62, 423);
            this.lbl_qck_regno.Name = "lbl_qck_regno";
            this.lbl_qck_regno.Size = new System.Drawing.Size(106, 31);
            this.lbl_qck_regno.TabIndex = 15;
            this.lbl_qck_regno.Text = "RegNo :";
            // 
            // lbl_qck_name
            // 
            this.lbl_qck_name.AutoSize = true;
            this.lbl_qck_name.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_name.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_name.Location = new System.Drawing.Point(62, 470);
            this.lbl_qck_name.Name = "lbl_qck_name";
            this.lbl_qck_name.Size = new System.Drawing.Size(95, 31);
            this.lbl_qck_name.TabIndex = 16;
            this.lbl_qck_name.Text = "Name :";
            // 
            // lbl_qck_dob
            // 
            this.lbl_qck_dob.AutoSize = true;
            this.lbl_qck_dob.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_dob.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_dob.Location = new System.Drawing.Point(62, 567);
            this.lbl_qck_dob.Name = "lbl_qck_dob";
            this.lbl_qck_dob.Size = new System.Drawing.Size(79, 31);
            this.lbl_qck_dob.TabIndex = 18;
            this.lbl_qck_dob.Text = "DOB :";
            // 
            // lbl_qck_gender
            // 
            this.lbl_qck_gender.AutoSize = true;
            this.lbl_qck_gender.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_gender.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_gender.Location = new System.Drawing.Point(62, 520);
            this.lbl_qck_gender.Name = "lbl_qck_gender";
            this.lbl_qck_gender.Size = new System.Drawing.Size(111, 31);
            this.lbl_qck_gender.TabIndex = 17;
            this.lbl_qck_gender.Text = "Gender :";
            // 
            // lbl_qck_phno
            // 
            this.lbl_qck_phno.AutoSize = true;
            this.lbl_qck_phno.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_phno.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_phno.Location = new System.Drawing.Point(508, 567);
            this.lbl_qck_phno.Name = "lbl_qck_phno";
            this.lbl_qck_phno.Size = new System.Drawing.Size(141, 31);
            this.lbl_qck_phno.TabIndex = 22;
            this.lbl_qck_phno.Text = "Phone No :";
            // 
            // lbl_qck_fname
            // 
            this.lbl_qck_fname.AutoSize = true;
            this.lbl_qck_fname.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_fname.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_fname.Location = new System.Drawing.Point(508, 520);
            this.lbl_qck_fname.Name = "lbl_qck_fname";
            this.lbl_qck_fname.Size = new System.Drawing.Size(173, 31);
            this.lbl_qck_fname.TabIndex = 21;
            this.lbl_qck_fname.Text = "Father Name :";
            // 
            // lbl_qck_crs
            // 
            this.lbl_qck_crs.AutoSize = true;
            this.lbl_qck_crs.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_crs.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_crs.Location = new System.Drawing.Point(508, 470);
            this.lbl_qck_crs.Name = "lbl_qck_crs";
            this.lbl_qck_crs.Size = new System.Drawing.Size(107, 31);
            this.lbl_qck_crs.TabIndex = 20;
            this.lbl_qck_crs.Text = "Course :";
            // 
            // lbl_qck_adhaar
            // 
            this.lbl_qck_adhaar.AutoSize = true;
            this.lbl_qck_adhaar.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_adhaar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_qck_adhaar.Location = new System.Drawing.Point(508, 423);
            this.lbl_qck_adhaar.Name = "lbl_qck_adhaar";
            this.lbl_qck_adhaar.Size = new System.Drawing.Size(151, 31);
            this.lbl_qck_adhaar.TabIndex = 19;
            this.lbl_qck_adhaar.Text = "Adhaar No :";
            // 
            // lbl_qck_dob_display
            // 
            this.lbl_qck_dob_display.AutoSize = true;
            this.lbl_qck_dob_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_dob_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_dob_display.Location = new System.Drawing.Point(147, 567);
            this.lbl_qck_dob_display.Name = "lbl_qck_dob_display";
            this.lbl_qck_dob_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_dob_display.TabIndex = 26;
            this.lbl_qck_dob_display.Text = "..........";
            // 
            // lbl_qck_gender_display
            // 
            this.lbl_qck_gender_display.AutoSize = true;
            this.lbl_qck_gender_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_gender_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_gender_display.Location = new System.Drawing.Point(179, 520);
            this.lbl_qck_gender_display.Name = "lbl_qck_gender_display";
            this.lbl_qck_gender_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_gender_display.TabIndex = 25;
            this.lbl_qck_gender_display.Text = "..........";
            // 
            // lbl_qck_name_display
            // 
            this.lbl_qck_name_display.AutoSize = true;
            this.lbl_qck_name_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_name_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_name_display.Location = new System.Drawing.Point(163, 470);
            this.lbl_qck_name_display.Name = "lbl_qck_name_display";
            this.lbl_qck_name_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_name_display.TabIndex = 24;
            this.lbl_qck_name_display.Text = "..........";
            // 
            // lbl_qck_regno_display
            // 
            this.lbl_qck_regno_display.AutoSize = true;
            this.lbl_qck_regno_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_regno_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_regno_display.Location = new System.Drawing.Point(174, 423);
            this.lbl_qck_regno_display.Name = "lbl_qck_regno_display";
            this.lbl_qck_regno_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_regno_display.TabIndex = 23;
            this.lbl_qck_regno_display.Text = "..........";
            // 
            // lbl_qck_adhaar_display
            // 
            this.lbl_qck_adhaar_display.AutoSize = true;
            this.lbl_qck_adhaar_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_adhaar_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_adhaar_display.Location = new System.Drawing.Point(665, 423);
            this.lbl_qck_adhaar_display.Name = "lbl_qck_adhaar_display";
            this.lbl_qck_adhaar_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_adhaar_display.TabIndex = 28;
            this.lbl_qck_adhaar_display.Text = "..........";
            // 
            // lbl_qck_crs_display
            // 
            this.lbl_qck_crs_display.AutoSize = true;
            this.lbl_qck_crs_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_crs_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_crs_display.Location = new System.Drawing.Point(621, 470);
            this.lbl_qck_crs_display.Name = "lbl_qck_crs_display";
            this.lbl_qck_crs_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_crs_display.TabIndex = 29;
            this.lbl_qck_crs_display.Text = "..........";
            // 
            // lbl_qck_fname_display
            // 
            this.lbl_qck_fname_display.AutoSize = true;
            this.lbl_qck_fname_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_fname_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_fname_display.Location = new System.Drawing.Point(687, 520);
            this.lbl_qck_fname_display.Name = "lbl_qck_fname_display";
            this.lbl_qck_fname_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_fname_display.TabIndex = 30;
            this.lbl_qck_fname_display.Text = "..........";
            // 
            // lbl_qck_phno_display
            // 
            this.lbl_qck_phno_display.AutoSize = true;
            this.lbl_qck_phno_display.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_phno_display.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_qck_phno_display.Location = new System.Drawing.Point(655, 567);
            this.lbl_qck_phno_display.Name = "lbl_qck_phno_display";
            this.lbl_qck_phno_display.Size = new System.Drawing.Size(140, 24);
            this.lbl_qck_phno_display.TabIndex = 31;
            this.lbl_qck_phno_display.Text = "..........";
            // 
            // cmb_qck_srch
            // 
            this.cmb_qck_srch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_qck_srch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_qck_srch.DropDownHeight = 100;
            this.cmb_qck_srch.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_qck_srch.FormattingEnabled = true;
            this.cmb_qck_srch.IntegralHeight = false;
            this.cmb_qck_srch.Location = new System.Drawing.Point(398, 202);
            this.cmb_qck_srch.Name = "cmb_qck_srch";
            this.cmb_qck_srch.Size = new System.Drawing.Size(477, 31);
            this.cmb_qck_srch.TabIndex = 33;
            // 
            // lbl_qck_studetails
            // 
            this.lbl_qck_studetails.AutoSize = true;
            this.lbl_qck_studetails.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qck_studetails.ForeColor = System.Drawing.Color.Red;
            this.lbl_qck_studetails.Location = new System.Drawing.Point(62, 344);
            this.lbl_qck_studetails.Name = "lbl_qck_studetails";
            this.lbl_qck_studetails.Size = new System.Drawing.Size(224, 34);
            this.lbl_qck_studetails.TabIndex = 35;
            this.lbl_qck_studetails.Text = "Students Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(976, 423);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(325, 183);
            this.dataGridView1.TabIndex = 36;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1244, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_qck_studetails);
            this.Controls.Add(this.cmb_qck_srch);
            this.Controls.Add(this.lbl_qck_phno_display);
            this.Controls.Add(this.lbl_qck_fname_display);
            this.Controls.Add(this.lbl_qck_crs_display);
            this.Controls.Add(this.lbl_qck_adhaar_display);
            this.Controls.Add(this.lbl_qck_dob_display);
            this.Controls.Add(this.lbl_qck_gender_display);
            this.Controls.Add(this.lbl_qck_name_display);
            this.Controls.Add(this.lbl_qck_regno_display);
            this.Controls.Add(this.lbl_qck_phno);
            this.Controls.Add(this.lbl_qck_fname);
            this.Controls.Add(this.lbl_qck_crs);
            this.Controls.Add(this.lbl_qck_adhaar);
            this.Controls.Add(this.lbl_qck_dob);
            this.Controls.Add(this.lbl_qck_gender);
            this.Controls.Add(this.lbl_qck_name);
            this.Controls.Add(this.lbl_qck_regno);
            this.Controls.Add(this.picbx);
            this.Controls.Add(this.btn_qck_clear);
            this.Controls.Add(this.btn_qck_srch);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STUDENT MANAGEMENT SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSubjectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_qck_srch;
        private System.Windows.Forms.Button btn_qck_clear;
        private System.Windows.Forms.PictureBox picbx;
        private System.Windows.Forms.Label lbl_qck_regno;
        private System.Windows.Forms.Label lbl_qck_name;
        private System.Windows.Forms.Label lbl_qck_dob;
        private System.Windows.Forms.Label lbl_qck_gender;
        private System.Windows.Forms.Label lbl_qck_phno;
        private System.Windows.Forms.Label lbl_qck_fname;
        private System.Windows.Forms.Label lbl_qck_crs;
        private System.Windows.Forms.Label lbl_qck_adhaar;
        private System.Windows.Forms.Label lbl_qck_dob_display;
        private System.Windows.Forms.Label lbl_qck_gender_display;
        private System.Windows.Forms.Label lbl_qck_name_display;
        private System.Windows.Forms.Label lbl_qck_regno_display;
        private System.Windows.Forms.Label lbl_qck_adhaar_display;
        private System.Windows.Forms.Label lbl_qck_crs_display;
        private System.Windows.Forms.Label lbl_qck_fname_display;
        private System.Windows.Forms.Label lbl_qck_phno_display;
        private System.Windows.Forms.ComboBox cmb_qck_srch;
        private System.Windows.Forms.Label lbl_qck_studetails;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}