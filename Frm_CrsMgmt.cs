using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_CrsMgmt : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;

        public static string Map_id;
        public static string Crs_id;
        public static string Crs_name;
        public static string sem;
        public static string Sub_id;
        public static string Sub_name;
        public static int chk=0;
        int flag = 0;

        public Frm_CrsMgmt()
        {
            InitializeComponent();
        }
        private void LoadMappedSubjects(string Prc,int flag)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {

                SqlCommand cmd = new SqlCommand(Prc, con);
                if(flag==1)
                {
                    cmd.Parameters.AddWithValue("@Crs_Id", cmb_coursename.SelectedValue);
                    cmd.Parameters.AddWithValue("@Sem", cmb_semester.Text);
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
                    dataGridView1.ColumnCount = 7;


                    //Add Columns
                    dataGridView1.Columns[1].Name = "Sub_Name";
                    dataGridView1.Columns[1].HeaderText = "Subject Name";
                    dataGridView1.Columns[1].DataPropertyName = "Sub_Name";
                    dataGridView1.Columns[1].Width = 200;

                    dataGridView1.Columns[2].Name = "Sub_Category";
                    dataGridView1.Columns[2].HeaderText = "Category";
                    dataGridView1.Columns[2].DataPropertyName = "Sub_Category";
                    dataGridView1.Columns[2].Width = 200;                    

                    dataGridView1.Columns[3].Name = "Semester";
                    dataGridView1.Columns[3].HeaderText = "Semester";
                    dataGridView1.Columns[3].DataPropertyName = "Semester";

                    dataGridView1.Columns[4].DataPropertyName = "Crs_Id";
                    dataGridView1.Columns[4].Visible = false;

                    dataGridView1.Columns[5].DataPropertyName = "Sub_Id";
                    dataGridView1.Columns[5].Visible = false;

                    dataGridView1.Columns[6].DataPropertyName = "Map_Id";
                    dataGridView1.Columns[6].Visible = false;

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
            flag = 0;
        }
       
        private void btn_ok_Click(object sender, EventArgs e)
        {
            if((cmb_coursename.Text!="")&&(cmb_semester.Text!=""))
            {
                LoadMappedSubjects("Prc_MapViewSubSem", 1);
            }
        }
        private void DisplayChkLst()
        {
            if (flag == 1)
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("PrcChkCrsSub", con);
                    cmd.Parameters.AddWithValue("@Crs_Id", cmb_CrsMapInsert.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    ChkLstSub.DataSource = dt;
                    ChkLstSub.DisplayMember = "Sub_Name";
                    ChkLstSub.ValueMember = "Sub_Id";
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
        private void Frm_CrsMgmt_Load(object sender, EventArgs e)
        {
            Frm_Home.Load_SubjectCombo(cmb_coursename);
            Frm_Home.Load_SubjectCombo(cmb_CrsMapInsert);
            flag = 1;
            DisplayChkLst();
        }
        private void cmb_CrsMapInsert_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayChkLst();            
        }

        private void btn_ok_insert_Click(object sender, EventArgs e)
        {
            string message;
            // if((cmb_CrsMapInsert.SelectedIndex!=-1)&&(cmb_sem_insert.SelectedIndex!=-1))//(cmb_MapSub.SelectedIndex!=-1)&&
            if (cmb_CrsMapInsert.SelectedIndex != -1 && ChkLstSub.CheckedItems.Count != 0 && cmb_sem_insert.SelectedIndex!=-1)
            {
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    SqlCommand cmd = new SqlCommand("PrcMapInsert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    foreach (var item in ChkLstSub.CheckedItems)
                    {                        
                        DataRowView row = item as DataRowView;

                        cmd.Parameters.AddWithValue("@Cours_Id", cmb_CrsMapInsert.SelectedValue);
                        cmd.Parameters.AddWithValue("@Subject_Id", row["Sub_Id"]);
                        //cmd.Parameters.AddWithValue("@Subject_Id", cmb_MapSub.SelectedValue);
                        cmd.Parameters.AddWithValue("@Semester", cmb_sem_insert.Text);
                        cmd.Parameters.AddWithValue("@MapDate", dateTimePicker1.Value.Date);
                        cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                        cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                        cmd.ExecuteNonQuery();
                        message = (string)cmd.Parameters["@ERROR"].Value;
                        cmd.Parameters.Clear();                        
                        label_status.Text = message;
                    }
                    MessageBox.Show("Operation Successful");
                    DisplayChkLst();
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_CrsMapInsert.Text = "";
          //  cmb_MapSub.Text = "";
            cmb_semester.Text = "";
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            //printer.Title = "Seshadripuram College Tumakuru";
            printer.SubTitle = "Mapping Details";
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

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void cmb_semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmb_coursename.Text != "") && (cmb_semester.Text != ""))
            {
                LoadMappedSubjects("Prc_MapViewSubSem", 1);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if ((cmb_coursename.Text != "") && (cmb_semester.Text != ""))
            {
                LoadMappedSubjects("Prc_MapViewSubSem", 1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                Frm_CrsMgmt.chk = 0;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Frm_MapUpdate objmap = new Frm_MapUpdate();
                //populate the textbox from specific value of the coordinates of column and row.

                Frm_CrsMgmt.Map_id = row.Cells[6].Value.ToString();
                Frm_CrsMgmt.Crs_id = row.Cells[4].Value.ToString();
                Frm_CrsMgmt.Crs_name = row.Cells[1].Value.ToString();
                Frm_CrsMgmt.sem = row.Cells[3].Value.ToString();
                Frm_CrsMgmt.Sub_id = row.Cells[5].Value.ToString();
                Frm_CrsMgmt.Sub_name = row.Cells[2].Value.ToString();

                objmap.Show();
            }
        }
    }
}
