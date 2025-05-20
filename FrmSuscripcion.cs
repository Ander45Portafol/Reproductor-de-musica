using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;

namespace Reproductor_de_Musica
{
    public partial class FrmSuscripcion : Form
    {
        public FrmSuscripcion()
        {
            InitializeComponent();
            this.Load += FrmSuscripcion_Load;

        }

        private void FrmSuscripcion_Load(object sender, EventArgs e)
        {
            RoundedForm.ApplyRoundCorners(this, 20);
            RoundedForm.ApplyRoundCorners(pnlsuscrip, 20);
        }


        private bool CrearUsuarios()
        {
            DateTime valor = DtNacimiento.Value;
            int edad = DateTime.Today.Year - valor.Year;
            try
            {
                using (SqlConnection connection = Conexion.DatabaseConnection())
                {
                    string query = "INSERT INTO Usuario(nombre_usuario,clave_usuario, correo_electronico, edad_usuario)VALUES (@Usuario,@Clave,@Correo,@Edad)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", TxtNombre.Text);
                        cmd.Parameters.AddWithValue("@Clave", TxtClave.Text);
                        cmd.Parameters.AddWithValue("@Correo", TxtCorreo.Text);
                        MessageBox.Show(edad.ToString());
                        cmd.Parameters.AddWithValue("@Edad",edad);
                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Usuario creado correctamente");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Hubo problemas para crear el usuario");
                            return false;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Error de SQL: {sqlEx.Message}\nNúmero: {sqlEx.Number}");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error general: {ex.Message}");
                return false;
            }
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (TxtClave.Text == TxtConfirm.Text)
            {
                CrearUsuarios();
            }
            else {
                MessageBox.Show("Hubo un problema, contraseña erronea","Diferente Contraseña",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
