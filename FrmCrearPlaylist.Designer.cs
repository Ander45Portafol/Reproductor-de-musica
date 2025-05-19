namespace Reproductor_de_Musica
{
    partial class FrmCrearPlaylist
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
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre_Lista = new System.Windows.Forms.TextBox();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::Reproductor_de_Musica.Properties.Resources.x_regular_24;
            this.BtnCerrar.Location = new System.Drawing.Point(602, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(32, 23);
            this.BtnCerrar.TabIndex = 60;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 43);
            this.label1.TabIndex = 61;
            this.label1.Text = "CREAR PLAYLIST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 23);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ingresar nombre:";
            // 
            // TxtNombre_Lista
            // 
            this.TxtNombre_Lista.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre_Lista.Location = new System.Drawing.Point(133, 133);
            this.TxtNombre_Lista.Name = "TxtNombre_Lista";
            this.TxtNombre_Lista.Size = new System.Drawing.Size(352, 28);
            this.TxtNombre_Lista.TabIndex = 63;
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(155)))));
            this.BtnCrear.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.ForeColor = System.Drawing.Color.White;
            this.BtnCrear.Location = new System.Drawing.Point(423, 230);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(189, 45);
            this.BtnCrear.TabIndex = 64;
            this.BtnCrear.Text = "Confirmar";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // FrmCrearPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 296);
            this.Controls.Add(this.BtnCrear);
            this.Controls.Add(this.TxtNombre_Lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearPlaylist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCrearPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre_Lista;
        private System.Windows.Forms.Button BtnCrear;
    }
}