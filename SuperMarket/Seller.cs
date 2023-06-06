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
using System.Xml.Linq;

namespace SuperMarket
{

    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
        }


        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Seller_Load(object sender, EventArgs e)
        {
            Retr.getseller(SellerDGV, id, sellerN, age, Phone, pass);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            insert.insert_seller(EMPNAME.Text, Convert.ToInt32(EMPAGE.Text), EMP_PHONE.Text, PASSWORD.Text);
            Retr.getseller(SellerDGV, id, sellerN, age, Phone, pass);
            EMPNAME.Clear();
            EMPAGE.Clear();
            EMP_PHONE.Clear();
            PASSWORD.Clear();
        }
        Int16 userID;
        private void button2_Click(object sender, EventArgs e)
        {
            delete.del_category("st_delseller", "@id", userID);
            Retr.getseller(SellerDGV, id, sellerN, age, Phone, pass);
            userID = 0;
            EMPNAME.Clear();
            EMPAGE.Clear();
            EMP_PHONE.Clear();
            PASSWORD.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            update.update_seller(userID, EMPNAME.Text, Convert.ToInt32(EMPAGE.Text), EMP_PHONE.Text, PASSWORD.Text);
            Retr.getseller(SellerDGV, id, sellerN, age, Phone, pass);
            userID = 0;
            EMPNAME.Clear();
            EMPAGE.Clear();
            EMP_PHONE.Clear();
            PASSWORD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCat emp = new EmployeeCat();
            emp.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetail emp = new EmployeeDetail();
            emp.Show();
        }

        private void SellerDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = SellerDGV.Rows[e.RowIndex];
                userID = Convert.ToInt16(row.Cells["id"].Value.ToString());
                EMPNAME.Text = row.Cells["sellerN"].Value.ToString();
                EMPAGE.Text = row.Cells["age"].Value.ToString();
                EMP_PHONE.Text = row.Cells["Phone"].Value.ToString();
                PASSWORD.Text = row.Cells["pass"].Value.ToString();
            }
        }


    }
}