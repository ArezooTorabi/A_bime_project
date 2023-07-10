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
    public partial class shjtakhfif2 : Form
    {
        public shjtakhfif2()
        {
            InitializeComponent();
        }
        public shjadid shj;
        private void button1_Click_1(object sender, EventArgs e)
        {
            string type = "تخفیف ندارد";
            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "UPDATE customers SET sabeghetakhfif = N'" + type + "'";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            scc.Close();
            khesarat khst = new khesarat();
            khst.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string type = "با همین پلاک تخفیف داشته";
            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "UPDATE customers SET sabeghetakhfif = N'" + type + "'";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            scc.Close();
            shjtakhfif shjt = new shjtakhfif();
            shjt.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string type = "پلاک دیگری دارد";
            SqlConnection scc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=TrueData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=TrueData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=TrueData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=TrueData Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Von\Downloads\bime_project-main (1)\bime_project-main\A_bimeh_khodro\A_bimeh_khodro\Database1.mdf"";Integrated Security=True");
            scc.Open();
            string query1 = "UPDATE customers SET sabeghetakhfif = N'" + type + "'";
            SqlCommand cmmd = new SqlCommand(query1, scc);
            cmmd.ExecuteNonQuery();
            scc.Close();
            pelakdigar plk = new pelakdigar();
            plk.Show();
            this.Hide();
        }

       
    }
}
