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
    public partial class FrmPlaylistBuscar: Form
    {
        public FrmPlaylistBuscar(string nombre_playlist)
        {
            InitializeComponent();
            LblNombre.Text = nombre_playlist;
            CargarLista(nombre_playlist);
        }

        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            this.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            this.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }

        private void CargarLista(string playlist)
        {
            try
            {
                using (SqlConnection conn = Conexion.DatabaseConnection())
                {
                    conn.Open();
                    string query = "SELECT id_lista FROM Lista WHERE nombre_lista=@Playlist";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Playlist", playlist);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            CargarCanciones( Convert.ToInt32(result));
                        }
                        else {
                            MessageBox.Show($"No se encontró la lista: {playlist}");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar ancion");
            }
        }
        private void CargarCanciones(int id)
        {
            using (SqlConnection conn = Conexion.DatabaseConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT b.nombre_cancion, a.fecha_agregado,c.nombre_album,d.nombre_artista FROM Lista_Canciones a, Canciones b ,Album c,Artistas d WHERE a.id_cancion=b.id_cancion AND b.id_album=c.id_album AND c.id_artista=d.id_artista AND id_lista=" + id;

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    DgvCanciones.DataSource = tabla;
                    DgvCanciones.Columns["nombre_cancion"].HeaderText = "Canción";
                    DgvCanciones.Columns["fecha_agregado"].HeaderText = "Agregada";
                    DgvCanciones.Columns["nombre_album"].HeaderText = "Albúm";
                    DgvCanciones.Columns["nombre_artista"].HeaderText = "Artista";

                }
                catch
                {
                    MessageBox.Show("Error al cargar canciones");
                }
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            //FrmPlaylist frmPlaylist = new FrmPlaylist();
            //CargarFormularioEnPanel(frmPlaylist);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmBuscarCancion frmBuscarCancion = new FrmBuscarCancion();
            frmBuscarCancion.ShowDialog();
        }
    }
}
