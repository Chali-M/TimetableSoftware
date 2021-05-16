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
    public partial class AddConsecutiveAndNonoverlapping : Form
    {
        public AddConsecutiveAndNonoverlapping()
        {
            InitializeComponent();
            populate3();
            populate4();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chali\Documents\Timetable.DB.mdf;Integrated Security=True;Connect Timeout=30");
        private void AddConsecutiveAndNonoverlapping_Load(object sender, EventArgs e)
        {

        }
        private void populate3()
        {

            Con.Open();
            String Query = "select * from Conse ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            cmcDGV.DataSource = ds.Tables[0];
            Con.Close();



        }
        private void populate4()
        {

            Con.Open();
            String Query = "select * from Nonoverlap ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CmnDGV.DataSource = ds.Tables[0];
            Con.Close();



        }
        int Key = 0;
        private void CmnDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CmnDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmn1.Text = CmnDGV.SelectedRows[0].Cells[1].Value.ToString();
            cmn2.Text = CmnDGV.SelectedRows[0].Cells[2].Value.ToString();

            if (cmn1.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CmnDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (Key == 0)
            {
                MessageBox.Show("Select the session to be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Nonoverlap where NonId = " + Key + " ;", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Session Deleted Successfully");
                    Con.Close();
                    populate4();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void cmcDGV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            cmcln.Text = cmcDGV.SelectedRows[0].Cells[1].Value.ToString();
            cmcss.Text = cmcDGV.SelectedRows[0].Cells[2].Value.ToString();
            cmctag1.Text = cmcDGV.SelectedRows[0].Cells[3].Value.ToString();
            cmctag2.Text = cmcDGV.SelectedRows[0].Cells[4].Value.ToString();

            if (cmcln.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(cmcDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
