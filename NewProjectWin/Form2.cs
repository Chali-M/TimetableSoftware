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
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\94774\Documents\WorkingDayManage.mdf;Integrated Security=True;Connect Timeout=30");

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
                    SqlCommand cmd = new SqlCommand("insert into LOCATIONTBL values('" + selLec.SelectedItem.ToString() + "','" + selGrp.SelectedItem.ToString() + "','" + selSGrp.SelectedItem.ToString() + "','" + selSID.SelectedItem.ToString() + "','" + timeDu.Text + "','" + selRoom.SelectedItem.ToString() + "','" + selDay.SelectedItem.ToString() + "','" + sTime.Text + "','" + eTime.Text + "')", Con);
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
            selRoom.Text = "";
            selDay.Text = "";
            sTime.Text = "";
            eTime.Text = "";

            key = 0;
        }

        private void btnClearSub_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnUpdateSub_Click(object sender, EventArgs e)
        {

            if (VselLec.Text == "" || VselGrp.Text == "" || VselSGrp.Text == "" || VselSID.Text == "" || VtimeDu.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "Update LOCATIONTBL set selLec ='" + VselLec.Text + "',selGrp='" + VselGrp.Text + "',selSGrp='" + VselSGrp.Text + "',selSesID='" + VselSID.Text + "',timeDue='" + VtimeDu.Text + "',selRoom='" + VselRoom.Text + "',selDay='" +VselDay.Text + "',startTime='" + VsTime.Text + "',endTime='" + VeTime.Text + "'where lecID='" + key + "';";
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

        private void btnDeleteSub_Click(object sender, EventArgs e)
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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            VselLec.Text = dataGV4.SelectedRows[0].Cells[1].Value.ToString();
            VselGrp.Text = dataGV4.SelectedRows[0].Cells[2].Value.ToString();
            VselSGrp.Text = dataGV4.SelectedRows[0].Cells[3].Value.ToString();
            VselSID.Text = dataGV4.SelectedRows[0].Cells[4].Value.ToString();
            VtimeDu.Text = dataGV4.SelectedRows[0].Cells[5].Value.ToString();
            VselRoom.Text = dataGV4.SelectedRows[0].Cells[6].Value.ToString();
            VselDay.Text = dataGV4.SelectedRows[0].Cells[7].Value.ToString();
            VsTime.Text = dataGV4.SelectedRows[0].Cells[8].Value.ToString();
            VeTime.Text = dataGV4.SelectedRows[0].Cells[9].Value.ToString();

            if (VselLec.Text == "")
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
    }
}
