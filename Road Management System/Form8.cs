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
    public partial class Form8 : Form
    {
        const string constr = "Data Source = MECHANICUS ; Initial Catalog = Road Management System ; Integrated Security= SSPI";
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cm = new SqlCommand();
        public Form8()
        {
            InitializeComponent();
        }
        private void LoadProjects()
        {
            con.Open();
            string sql = "select * from Project_Feasibility;";
            cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable pfdt = new DataTable();
            da.Fill(pfdt);
            con.Close();
            dataGridView1.DataSource = pfdt;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSize = false;
            dataGridView1.ScrollBars = ScrollBars.Both;
        }
        private void Form8_Load(object sender, EventArgs e)
        {
            LoadProjects();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
