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
    public partial class shjadid : Form
    {
        public shjadid()
        {
            InitializeComponent();
        }
        shjadid shj;
        private void shjadid_Load_1(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT  pishfarz FROM pishfarz";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string pishfarz = rd["pishfarz"].ToString();
                comboBox1.Items.Add(pishfarz);
            }
            sc.Close();
        }

        private void comboBox2_Click_1(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query;
            if (comboBox1.Text == "سواری")
            {
                query = " SELECT  scontrol FROM csavari";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    string type = rd["scontrol"].ToString();
                    comboBox2.Items.Add(type);
                }
            }

            else if (comboBox1.Text == "وانت/کامیون")
            {
                query = " SELECT  vcontrol FROM cvanet";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    string type = rd["vcontrol"].ToString();
                    comboBox2.Items.Add(type);
                }
            }

            else if (comboBox1.Text == "اتوبوس/مینی بوس")
            {
                query = "SELECT  bcontrol FROM cbus ";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    string type = rd["bcontrol"].ToString();
                    comboBox2.Items.Add(type);
                }
            }
            sc.Close();
        }

        private void comboBox3_Click_1(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query;
            if (comboBox1.Text == "سواری")
            {
                query = "SELECT  msavari FROM msavari ";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    string type = rd["msavari"].ToString();
                    comboBox3.Items.Add(type);
                }
            }
            else if (comboBox1.Text == "وانت/کامیون")
            {
                query = " SELECT  mvanet FROM mvanet";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    string type = rd["mvanet"].ToString();
                    comboBox3.Items.Add(type);
                }
            }
            else if (comboBox1.Text == "اتوبوس/مینی بوس")
            {
                query = "SELECT  mbus FROM mbus ";
                SqlCommand command = new SqlCommand(query, sc);
                SqlDataReader rd = command.ExecuteReader();
                while (rd.Read())
                {
                    string type = rd["mbus"].ToString();
                    comboBox3.Items.Add(type);
                   
                }
            }
            
            sc.Close();
        }

        private void textBox2_Click_1(object sender, EventArgs e)
        {

            textBox2.Text = "";
            if (textBox3.Text == "")
            {
                textBox3.Text = "سال ساخت خودرو";
            }
        }

        private void textBox3_Click_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
            if (textBox2.Text == "")
            {
                textBox2.Text = "سال ساخت خودرو";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            string type = comboBox1.Text;
            string control = comboBox2.Text;
            string brand = textBox2.Text;
            string model = comboBox3.Text;
            string saal = textBox3.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO customers (type,control,brand,model,saal) VALUES (N'" + type + "',N'" + control + "',N'" + brand + "',N'" + model + "',N'" + saal + "')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            comboBox3.Text = "مدل , تناژ , ظرفیت";
            textBox2.Text = "برند خودرو";
            textBox3.Text = "سال ساخت خودرو";
            comboBox1.Text = "نوع وسیله نقلیه";
            comboBox2.Text = "کاربری وسیله نقلیه";
            shjadid2 shj2 = new shjadid2();
            shj2.Show();
            this.Hide();
        }

    }
}
