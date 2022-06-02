using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial_Symphony;

namespace Tutorial_Symphony
{
    public class DBConnects
    {
        public string DBConnection1()
        {
            string con = @"Data Source=DESKTOP-MHVM5S2\SQLEXPRESS;Initial Catalog=POS_Database_1;Integrated Security=True";
            return con;
        }
    }
}
