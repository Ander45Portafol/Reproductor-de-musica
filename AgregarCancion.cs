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
using System.Collections;

namespace Reproductor_de_Musica
{
    public partial class AgregarCancion : Form
    {
        int id_lista;
        public AgregarCancion(int id_lista)
        {
            InitializeComponent();
            this.id_lista = id_lista;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//verifica que se dio click en una fila valia
            {
                // Obtener el ID de la cancion
                int idCancion = Convert.ToInt32(dgvcanciones.Rows[e.RowIndex].Cells["id_cancion"].Value);
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtbuscar != null)
            {
                string cancion = txtbuscar.Text;

                using (SqlConnection conn = Conexion.DatabaseConnection())
                {
                    try
                    {
                        conn.Open();
                        string query = "Select * from Canciones where nombre_cancion = " + cancion;
                        SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                    }
                    catch
                    {
                        MessageBox.Show("Error al cargar canciones");
                    }
                }
            }
            else
                MessageBox.Show("Ingresa el nombre de la canción que deseas buscar.");
        }
    }
}
