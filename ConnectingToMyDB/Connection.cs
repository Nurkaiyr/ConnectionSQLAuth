using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectingToMyDB
{
    public class Connection
    {
        public SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

            builder.UserID = "Vasya";
            builder.Password = "bulka1";
            builder.DataSource = "(local)";
            builder.InitialCatalog = "MyDB";
            builder.IntegratedSecurity = false; 

            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}
