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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Load += Login_Load;
            this.Resize += Login_Resize;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RoundedForm.ApplyRoundCorners(this, 20);
            RoundedForm.ApplyRoundCorners(pnllogin, 20);
        }

        private void Login_Resize(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios.Conexion.DatabaseConnection();
                MessageBox.Show("Si se realizo la conexion");
            }
            catch (Exception ex) {
                MessageBox.Show("No se pudo hacer la conexion");
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void LinkSuscrip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSuscripcion fomr = new FrmSuscripcion();
            fomr.Show();
            this.Hide();
        }
    }
}
