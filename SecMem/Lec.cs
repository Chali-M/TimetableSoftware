using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SecMem
{
    public partial class Lec : Form
    {
        public Lec()
        {
            InitializeComponent();
            populate();
        }

        int indexRow;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manujini\Documents\TTDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string Query = "select * from LecturerTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            LecDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (lectureName.Text == "" || lectureid.Text == "" || faculty.Text == "" || department.Text == "" || center.Text == "" || building.Text == "" || lev.Text == "" || rank1.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into LecturerTB values('" + lectureName.Text + "','" + lectureid.Text + "','" + faculty.Text + "','" + department.Text + "','" + center.Text + "','" + building.Text + "','" + lev.Text + "','" + rank1.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int key = 0;

        private void LecDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox16.Text = LecDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox15.Text = LecDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBo.Text = LecDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox2.Text = LecDGV.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = LecDGV.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = LecDGV.SelectedRows[0].Cells[6].Value.ToString();
            textBox14.Text = LecDGV.SelectedRows[0].Cells[7].Value.ToString();
            textBox13.Text = LecDGV.SelectedRows[0].Cells[8].Value.ToString();



            if (textBox16.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(LecDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select the lecturer to be selected");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from LecturerTB where LId=" + key + " ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox16.Text == "" || textBox15.Text == "" || textBo.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox14.Text == "" || textBox13.Text == "")
            {
                MessageBox.Show("Select the subject that should be updated");
            }
            else
            {
                try
                {

                    String Query = "update LecturerTB set LecName = '" + textBox16.Text + "',LecID = '" + textBox15.Text + "',Faculty = '" + textBo.Text + "',Department = '" + textBox2.Text + "',Center = '" + textBox4.Text + "',Building = '" + textBox3.Text + "',Level = '" + textBox14.Text + "',Rank = '" + textBox13.Text + "' where LId ='" + key + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful");
                    Con.Close();
                    populate();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string a = lectureid.Text;
            string b = lev.Text;
            string c = b + a;
            rank1.Text = c;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (selday.Text == "" || frm.Text == "" || too.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into HrsTB values('" + selday.Text + "','" + frm.Text + "','" + too.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successful");
                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
