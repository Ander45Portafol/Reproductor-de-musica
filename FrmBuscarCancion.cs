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
    public partial class FrmBuscarCancion: Form
    {
        public FrmBuscarCancion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightGray; 
            label1.Cursor = Cursors.Hand; 
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = SystemColors.Control;
        }
    }
}
