using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Xml.Linq;

namespace SuperMarket
{

    public partial class EmployeeDetail : Form
    {
        public EmployeeDetail()
        {
            InitializeComponent();
        }

        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            EMPJOIN.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
            Retr.loaditems("st_getempcat", EMPCAT, "ID", "Categories Name");
            Retr.getemployee(EMPDGV, esa, name, address, date, salary, cat, categories);
        }


        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCat cat = new EmployeeCat();
            cat.Show();
        }

        private void ButtonSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller seller = new Seller();
            seller.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu();
            menu.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert.insert_employee(EMPNAME.Text, EMPADDRESS.Text, EMPJOIN.Text, Convert.ToInt32(EMPSALARY.Text), Convert.ToInt16(EMPCAT.SelectedValue));
            Retr.getemployee(EMPDGV, esa, name, address, date, salary, cat, categories);
            EMPNAME.Clear();
            EMPADDRESS.Clear();
            EMPSALARY.Clear();
            EMPCAT.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete.del_category("st_delemployee", "@id", Id);
            Retr.getemployee(EMPDGV, esa, name, address, date, salary, cat, categories);
            Id = 0;
            EMPNAME.Clear();
            EMPADDRESS.Clear();
            EMPSALARY.Clear();
            EMPCAT.SelectedIndex = -1;
        }
        Int16 Id;
        private void button3_Click(object sender, EventArgs e)
        {
            update.update_employee(Id, EMPNAME.Text, EMPADDRESS.Text, EMPJOIN.Text, Convert.ToInt32(EMPSALARY.Text), Convert.ToInt16(EMPCAT.SelectedValue));
            Retr.getemployee(EMPDGV, esa, name, address, date, salary, cat, categories);
            Id = 0;
            EMPNAME.Clear();
            EMPADDRESS.Clear();
            EMPSALARY.Clear();
            EMPCAT.SelectedIndex = -1;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeCat cat = new EmployeeCat();
            cat.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller sa = new Seller();
            sa.Show();
        }

        private void EMPDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = EMPDGV.Rows[e.RowIndex];
                Id = Convert.ToInt16(row.Cells["esa"].Value.ToString());
                EMPNAME.Text = row.Cells["name"].Value.ToString();
                EMPADDRESS.Text = row.Cells["address"].Value.ToString();
                EMPJOIN.Text = row.Cells["date"].Value.ToString();
                EMPSALARY.Text = row.Cells["salary"].Value.ToString();
                EMPCAT.SelectedValue = row.Cells["cat"].Value;
            }
        }
    }
}