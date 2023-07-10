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
    public partial class pelakdigar : Form
    {
        public pelakdigar()
        {
            InitializeComponent();
        }
        public shjadid shj;
       
        private void button1_Click_1(object sender, EventArgs e)
        {

            string pelakdigar = textBox1.Text;
            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "INSERT INTO customers (pelakdigar) VALUES (N'" + pelakdigar + "')";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            scc.Close();
            shjtakhfif shjt = new shjtakhfif();
            shjt.Show();
            this.Hide();
        }
    }
}
