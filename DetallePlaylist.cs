using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Servicios;

namespace Reproductor_de_Musica
{
    public partial class DetallePlaylist : Form
    {
        int id_playlist;
        public DetallePlaylist(int id_playlist)
        {
            InitializeComponent();
            this.id_playlist = id_playlist;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Tag = id_playlist;
            int ID_Playlist = (int)btnAgregar.Tag;
            AgregarCancion frmAgregar = new AgregarCancion(ID_Playlist);
            frmAgregar.ShowDialog();
        }

        private void DetallePlaylist_Load(object sender, EventArgs e)
        {
            CargarCanciones();
        }
        private void CargarCanciones()
        {
            using(SqlConnection conn = Conexion.DatabaseConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Titulo, Duracion, Genero FROM Canciones WHERE id_playlist = " + id_playlist;

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgvCancionesPlaylist.DataSource = tabla;
                }
                catch
                {
                    MessageBox.Show("Error al cargar canciones");
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPlaylist frmplaylist = new FrmPlaylist();
            frmplaylist.ShowDialog();
            this.Visible = false;
        }
    }
}
