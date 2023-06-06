using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace SuperMarket
{
    internal class insert
    {
        public virtual void insert_category(string proc, string name, string des, string na, string desa)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand(proc, sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(na, name);
                cmd.Parameters.AddWithValue(desa, des);
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

        public static void insert_employee(string name, string address, string joindate, int salary, Int16 categories)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertemployee", sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@addr", address);
                cmd.Parameters.AddWithValue("@join_date", joindate);
                cmd.Parameters.AddWithValue("@salry", salary);
                cmd.Parameters.AddWithValue("@categ", categories);
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

        public virtual void insert_Product(string name, int qty, int price, float discount, float finalprice, Int16 cat_id)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertproduct", sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("price", price);
                cmd.Parameters.AddWithValue("@dis", discount);
                cmd.Parameters.AddWithValue("@finprice", finalprice);
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
        public static void insert_seller(string name, int age, string phone, string password)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand("st_insertseller", sqlpath.con);
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