using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_Course : Form
    {
        public static int flag = 0;
        private string message = string.Empty;
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public Frm_Course()
        {
            InitializeComponent();
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

       
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Frm_Home.txtvalidate_Code(txtbx_coursecode,err_crs_code,label_status);
            Frm_Home.txtvalidate_Name(txtbx_coursename,err_crs_name,label_status);
             
            if ((Frm_Home.var==0)&&(Frm_Home.var1==0))
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("PrcCourseInsert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Course_Code", txtbx_coursecode.Text);
                    cmd.Parameters.AddWithValue("@Course_Name", txtbx_coursename.Text);
                    cmd.Parameters.AddWithValue("@Course_Descript", txtbx_coursedescrp.Text);
                    cmd.Parameters.AddWithValue("@Course_Date", dateTimePicker1.Value.Date);
                    cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                    cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    message = (string)cmd.Parameters["@ERROR"].Value;
                    label_status.Text = message;
                    MessageBox.Show("Operation Successful.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong please try again !! \n\n" + ex);
                }
                finally
                {
                    con.Close();
                    ClearTextBoxes();
                }
            }
           
        }

        //============= Alphanumeric values only accepted=============================//
        private void txtbx_coursecode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Frm_Course_Load(object sender, EventArgs e)
        {
            if(Frm_CourseView.flag==1)
            {
                txtbx_coursecode.Text = Frm_CourseView.crs_code;
                txtbx_coursename.Text = Frm_CourseView.crs_name;
                txtbx_coursedescrp.Text = Frm_CourseView.crs_desc;

                //Disable textbox -- Should not be able to edit//
                txtbx_coursecode.Enabled = false;
                txtbx_coursename.Enabled = false;
                txtbx_coursedescrp.Enabled = false;

                btn_ok.Visible = false;
                btn_cancle.Visible = false;
                btn_edit.Visible = true;
                Frm_CourseView.flag = 0;
            }
        }

        public void btn_Update_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Updating will affect to all the existing related data. \n Are you sure, Do you wan't to Update?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                Frm_Home.txtvalidate_Code(txtbx_coursecode, err_crs_code, label_status);
                Frm_Home.txtvalidate_Name(txtbx_coursename, err_crs_name, label_status);
                if ((Frm_Home.var == 0) && (Frm_Home.var1 == 0))
                {
                    SqlConnection con = new SqlConnection(connectionString);
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Prc_CourseUpdate", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Course_Id", Frm_CourseView.crs_id);
                        cmd.Parameters.AddWithValue("@Course_Code", txtbx_coursecode.Text);
                        cmd.Parameters.AddWithValue("@Course_Name", txtbx_coursename.Text);
                        cmd.Parameters.AddWithValue("@Course_Descript", txtbx_coursedescrp.Text);
                        cmd.Parameters.AddWithValue("@Course_Date", dateTimePicker1.Value.Date);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        label_status.Text = "Course Updated Successfully.";
                        MessageBox.Show("Operation Successful.");                        
                       this.Close();                         
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something went wrong please try again !! \n\n" + ex);
                    }
                    finally
                    {
                        con.Close();
                        ClearTextBoxes();
                        btn_Update.Visible = false;                        
                    }
                }
            }
        }

        //======================Event Accept only alphabets ========== txtbxcoursename=================//
        private void txtbx_coursename_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //Enable textbox -- Should be able to edit//
                txtbx_coursecode.Enabled = true;
                txtbx_coursename.Enabled = true;
                txtbx_coursedescrp.Enabled = true;

                btn_Update.Visible = true;
                btn_cancle.Visible = true;

                btn_edit.Visible = false;              
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
