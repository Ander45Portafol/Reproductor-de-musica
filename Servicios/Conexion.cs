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
            string user = "ALEJANDROSURIA\aleda";
            string password = "123";
            string connectionString = "Server=ALEJANDROSURIA; Database=" + DB + ";Integrated Security = true;";
            //  SqlConnection _connection = new SqlConnection(connectionString);
            //  return _connection;

            return new SqlConnection(connectionString);
        }
    }
}
