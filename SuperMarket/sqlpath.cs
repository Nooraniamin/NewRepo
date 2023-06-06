using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;


namespace SuperMarket
{
    internal class sqlpath
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=AMIN;Initial Catalog=supermarkets;Persist Security Info=True;User ID=supermark;Password=1234567");
    }
}