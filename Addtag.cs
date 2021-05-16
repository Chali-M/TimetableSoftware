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
    public partial class Addtag : Form
    {
        public Addtag()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {

            Con.Open();
            String Query = "select * from AddtagTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            addtagv.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chali\Documents\Timetable.DB.mdf;Integrated Security=True;Connect Timeout=30");

        private void save1_Click(object sender, EventArgs e)
        {
            if (TtextB1.Text == "" || TtextB2.Text == "" || TcomboB2.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into AddtagTbl values('" + TtextB1.Text + "','" + TtextB2.Text + "','" + TcomboB2.SelectedItem.ToString() + "') ", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tag saved Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }


        
    }
        int Key = 0;
        private void addtagv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tv1.Text = addtagv.SelectedRows[0].Cells[1].Value.ToString();
            tv2.Text = addtagv.SelectedRows[0].Cells[2].Value.ToString();
            tv3.Text = addtagv.SelectedRows[0].Cells[3].Value.ToString();
            if (tv1.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(addtagv.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void Tupdate2_Click(object sender, EventArgs e)
        {
            if (tv1.Text == "" || tv2.Text == "" || tv3.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    String Query = "update AddtagTbl set Subjectcode = '" + tv1.Text + "',Tagname ='" + tv2.Text + "',Relatedtag='" + tv3.Text + "' where TagId =" + Key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(Query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tag update Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Tdelete2_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select the TAG to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from AddtagTbl where TagId = " + Key + " ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tag Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Addtag_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreatStudent obj = new CreatStudent();
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
