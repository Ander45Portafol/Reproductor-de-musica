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
    public partial class FrmArtistas : Form
    {
        public FrmArtistas()
        {
            InitializeComponent();
            this.Load += FrmArtistas_Load;
        }

        private void FrmArtistas_Load(object sender, EventArgs e)
        {
            int idArtista = 1; // cambia esto si es necesario

            CargarImagenArtista(idArtista);
            CargarCancionesPopulares(idArtista); // << añade esta líne

        }

        private void CargarImagenArtista(int idArtista)
        {
            string cadenaConexion = "Server=DESKTOP-RA97V0D\\MSSQLSERVER01;Database=Harmoniq;Integrated Security=True";
            string query = "SELECT url_foto_artista FROM Artistas WHERE id_artista = @id";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@id", idArtista);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.Read() && !lector.IsDBNull(0))
                    {
                        string url = lector.GetString(0);
                        pbFotoArtista.Load(url);
                    }
                    else
                    {
                        pbFotoArtista.Image = null;
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }

        private void CargarCancionesPopulares(int idArtista)
        {
            string cadenaConexion = "Server=DESKTOP-RA97V0D\\MSSQLSERVER01;Database=Harmoniq;Integrated Security=True";
            string query = @"
            SELECT TOP 6 url_imagen 
            FROM Canciones 
            WHERE id_artista = @id 
            ORDER BY reproducciones DESC";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.AddWithValue("@id", idArtista);

                try
                {
                    conexion.Open();
                    SqlDataReader lector = comando.ExecuteReader();

                    // Lista de tus PictureBoxes
                    PictureBox[] pictureBoxes = new PictureBox[] {
                    pictureBox1, pictureBox2, pictureBox3,
                    pictureBox4, pictureBox5, pictureBox6
            };

                    int index = 0;

                    while (lector.Read() && index < pictureBoxes.Length)
                    {
                        if (!lector.IsDBNull(0))
                        {
                            string urlImagen = lector.GetString(0);
                            pictureBoxes[index].Load(urlImagen);
                        }
                        else
                        {
                            pictureBoxes[index].Image = null;
                        }

                        index++;
                    }

                    lector.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar canciones populares: " + ex.Message);
                }
            }
        }




        private void ApplyRoundedCorners(Control control, int cornerRadius)
        {
            // Crear un camino gráfico con bordes redondos
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(control.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Esquina superior derecha
            path.AddArc(control.Width - cornerRadius, control.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, control.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asignar la región al control
            control.Region = new Region(path);
        }

        private void ApplyRoundedCornersToDataGridView(DataGridView dgv, int cornerRadius)
        {
            // Crear un camino gráfico con bordes redondos
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90); // Esquina superior izquierda
            path.AddArc(dgv.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90); // Esquina superior derecha
            path.AddArc(dgv.Width - cornerRadius, dgv.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, dgv.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Asignar la región al DataGridView
            dgv.Region = new Region(path);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmArtistas fomr = new FrmArtistas();
            fomr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmCanciones fomr = new FrmCanciones();
            fomr.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmPlaylist fomr = new FrmPlaylist();
            fomr.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmRadio fomr = new FrmRadio();
            fomr.Show();
            this.Hide();
        }

    }
    
}
