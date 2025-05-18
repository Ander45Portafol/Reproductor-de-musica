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
    public partial class FrmPlaylistBuscar: Form
    {
        public FrmPlaylistBuscar()
        {
            InitializeComponent();
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

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmPlaylist frmPlaylist = new FrmPlaylist();
            CargarFormularioEnPanel(frmPlaylist);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmBuscarCancion frmBuscarCancion = new FrmBuscarCancion();
            frmBuscarCancion.ShowDialog();
        }
    }
}
