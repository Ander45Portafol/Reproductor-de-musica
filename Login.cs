using System;
using Servicios;
using System.Data.SqlClient;
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
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RoundedForm.ApplyRoundCorners(this, 20);
            RoundedForm.ApplyRoundCorners(pnllogin, 20);
        }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string correo = txtcorreo.Text.Trim();
            string contraseña = txtcontraseña.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor ingrese sus credenciales");
                return;
            }

            if (Autenticacion.Autenticar(correo, contraseña))
            {
               
                MessageBox.Show("¡Bienvenido a Harmoniq!");

                FrmDashboard fmrinicio = new FrmDashboard();
                fmrinicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Intente nuevamente.");
                txtcontraseña.Clear();
                txtcontraseña.Focus();
            }
        }
     

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void LinkSuscrip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSuscripcion fomr = new FrmSuscripcion();
            fomr.Show();
            this.Hide();
        }


        private void btnIniciar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnIniciar_Click(sender, e);
            }
        }
    }
}
