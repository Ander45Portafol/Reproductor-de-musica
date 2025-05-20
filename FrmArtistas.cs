using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{

    public partial class FrmArtistas : Form
    {
        Dictionary<PictureBox, string> urlsAudio = new Dictionary<PictureBox, string>();
        ArbolBinario arbol = new ArbolBinario();
        string connectionString = "Server=DESKTOP-RA97V0D\\MSSQLSERVER01;Database=Harmoniq;Trusted_Connection=True;";

        public FrmArtistas()
        {
            InitializeComponent();
            this.Load += FrmArtistas_Load;
        }

        private void FrmArtistas_Load(object sender, EventArgs e)
        {
            CargarArtistasDesdeBD();

        }

        private void CargarArtistasDesdeBD()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Artistas", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Artista artista = new Artista()
                    {
                        Id = reader["id_artista"] != DBNull.Value ? Convert.ToInt32(reader["id_artista"]) : 0,
                        Nombre = reader["nombre_artista"] != DBNull.Value ? reader["nombre_artista"].ToString() : "",
                        Nacionalidad = reader["nacionalidad"] != DBNull.Value ? reader["nacionalidad"].ToString() : "",
                      //  Reproducciones = reader["reproducciones"] != DBNull.Value ? reader["reproducciones"].ToString() : "",
                        UrlImagen = reader["url_foto_artista"] != DBNull.Value ? reader["url_foto_artista"].ToString() : ""
                    };
                    arbol.Insertar(artista);
                }
            }
        }

        private void CargarCancionesDelArtista(int idArtista)
        {
            urlsAudio.Clear(); // Limpiar datos anteriores
            List<string> urlsImagenes = new List<string>();
            List<string> urlsAudios = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT TOP 6 url_imagen, url_audio FROM Canciones WHERE id_artista = @idArtista", conn);
                cmd.Parameters.AddWithValue("@idArtista", idArtista);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["url_imagen"] != DBNull.Value)
                        urlsImagenes.Add(reader["url_imagen"].ToString());

                    if (reader["url_audio"] != DBNull.Value)
                        urlsAudios.Add(reader["url_audio"].ToString());
                }
            }

            // Asignar imágenes a los PictureBoxes
            PictureBox[] pictureBoxes = { PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6 };

            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                pictureBoxes[i].Click -= PictureBox_Click; // Evitar múltiples asignaciones

                if (i < urlsImagenes.Count && i < urlsAudios.Count)
                {
                    pictureBoxes[i].Load(urlsImagenes[i]);
                    urlsAudio[pictureBoxes[i]] = urlsAudios[i];
                    pictureBoxes[i].Click += PictureBox_Click;
                }
                else
                {
                    pictureBoxes[i].Image = null;
                    urlsAudio[pictureBoxes[i]] = null;
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;

            if (pic != null && urlsAudio.ContainsKey(pic))
            {
                string url = urlsAudio[pic];
                if (!string.IsNullOrEmpty(url))
                {
                    wmpReproductor.URL = url;
                    wmpReproductor.Ctlcontrols.play();
                }
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            Artista artista = arbol.Buscar(nombre);
            if (artista != null)
            {
                pbFotoArtista.Load(artista.UrlImagen); // Mostrar imagen del artista
                CargarCancionesDelArtista(artista.Id); // Cargar canciones populares

                // Mostrar nombre y nacionalidad
                lblNombre.Text = artista.Nombre;
                lblNacionalidad.Text = artista.Nacionalidad;
            }
            else
            {
                MessageBox.Show("Artista no encontrado.");
                pbFotoArtista.Image = null;
                lblNacionalidad.Text = "";
                lblNacionalidad.Text = "";
            }

        }

        
    }
}
