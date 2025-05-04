using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor_de_Musica
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            FrmInicio frm = new FrmInicio();
            CargarFormularioEnPanel(frm);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CargarFormularioEnPanel(Form formulario)
        {
            // Limpiar el panel antes de cargar un nuevo formulario
            PanelContenido.Controls.Clear();

            // Establecer la propiedad TopLevel a false
            formulario.TopLevel = false;

            // Establecer la propiedad FormBorderStyle a None si no quieres bordes
            formulario.FormBorderStyle = FormBorderStyle.None;

            // Agregar el formulario al panel
            PanelContenido.Controls.Add(formulario);

            // Establecer el tamaño del formulario al tamaño del panel
            formulario.Dock = DockStyle.Fill;

            // Mostrar el formulario
            formulario.Show();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            FrmInicio frmInicio = new FrmInicio();
            CargarFormularioEnPanel(frmInicio);
        }

        private void BtnArtista_Click(object sender, EventArgs e)
        {
            FrmArtistas frmArtista = new FrmArtistas();
            CargarFormularioEnPanel(frmArtista);
        }
    }
}
