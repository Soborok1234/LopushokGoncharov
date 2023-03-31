using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDemoDemo
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = db.edu.cchgeu.ru; Initial Catalog = 193_Goncharov; User = 193_Goncharov; Password = Qq123123;");
        
        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }


}
