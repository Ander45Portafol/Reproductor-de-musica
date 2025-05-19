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
    public partial class FrmArtistas : Form
    {
        public FrmArtistas()
        {
            InitializeComponent();
            this.Load += FrmArtistas_Load;
            this.Resize += FrmArtistas_Resize;
        }

        private void FrmArtistas_Load(object sender, EventArgs e)
        {

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

        private void FrmArtistas_Resize(object sender, EventArgs e)
        {

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

        }

        private void label6_Click(object sender, EventArgs e)
        {
            FrmRadio fomr = new FrmRadio();
            fomr.Show();
            this.Hide();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }
    }
}
