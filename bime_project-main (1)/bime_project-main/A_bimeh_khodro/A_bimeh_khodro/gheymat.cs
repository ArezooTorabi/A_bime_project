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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A_bimeh_khodro
{
    public partial class gheymat : Form
    {
        public gheymat()
        {
            InitializeComponent();
        }
        shjadid shj;
        private void gheymat_Load_1(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT name FROM last ";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd["name"].ToString();
                comboBox1.Items.Add(name);
            }
            sc.Close();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "کمتر از چهار سیلندر")
            {
                label2.Text = "23.440.000 ریال ";
            }
            else if (comboBox1.Text == "چهار سیلندر")
            {
                label2.Text = "27.760.000 ریال ";
            }
            else if (comboBox1.Text == "بیشتر از چهار سیلندر")
            {
                label2.Text = "36.520.000 ریال ";
            }
            else if (comboBox1.Text == "یک تن")
            {
                label2.Text = "28.720.000 ریال ";
            }
            else if (comboBox1.Text == "یک تا سه تن")
            {
                label2.Text = "34.580.000 ریال ";
            }
            else if (comboBox1.Text == "پنج تا ده تن")
            {
                label2.Text = "56.080.000 ریال ";
            }
            else if (comboBox1.Text == "ده تا بیست تن")
            {
                label2.Text = "65.260.000 ریال ";
            }
            else if (comboBox1.Text == "بیشتر از بیست تن")
            {
                label2.Text = "69.160.000 ریال ";
            }
            else if (comboBox1.Text == "هفت نفره")
            {
                label2.Text = "87.386.000 ریال ";
            }
            else if (comboBox1.Text == "نه نفره")
            {
                label2.Text = "89.908.000 ریال ";
            }
            else if (comboBox1.Text == "شانزده نفره")
            {
                label2.Text = "111.774.000 ریال ";
            }
            else if (comboBox1.Text == "بیست و یک نفره")
            {
                label2.Text = "116.103.000 ریال ";
            }
            else if (comboBox1.Text == "بیست و هفت نفره")
            {
                label2.Text = "171.197.000 ریال ";
            }
            else if (comboBox1.Text == "چهل و چهار نفره")
            {
                label2.Text = "228.592.000 ریال ";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string gheymat = label2.Text;
            string query = "INSERT INTO customers (gheymat) VALUES (N'" + gheymat + "')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            last lst = new last();
            lst.Show();
            this.Hide();
        }
    }
}
