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
    public partial class Form4 : Form
    {
        public Form4()
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
            SessionDataGV4.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void SaveBTN2_Click(object sender, EventArgs e)
        {
            if (Lec1nameTB.Text == "" || Lec2nameTB.Text == "" || SubcodeTB.Text == "" || SubnameTB.Text == "" || GrpidTB.Text == "" || TagTB.Text == "" || RnameTB.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Sprint2TBL values('" + Lec1nameTB.Text + "','" + Lec2nameTB.Text + "','" + SubcodeTB.Text + "','" + SubnameTB.Text + "','" + GrpidTB.Text + "','" + TagTB.Text + "','" + RnameTB.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record saved successfully !");
                
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

            var newform = new Form2();
            newform.Show();

        }

        int key = 0;
        private void SessionDataGV4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Lec1nameTB.Text = SessionDataGV4.SelectedRows[0].Cells[1].Value.ToString();
            Lec2nameTB.Text = SessionDataGV4.SelectedRows[0].Cells[2].Value.ToString();
            SubcodeTB.Text = SessionDataGV4.SelectedRows[0].Cells[3].Value.ToString();
            SubnameTB.Text = SessionDataGV4.SelectedRows[0].Cells[4].Value.ToString();
            GrpidTB.Text = SessionDataGV4.SelectedRows[0].Cells[4].Value.ToString();
            TagTB.Text = SessionDataGV4.SelectedRows[0].Cells[4].Value.ToString();
            if (Lec1nameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SessionDataGV4.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
