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
        private int usuario;

        public FrmDashboard(int id_usuario)
        {
            InitializeComponent();
            FrmInicio frm = new FrmInicio();
            CargarFormularioEnPanel(frm);
            usuario = id_usuario;
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

        }

        private void BtnArtista_Click(object sender, EventArgs e)
        {
            FrmArtistas frmArtista = new FrmArtistas();
            CargarFormularioEnPanel(frmArtista);
        }

        private void BtnListas_Click(object sender, EventArgs e)
        {
            FrmPlaylist frmpla = new FrmPlaylist(usuario);
            CargarFormularioEnPanel(frmpla);
        }

        private void BtnCSesion_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Hide();
            frmLogin.Show();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnCanciones_Click(object sender, EventArgs e)
        {
            FrmCanciones formCancion= new FrmCanciones();
            CargarFormularioEnPanel(formCancion);

        }

        private void BtnAlbum_Click(object sender, EventArgs e)
        {
            FormAlbum formAlbum = new FormAlbum();
            CargarFormularioEnPanel(formAlbum);
        }
    }
}
