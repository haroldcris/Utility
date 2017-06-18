using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Aitech.Utility
{
    public class Database
    {
        public static SqlConnection CreateConnection()
        {
            var builder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "api",
                IntegratedSecurity = true
            };

            return new SqlConnection(builder.ToString());
        }
    }
}
