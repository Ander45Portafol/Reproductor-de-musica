namespace Reproductor_de_Musica
{
    partial class FrmPlaylist
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.FrmCrearPlaylist = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.DgvPlaylist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmCrearPlaylist
            // 
            this.FrmCrearPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.FrmCrearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmCrearPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmCrearPlaylist.Location = new System.Drawing.Point(431, 84);
            this.FrmCrearPlaylist.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.FrmCrearPlaylist.Name = "FrmCrearPlaylist";
            this.FrmCrearPlaylist.Size = new System.Drawing.Size(329, 63);
            this.FrmCrearPlaylist.TabIndex = 72;
            this.FrmCrearPlaylist.Text = "Crear nueva playlist";
            this.FrmCrearPlaylist.UseVisualStyleBackColor = false;
            this.FrmCrearPlaylist.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 59);
            this.label8.TabIndex = 73;
            this.label8.Text = "PLAYLIST";
            // 
            // DgvPlaylist
            // 
            this.DgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlaylist.Location = new System.Drawing.Point(38, 169);
            this.DgvPlaylist.Name = "DgvPlaylist";
            this.DgvPlaylist.ReadOnly = true;
            this.DgvPlaylist.RowHeadersWidth = 51;
            this.DgvPlaylist.RowTemplate.Height = 24;
            this.DgvPlaylist.Size = new System.Drawing.Size(1086, 537);
            this.DgvPlaylist.TabIndex = 74;
            this.DgvPlaylist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPlaylist_CellDoubleClick);
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 743);
            this.Controls.Add(this.DgvPlaylist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FrmCrearPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmPlaylist";
            this.Text = "Playlist";
            this.Load += new System.EventHandler(this.FrmPlaylist_Load);
            this.Resize += new System.EventHandler(this.FrmPlaylist_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FrmCrearPlaylist;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DgvPlaylist;
    }
}

