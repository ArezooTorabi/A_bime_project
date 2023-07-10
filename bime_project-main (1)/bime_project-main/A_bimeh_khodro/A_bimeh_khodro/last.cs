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
    public partial class last : Form
    {
        public last()
        {
            InitializeComponent();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox2.Text;
            string nationalcode = textBox3.Text;
            string cartag = textBox4.Text;
            string tarikhemroz = textBox5.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO customers (name,lastname,nationalcode,cartag, tarikhemroz) VALUES (N'" + name + "',N'" + lastname + "',N'" + nationalcode + "',N'" + cartag + "',N'" + tarikhemroz + "')";
            SqlCommand cmd = new SqlCommand(query, sc);
            cmd.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show(". با موفقیت ثبت شد");
           this.Hide();
        }
    }
}
