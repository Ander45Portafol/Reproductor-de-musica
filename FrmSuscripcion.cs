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

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
