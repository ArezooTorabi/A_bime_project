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
    public partial class shjtakhfif : Form
    {
        public shjtakhfif()
        {
            InitializeComponent();
        }
        public shjadid shj;
       
      

        private void shjtakhfif_Load_1(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT takhfif FROM takhfif";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string takhfif = rd["takhfif"].ToString();
                comboBox1.Items.Add(takhfif);
                comboBox2.Items.Add(takhfif);
            }
            sc.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string takhfifsales = comboBox1.Text;
            string takhfifranande = comboBox2.Text;
            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "INSERT INTO customers (takhfifsales,takhfifranande) VALUES (N'" + takhfifsales + "',N'" + takhfifranande + "')";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            scc.Close();
            khesarat khst = new khesarat();
            khst.Show();
            this.Hide();
        }
    }
}
