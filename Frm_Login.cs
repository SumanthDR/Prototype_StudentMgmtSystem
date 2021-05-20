using System;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            if((txtbx_userid.Text=="")&&(txtbx_pswd.Text==""))
            if (DialogResult.Yes == MessageBox.Show("Are you sure, Do you wan't to Exit?  ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                    this.Close();
            }
            if((txtbx_userid.Text != "") || (txtbx_pswd.Text != ""))
            {
                    txtbx_userid.Text = "";
                    txtbx_pswd.Text = "";
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if((txtbx_userid.Text=="admin")&&(txtbx_pswd.Text=="admin"))
            {
                this.Hide();
                Frm_Home objhm = new Frm_Home();
                objhm.Show();
            }
            else
            {
                MessageBox.Show("Invalid User-Id & Password !!");
            }
        }
    }
}
