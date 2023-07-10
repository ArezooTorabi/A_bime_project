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

namespace A_bimeh_khodro
{
    public partial class shjadidshomare : Form
    {
        public shjadidshomare()
        {
            InitializeComponent();
        }
       
        public khesarat khst;
       

        private void button1_Click_1(object sender, EventArgs e)
        {

            string phone = textBox1.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO customers (phone) VALUES (N'" + phone + "')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            gheymat ghmt = new gheymat();
            ghmt.Show();
            this.Hide();
        }
    }
}
