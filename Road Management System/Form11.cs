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

    public partial class Form11 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form11()
        {
            InitializeComponent();
        }


        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql2 = "select max(Maintenance_Report_ID) from maintenence;";
            cm = new SqlCommand(sql2, con);
            SqlDataAdapter da5 = new SqlDataAdapter(cm);
            DataTable dt5 = new DataTable();
            da5.Fill(dt5);
            con.Close();

            int mId = Convert.ToInt32(dt5.Rows[0].ItemArray[0].ToString());

            con.Open();
            string sql = "insert into Maintenence values (@Ename,@DamagereportId,@M_id,@Mdate,@Mbudget,@Completion);";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@Ename", textBox1.Text);
            cm.Parameters.AddWithValue("@DamagereportId", Convert.ToInt32(textBox2.Text));
            cm.Parameters.AddWithValue("@M_id", mId+1);
            cm.Parameters.AddWithValue("@Mdate", dateTimePicker1.Value);
            cm.Parameters.AddWithValue("@Mbudget", Convert.ToInt32(textBox3.Text));
            cm.Parameters.AddWithValue("@Completion", Convert.ToInt32(textBox5.Text));

            cm.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Report was successfully inserted", "Success.", MessageBoxButtons.OK);
        }
    }
}
