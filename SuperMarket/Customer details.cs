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
    public partial class Customer_details : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public Customer_details()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Autogen();
            cus c = new cus();
            c.Add(cusid, cusname, CUSPHONE, Address);
            populate();
        }
        public void Autogen()
        {
            string num = "123456789";
            int len = num.Length;
            string otp = string.Empty;
            int optdigit = 5;
            string finaldigit;

            int getindex;
            for (int i = 0; i < optdigit; i++)
            {
                do
                {
                    getindex = new Random().Next(0, len);
                    finaldigit = num.ToCharArray()[getindex].ToString();
                }
                while (otp.IndexOf(finaldigit) != -1);
                otp = finaldigit;
            }

            cusid.Text = (otp);
        }
        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu ad = new AdminMenu();
            ad.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            conn.Open();
            string Query = "select * from customer";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            cusdgv.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Customer_details_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void Delet_Click(object sender, EventArgs e)
        {
            cus n = new cus();  
            n.Delete(cusid);
            populate();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            cus n = new cus();
            n.update(cusid, cusname, CUSPHONE, Address);
        }
    }
}
