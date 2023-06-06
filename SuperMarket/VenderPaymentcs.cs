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
    public partial class VenderPayment : Form
    {
        public VenderPayment()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");

        private void ButtonProd_Add_Click(object sender, EventArgs e)
        {
            //int cash, credit, debit,balance;
            //cash = int.Parse(BillCash.Text);
            //credit = int.Parse(Credit.Text);
            //debit = int.Parse(Debit.Text);
            //balance = cash + credit - debit;
            //Balance.Text = balance.ToString();
            //try
            //{
            //    con.Open();
            //    string query = "insert into VenderPayment values(" + BillNo.Text + ",'" + ProdQuantity2.Text + "','" + BillCash.Text + "','" + Credit.Text + "','" + Debit.Text + "','" + Balance.Text + "','" + Date.Text + "','"+ VenderName.SelectedValue.ToString() +"')";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Vender Payment Added SuccessFully");
            //    con.Close();
            //    populate();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void fillcombo()
        {
            //catcombo
            con.Open();
            SqlCommand cmd = new SqlCommand("select Vendname from Vender", con);
            SqlDataReader rda;
            rda = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Vendname", typeof(string));
            dt.Load(rda);
            COMB_NAME.ValueMember = "Vendname";
            COMB_NAME.DataSource = dt;
            con.Close();
        }
        private void fillcombo2()
        {
            //catcombo
            con.Open();
            SqlCommand cmd = new SqlCommand("select Vendname from Vender", con);
            SqlDataReader rda;
            rda = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Vendname", typeof(string));
            dt.Load(rda);
            comboBox1.ValueMember = "Vendname";
            comboBox1.DataSource = dt;
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string Query = "select * from VenderPayment";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            VENDDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void VenderPayment_Load(object sender, EventArgs e)
        {
            DATE.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            fillcombo();
            populate();
            fillcombo2();
        }

        private void ButtonProdDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (BillNo.Text == "")
            //    {
            //        MessageBox.Show("Select The Bill No to Delete");
            //    }
            //    else
            //    {
            //        //con.Open();
            //        //string query = "delete from VenderPayment where BillNo=" + BillNo.Text + "";
            //        //SqlCommand cmd = new SqlCommand(query, con);
            //        //cmd.ExecuteNonQuery();
            //        //MessageBox.Show("Product is Successfully Delete");
            //        //con.Close();
            //        Delete de = new Delete();
            //        int delete = int.Parse(BillNo.Text);
            //        de.Id(delete);
            //        populate();
            //        populate();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ButtonProdUpdate_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if ( ProdQuantity2.Text == "" || BillNo.Text == "" || BillCash.Text == "" || Credit.Text == "" || Debit.Text == "" || Date.Text == "")
            //    {
            //        MessageBox.Show("Please fullfil All the information");
            //    }
            //    else
            //    {
            //        int cash, credit, debit, balance;
            //        cash = int.Parse(BillCash.Text);
            //        credit = int.Parse(Credit.Text);
            //        debit = int.Parse(Debit.Text);
            //        balance = cash + credit - debit;
            //        Balance.Text = balance.ToString();
            //        con.Open();
            //        string query = "update VenderPayment set Quantity='" + ProdQuantity2.Text + "', BillCash='" + BillCash.Text + "',Credit ='" + Credit.Text + "',Debit='" + Debit.Text + "',Balance='" + Balance.Text + "', Date='"+Date.Text+"', Name='" + VenderName.SelectedValue.ToString()+"'where BillNo=" + BillNo.Text + ";";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Vender Payment is Successfully update");
            //        con.Close();
            //        populate();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vender vender = new Vender();
            vender.Show();
        }

        private void VenderGVD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //BillNo.Text = VenderDGV.SelectedRows[0].Cells[0].Value.ToString();
            //ProdQuantity2.Text = VenderDGV.SelectedRows[0].Cells[1].Value.ToString();
            //BillCash.Text = VenderDGV.SelectedRows[0].Cells[2].Value.ToString();
            //Credit.Text = VenderDGV.SelectedRows[0].Cells[3].Value.ToString();
            //Debit.Text = VenderDGV.SelectedRows[0].Cells[4].Value.ToString();
            //Balance.Text = VenderDGV.SelectedRows[0].Cells[5].Value.ToString();
            //Date.Text = VenderDGV.SelectedRows[0].Cells[6].Value.ToString();
            //VenderName.SelectedValue = VenderDGV.SelectedRows[7].Cells[0].Value.ToString();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendpayment ve = new Vendpayment();
            ve.Add(VENDBILL, VENDQTY,BILLCASH, CREDIT, DEBIT, BALANCE, DATE, COMB_NAME);
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vendpayment ve = new Vendpayment();
            ve.Delete(VENDBILL);
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vendpayment ve =new Vendpayment();
            ve.update(VENDBILL, VENDQTY, CREDIT, DEBIT, BALANCE, DATE, COMB_NAME);
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vender ven = new Vender();
            ven.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "select billno,quantity, billcash, credit,debit ,balance, date from VenderPayment where name='" + comboBox1.SelectedValue.ToString() + "';";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                SqlCommandBuilder bu = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                VENDDGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VENDBILL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
