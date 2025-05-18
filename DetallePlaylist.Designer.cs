namespace Reproductor_de_Musica
{
    partial class DetallePlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomplaylist = new System.Windows.Forms.Label();
            this.dgvCancionesPlaylist = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancionesPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // nomplaylist
            // 
            this.nomplaylist.AutoSize = true;
            this.nomplaylist.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold);
            this.nomplaylist.Location = new System.Drawing.Point(32, 31);
            this.nomplaylist.Name = "nomplaylist";
            this.nomplaylist.Size = new System.Drawing.Size(164, 28);
            this.nomplaylist.TabIndex = 0;
            this.nomplaylist.Text = "Nombre Playlist";
            // 
            // dgvCancionesPlaylist
            // 
            this.dgvCancionesPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCancionesPlaylist.Location = new System.Drawing.Point(37, 96);
            this.dgvCancionesPlaylist.Name = "dgvCancionesPlaylist";
            this.dgvCancionesPlaylist.RowHeadersWidth = 51;
            this.dgvCancionesPlaylist.RowTemplate.Height = 24;
            this.dgvCancionesPlaylist.Size = new System.Drawing.Size(724, 266);
            this.dgvCancionesPlaylist.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(62)))), ((int)(((byte)(155)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(570, 31);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 45);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "Agregar Canción";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Navy;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(305, 381);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(181, 45);
            this.btnRegresar.TabIndex = 60;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // DetallePlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvCancionesPlaylist);
            this.Controls.Add(this.nomplaylist);
            this.Name = "DetallePlaylist";
            this.Text = "DetallePlaylist";
            this.Load += new System.EventHandler(this.DetallePlaylist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCancionesPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nomplaylist;
        private System.Windows.Forms.DataGridView dgvCancionesPlaylist;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
    }
}