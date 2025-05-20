using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Reproductor_de_Musica
{
    public partial class FrmCrearPlaylist : Form
    {
        private int usuario;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos

        // 2. Declarar el evento usando el delegado.
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmCrearPlaylist(int id_usuario)
        {
            InitializeComponent();
            usuario = id_usuario;
        }
        private bool CrearPlaylist()
        {
            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    string query = "INSERT INTO Lista(id_usuario,nombre_lista,fecha_creacion)VALUES (@Usuario,@NombreLista,@Fecha)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@NombreLista", TxtNombre_Lista.Text);
                        cmd.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = DateTime.Now;
                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Playlist creada correctamente");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Hubo problemas para crear la Playlist");
                            return false;
                        }
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
        protected virtual void OnDatoAgregado(EventArgs e)
        {
            DatoAgregado?.Invoke(this, e);
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CrearPlaylist();
            OnDatoAgregado(EventArgs.Empty);
            this.Hide();
        }
    }
}
