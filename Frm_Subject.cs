using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_Subject : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        int flag = 2, flag1 = 2,flag2=2,flag3=2,flag4=2;
        public string message;
        ArrayList my = new ArrayList();
        public Frm_Subject()
        {
            InitializeComponent();
        }

      
        // Method to insert and update subject //

        private void InsertUpdateSubject(string prc,int temp)
        {
            int sum = 0;
            Frm_Home.txtvalidate_Code(txtbx_SubCode, err_SubCode, label_status);
            Frm_Home.txtvalidate_Name(txtbx_SubName, err_SubName, label_status);
            Txtvalidate_ThMaxMarks(txtbx_sub_thMax, err_SubThMax, label_status);
            Txtvalidate_ThMinMarks(txtbx_sub_thMin, err_SubThMin, label_status);
            Txtvalidate_IAMaxMarks(txtbx_sub_IAMax, err_IAMax, label_status);
            Txtvalidate_IAMinMarks(txtbx_sub_IAMin, err_IAMin, label_status);
            cmbcheck(cmb_coursename, err_SubCrs, label_status);
            if ((Frm_Home.var == 0) && (Frm_Home.var1 == 0) && (flag2 == 0) && (flag3 == 0) && (flag == 0) && (flag1 == 0) && (my.Contains(0)))
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand(prc, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("@CrsId", cmb_coursename.SelectedValue);
                    if (temp == 1)
                     cmd.Parameters.AddWithValue("@Sub_Id", Frm_SubView.id);
                    cmd.Parameters.AddWithValue("@Sub_Code", txtbx_SubCode.Text);
                    cmd.Parameters.AddWithValue("@Sub_Name", txtbx_SubName.Text);
                    cmd.Parameters.AddWithValue("@Sub_Descript", txtbx_SubDesc.Text);
                    cmd.Parameters.AddWithValue("@Sub_Category", cmb_Category.Text);
                    cmd.Parameters.AddWithValue("@Sub_th_Max", txtbx_sub_thMax.Text);
                    cmd.Parameters.AddWithValue("@Sub_th_Min", txtbx_sub_thMin.Text);
                    cmd.Parameters.AddWithValue("@Sub_IA_Max", txtbx_sub_IAMax.Text);
                    cmd.Parameters.AddWithValue("@Sub_IA_Min", txtbx_sub_IAMin.Text);
                    if ((txtbx_sub_IAMax.Enabled == false) && (txtbx_sub_IAMin.Enabled == false))
                        sum = (0) + (Convert.ToInt32(txtbx_sub_thMax.Text));
                    else
                        sum = (Convert.ToInt32(txtbx_sub_IAMax.Text)) + (Convert.ToInt32(txtbx_sub_thMax.Text));
                    cmd.Parameters.AddWithValue("@Sub_Sum_th_IA", sum.ToString());
                    cmd.Parameters.AddWithValue("@Sub_Ins_Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@Course_Id", cmb_coursename.SelectedValue);
                    cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                    cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    message = (string)cmd.Parameters["@ERROR"].Value;
                    label_status.Text = message;
                   // MessageBox.Show(" Operation Successful.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\t Something went wrong please try again !! \n\n" + ex);
                }
                finally
                {
                    con.Close();
                    ClearTextBoxes();
                    cmb_Category.Text = "";
                }
            }
            my.Clear();
        }
        //============================CLEARS ALL TEXTBOXES=============== //
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        //==============================================================================================//
        //--------------------------------- EVENTS---------------------------------------------------- //

        // DISABLE KEYPRESS//
        private void cmb_Category_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_coursename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*

        //accept only alphanumeric//
        private void txtbx_SubCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = true;
        }
        
        //accept only alphabets//
        private void txtbx_SubName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
        */

        //============================ VALIDATION ================================================//
        private void Txtvalidate_ThMaxMarks(TextBox txtbx,ErrorProvider err,Label lbl)
        {
            int len_maxmarks = txtbx.Text.Length;
            if (txtbx.Text == "")
            {
                err.SetError(txtbx, "Max. Marks Field is Compulsory");
                lbl.Text = "ERROR!. -Please, Enter the Max. Marks.";
                flag = 1;
            }
            else if ((len_maxmarks < 1) || (len_maxmarks > 3) || (txtbx.Text.Any(c => !(Char.IsNumber(c)))))
            {
                err.SetError(txtbx, "Invalid Marks");
                lbl.Text = "ERROR!. -Please, Enter a valid marks.";
                flag = 1;
            }
            else
            {
                err.SetError(txtbx, "");
                flag = 0;
            }
        }
        private void Txtvalidate_ThMinMarks(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_maxmarks = txtbx.Text.Length;
            if (txtbx.Text == "")
            {
                err.SetError(txtbx, "Min. Marks Field is Compulsory");
                lbl.Text = "ERROR!. -Please, Enter the Min. Marks.";
                flag1 = 1;
            }
            else if ((len_maxmarks < 1) || (len_maxmarks > 3) || (txtbx.Text.Any(c => !(Char.IsNumber(c)))))
            {
                err.SetError(txtbx, "Invalid Marks");
                lbl.Text = "ERROR!. -Please, Enter a valid marks.";
                flag1 = 1;
            }
            else
            {
                if ((flag == 0) && (Int32.Parse(txtbx_sub_thMax.Text) < Int32.Parse(txtbx.Text)))
                {
                    err.SetError(txtbx, "Min. Marks should be less than Max.Marks");
                    lbl.Text = "ERROR!. -Min. Marks should be less than Max.Marks";
                    flag1 = 1;
                }
                else
                {
                    err.SetError(txtbx, "");
                    flag1 = 0;
                }
            }
        }
        private void Txtvalidate_IAMaxMarks(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_maxmarks = txtbx.Text.Length;
            if(chkbx_IA.Checked==true)
            {
                txtbx_sub_IAMax.Enabled = false;
                err.SetError(txtbx, "");
                flag2 = 0;
            }
            else
            {
                if (txtbx.Text == "")
                {
                    err.SetError(txtbx, "Max. Marks Field is Compulsory");
                    lbl.Text = "ERROR!. -Please, Enter the Max. Marks.";
                    flag2 = 1;
                }
                else if ((len_maxmarks < 1) || (len_maxmarks > 3) || (txtbx.Text.Any(c => !(Char.IsNumber(c)))))
                {
                    err.SetError(txtbx, "Invalid Marks");
                    lbl.Text = "ERROR!. -Please, Enter a valid marks.";
                    flag2 = 1;
                }
                else
                {
                    err.SetError(txtbx, "");
                    flag2 = 0;
                }
            }           
        }
        private void Txtvalidate_IAMinMarks(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_maxmarks = txtbx.Text.Length;
            if (chkbx_IA.Checked == true)
            {
                txtbx_sub_IAMin.Enabled = false;
                err.SetError(txtbx, "");
                flag3 = 0;
            }
            else
            {
                if (txtbx.Text == "")
                {
                    err.SetError(txtbx, "Min. Marks Field is Compulsory");
                    lbl.Text = "ERROR!. -Please, Enter the Min. Marks.";
                    flag3 = 1;
                }
                else if ((len_maxmarks < 1) || (len_maxmarks > 3) || (txtbx.Text.Any(c => !(Char.IsNumber(c)))))
                {
                    err.SetError(txtbx, "Invalid Marks");
                    lbl.Text = "ERROR!. -Please, Enter a valid marks.";
                    flag3 = 1;
                }
                else
                {
                    if ((flag2 == 0) && ((Int32.Parse(txtbx_sub_IAMax.Text)) < (Int32.Parse(txtbx.Text))))
                    {
                        err.SetError(txtbx, "Min. Marks should be less than Max.Marks");
                        lbl.Text = "ERROR!. -Min. Marks should be less than Max.Marks";
                        flag3 = 1;
                    }
                    else
                    {
                        err.SetError(txtbx, "");
                        flag3 = 0;
                    }
                }
            }     
        }
        private void btn_crsEdit_Click(object sender, EventArgs e)
        {
            Frm_Home.Load_SubjectCombo(cmb_coursename);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Updating will affect to all the existing related data. \n Are you sure, Do you wan't to Update?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                InsertUpdateSubject("Prc_SubUpdate", 1);
                this.Close();
            }
        }

        private void btn_cancle1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void chkbx_IA_CheckedChanged(object sender, EventArgs e)
        {
            txtbx_sub_IAMax.Text = "";
            txtbx_sub_IAMin.Text = "";
            txtbx_sub_IAMax.Enabled = false;
            txtbx_sub_IAMin.Enabled = false;
            if(chkbx_IA.Checked==false)
            {
                txtbx_sub_IAMax.Enabled = true;
                txtbx_sub_IAMin.Enabled = true;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        Bitmap bitmap;
        private void btn_Print_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);

            Graphics graphics = panel.CreateGraphics();
            Size size = this.ClientSize;
            bitmap = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bitmap);

            Point point = PointToScreen(panel.Location);
            graphics.CopyFromScreen(point.X,point.Y,0,0,size);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                txtbx_SubCode.Enabled = true;
                txtbx_SubName.Enabled = true;
                txtbx_SubDesc.Enabled = true;
                cmb_coursename.Enabled = true;
                cmb_Category.Enabled = true;
                txtbx_sub_thMax.Enabled = true;
                txtbx_sub_thMin.Enabled = true;
                txtbx_sub_IAMax.Enabled = true;
                txtbx_sub_IAMin.Enabled = true;

                btn_update.Visible = true;
                btn_crsEdit.Visible = true;
                btn_cancle1.Visible = true;
                btn_edit.Visible = false;

            }
        }

        private void cmbcheck(ComboBox cmb,ErrorProvider err,Label lbl)
        {
            if(cmb.Text=="")
            {
                err.SetError(cmb, "Please select a Course");
                lbl.Text = "ERROR!.-Please select a Course.";
                flag4 = 1;
            }
            else
            {
                err.SetError(cmb, "");
                flag4 = 0;
                
            }
            my.Add(flag4);
        }
        private void btn_ok1_Click(object sender, EventArgs e)
        {
            InsertUpdateSubject("PrcSubInsert1", 0);
        }
        private void Frm_Subject_Load(object sender, EventArgs e)
        {
            if(Frm_SubView.flag==1)
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("Prc_ComboSubView", con);
                    cmd.Parameters.AddWithValue("@Course_id", Frm_SubView.course_Id);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    cmb_coursename.DataSource = dt;
                    cmb_coursename.DisplayMember = "value";
                    cmb_coursename.ValueMember = "keys";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong please try again !! \n\n" + ex);
                }
                finally
                {
                    con.Close();
                }

                //populates textbox with values//
                txtbx_SubCode.Text = Frm_SubView.code;
                txtbx_SubName.Text = Frm_SubView.name;
                txtbx_SubDesc.Text= Frm_SubView.descript;
                cmb_Category.Text = Frm_SubView.category;
                txtbx_sub_thMax.Text = Frm_SubView.thmax;
                txtbx_sub_thMin.Text = Frm_SubView.thmin;
                txtbx_sub_IAMax.Text = Frm_SubView.iamax;
                txtbx_sub_IAMin.Text = Frm_SubView.iamin;

                txtbx_SubCode.Enabled = false;
                txtbx_SubName.Enabled = false;
                txtbx_SubDesc.Enabled = false;
                cmb_coursename.Enabled = false;
                cmb_Category.Enabled = false;
                txtbx_sub_thMax.Enabled = false;
                txtbx_sub_thMin.Enabled = false;
                txtbx_sub_IAMax.Enabled = false;
                txtbx_sub_IAMin.Enabled = false;

                btn_ok1.Visible = false;
                btn_crsEdit.Visible = false;
                btn_update.Visible = false;
                btn_cancle1.Visible = false;
                btn_edit.Visible = true;

                Frm_SubView.flag = 0;
            }
            else
            {
                Frm_Home.Load_SubjectCombo(cmb_coursename);
            }
        }
    }
}
