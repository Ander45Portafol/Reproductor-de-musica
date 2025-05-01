using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            this.Load += FrmInicio_Load;
            this.Resize += FrmInicio_Resize;

        }
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            // Aplica bordes redondos al formulario
            RoundedForm.ApplyRoundCorners(this, 30);

            // Aplica bordes redondos al panel del menú (pnlMenu)
            RoundedForm.ApplyRoundCorners(pnlmenu, 20);

            pnlmenu.BackColor = Color.FromArgb(51, 51, 153); // Nuevo color (51, 51, 153)
            pnlmenu.Padding = new Padding(10); // Margen interno

            // Aplicar bordes redondos al Panel que contiene el TextBox (pnlTextBoxContainer)
            RoundedForm.ApplyRoundCorners(pnlbuscador, 15); // Radio de 15 píxeles

            // Configurar el Panel que contiene el TextBox
            // pnlmenu.BackColor = Color.FromArgb(51, 51, 153); // Color de fondo del Panel
            pnlbuscador.Padding = new Padding(5); // Margen interno

            // Configurar el TextBox dentro del Panel
            txtbuscar.BorderStyle = BorderStyle.None; // Sin borde predeterminado
            txtbuscar.Dock = DockStyle.Fill; // Ocupar todo el espacio del Panel
                                             //  txtbuscar.BackColor = Color.White; // Color de fondo del TextBox
            txtbuscar.ForeColor = Color.Black; // Color del texto

            // Aplicar bordes redondos al DataGridView
            ApplyRoundedCornersToDataGridView(dgvnovedades, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct1, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct6, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct5, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct4, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct3, 15); // Radio de 15 píxeles

            // Aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct2, 15); // Radio de 15 píxeles
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

        private void FrmInicio_Resize(object sender, EventArgs e)
        {
            // Re-aplica bordes redondos al redimensionar el formulario
            RoundedForm.ApplyRoundCorners(this, 30);

            // Re-aplica bordes redondos al panel del menú
            RoundedForm.ApplyRoundCorners(pnlmenu, 20);

            // Re-aplicar bordes redondos al Panel que contiene el TextBox
            RoundedForm.ApplyRoundCorners(pnlbuscador, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct1, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct6, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct5, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct4, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct3, 15);

            // Re-aplicar bordes redondos al PictureBox
            ApplyRoundedCorners(pct2, 15);
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

