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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\94774\Documents\WorkingDayManage.mdf;Integrated Security=True;Connect Timeout=30");


        private void populate()
        {
            Con.Open();
            string Query = "select * from DAYMANAGETBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGV3.DataSource = ds.Tables[0];
            Con.Close();
        }

       


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NoWorkDaysTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBTN3_Click(object sender, EventArgs e)
        {
            if (NoWorkDaysTB3.Text == "" || WorkDaysTB3.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into DAYMANAGETBL values('" + NoWorkDaysTB3.Text + "','" + WorkDaysTB3.Text + "','" + HoursTB3.Text + "','" + MinutesTB3.Text + "')", Con);
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
            NoWorkDaysTB3.Text = "";
            WorkDaysTB3.Text = "";
            HoursTB3.Text = "";
            MinutesTB3.Text = "";

            key = 0;
        }


        private void DataGV3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
       

        private void WorkDaysTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoursTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinutesTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBTN3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void DataGV3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NoworkDaysVTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void WorkDaysVTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void HoursVTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MinutesVTB3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateBTN3_Click(object sender, EventArgs e)
        {
            if (NoworkDaysVTB3.Text == "" || WorkDaysVTB3.Text == "" || HoursVTB3.Text == "" || MinutesVTB3.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string Query = "Update DAYMANAGETBL set Nowdays ='" + NoworkDaysVTB3.Text + "',Wdays='" + WorkDaysVTB3.Text + "',Hours='" + HoursVTB3.Text + "',Minutes='" + MinutesVTB3.Text + "'where Wdayid='" + key + "';";
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

        private void DeleteBTN3_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("delete from DAYMANAGETBL where Wdayid=" + key + ";", Con);
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

        private void BackBTN_Click(object sender, EventArgs e)
        {

        }

        private void DataGV3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            NoworkDaysVTB3.Text = DataGV3.SelectedRows[0].Cells[1].Value.ToString();
            WorkDaysVTB3.Text = DataGV3.SelectedRows[0].Cells[2].Value.ToString();
            HoursVTB3.Text = DataGV3.SelectedRows[0].Cells[3].Value.ToString();
            MinutesVTB3.Text = DataGV3.SelectedRows[0].Cells[4].Value.ToString();
            if (NoworkDaysVTB3.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DataGV3.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void LocationBTN_Click(object sender, EventArgs e)
        {
            var newForm = new Form2();
            newForm.Show();
        }
    }
}
