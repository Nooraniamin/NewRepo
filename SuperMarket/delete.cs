using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperMarket
{
    internal class delete
    {
        public static void del_category(string pro, string val, Int16 As)
        {
            try
            {
                sqlpath.con.Open();
                SqlCommand cmd = new SqlCommand(pro, sqlpath.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(val, As);
                int res = cmd.ExecuteNonQuery();
                sqlpath.con.Close();
                if (res > 0)
                {
                    MessageBox.Show("Delete successfully into the system", "success");
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