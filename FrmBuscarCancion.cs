using System;
using System.Collections;
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
    public partial class FrmBuscarCancion: Form
    {
        private int id_lista;
        public FrmBuscarCancion(int lista)
        {
            InitializeComponent();
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

                using (SqlConnection conn = Conexion.DatabaseConnection())
                {
                    try
                    {
                        conn.Open();

                        string insertQuery = "INSERT INTO PlaylistCanciones (id_playlist, id_cancion) VALUES (" + idPlaylist + "," + idCancion + ")";
                        SqlCommand cmd = new SqlCommand(insertQuery, conn);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Canción agregada a la playlist correctamente 🎵");
                    }
                    catch
                    {
                        MessageBox.Show("Error al agregar la canción");
                    }
                }
            }
        }
    }
}
