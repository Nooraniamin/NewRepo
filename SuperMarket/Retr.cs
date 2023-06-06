using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace SuperMarket
{
    internal class Retr
    {
        public static void getempcat(DataGridView gv, DataGridViewColumn ID, DataGridViewColumn name, DataGridViewColumn des)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("st_getempcat", sqlpath.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ID.DataPropertyName = dt.Columns["ID"].ToString();
                    name.DataPropertyName = dt.Columns["Categories Name"].ToString();
                    des.DataPropertyName = dt.Columns["Description"].ToString();
                    gv.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static void getpro(DataGridView gv, DataGridViewColumn ID, DataGridViewColumn name, DataGridViewColumn qty, DataGridViewColumn oprice, DataGridViewColumn discount, DataGridViewColumn final, DataGridViewColumn cateID, DataGridViewColumn catName)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("st_getProduct", sqlpath.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ID.DataPropertyName = dt.Columns["Product ID"].ToString();
                    name.DataPropertyName = dt.Columns["Product Name"].ToString();
                    qty.DataPropertyName = dt.Columns["Quantity"].ToString();
                    oprice.DataPropertyName = dt.Columns["Price"].ToString();
                    discount.DataPropertyName = dt.Columns["Discount"].ToString();
                    final.DataPropertyName = dt.Columns["Selling Price"].ToString();
                    cateID.DataPropertyName = dt.Columns["Cateergory ID"].ToString();
                    catName.DataPropertyName = dt.Columns["Category"].ToString();
                    gv.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Error");
                }
            }
        }
        public static void loaditems(string proc, ComboBox cb, string vMember, string dMember)
        {

            try
            {

                SqlCommand cmd = new SqlCommand(proc, sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb.DisplayMember = dMember;
                cb.ValueMember = vMember;
                cb.DataSource = dt;


            }
            catch (Exception)
            {
                throw;

            }

        }
        public static void getCate(DataGridView gv, DataGridViewColumn UserIDGV, DataGridViewColumn userNameGV, DataGridViewColumn desGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getfoodcate", sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                UserIDGV.DataPropertyName = dt.Columns["Categories ID"].ToString();
                userNameGV.DataPropertyName = dt.Columns["Categories"].ToString();
                desGV.DataPropertyName = dt.Columns["Description"].ToString();
                gv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void getemployee(DataGridView gv, DataGridViewColumn ID, DataGridViewColumn name, DataGridViewColumn add, DataGridViewColumn joindate, DataGridViewColumn salary, DataGridViewColumn cateID, DataGridViewColumn catName)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("st_getemployee", sqlpath.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ID.DataPropertyName = dt.Columns["Employee ID"].ToString();
                    name.DataPropertyName = dt.Columns["Employee Name"].ToString();
                    add.DataPropertyName = dt.Columns["Address"].ToString();
                    joindate.DataPropertyName = dt.Columns["Join date"].ToString();
                    salary.DataPropertyName = dt.Columns["salary"].ToString();
                    cateID.DataPropertyName = dt.Columns["Cateergory ID"].ToString();
                    catName.DataPropertyName = dt.Columns["Category"].ToString();

                    gv.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Error");
                }
            }
        }
        public static void getseller(DataGridView gv, DataGridViewColumn ID, DataGridViewColumn name, DataGridViewColumn age, DataGridViewColumn phone, DataGridViewColumn pass)
        {
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("st_getseller", sqlpath.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ID.DataPropertyName = dt.Columns["seller ID"].ToString();
                    name.DataPropertyName = dt.Columns["seller Name"].ToString();
                    age.DataPropertyName = dt.Columns["Age"].ToString();
                    phone.DataPropertyName = dt.Columns["phone"].ToString();
                    pass.DataPropertyName = dt.Columns["password"].ToString();

                    gv.DataSource = dt;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "Error");
                }
            }
        }
    }
}