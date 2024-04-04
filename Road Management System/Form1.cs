using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Road_Management_System
{

    public partial class Form1 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        public Form1()  
        {
            InitializeComponent();
        }
        private int ConfirmLogin()
        {
            if (radioButton1.Checked == true)
            {
                con.Open();
                cm = new SqlCommand("SELECT count(userid) FROM ExecutingAgencyLogin WHERE userid = @userid and userpassword=@userpassword;", con);
                cm.Parameters.AddWithValue("@userid", textBox2.Text);
                cm.Parameters.AddWithValue("@userpassword", textBox3.Text);
                int login = (int)cm.ExecuteScalar();
                con.Close();
                if (login == 1)
                {
                    return 1;
                }
            }
            else if (radioButton2.Checked == true)
            {
                con.Open();
                cm = new SqlCommand("SELECT count(userid) FROM ContractorLogin WHERE userid = @userid and userpassword=@userpassword;", con);
                cm.Parameters.AddWithValue("@userid", textBox2.Text);
                cm.Parameters.AddWithValue("@userpassword", textBox3.Text);
                int login = (int)cm.ExecuteScalar();
                con.Close();
                if (login == 1)
                {
                    return 2;
                }
            }
            //else
            {
                //MessageBox.Show("Select a category button", "Error");
            }
            return 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ConfirmLogin() == 1)
            {
                Form5 f5 = new Form5(textBox2.Text);
                f5.ShowDialog();
                this.Close();
            }
            else if(ConfirmLogin()==2)
            {
                Form4 f4 = new Form4(Convert.ToInt32(textBox2.Text));
                f4.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong login entered.+", "Error");
            }
        }

    }
}
