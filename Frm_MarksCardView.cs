using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_MarksCardView : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
       // public static int flag = 0;
        public static string regno = "";
        public static string sem = "";        
        public Frm_MarksCardView()
        {
            InitializeComponent();
        }

        // Reset / Clear datagridview
        private void ResetDataGridView(DataGridView dgvs)
        {
            dgvs.CancelEdit();
            dgvs.Columns.Clear();
            dgvs.DataSource = null;            
        }
        private void DataGrid_Retrieve(string prc,int flag,DataGridView dgv)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd1 = new SqlCommand(prc, con);
                if(flag==1)
                {
                    cmd1.Parameters.AddWithValue("@regno", txtbx_regno.Text);
                }                
                else if(flag==2)
                {
                    cmd1.Parameters.AddWithValue("@regno", txtbx_regno.Text);
                    cmd1.Parameters.AddWithValue("@sem", cmb_sem.Text);
                }
                else if(flag==3)
                {
                    cmd1.Parameters.AddWithValue("@regno", txtbx_regno.Text);
                    cmd1.Parameters.AddWithValue("@result", cmb_result_regno.Text);
                }
                else if(flag==4)
                {                    
                    cmd1.Parameters.AddWithValue("@Courseid", cmb_course_sort.SelectedValue);
                    cmd1.Parameters.AddWithValue("@Year", txtbx_batch.Text.Substring(2));
                    cmd1.Parameters.AddWithValue("@Result", cmbbx_result_sort.Text);
                    cmd1.Parameters.AddWithValue("@Semester", cmb_sem_sort.Text);
                }
                cmd1.CommandType = CommandType.StoredProcedure;
                con.Open();
                if(flag!=4)
                {
                    using (SqlDataReader dr = cmd1.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Lbl_StuName.Text = (dr["StuName"].ToString());
                            Lbl_Course.Text = (dr["Course_Name"].ToString());
                            if (flag == 2)
                            {
                                Lbl_G_Total.Text = (dr["G_Total"].ToString());
                                Lbl_SGPA.Text = (dr["SGPA"].ToString());
                                Lbl_FinalRes.Text = (dr["Final_Result"].ToString());
                            }
                            if (Lbl_FinalRes.Text == "FAIL")
                            {
                                Lbl_FinalRes.ForeColor = Color.Red;
                                Lbl_G_Total.ForeColor = Color.Red;
                                Lbl_SGPA.ForeColor = Color.Red;
                            }
                            else
                            {
                                Lbl_G_Total.ForeColor = Color.Green;
                                Lbl_SGPA.ForeColor = Color.Green;
                                Lbl_FinalRes.ForeColor = Color.Green;
                            }

                        }
                        else
                        {
                            Lbl_Course.Text = "";
                            Lbl_StuName.Text = "";
                            Lbl_FinalRes.Text = "";
                            Lbl_G_Total.Text = "";
                            Lbl_SGPA.Text = "";
                        }
                    }                
                }
                using (SqlDataAdapter adt = new SqlDataAdapter(cmd1))
                {
                    DataTable dt = new DataTable();
                    adt.Fill(dt);

                    ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////

                    // Clear binding
                    dgv.DataSource = null;

                    //Set AutoGenerateColumns False
                    dgv.AutoGenerateColumns = false;                    

                    //Set Columns Count
                    if (flag==1)
                    {
                        dgv.ColumnCount = 12;
                        dataGridView_sem.Visible = false;// semester wise result
                        dataGridView_Sort.Visible = false;
                        dataGridView_regno.Visible = true;  // all semester result

                        dgv.Columns[1].Name = "stu_id";
                        dgv.Columns[1].Visible = false;
                        dgv.Columns[1].ReadOnly = true;
                        dgv.Columns[1].DataPropertyName = "stu_id";

                        dgv.Columns[2].Name = "RegNo";
                        dgv.Columns[2].HeaderText = "Register No.";
                        dgv.Columns[2].ReadOnly = true;
                        dgv.Columns[2].DataPropertyName = "RegNo";
                        dgv.Columns[2].Visible = false;

                        dgv.Columns[3].Name = "StuName";
                        dgv.Columns[3].HeaderText = "Name";
                        dgv.Columns[3].ReadOnly = true;
                        dgv.Columns[3].DataPropertyName = "StuName";
                        dgv.Columns[3].Visible = false;

                        dgv.Columns[4].Name = "CourseId";
                        dgv.Columns[4].Visible = false;
                        dgv.Columns[4].DataPropertyName = "CourseId";

                        dgv.Columns[5].Name = "Course_Name";
                        dgv.Columns[5].HeaderText = "Course";
                        dgv.Columns[5].ReadOnly = true;
                        dgv.Columns[5].DataPropertyName = "Course_Name";
                        dgv.Columns[5].Visible = false;

                        dgv.Columns[6].Name = "Semester";
                        dgv.Columns[6].HeaderText = "Semester";
                        dgv.Columns[6].ReadOnly = true;
                        dgv.Columns[6].DataPropertyName = "Semester";

                        dgv.Columns[7].Name = "Sub_Sum_th_IA";
                        dgv.Columns[7].HeaderText = "Total (Max. Marks)";
                        dgv.Columns[7].ReadOnly = true;
                        dgv.Columns[7].DataPropertyName = "Max_Marks";
                        dgv.Columns[7].Width = 80;

                        dgv.Columns[8].Name = "Total_Sec";
                        dgv.Columns[8].HeaderText = "Total (Sec. Marks)";
                        dgv.Columns[8].ReadOnly = true;
                        dgv.Columns[8].DataPropertyName = "G_Total";
                        dgv.Columns[8].Width = 80;

                        dgv.Columns[9].Name = "SGPA";
                        dgv.Columns[9].HeaderText = "SGPA";
                        dgv.Columns[9].ReadOnly = true;
                        dgv.Columns[9].DataPropertyName = "SGPA";

                        dgv.Columns[10].Name = "Final_Result";
                        dgv.Columns[10].HeaderText = "Result";
                        dgv.Columns[10].ReadOnly = true;
                        dgv.Columns[10].DataPropertyName = "Final_Result";

                        dgv.Columns[11].Name = "Card_Id";
                        dgv.Columns[11].Visible = false;
                        dgv.Columns[11].ReadOnly = true;
                        dgv.Columns[11].DataPropertyName = "Card_Id";
                    }                        
                    else if ((flag == 2)||(flag==3))
                    {
                        dgv.ColumnCount = 24;
                        dataGridView_regno.Visible = false;
                        dataGridView_Sort.Visible = false;
                        dataGridView_sem.Visible = true;

                        dgv.Columns[1].Name = "stu_id";
                        dgv.Columns[1].Visible = false;
                        dgv.Columns[1].ReadOnly = true;
                        dgv.Columns[1].DataPropertyName = "stu_id";

                        dgv.Columns[2].Name = "RegNo";
                        //dgv.Columns[2].HeaderText = "Register No.";
                        //dgv.Columns[2].ReadOnly = true;
                        dgv.Columns[2].DataPropertyName = "RegNo";
                        dgv.Columns[2].Visible = false;

                        dgv.Columns[3].Name = "StuName";
                        //dgv.Columns[3].HeaderText = "Name";
                        //dgv.Columns[3].ReadOnly = true;
                        dgv.Columns[3].DataPropertyName = "StuName";
                        dgv.Columns[3].Visible = false;

                        dgv.Columns[4].Name = "CourseId";
                        dgv.Columns[4].Visible = false;
                        dgv.Columns[4].DataPropertyName = "CourseId";

                        dgv.Columns[5].Name = "Course_Name";
                        //dgv.Columns[5].HeaderText = "Course";
                        //dgv.Columns[5].ReadOnly = true;
                        dgv.Columns[5].DataPropertyName = "Course_Name";
                        dgv.Columns[5].Visible = false;

                        dgv.Columns[6].Name = "Semester";
                        //dgv.Columns[6].HeaderText = "Semester";
                        //dgv.Columns[6].ReadOnly = true;
                        dgv.Columns[6].DataPropertyName = "Semester";
                        if(flag==3)
                        {
                            dgv.Columns[6].HeaderText = "Semester";
                            dgv.Columns[6].ReadOnly = true;
                            dgv.Columns[6].Visible = true;
                        }                        
                        else
                            dgv.Columns[6].Visible = false;

                        dgv.Columns[7].Name = "Sub_Sum_th_IA";
                        //dgv.Columns[7].HeaderText = "Total (Max. Marks)";
                        //dgv.Columns[7].ReadOnly = true;
                        dgv.Columns[7].DataPropertyName = "Max_Marks";
                        dgv.Columns[7].Visible = false;

                        dgv.Columns[8].Name = "G_Total_Sec";
                        //dgv.Columns[8].HeaderText = "Total (Sec. Marks)";
                        //dgv.Columns[8].ReadOnly = true;
                        dgv.Columns[8].Visible = false;
                        dgv.Columns[8].DataPropertyName = "G_Total";

                        dgv.Columns[9].Name = "SGPA";
                        //dgv.Columns[9].HeaderText = "SGPA";
                        //dgv.Columns[9].ReadOnly = true;
                        dgv.Columns[9].Visible = false;
                        dgv.Columns[9].DataPropertyName = "SGPA";

                        dgv.Columns[10].Name = "Final_Result";
                        //dgv.Columns[10].HeaderText = "Result";
                        //dgv.Columns[10].ReadOnly = true;
                        dgv.Columns[10].Visible = false;
                        dgv.Columns[10].DataPropertyName = "Final_Result";
                        dgv.Columns[10].Width = 60;

                        dgv.Columns[11].Name = "Subject_Id";
                        dgv.Columns[11].Visible = false;
                        dgv.Columns[11].DataPropertyName = "Subject_Id";

                        dgv.Columns[12].Name = "Sub_Name";
                        dgv.Columns[12].HeaderText = "Subject";
                        dgv.Columns[12].ReadOnly = true;
                        dgv.Columns[12].DataPropertyName = "Sub_Name";
                        dgv.Columns[12].Width = 360;

                        dgv.Columns[13].Name = "Sub_th_Max";
                        dgv.Columns[13].HeaderText = "Theory/Practicals (Max. Marks)";
                        dgv.Columns[13].ReadOnly = true;
                        dgv.Columns[13].DataPropertyName = "Sub_th_Max";
                        dgv.Columns[13].Width = 60;

                        dgv.Columns[14].Name = "Sub_th_Min";
                        dgv.Columns[14].HeaderText = "Theory/Practicals (Min. Marks)";
                        dgv.Columns[14].ReadOnly = true;
                        dgv.Columns[14].DataPropertyName = "Sub_th_Min";
                        dgv.Columns[14].Width = 60;

                        dgv.Columns[15].Name = "Th_Sec";
                        dgv.Columns[15].HeaderText = "Theory/Practicals (Sec. Marks)";
                        dgv.Columns[15].ReadOnly = true;
                        dgv.Columns[15].DataPropertyName = "Th_Sec";
                        dgv.Columns[15].Width = 60;
                        dgv.Columns[15].DefaultCellStyle.BackColor = Color.Gold;

                        dgv.Columns[16].Name = "Sub_IA_Max";
                        dgv.Columns[16].HeaderText = "IA (Max. Marks)";
                        dgv.Columns[16].ReadOnly = true;
                        dgv.Columns[16].DataPropertyName = "Sub_IA_Max";
                        dgv.Columns[16].Width = 60;

                        dgv.Columns[17].Name = "Sub_IA_Min";
                        dgv.Columns[17].HeaderText = "IA (Min. Marks)";
                        dgv.Columns[17].ReadOnly = true;
                        dgv.Columns[17].DataPropertyName = "Sub_IA_Min";
                        dgv.Columns[17].Width = 60;

                        dgv.Columns[18].Name = "IA_Sec";
                        dgv.Columns[18].HeaderText = "IA (Sec. Marks)";
                        dgv.Columns[18].ReadOnly = true;
                        dgv.Columns[18].DataPropertyName = "IA_Sec";
                        dgv.Columns[18].Width = 60;
                        dgv.Columns[18].DefaultCellStyle.BackColor = Color.Gold;

                        dgv.Columns[19].Name = "Sub_Sum_th_IA";
                        dgv.Columns[19].HeaderText = "Total (Max. Marks)";
                        dgv.Columns[19].ReadOnly = true;
                        dgv.Columns[19].DataPropertyName = "Sub_Sum_th_IA";
                        dgv.Columns[19].Width = 60;

                        dgv.Columns[20].Name = "Total_Sec";
                        dgv.Columns[20].HeaderText = "Total (Sec. Marks)";
                        dgv.Columns[20].ReadOnly = true;
                        dgv.Columns[20].DataPropertyName = "Total_Sec";
                        dgv.Columns[20].Width = 60;
                        dgv.Columns[20].DefaultCellStyle.BackColor = Color.Goldenrod;

                        dgv.Columns[21].Name = "Result";
                        dgv.Columns[21].HeaderText = "Result";
                        dgv.Columns[21].ReadOnly = true;
                        dgv.Columns[21].DataPropertyName = "Result";
                        dgv.Columns[21].Width = 70;
                        dgv.Columns[21].DefaultCellStyle.BackColor = Color.Goldenrod;

                        dgv.Columns[22].Name = "Year";
                        dgv.Columns[22].HeaderText = "Year";
                        dgv.Columns[22].ReadOnly = true;
                        dgv.Columns[22].DataPropertyName = "Year";
                        dgv.Columns[22].Width = 60;

                        dgv.Columns[23].Name = "Card_Id";
                        dgv.Columns[23].Visible = false;
                        dgv.Columns[23].ReadOnly = true;
                        dgv.Columns[23].DataPropertyName = "Card_Id";
                    }
                    else if(flag==4)
                    {                        
                        dataGridView_sem.Visible = false; // semester wise result
                        dataGridView_regno.Visible = false;  // all semester result
                        
                        if (cmb_sem_sort.Text!="")
                        {
                            ResetDataGridView(dgv);
                            dgv.ColumnCount = 11;                            

                            dgv.Columns[1].Name = "RegNo";
                            dgv.Columns[1].HeaderText = "Register No.";
                            dgv.Columns[1].ReadOnly = true;
                            dgv.Columns[1].Width = 150;
                            dgv.Columns[1].DataPropertyName = "RegNo";

                            dgv.Columns[2].Name = "StuName";
                            dgv.Columns[2].HeaderText = "Name";
                            dgv.Columns[2].ReadOnly = true;
                            dgv.Columns[2].Width = 200;
                            dgv.Columns[2].DataPropertyName = "StuName";

                            dgv.Columns[3].Name = "Course_Name";
                            dgv.Columns[3].HeaderText = "Course";
                            dgv.Columns[3].ReadOnly = true;
                            dgv.Columns[3].DataPropertyName = "Course_Name";

                            dgv.Columns[4].Name = "Semester";
                            dgv.Columns[4].HeaderText = "Sem";
                            dgv.Columns[4].ReadOnly = true;
                            dgv.Columns[4].Width = 100;
                            dgv.Columns[4].DataPropertyName = "Semester";

                            dgv.Columns[5].Name = "Max_Marks";
                            dgv.Columns[5].HeaderText = "Max. Marks";
                            dgv.Columns[5].ReadOnly = true;
                            dgv.Columns[5].Width = 100;
                            dgv.Columns[5].DataPropertyName = "Max_Marks";

                            dgv.Columns[6].Name = "G_Total";
                            dgv.Columns[6].HeaderText = "Sec. Marks";
                            dgv.Columns[6].ReadOnly = true;
                            dgv.Columns[6].Width = 100;
                            dgv.Columns[6].DataPropertyName = "G_Total";

                            dgv.Columns[7].Name = "Percentage";
                            dgv.Columns[7].HeaderText = "Percentage";
                            dgv.Columns[7].ReadOnly = true;
                            dgv.Columns[7].Width = 120;
                            dgv.Columns[7].DataPropertyName = "Percentage";

                            dgv.Columns[8].Name = "Final_Result";
                            dgv.Columns[8].HeaderText = "Result";
                            dgv.Columns[8].ReadOnly = true;
                            dgv.Columns[8].Width = 100;
                            dgv.Columns[8].DataPropertyName = "Final_Result";

                            dgv.Columns[9].Name = "stu_id";
                            dgv.Columns[9].Visible = false;
                            dgv.Columns[9].ReadOnly = true;
                            dgv.Columns[9].DataPropertyName = "stu_id";

                            dgv.Columns[10].Name = "Card_Id";
                            dgv.Columns[10].Visible = false;
                            dgv.Columns[10].ReadOnly = true;
                            dgv.Columns[10].DataPropertyName = "Card_Id";
                        }
                        else
                        {
                            ResetDataGridView(dgv);

                            dgv.ColumnCount = 12;

                            dgv.Columns[1].Name = "RegNo";
                            dgv.Columns[1].HeaderText = "Register No.";
                            dgv.Columns[1].ReadOnly = true;
                            dgv.Columns[1].Width = 150;
                            dgv.Columns[1].DataPropertyName = "RegNo";

                            dgv.Columns[2].Name = "StuName";
                            dgv.Columns[2].HeaderText = "Name";
                            dgv.Columns[2].ReadOnly = true;
                            dgv.Columns[2].Width = 200;
                            dgv.Columns[2].DataPropertyName = "StuName";

                            dgv.Columns[3].Name = "Course_Name";
                            dgv.Columns[3].HeaderText = "Course";
                            dgv.Columns[3].ReadOnly = true;
                            dgv.Columns[3].DataPropertyName = "Course_Name";

                            dgv.Columns[4].Name = "I";
                            dgv.Columns[4].HeaderText = "I Sem";
                            dgv.Columns[4].ReadOnly = true;
                            dgv.Columns[4].DataPropertyName = "I";

                            dgv.Columns[5].Name = "II";
                            dgv.Columns[5].HeaderText = "II Sem";
                            dgv.Columns[5].ReadOnly = true;
                            dgv.Columns[5].DataPropertyName = "II";

                            dgv.Columns[6].Name = "III";
                            dgv.Columns[6].HeaderText = "III Sem";
                            dgv.Columns[6].ReadOnly = true;
                            dgv.Columns[6].DataPropertyName = "III";

                            dgv.Columns[7].Name = "IV";
                            dgv.Columns[7].HeaderText = "IV Sem";
                            dgv.Columns[7].ReadOnly = true;
                            dgv.Columns[7].DataPropertyName = "IV";

                            dgv.Columns[8].Name = "V";
                            dgv.Columns[8].HeaderText = "V Sem";
                            dgv.Columns[8].ReadOnly = true;
                            dgv.Columns[8].DataPropertyName = "V";

                            dgv.Columns[9].Name = "VI";
                            dgv.Columns[9].HeaderText = "VI Sem";
                            dgv.Columns[9].ReadOnly = true;
                            dgv.Columns[9].DataPropertyName = "VI";

                            dgv.Columns[10].Name = "stu_id";
                            dgv.Columns[10].Visible = false;
                            dgv.Columns[10].ReadOnly = true;
                            dgv.Columns[10].DataPropertyName = "stu_id";

                            dgv.Columns[11].Name = "Card_Id";
                            dgv.Columns[11].Visible = false;
                            dgv.Columns[11].ReadOnly = true;
                            dgv.Columns[11].DataPropertyName = "Card_Id";
                        }                        
                    }
                    dgv.DataSource = dt;                    
                    dgv.Visible = true;
                    dgv.AllowUserToAddRows = false;                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR !. Something went wrong ,Please contact your Developer !! \n\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView_sem.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
       
        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView_regno.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtbx_regno_TextChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            //btn_Print.Visible = false;

            cmb_sem.Text = "-- SEM --";
            cmb_result_regno.Text = "SELECT RESULT";
            txtbx_batch.Text = "";
            cmb_course_sort.Text = "";
            cmbbx_result_sort.Text = "";
            DataGrid_Retrieve("Prc_Search_Regno", 1, dataGridView_regno);
        }

        private void cmb_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtbx_regno.Text != "")
            {
                cmb_sem.Text = "-- SEM --";
                DataGrid_Retrieve("Prc_Search_Result", 3, dataGridView_sem);
                panel_result.Visible = false;

                pictureBox1.Visible = false;
                //btn_Print.Visible = false;
            }
            else
            {                
                MessageBox.Show("Enter the Register/USN No. !");
                cmb_sem.Text = "-- SEM --";
            }                
        }

        private void cmb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtbx_regno.Text != "")
            {
                cmb_result_regno.Text = "SELECT RESULT";
                dataGridView_sem.DataSource = null;
                DataGrid_Retrieve("Prc_Search_RegnoSem", 2, dataGridView_sem);
                panel_result.Visible = true;

                pictureBox1.Visible = false;
               // btn_Print.Visible = false;
            }
            else
            {                
                MessageBox.Show("Enter the Register/USN No. !");
                cmb_result_regno.Text = "SELECT RESULT";
            }               
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_MarksCardView_Load(object sender, EventArgs e)
        {
            Frm_Home.Load_SubjectCombo(cmb_course_sort);
            cmb_course_sort.Text = "";

            pictureBox1.Visible = false;

            btn_Print.Visible = false;
        }

        private void btn_sort_CrsYrs_Click(object sender, EventArgs e)
        {
            //txtbx_regno.Text = "";
            Lbl_Course.Text = "";
            Lbl_StuName.Text = "";
            panel_result.Visible = false;
            if ((txtbx_batch.Text.Length == 4) && (cmb_course_sort.Text != ""))
            {
                pictureBox1.Visible = true;
                btn_Print.Visible = true;

                DataGrid_Retrieve("Prc_ViewStu_Marks_AllSem", 4, dataGridView_Sort);                
            }                
            else
            {
                MessageBox.Show("Enter valid Batch(ex: 2017) and select Semester");
            }                
        }

        private void dataGridView_Sort_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView_Sort.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btn_search_regno_Click(object sender, EventArgs e)
        {
            txtbx_batch.Text = "";
            cmb_course_sort.Text = "";
            cmbbx_result_sort.Text = "";
            cmb_sem.Text = "--SEM--";
            cmb_result_regno.Text = "SELECT RESULT";
            DataGrid_Retrieve("Prc_Search_Regno", 1, dataGridView_regno);
        }

        // Disable key enter for combobox Name="cmb_sem" //
        private void cmb_sem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Disable key enter for combobox  Name="cmb_result_regno" //
        private void cmb_result_regno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Disable key enter for combobox  Name="cmb_course_sort" //
        private void cmb_course_sort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Disable key enter for combobox  Name="cmbbx_result_sort" //
        private void cmbbx_result_sort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Disable key enter for combobox  Name="cmb_sem_sort" //
        private void cmb_sem_sort_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        // Update students marks//
        private void btn_Update_Click(object sender, EventArgs e)
        {            
            if((txtbx_regno.Text!="")&&(cmb_sem.Text!="")
                &&(cmb_sem.Text!= "-- SEM --")&&(Lbl_StuName.Text!=""))
            {
                Frm_MarksCard.flag1 = 1;
                if (ActiveMdiChild != null)
                    ActiveMdiChild.Close();
                Frm_MarksCardView.regno = txtbx_regno.Text;
                Frm_MarksCardView.sem = cmb_sem.Text;
                Frm_MarksCard objmkscd = new Frm_MarksCard();
                objmkscd.MdiParent = this.ParentForm;
                objmkscd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter USN/Register Number and select Semester, to update.");
            }            
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
            printer.PrintDataGridView(dataGridView_Sort);            
        }
    }
}
