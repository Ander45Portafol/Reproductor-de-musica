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
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmCrearPlaylist
            // 
            this.FrmCrearPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.FrmCrearPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FrmCrearPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrmCrearPlaylist.Location = new System.Drawing.Point(323, 68);
            this.FrmCrearPlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.FrmCrearPlaylist.Name = "FrmCrearPlaylist";
            this.FrmCrearPlaylist.Size = new System.Drawing.Size(247, 51);
            this.FrmCrearPlaylist.TabIndex = 72;
            this.FrmCrearPlaylist.Text = "Crear nueva playlist";
            this.FrmCrearPlaylist.UseVisualStyleBackColor = false;
            this.FrmCrearPlaylist.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 38);
            this.label8.TabIndex = 73;
            this.label8.Text = "PLAYLIST";
            // 
            // DgvPlaylist
            // 
            this.DgvPlaylist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPlaylist.Location = new System.Drawing.Point(28, 137);
            this.DgvPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvPlaylist.Name = "DgvPlaylist";
            this.DgvPlaylist.ReadOnly = true;
            this.DgvPlaylist.RowHeadersWidth = 51;
            this.DgvPlaylist.RowTemplate.Height = 24;
            this.DgvPlaylist.Size = new System.Drawing.Size(814, 436);
            this.DgvPlaylist.TabIndex = 74;
            this.DgvPlaylist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPlaylist_CellDoubleClick);
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(28, 98);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(210, 21);
            this.comboBoxFiltro.TabIndex = 75;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "Filtrar por:";
            // 
            // FrmPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 604);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxFiltro);
            this.Controls.Add(this.DgvPlaylist);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FrmCrearPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Label label1;
    }
}

