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
    public partial class FrmCanciones : Form
    {
        public FrmCanciones()
        {
            InitializeComponent();
            this.Load += FrmCanciones_Load;
            this.Resize += FrmCanciones_Resize;
        }

        private void FrmCanciones_Load(object sender, EventArgs e)
        {
            CargarCancionesEnLabels();
            txtbuscar.Select();

            // Aplica bordes redondos al formulario
            RoundedForm.ApplyRoundCorners(this, 30);

            // Aplica bordes redondos al panel del menú (pnlMenu)
            //RoundedForm.ApplyRoundCorners(pnlmenu, 20);

            //pnlmenu.BackColor = Color.FromArgb(51, 51, 153); // Nuevo color (51, 51, 153)
            //pnlmenu.Padding = new Padding(10); // Margen interno

            // Aplicar bordes redondos al Panel que contiene el TextBox (pnlTextBoxContainer)
            RoundedForm.ApplyRoundCorners(pnlTextBoxContainer, 15); // Radio de 15 píxeles

            // Configurar el Panel que contiene el TextBox
            // pnlmenu.BackColor = Color.FromArgb(51, 51, 153); // Color de fondo del Panel
            pnlTextBoxContainer.Padding = new Padding(5); // Margen interno

            // Configurar el TextBox dentro del Panel
            txtbuscar.BorderStyle = BorderStyle.None; // Sin borde predeterminado
            txtbuscar.Dock = DockStyle.Fill; // Ocupar todo el espacio del Panel
                                             //  txtbuscar.BackColor = Color.White; // Color de fondo del TextBox
            txtbuscar.ForeColor = Color.Black; // Color del texto

            // Aplicar bordes redondos al DataGridView1
            ApplyRoundedCornersToDataGridView(dataGridView1, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al DataGridView2
            //ApplyRoundedCornersToDataGridView(dataGridView2, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox15, 15); // Radio de 15 píxeles

            ApplyRoundedCorners(lstSugerenciasCanciones, 15);
            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox16, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox17, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox18, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox19, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox20, 15); // Radio de 15 píxeles
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

        private void FrmCanciones_Resize(object sender, EventArgs e)
        {
            // Re-aplica bordes redondos al redimensionar el formulario
            RoundedForm.ApplyRoundCorners(this, 30);

            // Re-aplica bordes redondos al panel del menú
            //RoundedForm.ApplyRoundCorners(pnlmenu, 20);

            // Re-aplicar bordes redondos al Panel que contiene el TextBox
            RoundedForm.ApplyRoundCorners(pnlTextBoxContainer, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox15, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox16, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox17, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox18, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox19, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pictureBox20, 15);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmInicio fomr = new FrmInicio();
            fomr.Show();
            this.Hide();
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
        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmRadio fomr = new FrmRadio();
            fomr.Show();
            this.Hide();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtbuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(textoBusqueda))
            {
                lstSugerenciasCanciones.Visible = false;
                lstSugerenciasCanciones.DataSource = null; 
                return;
            }

            
            if (textoBusqueda.Equals("Buscar...", StringComparison.OrdinalIgnoreCase))
            {
                 lstSugerenciasCanciones.Visible = false;
                 return;
            }

            BuscarCanciones(textoBusqueda);
        }

        private void BuscarCanciones(string textoBusqueda)
        {
            List<string> nombresCanciones = new List<string>();

            
            string query = "SELECT nombre_cancion FROM Canciones WHERE nombre_cancion LIKE @TextoBusqueda + '%' ORDER BY nombre_cancion;";

            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        
                        command.Parameters.AddWithValue("@TextoBusqueda", textoBusqueda);

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                nombresCanciones.Add(reader["nombre_cancion"].ToString());
                            }
                        }
                    }
                }

                if (nombresCanciones.Count > 0)
                {
                    lstSugerenciasCanciones.DataSource = nombresCanciones;
                    lstSugerenciasCanciones.Visible = true;
                    lstSugerenciasCanciones.BringToFront(); 
                }
                else
                {
                    lstSugerenciasCanciones.Visible = false;
                    lstSugerenciasCanciones.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar canciones: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstSugerenciasCanciones.Visible = false;
            }
        }

        private void lstSugerenciasCanciones_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstSugerenciasCanciones.SelectedItem != null)
            {
                txtbuscar.Text = lstSugerenciasCanciones.SelectedItem.ToString();
                lstSugerenciasCanciones.Visible = false;
                txtbuscar.Focus(); 
                txtbuscar.Select(txtbuscar.TextLength, 0); 
            }
        }

        private void txtbuscar_Leave(object sender, EventArgs e)
        {
            if (!lstSugerenciasCanciones.Focused)
            {
                lstSugerenciasCanciones.Visible = false; 
            }
        }

        private void txtbuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstSugerenciasCanciones.Visible && lstSugerenciasCanciones.Items.Count > 0)
                {
                    
                    if (lstSugerenciasCanciones.SelectedIndex == -1) // Si no hay nada seleccionado por teclado (arriba/abajo)
                    {
                        lstSugerenciasCanciones.SelectedIndex = 0; // Selecciona la primera
                    }
                    txtbuscar.Text = lstSugerenciasCanciones.SelectedItem.ToString();
                    lstSugerenciasCanciones.Visible = false;
                    txtbuscar.Select(txtbuscar.TextLength, 0); // Pone el cursor al final
                    e.SuppressKeyPress = true; // Evita otras acciones del enter
                }
            }
            else if (e.KeyCode == Keys.Down && lstSugerenciasCanciones.Visible && lstSugerenciasCanciones.Items.Count > 0)
            {
                // Mover selección hacia abajo en el ListBox
                lstSugerenciasCanciones.Focus();
                if (lstSugerenciasCanciones.SelectedIndex < lstSugerenciasCanciones.Items.Count - 1)
                {
                    lstSugerenciasCanciones.SelectedIndex++;
                }
                e.Handled = true; // Indica que la tecla fue manejada
            }
            else if (e.KeyCode == Keys.Up && lstSugerenciasCanciones.Visible && lstSugerenciasCanciones.Items.Count > 0)
            {
                // Mover selección hacia arriba en el ListBox
                lstSugerenciasCanciones.Focus();
                if (lstSugerenciasCanciones.SelectedIndex > 0)
                {
                    lstSugerenciasCanciones.SelectedIndex--;
                }
                e.Handled = true; // Indica que la tecla fue manejada
            }
            else if (e.KeyCode == Keys.Escape)
            {
                lstSugerenciasCanciones.Visible = false;
                e.Handled = true;
            }
        }

        private void lstSugerenciasCanciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (lstSugerenciasCanciones.SelectedItem != null)
                {
                    // Poner el texto del ítem seleccionado en el TextBox
                    txtbuscar.Text = lstSugerenciasCanciones.SelectedItem.ToString();
                    // Ocultar la lista de sugerencias
                    lstSugerenciasCanciones.Visible = false;
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
                lstSugerenciasCanciones.Visible = false;
                txtbuscar.Focus(); // Devolver el foco al TextBox
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            string nombreCancionABuscar = txtbuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreCancionABuscar))
            {
                MessageBox.Show("Por favor, ingrese o seleccione un nombre de canción para buscar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarLabelsDeDetalles();
                return;
            }

            CargarDetallesCancion(nombreCancionABuscar);
        }
        private void CargarDetallesCancion(string nombreCancion)
        {
            string query = @"
        SELECT 
            c.nombre_cancion, 
            c.tiempo_cancion,
            alb.nombre_album,
            art.nombre_artista,
            art.nacionalidad,
            art.id_artista
        FROM 
            Canciones c
        INNER JOIN 
            Album alb ON c.id_album = alb.id_album
        INNER JOIN 
            Artistas art ON alb.id_artista = art.id_artista
        WHERE 
            c.nombre_cancion = @NombreCancionParam;";

            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreCancionParam", nombreCancion);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Si se encontró la canción
                            {
                                // Asigna los valores a tus Labels
                                
                                lblCancionNombre.Text = reader["nombre_cancion"].ToString();
                                lblNomArt.Text = reader["nombre_artista"].ToString();
                                lblAlbum.Text = reader["nombre_album"].ToString();
                                lblNacionalildad.Text = reader["nacionalidad"].ToString();
                                lblTime.Text = reader["tiempo_cancion"].ToString();
                                lblTopArt.Text = reader["id_artista"].ToString();
                                
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron detalles para la canción: " + nombreCancion, "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LimpiarLabelsDeDetalles();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles de la canción: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarLabelsDeDetalles();
            }
        }

        private void LimpiarLabelsDeDetalles()
        {
           
            lblCancionNombre.Text = "------------"; 
            lblNomArt.Text = "------------";
            lblAlbum.Text = "------------";
            lblNacionalildad.Text = "------------";
            lblTime.Text = "------------";
        }

        private List<string> ObtenerSeisCancionesAleatorias()
        {
            List<string> nombresCanciones = new List<string>();
            

            string query = @"
            SELECT TOP 6 nombre_cancion 
            FROM Canciones 
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
                                nombresCanciones.Add(reader["nombre_cancion"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener canciones aleatorias: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return nombresCanciones;
        }

        private void CargarCancionesEnLabels()
        {
            List<string> cancionesAleatorias = ObtenerSeisCancionesAleatorias();

            Label[] labelsCanciones = new Label[]
            {
                lblTrend1, lblTrend2, lblTrend3,
                lblTrend4, lblTrend5, lblTrend6
            };

            
            foreach (Label lbl in labelsCanciones)
            {
                lbl.Text = "------------"; 
            }

            for (int i = 0; i < cancionesAleatorias.Count && i < labelsCanciones.Length; i++)
            {
                labelsCanciones[i].Text = cancionesAleatorias[i];
            }
        }

        private void lstSugerenciasCanciones_Click(object sender, EventArgs e)
        {

        }
    }
}
