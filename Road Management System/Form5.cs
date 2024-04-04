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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Road_Management_System
{
    public partial class Form5 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public int Agencyid { get; set; }
        public Form5(string y)
        {
            InitializeComponent();
            textBox2.Text = y;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Updatelabels()
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
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
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();

            cm = new SqlCommand("SELECT executingagencyid FROM ExecutingAgencyLogin WHERE userid = @userid;", con);
            cm.Parameters.AddWithValue("@userid", Convert.ToInt32(textBox2.Text));
            int p = (int)cm.ExecuteScalar();
            textBox2.Text = Convert.ToString(p);

            cm = new SqlCommand("SELECT executing_agency_name FROM Executing_Agency WHERE Executingagencyid = @eid;", con);
            cm.Parameters.AddWithValue("@eid", p);
            string x=(string)cm.ExecuteScalar();

            cm = new SqlCommand("SELECT head_name FROM Executing_Agency WHERE Executingagencyid = @eid;", con);
            cm.Parameters.AddWithValue("@eid", p);
            string y = (string)cm.ExecuteScalar();

            textBox1.Text = x;
            textBox3.Text = y;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9(Convert.ToInt32(textBox2.Text));
            f9.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
