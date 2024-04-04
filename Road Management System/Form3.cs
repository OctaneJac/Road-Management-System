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
    public partial class Form3 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }
        private void Loaddamage()
        {
            con.Open();
            string sql = "select * from Damage;";
            cm = new SqlCommand(sql, con);
            //cm.Parameters.AddWithValue("@Roadname", Roadnamesearch.Text);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        private void Loadmaintainence()
        {
            con.Open();
            string sql = "select * from Maintenence;";
            cm = new SqlCommand(sql, con);
            //cm.Parameters.AddWithValue("@Roadname", Roadnamesearch.Text);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            con.Close();
            dataGridView2.DataSource = dt1;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.RowHeadersVisible = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Loaddamage();
            Loadmaintainence();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            if (Damageid.Text.ToString() != "")
            {
                
                string sql = "select * from Damage where Damage_Report_ID=@Damageid;";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Damageid", Convert.ToInt32(Damageid.Text.ToString()));
            }
            else
            {
                string sql = "select * from Damage";
                cm = new SqlCommand(sql, con);
            }
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            con.Close();
            dataGridView1.DataSource = dt1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "Delete from Damage where Damage_Report_Id=@did;";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@did", Convert.ToInt32(textBox1.Text));
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Report was successfully deleted", "Success.", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            if(textBox7.Text.ToString()!="")
            {
                string sql = "select * from Maintenence where Maintenance_Report_ID=@Mainid;";
                cm = new SqlCommand(sql, con);
                cm.Parameters.AddWithValue("@Mainid", Convert.ToInt32(textBox7.Text.ToString()));
            }
            else
            {
                string sql = "select * from Maintenence";
                cm = new SqlCommand(sql, con);
            }
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            con.Close();
            dataGridView2.DataSource = dt1;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSize = false;
            dataGridView2.ScrollBars = ScrollBars.Both;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "select * from Damage where Damage_Report_Date>@Reportdate;";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@Reportdate", dateTimePicker1.Value);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            con.Close();
            dataGridView1.DataSource = dt1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();

            string sql = "select * from Maintenence where Maintenance_Report_Date>@Reportdate;";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@Reportdate", dateTimePicker2.Value);

            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            con.Close();
            dataGridView2.DataSource = dt1;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ForeColor = Color.Black;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSize = false;
            dataGridView2.ScrollBars = ScrollBars.Both;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "Delete from Maintenence where Maintenance_Report_Id=@mid;";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@mid", Convert.ToInt32(textBox2.Text));
            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Report was successfully deleted", "Success.", MessageBoxButtons.OK);
        }
    }
}
