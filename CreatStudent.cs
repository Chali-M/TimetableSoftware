using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TimetableM
{
    public partial class CreatStudent : Form
    {
        public CreatStudent()
        {
            InitializeComponent();
            populate2();
        }
        SqlConnection ton = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chali\Documents\Timetable.DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void gb1_Click(object sender, EventArgs e)
        {
            string a = tb1.Text;
            string b = tb2.Text;
            string c = tb3.Text;
            string f = nupd.Text;
            string sum = a + b + c;
            string sums = a + b + c + f;

            tb4.Text = sum;
            tb5.Text = sums;
        }

        private void populate2()
        {

            ton.Open();
            string Query = "select * from studentTT";
            SqlDataAdapter bn = new SqlDataAdapter(Query, ton);
            SqlCommandBuilder builder = new SqlCommandBuilder(bn);
            var ds = new DataSet();
            bn.Fill(ds);
            studentDGV.DataSource = ds.Tables[0];
            ton.Close();



        }
        private void reset()
        {

            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            nupd.Text = "";
            tb4.Text = "";
            tb5.Text = "";


        }
        private void but2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void but3_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "" || tb2.SelectedIndex == -1 || tb3.Text == "" || nupd.Text == "" || tb4.Text == "" || tb5.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    ton.Open();
                    SqlCommand cmd = new SqlCommand("insert into studentTT values('" + tb1.Text + "','" + tb2.SelectedItem.ToString() + "','" + tb3.Text + "','" + nupd.Text + "','" + tb4.Text + "','" + tb5.Text + "') ", ton);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student saved Successfully");
                    ton.Close();
                    populate2();
                    reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void studentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }


        int sey = 0;
        private void delete5_Click(object sender, EventArgs e)
        {

            if (sey == 0)
            {
                MessageBox.Show("Select Student Group Delete");
            }
            else
            {
                try
                {
                    ton.Open();
                    SqlCommand cmd = new SqlCommand("delete from studentTT where SID=" + sey + ";", ton);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student delete Successfully");
                    ton.Close();
                    populate2();
                    reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void but987_Click(object sender, EventArgs e)
        {
            if (tBox1.Text == "" || cBox1.Text == "" || tBox3.Text == "" || numericUpDown2.Text == "" || tBox5.Text == "" || tBox6.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {

                    string Query = "update studentTT set AcademicYS = '" + tBox1.Text + "',Programe = '" + cBox1.Text + "',GroupNumber = '" + tBox3.Text + "',SubGnum = '" + numericUpDown2.Text + "',GroupId = '" + tBox5.Text + "',SubGroupId = '" + tBox6.Text + "'where SID =" + Key + ";";
                    ton.Open();
                    SqlCommand cmd = new SqlCommand(Query, ton);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Subject Updated successfully");
                    ton.Close();

                    populate2();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void studentDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tBox1.Text = studentDGV.SelectedRows[0].Cells[1].Value.ToString();
            cBox1.Text = studentDGV.SelectedRows[0].Cells[2].Value.ToString();
            tBox3.Text = studentDGV.SelectedRows[0].Cells[3].Value.ToString();
            numericUpDown2.Text = studentDGV.SelectedRows[0].Cells[4].Value.ToString();
            tBox5.Text = studentDGV.SelectedRows[0].Cells[5].Value.ToString();
            tBox6.Text = studentDGV.SelectedRows[0].Cells[6].Value.ToString();




            if (tBox1.Text == "")
            {
                sey = 0;
            }
            else
            {
                sey = Convert.ToInt32(studentDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addtag obj = new Addtag();
            obj.Show();
            this.Hide();
        }

        private void subjects2_Click(object sender, EventArgs e)
        {
            Addsession obj = new Addsession();
            obj.Show();
            this.Hide();
        }
    }
}
