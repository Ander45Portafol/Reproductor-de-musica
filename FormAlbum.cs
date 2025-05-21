using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
            RoundedForm.ApplyRoundCorners(this, 30);
        }

        private void FormAlbum_Load(object sender, EventArgs e)
        {
            CargarLabelsEnAlbums();
            RoundedForm.ApplyRoundCorners(this, 30);
            txtbuscar.Select();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string albumNombre=txtbuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(albumNombre))
            {
                lstSugerenciasAlbums.Visible = false;
                lstSugerenciasAlbums.DataSource = null;
                return;
            }

            if (albumNombre.Equals("Buscar...", StringComparison.OrdinalIgnoreCase))
            {
                lstSugerenciasAlbums.Visible = false;
                return;
            }

            BuscarAlbum(albumNombre);
        }

        public void BuscarAlbum(string albumNombre)
        {
            List<string> nombresAlbums = new List<string>();


            string query = "SELECT nombre_album FROM Album WHERE nombre_album LIKE @TextoBusqueda + '%' ORDER BY nombre_album;";

            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@TextoBusqueda", albumNombre);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nombresAlbums.Add(reader["nombre_album"].ToString());
                            }
                        }
                    }
                }

                if (nombresAlbums.Count > 0)
                {
                    lstSugerenciasAlbums.DataSource = nombresAlbums;
                    lstSugerenciasAlbums.Visible = true;
                    lstSugerenciasAlbums.BringToFront();
                }
                else
                {
                    lstSugerenciasAlbums.Visible = false;
                    lstSugerenciasAlbums.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar albums: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstSugerenciasAlbums.Visible = false;
            }
        }

        private void lstSugerenciasAlbums_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstSugerenciasAlbums.SelectedItem != null)
            {
                txtbuscar.Text = lstSugerenciasAlbums.SelectedItem.ToString();
                lblAlbumNombre.Text= lstSugerenciasAlbums.SelectedItem.ToString();  
                lstSugerenciasAlbums.Visible = false;
                txtbuscar.Focus();
                txtbuscar.Select(txtbuscar.TextLength, 0);
            }
        }

        private void txtbuscar_Leave(object sender, EventArgs e)
        {
            if (!lstSugerenciasAlbums.Focused)
            {
                lstSugerenciasAlbums.Visible = false;
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstSugerenciasAlbums.Visible && lstSugerenciasAlbums.Items.Count > 0)
                {

                    if (lstSugerenciasAlbums.SelectedIndex == -1) // Si no hay nada seleccionado por teclado (arriba/abajo)
                    {
                        lstSugerenciasAlbums.SelectedIndex = 0; // Selecciona la primera
                    }
                    lblAlbumNombre.Text = lstSugerenciasAlbums.SelectedItem.ToString();
                    txtbuscar.Text = lstSugerenciasAlbums.SelectedItem.ToString();
                    lstSugerenciasAlbums.Visible = false;
                    txtbuscar.Select(txtbuscar.TextLength, 0); // Pone el cursor al final
                    e.SuppressKeyPress = true; // Evita otras acciones del enter
                }
            }
            else if (e.KeyCode == Keys.Down && lstSugerenciasAlbums.Visible && lstSugerenciasAlbums.Items.Count > 0)
            {
                // Mover selección hacia abajo en el ListBox
                lstSugerenciasAlbums.Focus();
                if (lstSugerenciasAlbums.SelectedIndex < lstSugerenciasAlbums.Items.Count - 1)
                {
                    lstSugerenciasAlbums.SelectedIndex++;
                }
                e.Handled = true; // Indica que la tecla fue manejada
            }
            else if (e.KeyCode == Keys.Up && lstSugerenciasAlbums.Visible && lstSugerenciasAlbums.Items.Count > 0)
            {
                // Mover selección hacia arriba en el ListBox
                lstSugerenciasAlbums.Focus();
                if (lstSugerenciasAlbums.SelectedIndex > 0)
                {
                    lstSugerenciasAlbums.SelectedIndex--;
                }
                e.Handled = true; // Indica que la tecla fue manejada
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstSugerenciasAlbums.Visible = false;
                e.Handled = true;
            }
        }

        private void lstSugerenciasAlbums_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstSugerenciasAlbums.SelectedItem != null)
                {
                    lblAlbumNombre.Text = lstSugerenciasAlbums.SelectedItem.ToString();
                    // Poner el texto del ítem seleccionado en el TextBox
                    txtbuscar.Text = lstSugerenciasAlbums.SelectedItem.ToString();
                    // Ocultar la lista de sugerencias
                    lstSugerenciasAlbums.Visible = false;
                    // Devolver el foco al TextBox (muy importante)
                    txtbuscar.Focus();
                    // Colocar el cursor al final del texto en el TextBox
                    txtbuscar.Select(txtbuscar.TextLength, 0);

                    // Indicar que la tecla fue manejada para evitar procesamiento adicional
                    e.Handled = true;
                    e.SuppressKeyPress = true; // Suprime el sonido "ding" y el evento KeyPress
                }
            }
            else if (e.KeyCode == Keys.Escape) // Opcional: Manejar Escape también desde el ListBox
            {
                lstSugerenciasAlbums.Visible = false;
                txtbuscar.Focus(); // Devolver el foco al TextBox
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private List<string> ObtenerSeisAlbumsAleatorios()
        {
            List<string> nombresAlbums = new List<string>();


            string query = @"
            SELECT TOP 6 nombre_album
            FROM Album 
            ORDER BY NEWID();";

            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nombresAlbums.Add(reader["nombre_album"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener albums aleatorios: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombresAlbums;
        }
        private void CargarLabelsEnAlbums()
        {
            List<string> albumnesAleatorios = ObtenerSeisAlbumsAleatorios();

            Label[] labelsAlbum = new Label[]
            {
                lblTrend1, lblTrend2, lblTrend3,
                lblTrend4, lblTrend5, lblTrend6
            };


            foreach (Label lbl in labelsAlbum)
            {
                lbl.Text = "------------";
            }

            for (int i = 0; i < albumnesAleatorios.Count && i < labelsAlbum.Length; i++)
            {
                labelsAlbum[i].Text = albumnesAleatorios[i];
            }
        }


        private void btnlupa_Click(object sender, EventArgs e)
        {
            string AlbumNom=txtbuscar.Text;
            string query = @"SELECT
                            c.nombre_cancion,
                            c.genero_musical,
                            c.anio_lanzamiento
                            FROM
                            Album a
                            INNER JOIN
                            Canciones c on a.id_album=c.id_album
                            INNER JOIN
                            Artistas art on a.id_artista=art.id_artista
                            WHERE
                            a.nombre_album=@nomAlbumParametro
                 ";

            string query2 = @"SELECT 
             art.nombre_artista,
             alb.cant_canciones
             FROM 
             Album alb
             INNER JOIN 
             Artistas art ON art.id_artista = alb.id_artista
             WHERE 
             alb.nombre_album = @NombreAlbumParametro;";

            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                        {
                          adapter.SelectCommand.Parameters.AddWithValue("@nomAlbumParametro", AlbumNom);
                            using (DataTable tabla = new DataTable())
                            {
                                adapter.Fill(tabla);
                                dataGridViewAlbum.DataSource = tabla;
                             dataGridViewAlbum.Columns["nombre_cancion"].HeaderText = "Titulo Cancion";
                             dataGridViewAlbum.Columns["genero_musical"].HeaderText = "Genero";
                             dataGridViewAlbum.Columns["anio_lanzamiento"].HeaderText = "Fecha Lanzamiento";
                            }
                        }
                    using (SqlCommand command = new SqlCommand(query2, connection))
                    {
                        command.Parameters.AddWithValue("@NombreAlbumParametro", AlbumNom);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si se encontró el album
                            {
                                // Asigna los valores a tus Labels
                                lblCantante.Text = reader["nombre_artista"].ToString();
                                lblNumCanciones.Text = reader["cant_canciones"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron detalles para el album: " + AlbumNom, "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarLabelsDeDetalles();
                            }



                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener album: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarLabelsDeDetalles()
        {

            lblCantante.Text = "------";
            lblNumCanciones.Text = "------";
        }
    }
       
}
