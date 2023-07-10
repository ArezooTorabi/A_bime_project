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
    public partial class shjadid2 : Form
    {
       
        public shjadid2()
        {
            InitializeComponent();
        }
       
        private void shjadid2_Load_1(object sender, EventArgs e)
        {

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT name FROM bimegar";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd["name"].ToString();
                comboBox1.Items.Add(name);
            }



            sc.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

             if (comboBox1.Text == "صفر کیلومتر")
            {
                textBox1.Enabled = true;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
            }
            else
            {
                textBox1.Enabled = false;
                textBox2.Enabled = textBox3.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string bime = comboBox1.Text;
            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "UPDATE customers SET bimeghabli = N'" + bime + "'";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            scc.Close();

            if (textBox1.Enabled == true)
            {
                string text = textBox1.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
                sc.Open();
                string query = "UPDATE customers SET tarikhtarkhis= N'" + text + "'";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                shjadidshomare shjsh = new shjadidshomare();
                shjsh.Show();
                this.Hide();
            }
            else if (textBox2.Enabled = textBox3.Enabled == true)
            {
                string shoro = textBox2.Text;
                string engheza = textBox3.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
                sc.Open();
                string query = "INSERT INTO customers (tarikhshoro,tarikhengheza) VALUES (N'" + shoro + "',N'" + engheza + "')";
                SqlCommand cmd = new SqlCommand(query, sc);
                cmd.ExecuteNonQuery();
                sc.Close();
                shjadid3 shj3 = new shjadid3();
                shj3.Show();
                this.Hide();
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("لطفا مراحل را طی نمایید.");
            }
        }
    }
}
