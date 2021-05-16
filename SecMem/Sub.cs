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
    public partial class Sub : Form
    {
        public Sub()
        {
            InitializeComponent();
            populate();
        }

        int indexRow;


        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Manujini\Documents\TTDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void populate()
        {
            Con.Open();
            string Query = "select * from SubjectTB";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            SubDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (offyear.Text == "" || offSem.Text == "" || subName.Text == "" || subCode.Text == "" || lech.Text == "" || tuteh.Text == "" || labh.Text == "" || evah.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into SubjectTB values('" + offyear.Text + "','" + offSem.Text + "','" + subName.Text + "','" + subCode.Text + "','" + lech.Text + "','" + tuteh.Text + "','" + labh.Text + "','" + evah.Text + "')", Con);
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

        private void SubDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        int key = 0;
        private void SubDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox8.Text = SubDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBox5.Text = SubDGV.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = SubDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = SubDGV.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = SubDGV.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = SubDGV.SelectedRows[0].Cells[6].Value.ToString();
            textBox1.Text = SubDGV.SelectedRows[0].Cells[7].Value.ToString();
            textBox2.Text = SubDGV.SelectedRows[0].Cells[8].Value.ToString();



            if (textBox8.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(SubDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)//delete
        {
            if (key == 0)
            {
                MessageBox.Show("select the subject to be deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from SubjectTB where SId = " + key + "; ", Con);
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

        private void button10_Click(object sender, EventArgs e)//update
        {
            if (textBox8.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Select the subject that should be updated");
            }
            else
            {
                try
                {

                    String Query = "update SubjectTB set OfferedYear = '" + textBox8.Text + "',OfferedSemester = '" + textBox5.Text + "',SubName = '" + textBox4.Text + "',SubCode = '" + textBox3.Text + "',LecHrs = '" + textBox6.Text + "',TuteHrs = '" + textBox7.Text + "',LabHrs = '" + textBox1.Text + "',EvaHrs = '" + textBox2.Text + "' where SId ='" + key + "';";
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
    }
}
