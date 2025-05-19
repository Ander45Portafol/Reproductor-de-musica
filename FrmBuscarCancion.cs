using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Reproductor_de_Musica
{
    public partial class FrmBuscarCancion: Form
    {
        private int id_lista;
        public delegate void DatoAgregadoEventHandler(object sender, EventArgs e); // Puedes crear una clase EventArgs personalizada para pasar datos

        // 2. Declarar el evento usando el delegado.
        public event DatoAgregadoEventHandler DatoAgregado;
        public FrmBuscarCancion(int lista)
        {
            InitializeComponent();
            this.id_lista = lista;
        }


        private void FrmBuscarCancion_Load(object sender, EventArgs e)
        {

        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (TxtBuscar != null)
            {
                string cancion = TxtBuscar.Text;
                try
                {
                    string query = "SELECT b.id_cancion,b.nombre_cancion,c.nombre_album,d.nombre_artista FROM  Canciones b ,Album c,Artistas d WHERE b.id_album=c.id_album AND c.id_artista=d.id_artista AND b.nombre_cancion= @Cancion";

                    using (SqlConnection conn = Conexion.DatabaseConnection())
                    using (SqlCommand cmdselect = new SqlCommand(query, conn))
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmdselect))
                    {
                        cmdselect.Parameters.AddWithValue("@Cancion", cancion);
                        conn.Open();
                        DataTable tabla = new DataTable();
                        adp.Fill(tabla);
                        DgvNuevas.DataSource = tabla;
                    }
                }
                catch(Exception )
                {
                    MessageBox.Show("Error al cargar canciones");
                }
            }
            else
                MessageBox.Show("Ingresa el nombre de la canción que deseas buscar.");
        }

        private void DgvNuevas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//verifica que se dio click en una fila valia
            {
                // Obtener el ID de la cancion
                int idCancion = Convert.ToInt32(DgvNuevas.Rows[e.RowIndex].Cells["id_cancion"].Value);
                int idPlaylist = id_lista;

                try
                {
                    if (verificarExiste(idPlaylist, idCancion))
                    {
                        using (SqlConnection connection = Conexion.DatabaseConnection())
                        {

                            string query = "INSERT INTO Lista_canciones(id_lista,id_cancion,fecha_agregado) VALUES (@lista, @cancion,@Fecha)";

                            using (SqlCommand cmd = new SqlCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@lista", id_lista);
                                cmd.Parameters.AddWithValue("@cancion", idCancion);
                                cmd.Parameters.AddWithValue("@Fecha", DateTime.Today.ToString("yyyy-MM-dd"));
                                connection.Open();
                                int result = cmd.ExecuteNonQuery();

                                if (result > 0)
                                {

                                    OnDatoAgregado(EventArgs.Empty);
                                    MessageBox.Show("Canción agregada con éxito ♫");
                                }
                                else
                                {
                                    MessageBox.Show("Hubo problemas para agregar la canción.");
                                }
                            }
                        }
                    }
                    else
                        MessageBox.Show("la cacnión ya éxiste en tu playlist.");
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show($"Error de SQL: {sqlEx.Message}\nNúmero: {sqlEx.Number}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error general: {ex.Message}");
                }
            }
        }

        protected virtual void OnDatoAgregado(EventArgs e)
        {
            DatoAgregado?.Invoke(this, e);
        }
        private bool verificarExiste(int idPlaylist, int idCancion)
        {
            using (SqlConnection connection = Conexion.DatabaseConnection())
            {
                string query = "SELECT COUNT(*) FROM Lista_canciones WHERE id_lista = @idLista AND id_cancion = @idCancion";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@idLista", idPlaylist);
                    cmd.Parameters.AddWithValue("@idCancion", idCancion);
                    connection.Open();

                    int count = (int)cmd.ExecuteScalar(); // Devuelve el número de coincidencias

                    return count == 0; // true si no existe aún
                }
            }
        }
    }
}
