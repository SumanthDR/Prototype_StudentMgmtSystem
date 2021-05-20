using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_StuView : Form
    {       
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public Frm_StuView()
        {
            InitializeComponent();
        }

        public static string StuId;
        public static string RegNo;
        public static string StuName;
        public static string DOB;
        public static string Gender;
        public static string AadhaarNo;
        public static string StuPhNo;
        public static string StuEmail;
        public static string FName;
        public static string FPhNo;
        public static string FEmail;
        public static string CourseName;
        public static string ILang;
        public static string Course_Id;
        public static string ILang_Id;
        public static int flag = 0;
        public int ForPrint = 0;

        private void Frm_StuView_Load(object sender, EventArgs e)
        {
            Frm_Home.Load_SubjectCombo(cmb_coursename);
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if(txtbx_year.Text.Length==4)
            {
                LoadDataGrid("Prc_ViewStuCrsYear", 3);

                txtbx_regno.Text = "";
                dateTimePicker1.Text = "";
            }            
        }

        private void LoadDataGrid(string prc,int flag)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(prc, con);
                if(flag==1)
                    cmd.Parameters.AddWithValue("@RegNo", txtbx_regno.Text);
                if (flag == 2)
                    cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value.Date);
                if(flag==3)
                {
                    cmd.Parameters.AddWithValue("@CourseId", cmb_coursename.SelectedValue);
                    cmd.Parameters.AddWithValue("@Year", txtbx_year.Text.Substring(2));
                }
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();

                    adt.Fill(dt);

                    ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////

                    // Clear binding
                    dataGridView1.DataSource = null;

                    //Set AutoGenerateColumns False
                    dataGridView1.AutoGenerateColumns = false;

                    //Set Columns Count
                    dataGridView1.ColumnCount = 16;


                    //Add Columns

                    dataGridView1.Columns[1].Name = "RegNo";
                    dataGridView1.Columns[1].HeaderText = "USN/Register No";
                    dataGridView1.Columns[1].DataPropertyName = "RegNo";

                    dataGridView1.Columns[2].Name = "StuName";
                    dataGridView1.Columns[2].HeaderText = "Student Name";
                    dataGridView1.Columns[2].DataPropertyName = "StuName";
                    dataGridView1.Columns[2].Width = 160;

                    dataGridView1.Columns[3].Name = "DOB";
                    dataGridView1.Columns[3].HeaderText = "Date Of Birth";
                    dataGridView1.Columns[3].DataPropertyName = "DOB";
                    dataGridView1.Columns[3].Width = 100;

                    dataGridView1.Columns[4].Name = "Gender";
                    dataGridView1.Columns[4].HeaderText = "Gender";
                    dataGridView1.Columns[4].DataPropertyName = "Gender";
                    dataGridView1.Columns[4].Width = 80;

                    dataGridView1.Columns[5].Name = "AadhaarNo";
                    dataGridView1.Columns[5].HeaderText = "Aadhaar No";
                    dataGridView1.Columns[5].DataPropertyName = "AadhaarNo";
                    dataGridView1.Columns[5].Width = 130;

                    dataGridView1.Columns[6].Name = "FName";
                    dataGridView1.Columns[6].HeaderText = "Father Name";
                    dataGridView1.Columns[6].DataPropertyName = "FName";
                    dataGridView1.Columns[6].Width = 160;

                    dataGridView1.Columns[7].Name = "FPhNo";
                    dataGridView1.Columns[7].HeaderText = "Phone Number";
                    dataGridView1.Columns[7].DataPropertyName = "FPhNo";
                    dataGridView1.Columns[7].Width = 110;

                    dataGridView1.Columns[8].Name = "Course_Name";
                    dataGridView1.Columns[8].HeaderText = "Course";
                    dataGridView1.Columns[8].DataPropertyName = "Course_Name";


                    dataGridView1.Columns[9].DataPropertyName = "StuId";
                    dataGridView1.Columns[9].Visible = false;

                    dataGridView1.Columns[10].DataPropertyName = "StuPhNo";
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[11].DataPropertyName = "StuEmail";
                    dataGridView1.Columns[11].Visible = false;

                    dataGridView1.Columns[12].DataPropertyName = "FEmail";
                    dataGridView1.Columns[12].Visible = false;

                    dataGridView1.Columns[13].DataPropertyName = "CourseId";
                    dataGridView1.Columns[13].Visible = false;

                    dataGridView1.Columns[14].DataPropertyName = "ILangId";
                    dataGridView1.Columns[14].Visible = false;

                    dataGridView1.Columns[15].DataPropertyName = "Sub_Name";
                    dataGridView1.Columns[15].Visible = false;

                    dataGridView1.AllowUserToAddRows = false;

                    ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    dataGridView1.Columns.Add(btn);
                    btn.HeaderText = "Action";
                    btn.Text = "View";
                    btn.Name = "btnGrid_Edit";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.DataSource = dt;
                }

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


        // EVENTS ----------- This block creates sl.no (eg-1,2,3,4,5...) //////////
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {            
            LoadDataGrid("Prc_ViewStuRegno", 1);

            cmb_coursename.Text = "";
            txtbx_year.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 16)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Frm_Stu_Application ObjStuReg = new Frm_Stu_Application();

                Frm_StuView.StuId = row.Cells[9].Value.ToString();
                Frm_StuView.RegNo = row.Cells[1].Value.ToString();
                Frm_StuView.StuName= row.Cells[2].Value.ToString();
                Frm_StuView.DOB=row.Cells[3].Value.ToString();
                Frm_StuView.Gender = row.Cells[4].Value.ToString();
                Frm_StuView.AadhaarNo = row.Cells[5].Value.ToString();
                Frm_StuView.StuPhNo = row.Cells[10].Value.ToString();
                Frm_StuView.StuEmail = row.Cells[11].Value.ToString();
                Frm_StuView.FName = row.Cells[6].Value.ToString();
                Frm_StuView.FPhNo= row.Cells[7].Value.ToString();
                Frm_StuView.FEmail= row.Cells[12].Value.ToString();
                Frm_StuView.Course_Id = row.Cells[13].Value.ToString();
                Frm_StuView.ILang_Id = row.Cells[14].Value.ToString(); ;
                Frm_StuView.CourseName = row.Cells[8].Value.ToString();
                Frm_StuView.ILang = row.Cells[15].Value.ToString();

                Frm_StuView.flag = 1;
              
                ObjStuReg.Show();
            }
        }

        private void btn_search_dob_Click(object sender, EventArgs e)
        {
            LoadDataGrid("Prc_ViewStuDob", 2);

            txtbx_regno.Text = "";
            txtbx_year.Text = "";
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            
            //printer.Title = "Seshadripuram College Tumakuru";
            printer.SubTitle = "Students Details";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (txtbx_year.Text.Length == 4)
            {
                LoadDataGrid("Prc_ViewStuCrsYear", 3);

                txtbx_regno.Text = "";
                dateTimePicker1.Text = "";
            }
        }
    }
}
