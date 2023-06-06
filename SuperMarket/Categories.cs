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

namespace SuperMarket
{
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }
        private void Button_CatAdd_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    //AddCode
            //    con.Open();
            //    string query = "insert into Categories values("+TextBox_CatId.Text+",'" + TextBox_CatName.Text + "','" + Textbox_CatDescription.Text +"')";
            //    SqlCommand cmd = new SqlCommand(query, con);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Category Added SuccessFully");
            //    con.Close();
            //    populate();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //BackCode
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            Retr.getCate(CatDGV, ID, CateName, DES);
        }

        private void CatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Show
            //TextBox_CatId.Text = CatDGV.SelectedRows[0].Cells[0].Value.ToString();
            //TextBox_CatName.Text = CatDGV.SelectedRows[0].Cells[1].Value.ToString();
            //Textbox_CatDescription.Text = CatDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void Button_CatDelete_Click(object sender, EventArgs e)
        {

            //DeleteCode
            //try
            //{
            //    if(TextBox_CatId.Text == "")
            //    {
            //        MessageBox.Show("Select The Category to Delete");
            //    }
            //    else
            //    {
            //        //con.Open();
            //        //string query = "delete from Categories where CatId="+ TextBox_CatId.Text +"";
            //        //SqlCommand cmd = new SqlCommand(query,con);
            //        //cmd.ExecuteNonQuery();
            //        //MessageBox.Show("Category is Successfully Delete");
            //        //con.Close();
            //        //populate();
            //        Delete de = new Delete();
            //        int delete = int.Parse(TextBox_CatId.Text);
            //        de.Id(delete);
            //        populate();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Button_CatUpdate_Click(object sender, EventArgs e)
        {
            //UpdateCode
            //try
            //{
            //    if (TextBox_CatId.Text == "" || TextBox_CatName.Text == "" || Textbox_CatDescription.Text == "")
            //    {
            //        MessageBox.Show("Please fullfil All the information");
            //    }
            //    else
            //    {
            //        con.Open();
            //        string query = "update Categories set CatName='" + TextBox_CatName.Text + "',CatDescription='" + Textbox_CatDescription.Text + "'where CatId=" + TextBox_CatId.Text + ";";
            //        SqlCommand cmd = new SqlCommand(query, con);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Category is Successfully update");
            //        con.Close();
            //        populate();

            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            insert As = new insert();
            As.insert_category("st_insertprocat", txt_name.Text, txt_discription.Text, "@name", "@descrp");
            Retr.getCate(CatDGV, ID, CateName, DES);
            txt_name.Clear();
            txt_discription.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete.del_category("st_delprocat", "@id", Id);
            Retr.getCate(CatDGV, ID, CateName, DES);
            txt_name.Clear();
            txt_discription.Clear();
        }
        Int16 Id;
        private void button3_Click(object sender, EventArgs e)
        {
            update.update_category(Id, txt_name.Text, txt_discription.Text, "st_updateprocat", "@descrp", "@name", "@id");
            Retr.getCate(CatDGV, ID, CateName, DES);
            txt_name.Clear();
            txt_discription.Clear();
        }

        private void CatDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                DataGridViewRow row = CatDGV.Rows[e.RowIndex];
                Id = Convert.ToInt16(row.Cells["ID"].Value.ToString());
                txt_name.Text = row.Cells["CateName"].Value.ToString();
                txt_discription.Text = row.Cells["DES"].Value.ToString();
            }

        }
    }
}