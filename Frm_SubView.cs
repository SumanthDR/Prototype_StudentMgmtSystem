using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_SubView : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public static string id = string.Empty;
        public static string code = string.Empty;
        public static string name = string.Empty;
        public static string course_Id = string.Empty;
        public static string category = string.Empty;
        public static string descript = string.Empty;
        public static string thmax = string.Empty;
        public static string thmin = string.Empty;
        public static string iamax = string.Empty;
        public static string iamin = string.Empty;
        public static int flag = 0;
        public Frm_SubView()
        {
            InitializeComponent();
        }
       
        private void Load_GridView(string prc,int flag)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand(prc, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if(flag==1)
                {
                    cmd.Parameters.AddWithValue("@Parameter", cmb_coursename.SelectedValue);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Parameter", txtbx_SubCode.Text);
                }
                cmd.Parameters.AddWithValue("@flag", flag);
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
                    dataGridView1.ColumnCount = 13;


                    //Add Columns

                    dataGridView1.Columns[1].HeaderText = "Subject Code";
                    dataGridView1.Columns[1].Name = "Sub_Code";
                    dataGridView1.Columns[1].DataPropertyName = "Sub_Code";
                    dataGridView1.Columns[1].Width = 120;

                    dataGridView1.Columns[2].Name = "Subject Name";
                    dataGridView1.Columns[2].HeaderText = "Subject Name";
                    dataGridView1.Columns[2].DataPropertyName = "Sub_Name";
                    dataGridView1.Columns[2].Width=350;

                    dataGridView1.Columns[3].Name = "Sub_Category";
                    dataGridView1.Columns[3].HeaderText = "Category";
                    dataGridView1.Columns[3].DataPropertyName = "Sub_Category";
                    dataGridView1.Columns[3].Width = 130;

                    dataGridView1.Columns[4].Name = "Course_Code";
                    dataGridView1.Columns[4].HeaderText = "Course Code";
                    dataGridView1.Columns[4].DataPropertyName = "Course_Code";
                    dataGridView1.Columns[4].Width = 80;

                    dataGridView1.Columns[5].Name = "Course_Name";
                    dataGridView1.Columns[5].HeaderText = "Course Name";
                    dataGridView1.Columns[5].DataPropertyName = "Course_Name";

                    // THESE ARE NOT DISPLAYED . FOR PROGRAMMING PURPOSE ONLY //

                    dataGridView1.Columns[6].DataPropertyName = "Sub_Id";
                    dataGridView1.Columns[6].Visible = false;

                    dataGridView1.Columns[7].DataPropertyName = "Crs_Id";
                    dataGridView1.Columns[7].Visible = false;

                    dataGridView1.Columns[8].DataPropertyName = "Sub_Descript";
                    dataGridView1.Columns[8].Visible = false;

                    dataGridView1.Columns[9].DataPropertyName = "Sub_th_Max";
                    dataGridView1.Columns[9].Visible = false;

                    dataGridView1.Columns[10].DataPropertyName = "Sub_th_Min";
                    dataGridView1.Columns[10].Visible = false;

                    dataGridView1.Columns[11].DataPropertyName = "Sub_IA_Max";
                    dataGridView1.Columns[11].Visible = false;

                    dataGridView1.Columns[12].DataPropertyName = "Sub_IA_Min";
                    dataGridView1.Columns[12].Visible = false;

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
        private void Frm_SubView_Load(object sender, EventArgs e)
        {
           Frm_Home.Load_SubjectCombo(cmb_coursename);
        }

        private void btn_search_crs_Click(object sender, EventArgs e)
        {
            Load_GridView("Prc_SubView",1);
        }
        // EVENTS ----------- This block creates sl.no (eg-1,2,3,4,5...) //////////

        private void dataGridView1_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 13)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Frm_Subject objSub = new Frm_Subject();

                //populate the textbox from specific value of the coordinates of column and row.
                Frm_SubView.id= row.Cells[6].Value.ToString();
                Frm_SubView.code= row.Cells[1].Value.ToString();
                Frm_SubView.name = row.Cells[2].Value.ToString();
                Frm_SubView.descript= row.Cells[8].Value.ToString();
                Frm_SubView.course_Id= row.Cells[7].Value.ToString();
                Frm_SubView.category= row.Cells[3].Value.ToString();
                Frm_SubView.thmax= row.Cells[9].Value.ToString();
                Frm_SubView.thmin = row.Cells[10].Value.ToString();
                Frm_SubView.iamax = row.Cells[11].Value.ToString();
                Frm_SubView.iamin = row.Cells[12].Value.ToString();

                Frm_SubView.flag = 1;
                objSub.Show();
            }
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            //printer.Title = "Seshadripuram College Tumakuru";
            printer.SubTitle = "Subjects Details";
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

        private void txtbx_SubCode_TextChanged(object sender, EventArgs e)
        {
            cmb_coursename.Text = "";
            Load_GridView("Prc_SubView", 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_GridView("Prc_SubView", 1);
        }
    }
}
 