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
    public partial class khesarat : Form
    {
        public khesarat()
        {
            InitializeComponent();
        }

        private void khesarat_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = " SELECT khesarat FROM khesarat";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while(rd.Read())
            {
                string khesarat = rd["khesarat"].ToString();
                comboBox1.Items.Add(khesarat);
                comboBox2.Items.Add(khesarat);
                comboBox3.Items.Add(khesarat);
            }
            sc.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mali = comboBox1.Text;
            string jani = comboBox2.Text;
            string havades = comboBox3.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = " INSERT INTO customers (khesaratmali,khesaratjani,havadesranande) VALUES  (N'" + mali + "',N'" + jani + "',N'" + havades  +"')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            comboBox1.Text = "تعداد خسارت مالی";
            comboBox2.Text = "تعداد خسارت جانی";
            comboBox3.Text = "تعداد خسارت حوادث راننده ";
            shjadidshomare shjsh = new shjadidshomare();
            shjsh.Show();
            this.Hide();
        }
    }
}
