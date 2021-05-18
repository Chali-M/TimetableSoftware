using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NewProjectWin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            populate();
            fillcombobox();
            fillcombobox1();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\94774\Documents\WorkingDayManage.mdf;Integrated Security=True;Connect Timeout=30");

        public void fillcombobox()
        {
            string sql = "select * from LECTURERTB";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(1);
                    selLec.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }

        public void fillcombobox1()
        {
            string sql = "select * from STUDENTTT";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader myreader;
            try
            {
                Con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                
                {
                    string gname = myreader.GetString(3);
                    selGrp.Items.Add(gname);

                    string Subname = myreader.GetString(4);
                    selSGrp.Items.Add(Subname);
                }
               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string Query = "select * from LOCATIONTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGV4.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void btnSaveSub_Click(object sender, EventArgs e)
        {
            if (selLec.SelectedIndex == -1  || selGrp.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into LOCATIONTBL values('" + selLec.SelectedItem.ToString() + "','" + selGrp.SelectedItem.ToString() + "','" + selSGrp.SelectedItem.ToString() + "','" + selSID.SelectedItem.ToString() + "','" + timeDu.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Added Successfully");
                    Con.Close();
                    populate();
                    reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;

        private void reset()
        {
            selLec.Text = "";
            selGrp.Text = "";
            selSGrp.Text = "";
            selSID.Text = "";
            timeDu.Text = "";
           

            key = 0;
        }

        private void btnClearSub_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {

         
        }

        private void btnDeleteSub_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

           
            VtimeDu.Text = dataGV4.SelectedRows[0].Cells[5].Value.ToString();
            

            if (VtimeDu.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(dataGV4.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdateSub_Click_1(object sender, EventArgs e)
        {

            if ( VtimeDu.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "Update LOCATIONTBL set timeDue='" + VtimeDu.Text +  "'where lecID='" + key + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Updated Successfully");
                    Con.Close();
                    populate();
                    reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btnDeleteSub_Click_1(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the Deta to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from LOCATIONTBL where lecID=" + key + ";", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Details Deleted Successfully");
                    Con.Close();
                    populate();
                    reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void addLocBTN_Click(object sender, EventArgs e)
        {
            var newform = new Form3();
            newform.Show();
        }

        private void selGrp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LdataGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
