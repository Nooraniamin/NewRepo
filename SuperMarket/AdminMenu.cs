using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller sell = new Seller();
            sell.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vender vender = new Vender();
            vender.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories categories = new Categories();
            categories.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductFoam foam = new ProductFoam();
            foam.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyRen ren = new DailyRen();
            ren.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_details cusa = new Customer_details();
            cusa.Show();
        }
    }
}
