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

namespace Road_Management_System
{
    public partial class Form4 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();

        int Id;

        public Form4(int y)
        {
            InitializeComponent();
            Id = y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();

            cm = new SqlCommand("SELECT contractorid FROM ContractorLogin WHERE userid = @userid;", con);
            cm.Parameters.AddWithValue("@userid", Id);
            int p = (int)cm.ExecuteScalar();

            cm = new SqlCommand("select contractor_name from Contractor_Info where contractorid=@cid;", con);
            cm.Parameters.AddWithValue("@cid", p);
            string x = (string)cm.ExecuteScalar();

            cm = new SqlCommand("select contractor_category from Contractor_info where contractorid=@cid;", con);
            cm.Parameters.AddWithValue("@cid", p);
            string y = (string)cm.ExecuteScalar();

            cm = new SqlCommand("select contractor_specialization from Contractor_info where contractorid=@cid;", con);
            cm.Parameters.AddWithValue("@cid", p);
            string z = (string)cm.ExecuteScalar();

            cm = new SqlCommand("select SRB_Regestration_Number from Contractor_info where contractorid=@cid;", con);
            cm.Parameters.AddWithValue("@cid", p);
            string a = (string)cm.ExecuteScalar();

            textBox1.Text = x;
            textBox2.Text = y;
            textBox3.Text = z;
            textBox5.Text = a;
            con.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
