using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    internal class update
    {
        public static void update_category(Int16 id, string name, string des, string pro, string desa, string na, string idd)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand(pro, sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(idd, id);
                cmd.Parameters.AddWithValue(na, name);
                cmd.Parameters.AddWithValue(desa, des);
                int res = cmd.ExecuteNonQuery();
                sqlpath.con.Close();
                if (res > 0)
                {
                    MessageBox.Show("Update successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                sqlpath.con.Close();
                MessageBox.Show(ex.Message);
            }

        }
        public static void update_employee(Int16 id, string name, string addr, string joindat, int salary, Int16 categ)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand("st_updateemployee", sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@addr", addr);
                cmd.Parameters.AddWithValue("@join_date", joindat);
                cmd.Parameters.AddWithValue("@salry", salary);
                cmd.Parameters.AddWithValue("@categ", categ);
                int res = cmd.ExecuteNonQuery();
                sqlpath.con.Close();
                if (res > 0)
                {
                    MessageBox.Show("add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                sqlpath.con.Close();
                MessageBox.Show(ex.Message);
            }

        }
        public virtual void update_product(Int16 id, string name, int qty, int price, float discount, float finalprice, Int16 cat_id)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand("st_updateproduct", sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@finprice", finalprice);
                cmd.Parameters.AddWithValue("@dis", discount);
                cmd.Parameters.AddWithValue("@cat_id", cat_id);
                int res = cmd.ExecuteNonQuery();
                sqlpath.con.Close();
                if (res > 0)
                {
                    MessageBox.Show("add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                sqlpath.con.Close();
                MessageBox.Show(ex.Message);
            }

        }
        public static void update_seller(Int16 id, string name, int age, string phone, string password)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand("st_updateseller", sqlpath.con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@password", password);

                int res = cmd.ExecuteNonQuery();
                sqlpath.con.Close();
                if (res > 0)
                {
                    MessageBox.Show("add successfully into the system", "success");
                }
            }
            catch (Exception ex)
            {
                sqlpath.con.Close();
                MessageBox.Show(ex.Message);
            }

        }
    }


}
