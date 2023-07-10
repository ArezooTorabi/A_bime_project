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
    public partial class shakhs_sales : Form
    {
        public shakhs_sales()
        {
            InitializeComponent();
        }
        bool check;
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            shjadid shj = new shjadid();
            shj.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text =="" && textBox2.Text=="")
            {
                button2.Enabled = false;
            }
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT cartag , nationalcode FROM customers ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string cartag = rd["cartag"].ToString();
                string nationalcode = rd["nationalcode"].ToString();
                if (textBox1.Text == cartag && textBox2.Text == nationalcode)
                {
                    check = true;
                }
            }
            if (check== true)
            {
                estelam es = new estelam();
                es.Show();
            }
            sc.Close();
            this.Hide();
        }
    }
}
