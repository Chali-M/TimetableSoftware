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
    public partial class Addsession : Form
    {
        public Addsession()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chali\Documents\Timetable.DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        private void reset()
        {

            cln.Text = "";
            cssub.Text = "";
            cat1.Text = "";
            cat2.Text = "";
           


        }



        private void cninsert_Click(object sender, EventArgs e)
        {
            if (cnsub1.SelectedIndex == -1  || cnsub2.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Nonoverlap values('" + cnsub1.SelectedItem.ToString() +"','"+ cnsub2.SelectedItem.ToString() + "') ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session saved Successfully");
                    Con.Close();
                    //populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        }

        private void ccadd_Click(object sender, EventArgs e)
        {
            if (cln.SelectedIndex == -1 || cssub.SelectedIndex == -1 || cat1.SelectedIndex == -1 || cat2.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Conse values('" + cln.SelectedItem.ToString() + "','" + cssub.SelectedItem.ToString() + "','" + cat1.SelectedItem.ToString() + "','" + cat2.SelectedItem.ToString() + "') ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tag saved Successfully");
                    Con.Close();
                   // populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

          
        }

        private void ccclear_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Addtag obj = new Addtag();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreatStudent obj = new CreatStudent();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddConsecutiveAndNonoverlapping obj = new AddConsecutiveAndNonoverlapping();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddConsecutiveAndNonoverlapping obj = new AddConsecutiveAndNonoverlapping();
            obj.Show();
            this.Hide();
        }
    }
}
