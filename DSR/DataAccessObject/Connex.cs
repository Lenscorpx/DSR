using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace DSR.DataAccessObject
{
    class Connex
    {
        public static SqlConnection con = null; 
        public Connex()
        {
            //Data Source=DESKTOP-KT3C194\LENSCORPX;Initial Catalog=db_gesproj;User ID=sa;Password=***********
            con = new SqlConnection("Network Library=DBMSSOCN; Data Source=DESKTOP-PO0I2OH\\LENSCORPX,1433; Initial Catalog=bd_daily_security; User Id=Lens; Password=Windy@2019.com?;");
            con.Open();
        }        
    }
}
