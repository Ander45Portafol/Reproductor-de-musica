using Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public class Autenticacion
    {
        public static bool Autenticar(string correo, string contraseña)
        {
            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Usuario WHERE correo_electronico=@Correo AND clave_usuario=@Contraseña";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}\nNúmero: {sqlEx.Number}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}");
                return false;
            }
        }
    }
}

