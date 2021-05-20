using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_CourseView : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public static string crs_id;
        public static string crs_code;
        public static string crs_name;
        public static string crs_desc;
        public static int flag = 0;
        public Frm_CourseView()
        {
            InitializeComponent();
        }       
        public void Load_Data_Grid(string prc,int temp1)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
            try
            {             
                SqlCommand cmd = new SqlCommand(prc, con);
                cmd.CommandType = CommandType.StoredProcedure;
                if(temp1==1)
                cmd.Parameters.AddWithValue("@Course_Code", txtbx_crs_search.Text);//
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        dataGridView1.DataSource = dt;//
                    }
                    else
                    {
                        MessageBox.Show("Course Not Found! ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Some thing went wrong.Please try again :)" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        
        private void Frm_CourseView_Load(object sender, EventArgs e)
        {       
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Prc_CourseView", con);
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
                    dataGridView1.ColumnCount = 5;

                    
                    //Add Columns
                    
                    dataGridView1.Columns[1].Name = "Course_Code";
                    dataGridView1.Columns[1].HeaderText = "Course Code";
                    dataGridView1.Columns[1].DataPropertyName = "Course_Code";
                    
                    dataGridView1.Columns[2].Name = "Course_Name";
                    dataGridView1.Columns[2].HeaderText = "Course Name";
                    dataGridView1.Columns[2].DataPropertyName = "Course_Name";
                    dataGridView1.Columns[2].Width = 210;

                    dataGridView1.Columns[3].Name = "Course_Descript";
                    dataGridView1.Columns[3].HeaderText = "Course Description";
                    dataGridView1.Columns[3].DataPropertyName = "Course_Descript";
                    dataGridView1.Columns[3].Width = 220;

                    dataGridView1.Columns[4].DataPropertyName = "Course_Id";
                    dataGridView1.Columns[4].Visible = false;


                    ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    dataGridView1.Columns.Add(btn);
                    btn.HeaderText = "Action";
                    btn.Text = "Edit";
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

        // Search button method //
        private void btn_search_Click_1(object sender, EventArgs e)
        {
            Load_Data_Grid("Prc_crs_search", 1);
        }

        private void btn_refresh_Click_1(object sender, EventArgs e)
        {
            Load_Data_Grid("Prc_CourseView", 0);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Frm_Course objCrs = new Frm_Course();

                //populate the textbox from specific value of the coordinates of column and row.
                Frm_CourseView.crs_id = row.Cells[4].Value.ToString();
                Frm_CourseView.crs_code = row.Cells[1].Value.ToString();
                Frm_CourseView.crs_name = row.Cells[2].Value.ToString();
                Frm_CourseView.crs_desc = row.Cells[3].Value.ToString();
                Frm_CourseView.flag = 1;
                objCrs.Show();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            //printer.Title = "Seshadripuram College Tumakuru";
            printer.SubTitle = "Course";
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);
        }
    }
}
