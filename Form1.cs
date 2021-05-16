using System;
using System.Windows.Forms;

namespace TimetableM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            cusername.Text = "";
            cpassword.Text = "";
        }

        private void clogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = cusername.Text;
            pass = cpassword.Text;
            if(user == "admin" && pass == "admin")
            {

                MessageBox.Show("Successfull");

                Addtag obj = new Addtag();
                obj.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("REenter");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
