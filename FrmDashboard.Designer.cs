﻿namespace Reproductor_de_Musica
{
    partial class FrmDashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCSesion = new System.Windows.Forms.Button();
            this.BtnListas = new System.Windows.Forms.Button();
            this.BtnAlbum = new System.Windows.Forms.Button();
            this.BtnCanciones = new System.Windows.Forms.Button();
            this.BtnArtista = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.panel2.Location = new System.Drawing.Point(0, 420);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 7);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.BtnCSesion);
            this.panel1.Controls.Add(this.BtnListas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnAlbum);
            this.panel1.Controls.Add(this.BtnCanciones);
            this.panel1.Controls.Add(this.BtnArtista);
            this.panel1.Controls.Add(this.BtnInicio);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 798);
            this.panel1.TabIndex = 0;
            // 
            // BtnCSesion
            // 
            this.BtnCSesion.FlatAppearance.BorderSize = 0;
            this.BtnCSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCSesion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BtnCSesion.Image = global::Reproductor_de_Musica.Properties.Resources.log_out_solid_24;
            this.BtnCSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCSesion.Location = new System.Drawing.Point(0, 674);
            this.BtnCSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCSesion.Name = "BtnCSesion";
            this.BtnCSesion.Size = new System.Drawing.Size(225, 58);
            this.BtnCSesion.TabIndex = 7;
            this.BtnCSesion.Tag = "";
            this.BtnCSesion.Text = "Cerrar sesión";
            this.BtnCSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCSesion.UseVisualStyleBackColor = true;
            this.BtnCSesion.Click += new System.EventHandler(this.BtnCSesion_Click);
            // 
            // BtnListas
            // 
            this.BtnListas.FlatAppearance.BorderSize = 0;
            this.BtnListas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BtnListas.Image = global::Reproductor_de_Musica.Properties.Resources.playlist_solid_241;
            this.BtnListas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListas.Location = new System.Drawing.Point(0, 437);
            this.BtnListas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListas.Name = "BtnListas";
            this.BtnListas.Size = new System.Drawing.Size(225, 58);
            this.BtnListas.TabIndex = 6;
            this.BtnListas.Tag = "";
            this.BtnListas.Text = "Mis listas";
            this.BtnListas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnListas.UseVisualStyleBackColor = true;
            this.BtnListas.Click += new System.EventHandler(this.BtnListas_Click);
            // 
            // BtnAlbum
            // 
            this.BtnAlbum.FlatAppearance.BorderSize = 0;
            this.BtnAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlbum.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BtnAlbum.Image = global::Reproductor_de_Musica.Properties.Resources.folder_solid_243;
            this.BtnAlbum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlbum.Location = new System.Drawing.Point(0, 271);
            this.BtnAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAlbum.Name = "BtnAlbum";
            this.BtnAlbum.Size = new System.Drawing.Size(225, 58);
            this.BtnAlbum.TabIndex = 3;
            this.BtnAlbum.Tag = "";
            this.BtnAlbum.Text = "Albumes";
            this.BtnAlbum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlbum.UseVisualStyleBackColor = true;
            this.BtnAlbum.Click += new System.EventHandler(this.BtnAlbum_Click);
            // 
            // BtnCanciones
            // 
            this.BtnCanciones.FlatAppearance.BorderSize = 0;
            this.BtnCanciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCanciones.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCanciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BtnCanciones.Image = global::Reproductor_de_Musica.Properties.Resources.music_solid_243;
            this.BtnCanciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCanciones.Location = new System.Drawing.Point(0, 207);
            this.BtnCanciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCanciones.Name = "BtnCanciones";
            this.BtnCanciones.Size = new System.Drawing.Size(225, 58);
            this.BtnCanciones.TabIndex = 2;
            this.BtnCanciones.Tag = "";
            this.BtnCanciones.Text = "Canciones";
            this.BtnCanciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCanciones.UseVisualStyleBackColor = true;
            this.BtnCanciones.Click += new System.EventHandler(this.BtnCanciones_Click);
            // 
            // BtnArtista
            // 
            this.BtnArtista.FlatAppearance.BorderSize = 0;
            this.BtnArtista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArtista.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArtista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BtnArtista.Image = global::Reproductor_de_Musica.Properties.Resources.microphone_solid_243;
            this.BtnArtista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArtista.Location = new System.Drawing.Point(0, 143);
            this.BtnArtista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnArtista.Name = "BtnArtista";
            this.BtnArtista.Size = new System.Drawing.Size(225, 58);
            this.BtnArtista.TabIndex = 1;
            this.BtnArtista.Tag = "";
            this.BtnArtista.Text = "Artistas";
            this.BtnArtista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnArtista.UseVisualStyleBackColor = true;
            this.BtnArtista.Click += new System.EventHandler(this.BtnArtista_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(192)))), ((int)(((byte)(193)))));
            this.BtnInicio.Image = global::Reproductor_de_Musica.Properties.Resources.bxs_home_alt_2_12;
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(0, 82);
            this.BtnInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(225, 55);
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.Tag = "198; 192; 193";
            this.BtnInicio.Text = "Inicio";
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = global::Reproductor_de_Musica.Properties.Resources.x_regular_24;
            this.button6.Location = new System.Drawing.Point(1363, 12);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(32, 23);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.SystemColors.Control;
            this.PanelContenido.Location = new System.Drawing.Point(231, 50);
            this.PanelContenido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(1173, 743);
            this.PanelContenido.TabIndex = 2;
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1405, 794);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button BtnArtista;
        private System.Windows.Forms.Button BtnCanciones;
        private System.Windows.Forms.Button BtnAlbum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnListas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BtnCSesion;
        private System.Windows.Forms.Panel PanelContenido;
    }
}