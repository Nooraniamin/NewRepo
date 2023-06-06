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
    public partial class Vender : Form
    {
        public Vender()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        private void ButtonADD_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    con.Open();
            //    string query = "insert into VENDER values(" + VenderId.Text + ",'" + VenderName.Text + "','" + VenderCompanyName.Text + "','" + VenderPhone.Text + "')";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Vender Added SuccessFully");
            //    con.Close();
            //    populate();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {//DELETECODE
            //try
            //{
            //    if (VenderId.Text == "")
            //    {
            //        MessageBox.Show("Select The Employee to Delete");
            //    }
            //    else
            //    {
            //        //con.Open();
            //        //string query = "delete from VENDER where VenderId=" + VenderId.Text + "";
            //        //SqlCommand cmd = new SqlCommand(query, con);
            //        //cmd.ExecuteNonQuery();
            //        //MessageBox.Show("Vender is Successfully Delete");
            //        //con.Close();
            //        Delete de = new Delete();
            //        int delete = int.Parse(VenderId.Text);
            //        de.Id(delete);
            //        populate();
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (VenderId.Text == "" || VenderName.Text == "" || VenderCompanyName.Text == "" || VenderPhone.Text == "")
            //    {
            //        MessageBox.Show("Please fullfil All the information");
            //    }
            //    else
            //    {
            //        con.Open();
            //        string query = "update VENDER set VenderName='" + VenderName.Text + "',VenderCompanyName='" + VenderCompanyName.Text + "',VenderPhone='" + VenderPhone.Text + "'where VenderId=" + VenderId.Text + ";";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Vender is Successfully update");
            //        con.Close();
            //        populate();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }
        private void populate()
        {
            con.Open();
            string Query = "select * from Vender";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VENDDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Vender_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        private void VenderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //VenderId.Text = VenderDGV.SelectedRows[0].Cells[0].Value.ToString();
            //VenderName.Text = VenderDGV.SelectedRows[0].Cells[1].Value.ToString();
            //VenderCompanyName.Text = VenderDGV.SelectedRows[0].Cells[2].Value.ToString();
            //VenderPhone.Text = VenderDGV.SelectedRows[0].Cells[3].Value.ToString();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VenderPayment vender = new VenderPayment();
            vender.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            vender ven = new vender();
            ven.Delete(VENDiD);
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autogen();
            vender ven = new vender();
            ven.Add(VENDiD, VENDNAME, VENDCOMP, VENDPHONE);
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

            VENDiD.Text = (otp);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            vender ven = new vender();
            ven.update(VENDiD, VENDNAME, VENDCOMP, VENDPHONE);
            populate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            VenderPayment ven = new VenderPayment();
            ven.Show();
        }
    }
}
