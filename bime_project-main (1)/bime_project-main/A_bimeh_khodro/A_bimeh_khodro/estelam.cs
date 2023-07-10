using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_bimeh_khodro
{
    public partial class estelam : Form
    {
        public estelam()
        {
            InitializeComponent();
        }

        private void estelam_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            sc.Open();
            string query = "SELECT name,lastname,nationalcode,phone,type,control,bimeghabli,sabeghetakhfif,tarikhemroz,gheymat FROM customers";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                string name = rd["name"].ToString();
                string lastname = rd["lastname"].ToString();
                string nationalcode = rd["nationalcode"].ToString();
                string phone = rd["phone"].ToString();
                string type = rd["type"].ToString();
                string control = rd["control"].ToString();
                string bimeghabli = rd["bimeghabli"].ToString();
                string sabeghetakhfif = rd["sabeghetakhfif"].ToString();
                string tarikhemroz = rd["tarikhemroz"].ToString();
                string gheymat = rd["gheymat"].ToString();
                label2.Text = name;
                label4.Text = lastname;
                label16.Text = nationalcode;
                label8.Text = phone;
                label10.Text = type;
                label12.Text = control;
                label14.Text = bimeghabli;
                label16.Text = sabeghetakhfif;
                label18.Text = tarikhemroz;
                label20.Text = gheymat;
            }
            sc.Close();
        }
    }
}
