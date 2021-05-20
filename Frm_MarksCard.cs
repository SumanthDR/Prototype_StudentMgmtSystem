using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MARKSCARDMANAGEMENT
{
    public partial class Frm_MarksCard : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
        public static int flag1=0,flag2=0;
        int courseid, sub_id, cal = 0, flag=0;
        ArrayList lists = new ArrayList();
        //ArrayList list = new ArrayList();
        ArrayList Arrlist1 = new ArrayList();
        ArrayList Arrlist2 = new ArrayList();
        public Frm_MarksCard()
        {
            InitializeComponent();
           // setFormSize();
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
        //````````````````` Auto-fit form size to the system resolution```````````````````//

        //private void setFormSize()
        //{
        //    Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        //    int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
        //    int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
        //    this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
        //    this.Size = new Size(w, h);
        //}
        //=================================== CONVERTS NUMBER TO WORDS ===================================================//
        public string ConvertNumbertoWords(long number)
        {
            if (number == 0) return "ZERO";
            if (number < 0) return "minus " + ConvertNumbertoWords(Math.Abs(number));
            string words = "";
            if ((number / 1000000) > 0)
            {
                words += ConvertNumbertoWords(number / 100000) + " LAKHS ";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                words += ConvertNumbertoWords(number / 1000) + " THOUSAND ";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                words += ConvertNumbertoWords(number / 100) + " HUNDRED ";
                number %= 100;
            }
            if (number > 0)
            {
                if (words != "") words += "AND ";
                var unitsMap = new[]   
                    {  
                        "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN"  
                    };
                var tensMap = new[]   
                    {  
                        "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY"  
                    };
                if (number < 20) words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0) words += " " + unitsMap[number % 10];
                }
            }
            return words;
        }


        //------------------ Calculates all the values and puts result in another cell ---------------//
        private void Calculate(DataGridView dgv,int flag1)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if ((Convert.ToString(row.Cells["Sub_th_Sec"].Value) == string.Empty) ||
                        (Convert.ToString(row.Cells["Sub_IA_Sec"].Value) == string.Empty) ||
                        (Convert.ToString(row.Cells["Year"].Value) == string.Empty))
                {
                    label_status.Text = "ERROR, Please fill all the feilds.";
                    lists.Add(1);
                }
                if ((Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Sec"].Index].Value)) >
                    (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_th_Max"].Index].Value)) ||
                    (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Sec"].Index].Value)) >
                    (Convert.ToInt32(row.Cells[dataGridView1.Columns["Sub_IA_Max"].Index].Value)))
                {
                    label_status.Text = "ERROR, Secured marks must be less than OR equal to Maximum Marks";
                    lists.Add(1);
                }
            }
            if(!lists.Contains(1))
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    row.Cells[dgv.Columns["Total_Max"].Index].Value = ((Convert.ToInt32(row.Cells[dgv.Columns["Sub_th_Max"].Index].Value)) + (Convert.ToInt32(row.Cells[dgv.Columns["Sub_IA_Max"].Index].Value)));
                    row.Cells[dgv.Columns["Total_Sec"].Index].Value = ((Convert.ToInt32(row.Cells[dgv.Columns["Sub_th_Sec"].Index].Value)) + (Convert.ToInt32(row.Cells[dgv.Columns["Sub_IA_Sec"].Index].Value)));

                    if ((Convert.ToInt32(row.Cells[dgv.Columns["Sub_th_Sec"].Index].Value)) >=
                        (Convert.ToInt32(row.Cells[dgv.Columns["Sub_th_Min"].Index].Value)) &&
                        (Convert.ToInt32(row.Cells[dgv.Columns["Sub_IA_Sec"].Index].Value)) >=
                        (Convert.ToInt32(row.Cells[dgv.Columns["Sub_IA_Min"].Index].Value)))
                    {
                        row.Cells[dgv.Columns["Result"].Index].Value = "PASS";
                    }
                    else
                    {
                        row.Cells[dgv.Columns["Result"].Index].Value = "FAIL";
                    }

                }
                //Sum each row //
                int sum = 0;
                int sum1 = 0;
                //int flag2 = 0;
              
                for (int i = 0; i < dgv.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dgv.Rows[i].Cells[8].Value);
                    sum1 += Convert.ToInt32(dgv.Rows[i].Cells[9].Value);
                }
                for (int i = 0; i < dgv.Rows.Count; ++i)
                {
                    if (dgv.Rows[i].Cells[10].Value == "PASS")
                    {
                        //txtbx_result.Text = "PASS";
                        if(flag1==0)
                            Arrlist1.Add(1);
                        if (flag1 == 1)
                            Arrlist2.Add(1);
                    }                    
                }
                for (int i = 0; i < dgv.Rows.Count; ++i)
                {
                    if (dgv.Rows[i].Cells[10].Value == "FAIL")
                    {
                        //txtbx_result.Text = "FAIL";
                        if (flag1 == 0)
                            Arrlist1.Add(2);
                        if (flag1 == 1)
                            Arrlist2.Add(2);
                    }
                }
                if (flag1 == 0)
                {
                    txtbx_max_mks.Text = sum.ToString();
                    txtbx_gtotal.Text = sum1.ToString();
                }
                // Display Final Result //
                if ((Arrlist1.Contains(2)) || (Arrlist2.Contains(2)))
                {
                    txtbx_result.Text = "FAIL";
                }
                else if ((!Arrlist1.Contains(2)) && (!Arrlist2.Contains(2)))
                {
                    txtbx_result.Text = "PASS";
                }
                //Calculate SGPA//
                txtbx_sgpa.Text = Math.Round(((float.Parse(txtbx_gtotal.Text)) / (float.Parse(txtbx_max_mks.Text)) * 10), 2).ToString();
                //Calculate Percentage//
                txtbx_per.Text = Math.Round(((float.Parse(txtbx_gtotal.Text)) / (float.Parse(txtbx_max_mks.Text)) * 100), 2).ToString();
                //Display in words//
                txtbx_gtotal_words.Text = ConvertNumbertoWords(Convert.ToInt64(txtbx_gtotal.Text));

                if ((cal == 1) && (flag1 == 0))
                    flag = 1;
                if((cal==1)&&(flag1==1))
                {
                    if(flag2==1)
                    {
                        SaveValuesDatagrid(dataGridView1, "Prc_MarksCard_Update");
                        SaveValuesDatagrid(dataGridView2, "Prc_MarksCard_Update");                        
                    }
                    else
                    {
                        SaveValuesDatagrid(dataGridView1, "Prc_MarksCard_Inser");
                        SaveValuesDatagrid(dataGridView2, "Prc_MarksCard_Inser");
                    }
                }                    
            }             
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }
        
        // Sum the cells and display the output in other cell  (Calculate Method is called) //
        private void btnsum_Click(object sender, EventArgs e)
        {
            lists.Clear();
            Arrlist1.Clear();
            Arrlist2.Clear();
            Calculate(dataGridView1, 0);
            Calculate(dataGridView2, 1);
        }

        private void btn_clearall_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            cmb_sem.Text = "";
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }

        // Retrievs all subjects associated to that particular Course ,Semester and Regno //
        private void display_all_subjects(DataGridView dgv1)
        {
            if ((txtbx_coursename.Text != "") && (txtbx_name.Text != "") && (txtbx_Regno.Text != ""))
            {
                string Prcstr="";
                SqlConnection con = new SqlConnection(connectionString);
                try
                {
                    if (dgv1 == dataGridView1)
                    {
                        if (Frm_MarksCard.flag1 == 1)
                            Prcstr = "Prc_ViewSemMarks_Update";
                        else
                            Prcstr = "Prc_ViewSemMarks";                        
                    }                        
                    if(dgv1 == dataGridView2)
                    {
                        if (Frm_MarksCard.flag1 == 1)
                            Prcstr = "Prc_ViewSubsidairy_Update";
                        else
                            Prcstr = "Prc_ViewSubsidairy";                        
                    }                        
                    SqlCommand cmd = new SqlCommand(Prcstr, con);
                    cmd.Parameters.AddWithValue("@course_id", courseid);
                    cmd.Parameters.AddWithValue("@semester", cmb_sem.Text);
                    cmd.Parameters.AddWithValue("@regno", txtbx_Regno.Text);
                    cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                    cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    // For Datagrid View subjects //
                    con.Open();

                    using (SqlDataAdapter adt = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();

                        adt.Fill(dt);

                        ///     CREATES BUTTON IN DATAGRID VIEW  /////////////////

                        // Clear binding
                        dgv1.DataSource = null;

                        //Set AutoGenerateColumns False
                        dgv1.AutoGenerateColumns = false;

                        //Set Columns Count
                        dgv1.ColumnCount = 16;

                        //Add Columns
                        dgv1.Columns[1].Name = "Sub_Name";
                        dgv1.Columns[1].HeaderText = "Subjects / Papers";
                        dgv1.Columns[1].DataPropertyName = "Sub_Name";
                        dgv1.Columns[1].ReadOnly = true;
                        dgv1.Columns[1].Width = 200;

                        dgv1.Columns[2].Name = "Sub_th_Max";
                        dgv1.Columns[2].HeaderText = "Theory/Practical (Max.)";
                        dgv1.Columns[2].DataPropertyName = "Sub_th_Max";
                        dgv1.Columns[2].ReadOnly = true;

                        dgv1.Columns[3].Name = "Sub_th_Min";
                        dgv1.Columns[3].HeaderText = "Theory/Practical (Min.)";
                        dgv1.Columns[3].DataPropertyName = "Sub_th_Min";
                        dgv1.Columns[3].ReadOnly = true;

                        dgv1.Columns[4].Name = "Sub_th_Sec";
                        dgv1.Columns[4].HeaderText = "Theory/Practical (Sec.)";
                        dgv1.Columns["Sub_th_Sec"].DefaultCellStyle.BackColor = Color.Aquamarine;
                        if (Frm_MarksCard.flag1 == 1)
                            dgv1.Columns[4].DataPropertyName = "Th_Sec";

                        dgv1.Columns[5].Name = "Sub_IA_Max";
                        dgv1.Columns[5].HeaderText = "I.A/Record/Viva (Max.)";
                        dgv1.Columns[5].DataPropertyName = "Sub_IA_Max";
                        dgv1.Columns[5].ReadOnly = true;

                        dgv1.Columns[6].Name = "Sub_IA_Min";
                        dgv1.Columns[6].HeaderText = "I.A/Record/Viva (Min.)";
                        dgv1.Columns[6].DataPropertyName = "Sub_IA_Min";
                        dgv1.Columns[6].ReadOnly = true;

                        dgv1.Columns[7].Name = "Sub_IA_Sec";
                        dgv1.Columns[7].HeaderText = "I.A/Record/Viva (Sec.)";
                        dgv1.Columns["Sub_IA_Sec"].DefaultCellStyle.BackColor = Color.Aquamarine;
                        if (Frm_MarksCard.flag1 == 1)
                            dgv1.Columns[7].DataPropertyName = "IA_Sec";

                        dgv1.Columns[8].Name = "Total_Max";
                        dgv1.Columns[8].HeaderText = "Total (Max.)";
                        dgv1.Columns[8].ReadOnly = true;
                        
                        dgv1.Columns[9].Name = "Total_Sec";
                        dgv1.Columns[9].HeaderText = "Total (Sec.)";
                        dgv1.Columns[9].ReadOnly = true;
                        if (Frm_MarksCard.flag1 == 1)
                            dgv1.Columns[9].DataPropertyName = "Total_Sec";

                        dgv1.Columns[10].Name = "Result";
                        dgv1.Columns[10].HeaderText = "Result";
                        dgv1.Columns[10].ReadOnly = true;
                        dgv1.Columns[10].Width = 50;
                        if (Frm_MarksCard.flag1 == 1)
                            dgv1.Columns[10].DataPropertyName = "Result";

                        dgv1.Columns[11].Name = "Year";
                        dgv1.Columns[11].HeaderText = "Year";
                        dgv1.Columns["Year"].DefaultCellStyle.BackColor = Color.Aquamarine;
                        dgv1.Columns[11].Width = 100;
                        if (Frm_MarksCard.flag1 == 1)
                            dgv1.Columns[11].DataPropertyName = "Year";

                        //Course Id //
                        dgv1.Columns[12].Name = "Course_Id";
                        dgv1.Columns[12].DataPropertyName = "Course_Id";
                        dgv1.Columns[12].Visible = false;

                        //Subject Id //
                        dgv1.Columns[13].Name = "Subject_Id";
                        dgv1.Columns[13].DataPropertyName = "Subject_Id";
                        dgv1.Columns[13].Visible = false;

                        //Student Id //
                        dgv1.Columns[14].Name = "stu_id";
                        dgv1.Columns[14].DataPropertyName = "stu_id";
                        dgv1.Columns[14].Visible = false;

                        //Card Id //
                        dgv1.Columns[15].Name = "card_id";
                        dgv1.Columns[15].DataPropertyName = "Card_Id";
                        dgv1.Columns[15].Visible = false;

                        dgv1.DataSource = dt;

                        foreach (DataGridViewRow row in dgv1.Rows)
                        {
                            row.Cells[dgv1.Columns["Total_Max"].Index].Value = ((Convert.ToInt32(row.Cells[dgv1.Columns["Sub_th_Max"].Index].Value)) + (Convert.ToInt32(row.Cells[dgv1.Columns["Sub_IA_Max"].Index].Value)));
                        }
                    }
                    label_status.Text = (string)cmd.Parameters["@ERROR"].Value;
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
            else
            {
                dgv1.DataSource = null;
            }

        }
        // ComboBox Semester Code //

        // Displays all subjects associated with that particular Student USN and Semester //
        private void cmb_sem_SelectedIndexChanged(object sender, EventArgs e)
        {
            display_all_subjects(dataGridView1);
            display_all_subjects(dataGridView2);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(cmb_sem.Text!="")
            {
                //flag2 = 1;
                cal = 1;
                lists.Clear();
                Arrlist1.Clear();
                Arrlist2.Clear();
                Calculate(dataGridView1, 0);
                Calculate(dataGridView2, 1);
                cal = 0;
                //flag1 = 0;
            }   
            else
            {
                MessageBox.Show("Select the semester !!");
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cmb_sem.Text != "")
            {
                flag2 = 1;
                cal = 1;
                lists.Clear();
                Arrlist1.Clear();
                Arrlist2.Clear();
                Calculate(dataGridView1, 0);
                Calculate(dataGridView2, 1);
                cal = 0;
                cmb_sem.Text = "";
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                flag2 = 0;
            }
            else
            {
                MessageBox.Show("Select the semester !!");
            }
        }
        public void SaveValuesDatagrid(DataGridView dgv,string prc)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                foreach (DataGridViewRow dr in dgv.Rows)
                {
                    SqlCommand cmd = new SqlCommand(prc, con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (dr.IsNewRow) continue;
                    {                                            
                        if(flag2==1)
                        cmd.Parameters.AddWithValue("@card_id", dr.Cells["Card_Id"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Stu_Id", dr.Cells["stu_id"].Value ?? DBNull.Value);
                        //cmd.Parameters.AddWithValue("@Stu_Id", 2);
                        //cmd.Parameters.AddWithValue("@Stu_Name", txtbx_name.Text);
                        cmd.Parameters.AddWithValue("@Course_Id", dr.Cells["Course_Id"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Semester", cmb_sem.Text);
                        cmd.Parameters.AddWithValue("@Subject_Id", dr.Cells["Subject_Id"].Value ?? DBNull.Value);
                        //cmd.Parameters.AddWithValue("@Th_Max", dr.Cells["Sub_th_Max"].Value ?? DBNull.Value);
                        //cmd.Parameters.AddWithValue("@Th_Min", dr.Cells["Sub_th_Min"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Th_Sec", dr.Cells["Sub_th_Sec"].Value ?? DBNull.Value);
                        //cmd.Parameters.AddWithValue("@IA_Max", dr.Cells["Sub_IA_Max"].Value ?? DBNull.Value);
                        //cmd.Parameters.AddWithValue("@IA_Min", dr.Cells["Sub_IA_Min"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@IA_Sec", dr.Cells["Sub_IA_Sec"].Value ?? DBNull.Value);
                        //cmd.Parameters.AddWithValue("@Total_Max", dr.Cells["Total_Max"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Total_Sec", dr.Cells["Total_Sec"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Result", dr.Cells["Result"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Year", dr.Cells["Year"].Value ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@Max_Marks", txtbx_max_mks.Text);
                        cmd.Parameters.AddWithValue("@G_Total", txtbx_gtotal.Text);
                        //cmd.Parameters.AddWithValue("@G_Total_Words", txtbx_gtotal_words.Text);
                        cmd.Parameters.AddWithValue("@SGPA", txtbx_sgpa.Text);
                        cmd.Parameters.AddWithValue("@Final_Result", txtbx_result.Text);
                        cmd.Parameters.AddWithValue("@Percentage",txtbx_per.Text);                           
                        cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
                        cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        label_status.Text = (string)cmd.Parameters["@ERROR"].Value;
                    }
                }
                dgv.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Please try again !! \n\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }
        
        // Accepts only numeric values //
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control != null && e.Control is TextBox)
            {
                e.Control.KeyPress += delegate (object MySender, KeyPressEventArgs MyE)
                {
                    if (!char.IsDigit(MyE.KeyChar))
                    {
                        MyE.Handled = true;
                        label_status.Text = "ERROR, Please enter numeric values only.";
                    }
                    else
                    {
                        label_status.Text = "";
                    }
                };
            }
        }

        private void dataGridView2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control != null && e.Control is TextBox)
            {
                e.Control.KeyPress += delegate (object MySender, KeyPressEventArgs MyE)
                {
                    if (!char.IsDigit(MyE.KeyChar))
                    {
                        MyE.Handled = true;
                        label_status.Text = "ERROR, Please enter numeric values only.";
                    }
                    else
                    {
                        label_status.Text = "";
                    }
                };
            }
        }

        private void chkbx_year_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_year.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[dataGridView1.Columns["Year"].Index].Value = txtbx_year.Text;
                }
                foreach (DataGridViewRow row1 in dataGridView2.Rows)
                {
                    row1.Cells[dataGridView2.Columns["Year"].Index].Value = txtbx_year.Text;
                }
            }
            if (chkbx_year.Checked == false)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[dataGridView1.Columns["Year"].Index].Value = "";
                }
                foreach (DataGridViewRow row1 in dataGridView2.Rows)
                {
                    row1.Cells[dataGridView2.Columns["Year"].Index].Value ="";
                }
            }
        }

        private void dataGridView2_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void cmb_sem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Frm_MarksCard_Load(object sender, EventArgs e)
        {
            if(Frm_MarksCard.flag1==1)
            {
                txtbx_Regno.Text = Frm_MarksCardView.regno;
                cmb_sem.Text = Frm_MarksCardView.sem;
                txtbx_Regno.Enabled = false;
                cmb_sem.Enabled = false;
                chkbx_year.Enabled = false;
                btn_update.Visible = true;

                display_all_subjects(dataGridView1);
                display_all_subjects(dataGridView2);
                ///////////////////////////////////////////////
                //lists.Clear();
                //Arrlist1.Clear();
                //Arrlist2.Clear();
                //Calculate(dataGridView1, 0);
                //Calculate(dataGridView2, 1);

                Frm_MarksCard.flag1 = 0;               
            }            
        }

        

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbx_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = false;
                label_status.Text = "ERROR, Please enter numeric values only.";
            }
            else
            {
                e.Handled = true;
                label_status.Text = "";
            }
        }
        private void txtbx_Regno_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Prc_FetchCrsLang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@regno", txtbx_Regno.Text);
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        txtbx_name.Text = (dr["StuName"].ToString());
                        txtbx_coursename.Text = (dr["Course_Name"].ToString());
                        courseid = Int16.Parse(dr["CourseId"].ToString());
                        sub_id = Int16.Parse(dr["ILangId"].ToString());
                    }
                    else
                    {
                        txtbx_name.Text = "";
                        txtbx_coursename.Text = "";
                        dataGridView1.DataSource = null;
                        dataGridView2.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong, Please try again!.\n\n" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
