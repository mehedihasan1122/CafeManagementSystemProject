using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagementSystem
{
    class DataAccess
    {
        public SqlConnection connection;
        private SqlCommand command;

        public DataAccess()
        {
            this.connection = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=cafeManagementSystem;Integrated Security=True;MultipleActiveResultSets=true;");
            this.connection.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteReader();
        }


        public int ExecuteQuery(string sql)
        {
            this.command = new SqlCommand(sql, this.connection);
            return this.command.ExecuteNonQuery();
        }

        public void Dispose()
        {
            this.connection.Close();
        }
    }
}
