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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "SELECT YOUR ROLE";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //if (TextBox_Username.Text == "" || TextBox_Password.Text == "")
            //{
            //    MessageBox.Show("Enter The User Name and Password");

            //}
            //else
            //{
            //    if (ComboBox_Role.SelectedIndex > -1)
            //    {
            //        if (ComboBox_Role.SelectedItem.ToString() == "ADMIN")
            //        {
            //            if (TextBox_Username.Text == "Admin" && TextBox_Password.Text == "Admin")
            //            {
            //                AdminMenu Admin = new AdminMenu();
            //                Admin.Show();
            //                this.Hide();
            //            }
            //            else
            //            {
            //                MessageBox.Show("If You are the Admin, Enter The Correct Id and Password");
            //            }
            //        }
            //        else
            //        {
            //            //MessageBox.Show("Your in Seller Section");
            //            con.Open();
            //            SqlDataAdapter sda = new SqlDataAdapter("Select count(0) from Seller where SellerName='" + TextBox_Username.Text + "' and SellerPass='" + TextBox_Password.Text + "'", con);
            //            DataTable dt = new DataTable();
            //            sda.Fill(dt);
            //            if (dt.Rows[0][0].ToString() == "1")
            //            {
            //                Sellername = TextBox_Username.Text;
            //                SellingForm sell = new SellingForm();
            //                sell.Show();
            //                this.Hide();
            //                con.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Wrong UserName or Password");
            //            }
            //            con.Close();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please Select The Role");
            //    }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Enter The User Name and Password");

            }
            else
            {
                if (comboBox1.SelectedIndex > -1)
                {
                    if (comboBox1.SelectedItem.ToString() == "ADMIN")
                    {
                        if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                        {
                            AdminMenu Admin = new AdminMenu();
                            Admin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin, Enter The Correct Id and Password");
                        }
                    }
                    else
                    {
                        try
                        {
                            sqlpath.con.Open();
                            SqlDataAdapter sda = new SqlDataAdapter("Select count(8) from seller where name='" + textBox1.Text + "' and password='" + textBox2.Text + "'",sqlpath.con);
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            if (dt.Rows[0][0].ToString() == "1")
                            {
                                Sellername = textBox1.Text;
                                SellingForm sell = new SellingForm();
                                sell.Show();
                                this.Hide();
                                sqlpath.con.Close();
                            }
                            else
                            {
                                MessageBox.Show("Wrong UserName or Password");
                            }
                            sqlpath.con.Close();
                        }
                        catch (Exception ex)
                        { MessageBox.Show(ex.Message);}
                        //MessageBox.Show("Your in Seller Section");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Please Select The Role");
                }
            }
        }
    }
}


