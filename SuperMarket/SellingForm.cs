using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace SuperMarket
{
    public partial class SellingForm : Form
    {
        private StringReader myReader;
        public SellingForm()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            //populateBill();
            populate();
            fillcombo();
            lbl_Date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            SellerName.Text = Form1.Sellername;
        }
        //int flag = 0;
        //private void populateBill()
        //{
        //    con.Open();
        //    string Query = "select * from Bill";
        //    SqlDataAdapter sda = new SqlDataAdapter(Query, con);
        //    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        //    var ds = new DataSet();
        //    sda.Fill(ds);
        //    Prod2GVD.DataSource = ds.Tables[0];
        //    con.Close();
        //}
        private void populate()
        {
            sqlpath.con.Open();
            string Query = "select ProdName, ProdPrice, ProdDiscount, ProdFinal from product";
            SqlDataAdapter sda = new SqlDataAdapter(Query, sqlpath.con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PROITEM.DataSource = ds.Tables[0];
            sqlpath.con.Close();
        }

        private void ProdDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ProdName.Text = ProdDGV.SelectedRows[0].Cells[0].Value.ToString();
            // ProdPrice.Text = ProdDGV.SelectedRows[0].Cells[1].Value.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        int grandtotal = 0, n = 0;

        private void ButtonProd_Add_Click(object sender, EventArgs e)
        {
            //if (BillId.Text == "")
            //{
            //    MessageBox.Show("Bill Id is Missing");
            //}
            //else
            //{
            //    try
            //    {
            //        con.Open();
            //        string query = "insert into Bill values(" + BillId.Text + ",'" + SellerName.Text + "','" + lbl_Date.Text + "','" + AmtLbl.Text + "')";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Order Added SuccessFully");
            //        con.Close();
            //        populate();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void ButtonProdDelete_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Prod2GVD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //flag = 1;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawString("SUPERMAEKET", new Font("Century Gothic", 25, FontStyle.Bold),Brushes.Red, new Point(230));
            //e.Graphics.DrawString("Bill ID:"+BILLID.Text, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100,70));
            //float lineaPage = 0;
            //float yPositio = 0;
            //int count = 0;
            //float leftmargin = e.MarginBounds.Left;
            //float topmargin = e.MarginBounds.Top;
            //string line = null;
            //Font printfont = this.listBox1.Font;
            //SolidBrush myBrush = new SolidBrush(Color.Black);
            //lineaPage = e.MarginBounds.Height/ printfont.GetHeight(e.Graphics);
            //while(count < lineaPage && ((line = myReader.ReadLine()) != null))
            //{
            //    yPositio = topmargin + (count * printfont.GetHeight(e.Graphics));
            //    e.Graphics.DrawString(line, printfont, myBrush, leftmargin, yPositio, new StringFormat());
            //    count++;
            //}
            //if(line != null)
            //{
            //    e.HasMorePages = true;
            //}
            //else
            //{
            //    e.HasMorePages= false;
            //    myBrush.Dispose();
            //}
           // e.Graphics.DrawString("\nSell Name:" + listBox1, new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            //e.Graphics.DrawString("\n\nDate:" + Prod2GVD.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
            //e.Graphics.DrawString("\n\n\nAmount:\t" + Prod2GVD.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century Gothic", 15, FontStyle.Bold), Brushes.Blue, new Point(100, 70));
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            
        }
        private void fillcombo()
        {

            //catcombo
            sqlpath.con.Open();
            SqlCommand cmd = new SqlCommand("select catname from Categories", sqlpath.con);
            SqlDataReader rda;
            rda = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("catname", typeof(string));
            dt.Load(rda);
            comboBox1.ValueMember = "catname";
            comboBox1.DataSource = dt;
            sqlpath.con.Close();
        }

        private void ProdCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from Product where ProdCategory"+ ProdCategory.SelectedValue, con);
            //SqlDataReader rda;
            //rda = cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("CatName", typeof(string));
            //dt.Load(rda);
            //ProdDGV.DataSource = dt.TableName[0];
            //con.Close();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        Int16 ID;
        private void button1_Click(object sender, EventArgs e)
        {
            if (PRODNAME.Text == "" && QUANITITY.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                n++;
                BILLID.Text = n.ToString();
                int total = (int)(Convert.ToInt64(PRICE1.Text) * Convert.ToInt64(QUANITITY.Text));
                textBox1.Text = total.ToString();
                // listBox1.Text += text;
                dataGridView1.Rows.Add(ID, BILLID.Text, PRODNAME.Text, OPRICE.Text, DISCOUNT1.Text, PRICE1.Text, QUANITITY.Text, textBox1.Text);
                grandtotal += total;
                AmtLbl.Text = "RS " + grandtotal;
            }

        }

        private void DETAIL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            AMOUNT.Text = AmtLbl.Text;
            if(payment.Text == "CREDIT CARD")
            {
                label14.Visible = false;
                label15.Visible = false;
                TAKEAMOUNT.Visible = false;
                GIVEAMOUNT.Visible = false;
                int originalPrice = 0;
                double discount, discountGiven, SalePrice;
                originalPrice = int.Parse(AMOUNT.Text);
                discount = 5;
                DTYPE.Text = discount.ToString();
                discountGiven = originalPrice * (discount / 100);
                SalePrice = originalPrice - discountGiven;
                TOTAL1.Text = SalePrice.ToString();
            }
            else if(payment.Text == "MEMBER/CREDIT")
            {
                label14.Visible = false;
                label15.Visible = false;
                TAKEAMOUNT.Visible = false;
                GIVEAMOUNT.Visible = false;

                int originalPrice = 0;
                double discount, discountGiven, SalePrice;
                originalPrice = int.Parse(AMOUNT.Text);
                discount = 7;
                DTYPE.Text = discount.ToString();
                discountGiven = originalPrice * (discount / 100);
                SalePrice = originalPrice - discountGiven;
                TOTAL1.Text = SalePrice.ToString();
            }
            else if(payment.Text== "CASH")
            {
                
                label14.Visible = true;
                label15.Visible = true;
                TAKEAMOUNT.Visible = true;
                GIVEAMOUNT.Visible = true;
                label13.Visible = false;
                DTYPE.Visible = false;
                int t = Convert.ToInt32(TAKEAMOUNT.Text);
                int t2 = Convert.ToInt32(AmtLbl.Text);
                int total = t - t2;
                GIVEAMOUNT.Text = total.ToString();
                TOTAL1.Text = AMOUNT.Text;

            }
            else if (payment.Text== "MEMBERSHIP")
            {
                label14.Visible = true;
                label15.Visible = true;
                TAKEAMOUNT.Visible = true;
                GIVEAMOUNT.Visible = true;
                int originalPrice = 0;
                double discount, discountGiven, SalePrice;
                originalPrice = int.Parse(AMOUNT.Text);
                discount = 2;
                DTYPE.Text = discount.ToString();
                discountGiven = originalPrice * (discount / 100);
                SalePrice = originalPrice - discountGiven;
                TOTAL1.Text = SalePrice.ToString();
                int t = Convert.ToInt32(TAKEAMOUNT.Text);
                int t2 = Convert.ToInt32(TOTAL1.Text);
                int total = t2 - t;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int grandto = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            if(payment.Text== "CASH")
            {
                int p = Convert.ToInt32(TOTAL1.Text);
                grandto = p + grandto;
                cash.Text = grandto.ToString();
                Autogen();
                sell se = new sell();
                se.Add(BILLID,AMOUNT,DTYPE,TOTAL1,cash,lbl_Date,SellerName);
            }
            else if(payment.Text=="MEMBERSHIP")
            {
                int p = Convert.ToInt32(TOTAL1.Text);
                grandto = p + grandto;
                cash.Text = grandto.ToString();
                Autogen();
                sell se = new sell();
                se.Add(BILLID, AMOUNT, DTYPE, TOTAL1, cash, lbl_Date, SellerName);
            }
            else if (payment.Text == "CREDIT CARD")
            {
                MessageBox.Show("This Amount Can't Enter in Cash");
            }
            else if (payment.Text == "MEMBER/CREDIT")
            {
                MessageBox.Show("This Amount Can't Enter in Cash");
            }

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

            BILLID.Text = (otp);
        }
        int grand = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (payment.Text == "CREDIT CARD")
            {
                int p = Convert.ToInt32(TOTAL1.Text);
                grand = p + grand;
                creditcard.Text = grand.ToString();
                Autogen();
                sell se = new sell();
                se.Add2(BILLID, AMOUNT, DTYPE, TOTAL1, cash, lbl_Date, SellerName);
            }
            else if (payment.Text == "MEMBER/CREDIT")
            {
                int p = Convert.ToInt32(TOTAL1.Text);
                grand = p + grand;
                creditcard.Text = grand.ToString();
                Autogen();
                sell se = new sell();
                se.Add2(BILLID, AMOUNT, DTYPE, TOTAL1, cash, lbl_Date, SellerName);
            }
            else if (payment.Text == "CASH")
            {
                MessageBox.Show("This Amount Can't Enter in Credit Card");
            }
            else if (payment.Text == "MEMBERSHIP")
            {
                MessageBox.Show("This Amount Can't Enter in Credit Card");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sqlpath.con.Open();
            string query = "select ProdName, ProdPrice, ProdDiscount, ProdFinal from product where ProdCat= '" + comboBox1.SelectedValue.ToString() + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlpath.con);
            SqlCommandBuilder bu = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PROITEM.DataSource = ds.Tables[0];
            sqlpath.con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void PROITEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    PRODNAME.Text = PROITEM.SelectedRows[0].Cells[0].Value.ToString();
            //    OPRICE.Text = PROITEM.SelectedRows[0].Cells[1].Value.ToString();
            //    DISCOUNT1.Text = PROITEM.SelectedRows[0].Cells[2].Value.ToString();
            //    PRICE1.Text = PROITEM.SelectedRows[0].Cells[3].Value.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        
        
    }
}
