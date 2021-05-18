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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\94776\Documents\TimetableDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void populate()
        {
            Con.Open();
            string Query = "select * from Sprint2TBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TimetableDGV2.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        int key = 0;
        private void TimetableDGV2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RoomArea.Text = TimetableDGV2.SelectedRows[0].Cells[7].Value.ToString();
           
            if (RoomArea.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(TimetableDGV2.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void AddroomBTN2_Click(object sender, EventArgs e)
        {

            if (RoomArea.Text == "" )
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    string Query = "update Sprint2TBL set room_s = '" + RoomArea.Text + "' where session_id = " + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Location details updated successfully!");
                    Con.Close();
                    populate();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
