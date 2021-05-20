using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_Stu_Application : Form
    {
        string message;
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        int flag0, flag1,flag2,flag3,flag4;
       
        public Frm_Stu_Application()
        {
            InitializeComponent();
        }

        private void LoadLangCombo()
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("PrcComboLang", con);
                cmd.Parameters.AddWithValue("@CourseId", cmb_coursename.SelectedValue);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                cmb_lang.DataSource = dt;
                cmb_lang.DisplayMember = "value";
                cmb_lang.ValueMember = "keys";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong please try again !! \n\n" + ex);
            }
            finally
            {
                con.Close();
            }
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

        // Course ComboBox //
        int flag = 0;
        private void Frm_Stu_Application_Load(object sender, EventArgs e)
        {
            Frm_Home.Load_SubjectCombo(cmb_coursename);

            LoadLangCombo();
            flag = 1;

            if(Frm_StuView.flag==1)
            {
                // -----------------    Populate feilds all feilds ----------------- //
                txtbx_regno.Text = Frm_StuView.RegNo;
                txtbx_name.Text = Frm_StuView.StuName;
                dateTimePicker1.Text = Frm_StuView.DOB;
                txtbx_aadhar.Text = Frm_StuView.AadhaarNo;
                txtbx_StuPhno.Text = Frm_StuView.StuPhNo;
                txtbx_StuEmail.Text = Frm_StuView.StuEmail;
                txtbx_fname.Text = Frm_StuView.FName;
                txtbx_fphno.Text = Frm_StuView.FPhNo;
                txtbx_FEmail.Text = Frm_StuView.FEmail;
                cmb_Gender.Text = Frm_StuView.Gender;
                cmb_coursename.Text = Frm_StuView.CourseName;
                cmb_lang.Text = Frm_StuView.ILang;


                // Disable all feilds //
                txtbx_regno.Enabled = false;
                txtbx_name.Enabled = false;
                dateTimePicker1.Enabled = false;
                cmb_Gender.Enabled = false;
                txtbx_aadhar.Enabled = false;
                txtbx_StuPhno.Enabled = false;
                txtbx_StuEmail.Enabled = false;
                txtbx_fname.Enabled = false;
                txtbx_fphno.Enabled = false;
                txtbx_FEmail.Enabled = false;
                cmb_coursename.Enabled = false;
                cmb_lang.Enabled = false;
                btn_Cancle.Enabled = false;
                btn_save.Enabled = false;
                btn_Edit.Visible = true;
                btn_Update.Visible = true;
                btn_Update.Enabled = false;

                Frm_StuView.flag = 0;
            }           
        }


        // EVENTS ARE HANDLED //

        private void txtbx_regno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || (e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtbx_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void cmb_coursename_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_lang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtbx_phno1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtbx_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtbx_aadhar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ Above Code Events End^^^^^^^^^^^^^^^^^^^^^^^^^^^^^//


        // <<<<<<<<<<<<<<<<<  Save Button Insert Operation is Done >>>>>>>>>>>>>>>>>>>>>>>>//
        private void btn_save_Click(object sender, EventArgs e)
        {
            ValidateAll();
            if ((cmb_coursename.Text=="")||(cmb_Gender.Text=="")||(cmb_lang.Text=="")||(flag0!=0)||(flag1!=0)||(flag2!=0)||(flag3!=0)||(flag4!=0))
            {
                label_status.Text = "Enter a valid input to all feilds, All Feilds are compulsory.";
            }
            else
            {
                label_status.Text = "";
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("Prc_RegisterStu", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@regno", txtbx_regno.Text);
                    cmd.Parameters.AddWithValue("@stuname", txtbx_name.Text);
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                    cmd.Parameters.AddWithValue("@gender", cmb_Gender.Text);
                    cmd.Parameters.AddWithValue("@aadhaarno", txtbx_aadhar.Text);
                    cmd.Parameters.AddWithValue("@stuphno", txtbx_StuPhno.Text);
                    cmd.Parameters.AddWithValue("@stuemail", txtbx_StuEmail.Text);
                    cmd.Parameters.AddWithValue("@fname", txtbx_fname.Text);
                    cmd.Parameters.AddWithValue("@fphno", txtbx_fphno.Text);
                    cmd.Parameters.AddWithValue("@femail", txtbx_FEmail.Text);
                    cmd.Parameters.AddWithValue("@courseid", cmb_coursename.SelectedValue);
                    cmd.Parameters.AddWithValue("@langid", cmb_lang.SelectedValue);
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
                    cmb_coursename.Text = "";
                    cmb_lang.Text = "";

                }
            }
            

        }
        private void cmb_coursename_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                LoadLangCombo();
                cmb_lang.Text = "";
            }
        }


        // Code for Validation ///


        // Email Vlidation  ///
        private void EmailValidation(TextBox txtbx,ErrorProvider err)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(txtbx.Text);
            if (!match.Success)
            {
                label_status.Text = "Please enter a valid Email Address";
                err.SetError(txtbx, "Invalid Email Address");
                flag2 = 1;
            }
            else
            {
                label_status.Text = "";
                err.SetError(txtbx, "");
                flag2 = 0;
            }
        }

        //Phone number Validation //
        private void phNoValidation(TextBox txtbx,ErrorProvider err)
        {
            if(txtbx.Text.Length!=10)
            {
                label_status.Text = "Please enter a valid Phone Number.";
                err.SetError(txtbx, "Invalid Phone Number");
                flag0 = 1;
            }
            else
            {
                label_status.Text = "";
                err.SetError(txtbx, "");
                flag0=0;
            }
        }

        // Name validation //
        private void ValidateName(TextBox txtbx, ErrorProvider err)
        {
            if ((txtbx.Text == "") || (txtbx.Text.Length < 5))
            {
                err.SetError(txtbx, "Invalid Name");
                label_status.Text = "Please enter a valid Name";
                flag1 = 1;
            }
            else
            {
                err.SetError(txtbx, "");
                label_status.Text = "";
                flag1=0;
            }
        }
        private void ValidateAll()
        {
            phNoValidation(txtbx_StuPhno, err_StuPhno);
            if (flag0 == 0)
                phNoValidation(txtbx_fphno, err_FPhno);
            else
                phNoValidation(txtbx_StuPhno, err_StuPhno);
            ValidateName(txtbx_name, err_StuName);
            if(flag1==0)
                ValidateName(txtbx_fname, err_FName);
            else
                ValidateName(txtbx_name, err_StuName);
            EmailValidation(txtbx_StuEmail, err_StuEmail);
            if (flag2==0)
                EmailValidation(txtbx_FEmail, err_FEmail);
            else
                EmailValidation(txtbx_StuEmail, err_StuEmail);

        }

        private void txtbx_name_TextChanged(object sender, EventArgs e)
        {
            ValidateName(txtbx_name, err_StuName);
        }

        private void txtbx_StuPhno_TextChanged(object sender, EventArgs e)
        {
            phNoValidation(txtbx_StuPhno, err_StuPhno);
        }

        private void txtbx_StuEmail_TextChanged(object sender, EventArgs e)
        {
            EmailValidation(txtbx_StuEmail, err_StuEmail);
        }

        private void txtbx_fname_TextChanged(object sender, EventArgs e)
        {
            ValidateName(txtbx_fname, err_FName);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                btn_Edit.Visible = false;
                txtbx_regno.Enabled = true;
                txtbx_name.Enabled = true;
                dateTimePicker1.Enabled = true;
                cmb_Gender.Enabled = true;
                txtbx_aadhar.Enabled = true;
                txtbx_StuPhno.Enabled = true;
                txtbx_StuEmail.Enabled = true;
                txtbx_fname.Enabled = true;
                txtbx_fphno.Enabled = true;
                txtbx_FEmail.Enabled = true;
                cmb_coursename.Enabled = true;
                cmb_lang.Enabled = true;
                btn_Cancle.Enabled = true;
                btn_Update.Enabled = true;
                btn_Print.Visible = true;
                pictureBox1.Visible = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Updating will affect to all the existing related data. \n Are you sure, Do you wan't to Update?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                ValidateAll();
                if ((cmb_coursename.Text == "") || (cmb_Gender.Text == "") || (cmb_lang.Text == "") || (flag0 != 0) || (flag1 != 0) || (flag2 != 0) || (flag3 != 0))
                {
                    label_status.Text = "All fields are compulsory.";
                }
                else
                {
                    label_status.Text = "";
                    SqlConnection con = new SqlConnection(connectionString);
                    try
                    {
                        SqlCommand cmd = new SqlCommand("Prc_RegisterStuUpdate", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@stu_id", Frm_StuView.StuId);
                        cmd.Parameters.AddWithValue("@regno", txtbx_regno.Text);
                        cmd.Parameters.AddWithValue("@stuname", txtbx_name.Text);
                        cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@gender", cmb_Gender.Text);
                        cmd.Parameters.AddWithValue("@aadhaarno", txtbx_aadhar.Text);
                        cmd.Parameters.AddWithValue("@stuphno", txtbx_StuPhno.Text);
                        cmd.Parameters.AddWithValue("@stuemail", txtbx_StuEmail.Text);
                        cmd.Parameters.AddWithValue("@fname", txtbx_fname.Text);
                        cmd.Parameters.AddWithValue("@fphno", txtbx_fphno.Text);
                        cmd.Parameters.AddWithValue("@femail", txtbx_FEmail.Text);
                        cmd.Parameters.AddWithValue("@courseid", cmb_coursename.SelectedValue);
                        cmd.Parameters.AddWithValue("@langid", cmb_lang.SelectedValue);
                        cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                        cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        message = (string)cmd.Parameters["@ERROR"].Value;
                        label_status.Text = message;
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
                        cmb_coursename.Text = "";
                        cmb_lang.Text = "";
                    }
                }
            }    
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to exit.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        //Bitmap bitmap;
        private void btn_Print_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //this.Controls.Add(panel);

            //Graphics graphics = panel.CreateGraphics();
            //Size size = this.ClientSize;
            //bitmap = new Bitmap(size.Width, size.Height, graphics);
            //graphics = Graphics.FromImage(bitmap);

            //Point point = PointToScreen(panel.Location);
            //graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();

            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Print Labels

            string heading = "Student Details";

            e.Graphics.DrawString(heading, new Font("Arial", 25, FontStyle.Bold), Brushes.Black, 270, 30);
            e.Graphics.DrawString(lbl_regno.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 160);
            e.Graphics.DrawString(lbl_name.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 190);
            e.Graphics.DrawString(lbl_dob.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 220);
            e.Graphics.DrawString(grpbx_gender.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 250);
            e.Graphics.DrawString(lbl_aadhaar.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 280);
            e.Graphics.DrawString(lbl_phno.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 310);
            e.Graphics.DrawString(lbl_email.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 340);
            e.Graphics.DrawString(lbl_fname.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 370);            
            e.Graphics.DrawString(lbl_f_phno.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 400);
            e.Graphics.DrawString(lbl_f_email.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 430);
            e.Graphics.DrawString(lbl_course.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 460);
            e.Graphics.DrawString(lbl_lang.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 50, 490);

            //Print Values in Textbox

            e.Graphics.DrawString(txtbx_regno.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 160);
            e.Graphics.DrawString(txtbx_name.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 190);
            e.Graphics.DrawString(dateTimePicker1.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 220);
            e.Graphics.DrawString(cmb_Gender.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 250);
            e.Graphics.DrawString(txtbx_aadhar.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 280);
            e.Graphics.DrawString(txtbx_StuPhno.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 310);
            e.Graphics.DrawString(txtbx_StuEmail.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 340);
            e.Graphics.DrawString(txtbx_fname.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 370);
            e.Graphics.DrawString(txtbx_fphno.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 400);
            e.Graphics.DrawString(txtbx_FEmail.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 430);
            e.Graphics.DrawString(cmb_coursename.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 460);
            e.Graphics.DrawString(cmb_lang.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, 400, 490);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbx_aadhar_TextChanged(object sender, EventArgs e)
        {
            if(txtbx_aadhar.Text.Length!=12)
            {
                err_aadhaar.SetError(txtbx_aadhar, "Invalid Aadhaar No");
                label_status.Text = "Please enter a valid Aadhaar No.";
                flag4 = 1;
            }
            else
            {
                err_aadhaar.SetError(txtbx_aadhar, "");
                label_status.Text = "";
                flag4 = 0;
            }
        }

        private void txtbx_fphno_TextChanged(object sender, EventArgs e)
        {
            phNoValidation(txtbx_fphno, err_FPhno);
        }

        private void txtbx_FEmail_TextChanged(object sender, EventArgs e)
        {
            EmailValidation(txtbx_FEmail, err_FEmail);
        }

        private void txtbx_regno_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(([0-9]{2})+([a-zA-Z]{1})+([0-9]{5}))$");
            Match match = regex.Match(txtbx_regno.Text);
            if(!match.Success)
            {
                err_RegNo.SetError(txtbx_regno, "Invalid Register Number");
                label_status.Text = "Enter a valid Register Number.";
                flag3 = 1;
            }
            else
            {
                err_RegNo.SetError(txtbx_regno, "");
                label_status.Text = "";
                flag3=0;
            }
        }
    }
}
