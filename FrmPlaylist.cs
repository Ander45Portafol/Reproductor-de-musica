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
using Servicios;

namespace Reproductor_de_Musica
{
    public partial class FrmPlaylist : Form
    {
        private int id_user;
        public FrmPlaylist(int usuario)
        {
            InitializeComponent();
            this.Load += FrmPlaylist_Load;
            this.Resize += FrmPlaylist_Resize;
            CargarListas(usuario);
            id_user = usuario;
        }

        private void FrmPlaylist_Load(object sender, EventArgs e)
        {
           
            // Aplica bordes redondos al formulario
            RoundedForm.ApplyRoundCorners(this, 30);

            // Aplica bordes redondos al panel del menú (pnlMenu)
            //RoundedForm.ApplyRoundCorners(pnlmenu, 20);

            //pnlmenu.BackColor = Color.FromArgb(51, 51, 153); // Nuevo color (51, 51, 153)
            //pnlmenu.Padding = new Padding(10); // Margen interno

            // Aplicar bordes redondos al Panel que contiene el TextBox (pnlTextBoxContainer)
            //RoundedForm.ApplyRoundCorners(pnlTextBoxContainer, 15); // Radio de 15 píxeles

            // Configurar el Panel que contiene el TextBox
           // pnlmenu.BackColor = Color.FromArgb(51, 51, 153); // Color de fondo del Panel
            //pnlTextBoxContainer.Padding = new Padding(5); // Margen interno

            // Configurar el TextBox dentro del Panel
           // txtbuscar.BorderStyle = BorderStyle.None; // Sin borde predeterminado
           // txtbuscar.Dock = DockStyle.Fill; // Ocupar todo el espacio del Panel
          //  txtbuscar.BackColor = Color.White; // Color de fondo del TextBox
            //txtbuscar.ForeColor = Color.Black; // Color del texto

            // Aplicar bordes redondos al DataGridView
            //ApplyRoundedCornersToDataGridView(dataGridView1, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox15, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox16, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox17, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox18, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox19, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox20, 15); // Radio de 15 píxeles
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
        
        private void FrmPlaylist_Resize(object sender, EventArgs e)
        {
            // Re-aplica bordes redondos al redimensionar el formulario
            RoundedForm.ApplyRoundCorners(this, 30);

            // Re-aplica bordes redondos al panel del menú
            //RoundedForm.ApplyRoundCorners(pnlmenu, 20);

            // Re-aplicar bordes redondos al Panel que contiene el TextBox
            //RoundedForm.ApplyRoundCorners(pnlTextBoxContainer, 15);

            // Re-aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox15, 15);

            // Re-aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox16, 15);

            // Re-aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox17, 15);

            // Re-aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox18, 15);

            // Re-aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox19, 15);

            // Re-aplicar bordes redondos al PictureBox
            //ApplyRoundedCorners(pictureBox20, 15);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CargarListas(int id)
        {
            using (SqlConnection conn = Conexion.DatabaseConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT a.nombre_lista,a.fecha_creacion,b.nombre_usuario FROM Lista a, Usuario b WHERE a.id_usuario=b.id_usuario AND a.id_usuario= "+id;

                    SqlDataAdapter adaptador = new SqlDataAdapter(query, conn);

                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    DgvPlaylist.DataSource = tabla;
                    DgvPlaylist.Columns["nombre_lista"].HeaderText = "Playlist";
                    DgvPlaylist.Columns["nombre_usuario"].HeaderText = "Usuario";
                    DgvPlaylist.Columns["fecha_creacion"].HeaderText = "Fecha creada";

                }
                catch
                {
                    MessageBox.Show("Error al cargar canciones");
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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
        private void FormAgregar_DatoAgregado(object sender, EventArgs e)
        {
            // Aquí es donde actualizas tu FormPrincipal
            CargarListas(id_user); // Vuelve a cargar los datos en tu DataGridView o ListBox
        }
        private void button4_Click(object sender, EventArgs e)
        {
            FrmCrearPlaylist frmCrearPlaylist = new FrmCrearPlaylist(id_user);
            frmCrearPlaylist.DatoAgregado += FormAgregar_DatoAgregado;
            frmCrearPlaylist.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void DgvPlaylist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el doble clic no sea en el encabezado de las columnas o filas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obtener la fila en la que se hizo doble clic
                DataGridViewRow filaSeleccionada = DgvPlaylist.Rows[e.RowIndex];

                // Suponiendo que el dato que quieres está en la columna con índice '0'
                // Puedes cambiar el índice por el número de la columna que necesites.
                string dato = filaSeleccionada.Cells[0].Value?.ToString();
                //Abrimos el formulario pero usando el nuevo constructor para especificar que
                //se actualizaran los datos
                FrmPlaylistBuscar frmBuscarPlaylist= new FrmPlaylistBuscar(dato);
                CargarFormularioEnPanel(frmBuscarPlaylist);
            }
        }
    }
    
} 


