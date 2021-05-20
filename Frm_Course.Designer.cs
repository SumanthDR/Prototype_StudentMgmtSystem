namespace MARKSCARDMANAGEMENT
{
    partial class Frm_Course
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
            this.components = new System.ComponentModel.Container();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.txtbx_coursename = new System.Windows.Forms.TextBox();
            this.lbl_coursename = new System.Windows.Forms.Label();
            this.lbl_coursedescrp = new System.Windows.Forms.Label();
            this.txtbx_coursedescrp = new System.Windows.Forms.TextBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbx_coursecode = new System.Windows.Forms.TextBox();
            this.err_crs_code = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_crs_name = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_status = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_name)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ok.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ok.Location = new System.Drawing.Point(424, 373);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(87, 28);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_heading
            // 
            this.lbl_heading.AutoSize = true;
            this.lbl_heading.BackColor = System.Drawing.Color.Transparent;
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(216, 36);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(97, 28);
            this.lbl_heading.TabIndex = 1;
            this.lbl_heading.Text = "COURSE";
            this.lbl_heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbx_coursename
            // 
            this.txtbx_coursename.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_coursename.Location = new System.Drawing.Point(185, 196);
            this.txtbx_coursename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbx_coursename.Name = "txtbx_coursename";
            this.txtbx_coursename.Size = new System.Drawing.Size(326, 26);
            this.txtbx_coursename.TabIndex = 1;
            this.txtbx_coursename.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_coursename_KeyPress);
            // 
            // lbl_coursename
            // 
            this.lbl_coursename.AutoSize = true;
            this.lbl_coursename.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coursename.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursename.Location = new System.Drawing.Point(58, 200);
            this.lbl_coursename.Name = "lbl_coursename";
            this.lbl_coursename.Size = new System.Drawing.Size(121, 22);
            this.lbl_coursename.TabIndex = 3;
            this.lbl_coursename.Text = "Course Name :";
            // 
            // lbl_coursedescrp
            // 
            this.lbl_coursedescrp.AutoSize = true;
            this.lbl_coursedescrp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_coursedescrp.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_coursedescrp.Location = new System.Drawing.Point(15, 242);
            this.lbl_coursedescrp.Name = "lbl_coursedescrp";
            this.lbl_coursedescrp.Size = new System.Drawing.Size(164, 22);
            this.lbl_coursedescrp.TabIndex = 4;
            this.lbl_coursedescrp.Text = "Course Description :";
            // 
            // txtbx_coursedescrp
            // 
            this.txtbx_coursedescrp.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_coursedescrp.Location = new System.Drawing.Point(185, 240);
            this.txtbx_coursedescrp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbx_coursedescrp.Multiline = true;
            this.txtbx_coursedescrp.Name = "txtbx_coursedescrp";
            this.txtbx_coursedescrp.Size = new System.Drawing.Size(326, 126);
            this.txtbx_coursedescrp.TabIndex = 3;
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_cancle.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancle.Location = new System.Drawing.Point(305, 373);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(87, 27);
            this.btn_cancle.TabIndex = 4;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(99, 101);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course Code :";
            // 
            // txtbx_coursecode
            // 
            this.txtbx_coursecode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_coursecode.Location = new System.Drawing.Point(185, 153);
            this.txtbx_coursecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbx_coursecode.Name = "txtbx_coursecode";
            this.txtbx_coursecode.Size = new System.Drawing.Size(207, 26);
            this.txtbx_coursecode.TabIndex = 0;
            this.txtbx_coursecode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbx_coursecode_KeyPress);
            // 
            // err_crs_code
            // 
            this.err_crs_code.ContainerControl = this;
            // 
            // err_crs_name
            // 
            this.err_crs_name.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Status :-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.label_status);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 30);
            this.panel1.TabIndex = 11;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.Location = new System.Drawing.Point(75, 5);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 19);
            this.label_status.TabIndex = 11;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Update.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Update.Location = new System.Drawing.Point(424, 374);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(87, 27);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Visible = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_edit.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_edit.Location = new System.Drawing.Point(239, 400);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(87, 27);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Visible = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Red;
            this.btn_Close.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(485, -2);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(46, 31);
            this.btn_Close.TabIndex = 14;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // Frm_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MARKSCARDMANAGEMENT.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(531, 467);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbx_coursecode);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.txtbx_coursedescrp);
            this.Controls.Add(this.lbl_coursedescrp);
            this.Controls.Add(this.lbl_coursename);
            this.Controls.Add(this.txtbx_coursename);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.btn_ok);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_crs_name)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.TextBox txtbx_coursename;
        private System.Windows.Forms.Label lbl_coursename;
        private System.Windows.Forms.Label lbl_coursedescrp;
        private System.Windows.Forms.TextBox txtbx_coursedescrp;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbx_coursecode;
        private System.Windows.Forms.ErrorProvider err_crs_code;
        private System.Windows.Forms.ErrorProvider err_crs_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_Close;
    }
}

