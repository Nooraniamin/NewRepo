using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SuperMarket
{
    public partial class Totalbusiness : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public Totalbusiness()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu ad = new AdminMenu();
            ad.Show();
        }
        private void populate()
        {
            con.Open();
            string Query = "select * from sellingform";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populate2()
        {
            con.Open();
            string Query = "select * from sellingform";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Totalbusiness_Load(object sender, EventArgs e)
        {
            populate();
            populate2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyRen ren = new DailyRen();
            ren.Show();
        }
    }
}
