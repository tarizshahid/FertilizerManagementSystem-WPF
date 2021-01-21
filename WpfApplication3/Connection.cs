using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3
{
    class Connection
    {
        public SqlConnection CON;
        public Connection()
        {
            CON = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString);
        }   
    }
}
