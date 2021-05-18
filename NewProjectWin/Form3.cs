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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            populate();
            
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\94774\Documents\WorkingDayManage.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            {
                Con.Open();
                string Query = "select * from LOCATIONTBL";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                LocDGV2.DataSource = ds.Tables[0];
                Con.Close();
            }
            {   Con.Open();
                string Query = "select * from SESSIONTBL2";
                SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGV9.DataSource = ds.Tables[0];
                Con.Close();
            }
        }
       

        private void VselLec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void VselLec_TextChanged(object sender, EventArgs e)
        {

        }

        private void addSesBTN_Click(object sender, EventArgs e)
        {

            if (selRoom.SelectedIndex == -1 || selDay.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SESSIONTBL2 values('" + VselLec.Text + "','" + VselGrp.Text + "','" + VselSGrp.Text + "','" + VselSID.Text + "','" + VtimeDu.Text + "','" + selRoom.SelectedItem.ToString() + "','" + selDay.SelectedItem.ToString() + "','" + sTime.Text + "','" + eTime.Text + "')", Con) ;
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
       

        private void reset()
        {
            selRoom.Text = "";
            selDay.Text = "";
            sTime.Text = "";
            eTime.Text = "";
            


            
        }


        int key = 0;
        private void LocDGV2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            VselLec.Text = LocDGV2.SelectedRows[0].Cells[1].Value.ToString();
            VselGrp.Text = LocDGV2.SelectedRows[0].Cells[2].Value.ToString();
            VselSGrp.Text = LocDGV2.SelectedRows[0].Cells[3].Value.ToString();
            VselSID.Text = LocDGV2.SelectedRows[0].Cells[4].Value.ToString();
            VtimeDu.Text = LocDGV2.SelectedRows[0].Cells[5].Value.ToString();


            if (VselLec.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LocDGV2.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {

            var newform1 = new Form2();
            newform1.Show();
        }
    }
}
