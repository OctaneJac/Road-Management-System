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
    public partial class Form10 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql2 = "select max(Damage_Report_ID) from Damage;";
            cm = new SqlCommand(sql2, con);
            SqlDataAdapter da5 = new SqlDataAdapter(cm);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            con.Close();

            int DId = Convert.ToInt32(dt5.Rows[0].ItemArray[0].ToString());
            con.Open();
            string sql = "insert into Damage values (@Roadname,@DamagereportId,@DamageReportDate,@DamageSectionLength,@DamageDescription);";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@Roadname", textBox1.Text);
            cm.Parameters.AddWithValue("@DamagereportId", DId+1);
            cm.Parameters.AddWithValue("@DamageReportDate", dateTimePicker1.Value);
            cm.Parameters.AddWithValue("@DamageSectionLength", textBox4.Text);
            cm.Parameters.AddWithValue("@DamageDescription", richTextBox1.Text);

            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Report was successfully inserted", "Success.", MessageBoxButtons.OK);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
