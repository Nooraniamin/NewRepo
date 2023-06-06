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
    public partial class DailyRen : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=Supermarket3;Integrated Security=True");
        public DailyRen()
        {
            InitializeComponent();
        }
        int n = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            n++;
            S_NO.Text = n.ToString();

            int cash, Credit, Debit, Balance;
            cash = int.Parse(opencash.Text);
            Credit = int.Parse(credit.Text);
            Debit = int.Parse(debit.Text);
            Balance = cash + Credit - Debit;
            balance.Text = Balance.ToString();
            if (Balance == cash)
            {
                profit_loss.Text = "Average";

            }
            else if (Balance >= cash)
            {
                profit_loss.Text = "Profit";
            }
            else
            {
                profit_loss.Text = "Loss";
            }
            daily d = new daily();
            d.Add(S_NO, opencash, credit, debit, balance, date, Description);
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu ad = new AdminMenu();
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            daily d = new daily();
            d.Delete(S_NO);
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cash, Credit, Debit, Balance;
            cash = int.Parse(opencash.Text);
            Credit = int.Parse(credit.Text);
            Debit = int.Parse(debit.Text);
            Balance = cash + Credit - Debit;
            balance.Text = Balance.ToString();
            if (Balance == cash)
            {
                profit_loss.Text = "Average";

            }
            else if (Balance >= cash)
            {
                profit_loss.Text = "Profit";
            }
            else
            {
                profit_loss.Text = "Loss";
            }
            daily d = new daily();
            d.update(S_NO, opencash, credit, debit, balance, date, Description);
            populate(); 
        }
        private void populate()
        {//Display
            con.Open();
            string Query = "select * from Dailyren";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DailyDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void DailyRen_Load(object sender, EventArgs e)
        {
            date.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            populate();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Totalbusiness t  = new Totalbusiness();
            t.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "select sno ,opencash,credit,debit ,balance,description from Dailyren where date='" + textBox1.Text + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder bu = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DailyDGV.DataSource = ds.Tables[0];
            con.Close();
        }
    }
}
