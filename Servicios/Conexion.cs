using System;
using Servicios;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Conexion
    {
        public static SqlConnection DatabaseConnection()
        {
            string DB = "Harmoniq";
            string user = "sa";
            string password = "123";
            string connectionString = "Server=localhost;Database=" + DB + ";User=" + user + ";Password=" + password + ";";
            SqlConnection _connection = new SqlConnection(connectionString);
            return _connection;
        }
    }
}
