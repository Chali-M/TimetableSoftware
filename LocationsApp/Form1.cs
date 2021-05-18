using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LocationsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\94776\Documents\TimetableDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string Query = "select * from SprintTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DataGV2.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void BuildingNameTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNameTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomTypeCB2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CapacityTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBTN2_Click(object sender, EventArgs e)
        {
            if (BuildingNameTB2.Text == "" || RoomNameTB2.Text == "" || RoomTypeCB2.SelectedIndex == -1 || CapacityTB2.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SPRINTTBL values('" + BuildingNameTB2.Text + "','" + RoomNameTB2.Text + "','" + RoomTypeCB2.SelectedItem.ToString() + "','" + CapacityTB2.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location saved successfully!");
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

        private void DataGV2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void reset()
        {
            BuildingNameTB2.Text = "";
            RoomNameTB2.Text = "";
            RoomTypeCB2.SelectedIndex = -1;
            CapacityTB2.Text = "";
            key = 0;
        }

        private void ClearBTN2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void DataGV2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateBTN2_Click(object sender, EventArgs e)
        {
            if (BuildingNameVTB2.Text == "" || RoomNameVTB2.Text == "" || RoomTypeVTB2.Text == "" || CapacityVTB2.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    string Query = "update SPRINTTBL set Bname = '" + BuildingNameVTB2.Text + "',Rname = '" + RoomNameVTB2.Text + "',Rtype = '" + RoomTypeVTB2.Text + "',Capacity = '" + CapacityVTB2.Text + "' where LocId = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location details updated successfully!");
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

        private void DeleteBTN2_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the record to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from SprintTBL where LocId=" + key + "; ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location deleted successfully!");
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

        private void ClBTN2_Click(object sender, EventArgs e)
        {

        }

        private void BuildingNameVTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomNameVTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RoomTypeVTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CapacityVTB2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGV2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BuildingNameVTB2.Text = DataGV2.SelectedRows[0].Cells[1].Value.ToString();
            RoomNameVTB2.Text = DataGV2.SelectedRows[0].Cells[2].Value.ToString();
            RoomTypeVTB2.Text = DataGV2.SelectedRows[0].Cells[3].Value.ToString();
            CapacityVTB2.Text = DataGV2.SelectedRows[0].Cells[4].Value.ToString();
            if (BuildingNameVTB2.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(DataGV2.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
