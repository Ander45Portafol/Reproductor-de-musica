namespace Reproductor_de_Musica
{
    partial class FrmPlaylistBuscar
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
            this.button4 = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DgvCanciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(795, 101);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(329, 63);
            this.button4.TabIndex = 75;
            this.button4.Text = "Buscar canciones";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(14, 9);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(182, 47);
            this.LblNombre.TabIndex = 76;
            this.LblNombre.Text = "PLAYLIST";
            // 
            // DgvCanciones
            // 
            this.DgvCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCanciones.Location = new System.Drawing.Point(38, 172);
            this.DgvCanciones.Name = "DgvCanciones";
            this.DgvCanciones.ReadOnly = true;
            this.DgvCanciones.RowHeadersWidth = 51;
            this.DgvCanciones.RowTemplate.Height = 24;
            this.DgvCanciones.Size = new System.Drawing.Size(1085, 559);
            this.DgvCanciones.TabIndex = 77;
            // 
            // FrmPlaylistBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1173, 743);
            this.Controls.Add(this.DgvCanciones);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPlaylistBuscar";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView DgvCanciones;
    }
}