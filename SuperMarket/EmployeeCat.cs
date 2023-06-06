using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Guna.UI2.WinForms.Suite;
using System.Xml.Linq;
using BLL;
namespace SuperMarket
{
    public partial class EmployeeCat : Form
    {
        public EmployeeCat()
        {
            InitializeComponent();
        }



        private void EmployeeCat_Load(object sender, EventArgs e)
        {
            Retr.getempcat(EmpDGV, ID, name, description);
        }


        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSeller_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller seller = new Seller();
            seller.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetail employeeDetail = new EmployeeDetail();
            employeeDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert As = new insert();
            //As.insert_category("st_insertempcat", txt_name.Text, txt_discription.Text, "@name", "@descrp");
            BLL.bll_Student asd = new BLL.bll_Student();
            asd.saveStudent(txt_name.Text, txt_discription.Text);
            Retr.getempcat(EmpDGV, ID, name, description);
            txt_name.Clear();
            txt_discription.Clear();
        }
        Int16 id;
        private void button2_Click(object sender, EventArgs e)
        {
            //delete.del_category("st_delempcat", "@id", id);
            BLL.bll_Student asd = new BLL.bll_Student();
            asd.update(id);
            Retr.getempcat(EmpDGV, ID, name, description);
            id = 0;
            txt_name.Clear();
            txt_discription.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update.update_category(id, txt_name.Text, txt_discription.Text, "st_updateempcat", "@descrp", "@name", "@id");
            BLL.bll_Student asd = new BLL.bll_Student();
            asd.update(id , txt_name.Text, txt_discription.Text);
            Retr.getempcat(EmpDGV, ID, name, description);
            id = 0;
            txt_name.Clear();
            txt_discription.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetail emp = new EmployeeDetail();
            emp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seller sl = new Seller();
            sl.Show();
        }

        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = EmpDGV.Rows[e.RowIndex];
                id = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                txt_name.Text = row.Cells["name"].Value.ToString();
                txt_discription.Text = row.Cells["description"].Value.ToString();
            }
        }
    }
}