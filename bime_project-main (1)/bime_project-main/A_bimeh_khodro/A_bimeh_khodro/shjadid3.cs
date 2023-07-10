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
    public partial class shjadid3 : Form
    {
        public shjadid3()
        {
            InitializeComponent();
        }
        public shjadid shj;
        
      
       

        private void shjadid3_Load_1(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT taviz FROM taviz";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string taviz = rd["taviz"].ToString();
                comboBox1.Items.Add(taviz);
            }
            sc.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string taviz = comboBox1.Text;

            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "UPDATE customers SET tavizpelak = N'" + taviz + "'";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            if (comboBox1.Text == "بله")
            {
                shjtakhfif2 shjt2 = new shjtakhfif2();
                shjt2.Show();
            }
            else if (comboBox1.Text == "خیر")
            {
                shjtakhfif shjt = new shjtakhfif();
                shjt.Show();
            }
            scc.Close();
            this.Hide();
        }
    }
}
