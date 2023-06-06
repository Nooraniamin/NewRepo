using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net;
using System.Xml.Linq;

namespace SuperMarket
{
    public partial class ProductFoam : Form
    {
        public ProductFoam()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //add
            //int originalPrice = 0;
            //double discount, discountGiven, SalePrice;
            //originalPrice = int.Parse(ProdPrice.Text);
            //discount = double.Parse(ProdDiscount.Text);
            //discountGiven = originalPrice * (discount / 100);
            //SalePrice = originalPrice - discountGiven;
            //ProdFinalPrice.Text = SalePrice.ToString();
            //try
            //{
            //    con.Open();
            //    string query = "insert into Product values(" + ProdId.Text + ",'" + ProdName.Text + "','" + ProdQuantity.Text + "','" + ProdPrice.Text +"','" + ProdDiscount.Text + "','" + ProdFinalPrice.Text + "','" + ProdCategory.SelectedValue.ToString() + "')";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Product Added SuccessFully");
            //    con.Close();
            //    populate();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        Int16 id;


        private void ProductFoam_Load(object sender, EventArgs e)
        {
            Retr.loaditems("st_getfoodcate", PRODCAT, "Categories ID", "Categories");
            Retr.getpro(PRODDGV, PROID, name, qty, oprice, dis, fprice, catid, Cat);
        }
        Int16 ID;

        private void button2_Click(object sender, EventArgs e)
        {
            delete.del_category("st_delproduct", "@id", ID);
            Retr.getpro(PRODDGV, PROID, name, qty, oprice, dis, fprice, catid, Cat);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update ne = new update();
            ne.update_product(ID, PRODNAME.Text, Convert.ToInt32(PRODQTY.Text), int.Parse(PRODPRICE.Text), float.Parse(PRODDISCOUNT.Text), float.Parse(PRODFINAL.Text), Convert.ToInt16(PRODCAT.SelectedValue.ToString()));
            Retr.getpro(PRODDGV, PROID, name, qty, oprice, dis, fprice, catid, Cat);
        }

        private void PRODDISCOUNT_TextChanged(object sender, EventArgs e)
        {
            if (PRODPRICE.Text == "" && PRODDISCOUNT.Text == "")
            {
                PRODPRICE.Text = "0";
                PRODDISCOUNT.Text = "0";
            }
            else
            {
                int originalPrice = 0;
                float discountGiven, SalePrice;
                originalPrice = int.Parse(PRODPRICE.Text);
                discountGiven = float.Parse(PRODDISCOUNT.Text);
                discountGiven = originalPrice * (discountGiven / 100);
                SalePrice = originalPrice - discountGiven;
                PRODFINAL.Text = SalePrice.ToString();
            }


        }
        private void button8_Click(object sender, EventArgs e)
        {


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert ad = new insert();
            ad.insert_Product(PRODNAME.Text, Convert.ToInt32(PRODQTY.Text), int.Parse(PRODPRICE.Text), float.Parse(PRODDISCOUNT.Text), float.Parse(PRODFINAL.Text), Convert.ToInt16(PRODCAT.SelectedValue.ToString()));
            Retr.getpro(PRODDGV, PROID, name, qty, oprice, dis, fprice, catid, Cat);
        }

        private void PRODDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = PRODDGV.Rows[e.RowIndex];
                ID = Convert.ToInt16(row.Cells["PROID"].Value.ToString());
                PRODNAME.Text = row.Cells["name"].Value.ToString();
                PRODQTY.Text = row.Cells["qty"].Value.ToString();
                PRODPRICE.Text = row.Cells["oprice"].Value.ToString();
                PRODDISCOUNT.Text = row.Cells["dis"].Value.ToString();
                PRODFINAL.Text = row.Cells["fprice"].Value.ToString();
                PRODCAT.SelectedValue = row.Cells["catid"].Value;
            }
        }
    }
}