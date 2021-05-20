using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_MapUpdate : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public Frm_MapUpdate()
        {
            InitializeComponent();
        }

        private void Frm_MapUpdate_Load(object sender, EventArgs e)
        {

            txtbx_Subject.Enabled = false;
            cmb_Semester.Enabled = false;
            txtbx_Course.Enabled = false;

            txtbx_Course.Text = Frm_CrsMgmt.Crs_name;
            cmb_Semester.Text = Frm_CrsMgmt.sem;
            txtbx_Subject.Text = Frm_CrsMgmt.Sub_name;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Do you want to Edit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                cmb_Semester.Enabled = true;
                btn_cancle.Visible = true;
                btn_update.Visible = true;
                btn_edit.Visible = false;               
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Updating will affect to all the existing related data. \n Are you sure, Do you wan't to Update?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("Prc_MapUpdate", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Map_Id",Frm_CrsMgmt.Map_id);
                    cmd.Parameters.AddWithValue("@Cours_Id", Frm_CrsMgmt.Crs_id);
                    cmd.Parameters.AddWithValue("@Subject_Id", Frm_CrsMgmt.Sub_id);
                    cmd.Parameters.AddWithValue("@Semester", cmb_Semester.Text);
                    cmd.Parameters.AddWithValue("@MapDate", dateTimePicker1.Value.Date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Operation Successful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("\t Something went wrong please try again !! \n\n" + ex);
                }
                finally
                {
                    con.Close();
                    this.Close();
                }
                Frm_CrsMgmt.chk = 1;
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //string sql="delete from Tbl where "
        }
    }
}
