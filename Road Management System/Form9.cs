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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Road_Management_System
{
    public partial class Form9 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        int Id;
        public Form9(int y)
        {
            InitializeComponent();
            Id = y;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con.Open();
            string sql = "select * from Executing_Agency_Employees where Id=@ID;";
            cm = new SqlCommand(sql, con);
            cm.Parameters.AddWithValue("@ID", Id);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable projectdt = new DataTable();
            da.Fill(projectdt);
            con.Close();
            dataGridView1.DataSource = projectdt;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;

        }
    }
}
