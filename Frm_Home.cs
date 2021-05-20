using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }
        public static int var = 0, var1 = 0;       
        public static Frm_CourseView obj_crsview = new Frm_CourseView();
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public void clearhome()
        {
            picbx.Visible = false;
            lbl_name.Visible = false;
            cmb_qck_srch.Visible = false;
            btn_qck_srch.Visible = false;
            btn_qck_clear.Visible = false;

            lbl_qck_studetails.Visible = false;
            lbl_qck_regno.Visible = false;
            lbl_qck_regno_display.Visible = false;
            lbl_qck_name.Visible = false;
            lbl_qck_name_display.Visible = false;
            lbl_qck_gender.Visible = false;
            lbl_qck_gender_display.Visible = false;
            lbl_qck_dob.Visible = false;
            lbl_qck_dob_display.Visible = false;
            lbl_qck_adhaar.Visible = false;
            lbl_qck_adhaar_display.Visible = false;
            lbl_qck_crs.Visible = false;
            lbl_qck_crs_display.Visible = false;
            lbl_qck_fname.Visible = false;
            lbl_qck_fname_display.Visible = false;
            lbl_qck_phno.Visible = false;
            lbl_qck_phno_display.Visible = false;

            dataGridView1.Visible = false;
        }
        public void Quick_Search_Name()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                using (SqlCommand cmd = new SqlCommand("Prc_View_qck_stuinfo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Para", cmb_qck_srch.SelectedValue);
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            lbl_qck_regno_display.Text = dr["RegNo"].ToString();
                            lbl_qck_name_display.Text = dr["StuName"].ToString();
                            lbl_qck_gender_display.Text= dr["Gender"].ToString();
                            lbl_qck_dob_display.Text = dr["DOB"].ToString();
                            lbl_qck_adhaar_display.Text = dr["AadhaarNo"].ToString();
                            lbl_qck_crs_display.Text = dr["Course_Name"].ToString();
                            lbl_qck_fname_display.Text = dr["FName"].ToString();
                            lbl_qck_phno_display.Text = dr["FPhNo"].ToString();
                        }
                    }
                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adt.Fill(dt);

                        // Clear binding
                        dataGridView1.DataSource = null;
                                              
                        dataGridView1.ColumnCount = 13;

                        dataGridView1.Columns[0].Name = "Semester";
                        dataGridView1.Columns[0].HeaderText = "Semester";
                        dataGridView1.Columns[0].ReadOnly = true;
                        dataGridView1.Columns[0].DataPropertyName = "Semester";                        
                        dataGridView1.Columns[0].Width = 60;

                        dataGridView1.Columns[1].Name = "Sub_Sum_th_IA";
                        dataGridView1.Columns[1].HeaderText = "Total (Max. Marks)";
                        dataGridView1.Columns[1].ReadOnly = true;
                        dataGridView1.Columns[1].DataPropertyName = "Max_Marks";
                        dataGridView1.Columns[1].Width = 50;

                        dataGridView1.Columns[2].Name = "Total_Sec";
                        dataGridView1.Columns[2].HeaderText = "Total (Sec. Marks)";
                        dataGridView1.Columns[2].ReadOnly = true;
                        dataGridView1.Columns[2].DataPropertyName = "G_Total";
                        dataGridView1.Columns[2].Width = 50;

                        dataGridView1.Columns[3].Name = "SGPA";
                        dataGridView1.Columns[3].HeaderText = "SGPA";
                        dataGridView1.Columns[3].ReadOnly = true;
                        dataGridView1.Columns[3].DataPropertyName = "SGPA";
                        dataGridView1.Columns[3].Width = 60;

                        dataGridView1.Columns[4].Name = "Final_Result";
                        dataGridView1.Columns[4].HeaderText = "Result";
                        dataGridView1.Columns[4].ReadOnly = true;
                        dataGridView1.Columns[4].DataPropertyName = "Final_Result";
                        dataGridView1.Columns[4].Width = 60;

                        dataGridView1.Columns[5].Visible = false;
                        dataGridView1.Columns[5].DataPropertyName = "RegNo";

                        dataGridView1.Columns[6].Visible = false;
                        dataGridView1.Columns[6].DataPropertyName = "StuName";

                        dataGridView1.Columns[7].Visible = false;
                        dataGridView1.Columns[7].DataPropertyName = "Gender";

                        dataGridView1.Columns[8].Visible = false;
                        dataGridView1.Columns[8].DataPropertyName = "DOB";

                        dataGridView1.Columns[9].Visible = false;
                        dataGridView1.Columns[9].DataPropertyName = "AadhaarNo";

                        dataGridView1.Columns[10].Visible = false;
                        dataGridView1.Columns[10].DataPropertyName = "Course_Name";

                        dataGridView1.Columns[11].Visible = false;
                        dataGridView1.Columns[11].DataPropertyName = "FName";

                        dataGridView1.Columns[12].Visible = false;
                        dataGridView1.Columns[12].DataPropertyName = "FPhNo";

                        dataGridView1.DataSource = dt;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!, Please contact developer \n\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        private void insertMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (ActiveMdiChild != null)	//check if any other child form is open, if open then close //
                ActiveMdiChild.Close();
            Frm_MarksCard objmkrcrd = new Frm_MarksCard();
            objmkrcrd.MdiParent = this;
            objmkrcrd.Show();
            clearhome();
        }
        
        private void courseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Course objcrs = new Frm_Course();
            objcrs.MdiParent = this;
            objcrs.Show();
            clearhome();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Subject objsub = new Frm_Subject();
            objsub.MdiParent = this;
            objsub.Show();
            clearhome();
        }

        private void subjectMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CrsMgmt objcrsmgmt = new Frm_CrsMgmt();
            objcrsmgmt.MdiParent = this;
            objcrsmgmt.Show();
            clearhome();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CrsMgmt objcrsmgmt = new Frm_CrsMgmt();
            objcrsmgmt.MdiParent = this;
            objcrsmgmt.Show();
            clearhome();
        }
        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Stu_Application obj_stuapp = new Frm_Stu_Application();
            obj_stuapp.MdiParent = this;
            obj_stuapp.Show();
            clearhome();
        }
        
        private void viewSubjectToolStripMenuItem_Click_1(object sender, EventArgs e)
        {           
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_CourseView obj_crsview = new Frm_CourseView();
            obj_crsview.MdiParent = this;
            obj_crsview.Show();
            clearhome();
        }
        private void viewSubjectToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_SubView obj_subview = new Frm_SubView();
            obj_subview.MdiParent = this;
            obj_subview.Show();
            clearhome();
        }
        private void viewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_StuView objstuview = new Frm_StuView();
            objstuview.MdiParent = this;
            objstuview.Show();
            clearhome();
        }
        private void viewMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_MarksCardView obj_mksview = new Frm_MarksCardView();
            obj_mksview.MdiParent = this;
            obj_mksview.Show();
            clearhome();
        }
        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Author obj_author = new Frm_Author();
            obj_author.MdiParent = this;
            obj_author.Show();
            clearhome();
        }
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            Frm_Help obj_hlp = new Frm_Help();
            obj_hlp.MdiParent = this;
            obj_hlp.Show();
            clearhome();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
            picbx.Visible = true;
            lbl_name.Visible = true;
            cmb_qck_srch.Visible = true;
            btn_qck_srch.Visible = true;
            btn_qck_clear.Visible = true;

            lbl_qck_regno.Visible = true;
            lbl_qck_regno_display.Visible = true;
            lbl_qck_name.Visible = true;
            lbl_qck_name_display.Visible = true;
            lbl_qck_gender.Visible = true;
            lbl_qck_gender_display.Visible = true;
            lbl_qck_dob.Visible = true;
            lbl_qck_dob_display.Visible = true;
            lbl_qck_adhaar.Visible = true;
            lbl_qck_adhaar_display.Visible = true;
            lbl_qck_crs.Visible = true;
            lbl_qck_crs_display.Visible = true;
            lbl_qck_fname.Visible = true;
            lbl_qck_fname_display.Visible = true;
            lbl_qck_phno.Visible = true;
            lbl_qck_phno_display.Visible = true;

            dataGridView1.Visible = true;
        }

        public static void txtvalidate_Code(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_crscode = txtbx.Text.Length;
            if (txtbx.Text == "")
            {
                err.SetError(txtbx, "Code Field is Compulsory");
                lbl.Text = "ERROR!. -Please, Enter the Code.";
                var = 1;
            }
            else if ((len_crscode < 3) || (len_crscode > 20))
            {
                err.SetError(txtbx, "Invalid Code");
                lbl.Text = "ERROR!. -Please, Enter a valid code.";
                var = 1;
            }
            else
            {
                err.SetError(txtbx, "");
                var = 0;
            }        
        }
        
        public static void txtvalidate_Name(TextBox txtbx, ErrorProvider err, Label lbl)
        {
            int len_crsname = txtbx.Text.Length;
            if (txtbx.Text == "")
            {
                err.SetError(txtbx, "Name Field is Compulsory");
                lbl.Text = "ERROR!. -Please, Enter the name.";
                var1 = 1;
            }
            else if ((len_crsname < 3) || (len_crsname > 40))
            {
                err.SetError(txtbx, "Name Invalid");
                lbl.Text = "ERROR!. -Please, Enter a valid name.";
                var1 = 1;
            }
            else
            {
                err.SetError(txtbx, "");
                var1 = 0;
            }
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Prc_View_qck_name", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                cmb_qck_srch.DataSource = dt;
                cmb_qck_srch.DisplayMember = "StuInfo";
                cmb_qck_srch.ValueMember = "RegNo";                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!!, Please contact your developer\n\n"+ex);
            }
            finally
            {
                con.Close();
            }
            cmb_qck_srch.Text = "";
        }

        private void btn_qck_clear_Click(object sender, EventArgs e)
        {
            cmb_qck_srch.Text = "";
            lbl_qck_regno_display.Text = "..........";
            lbl_qck_name_display.Text = "..........";
            lbl_qck_gender_display.Text = "..........";
            lbl_qck_dob_display.Text = "..........";
            lbl_qck_adhaar_display.Text = "..........";
            lbl_qck_crs_display.Text = "..........";
            lbl_qck_fname_display.Text = "..........";
            lbl_qck_phno_display.Text = "..........";
            dataGridView1.DataSource = null;
        }

        private void btn_qck_srch_Click(object sender, EventArgs e)
        {          
            Quick_Search_Name();         
        }

        



        //==========================BIND COURSE INTO COMBO_BOX =================================== //

        public static void Load_SubjectCombo(ComboBox cmb)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("PrcComboSub", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                cmb.DataSource = dt;
                cmb.DisplayMember = "value";
                cmb.ValueMember = "keys";
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
    }
}
