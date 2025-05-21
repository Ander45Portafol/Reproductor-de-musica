namespace Reproductor_de_Musica
{
    partial class FormAlbum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlbum));
            this.lstSugerenciasAlbums = new System.Windows.Forms.ListBox();
            this.pnlTextBoxContainer = new System.Windows.Forms.Panel();
            this.btnlupa = new System.Windows.Forms.PictureBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTrend6 = new System.Windows.Forms.Label();
            this.lblTrend5 = new System.Windows.Forms.Label();
            this.lblTrend4 = new System.Windows.Forms.Label();
            this.lblTrend3 = new System.Windows.Forms.Label();
            this.lblTrend2 = new System.Windows.Forms.Label();
            this.lblTrend1 = new System.Windows.Forms.Label();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewAlbum = new System.Windows.Forms.DataGridView();
            this.lblAlbumNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumCanciones = new System.Windows.Forms.Label();
            this.lblCantante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTextBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSugerenciasAlbums
            // 
            this.lstSugerenciasAlbums.BackColor = System.Drawing.Color.LightGray;
            this.lstSugerenciasAlbums.FormattingEnabled = true;
            this.lstSugerenciasAlbums.ItemHeight = 16;
            this.lstSugerenciasAlbums.Location = new System.Drawing.Point(141, 98);
            this.lstSugerenciasAlbums.Name = "lstSugerenciasAlbums";
            this.lstSugerenciasAlbums.Size = new System.Drawing.Size(761, 84);
            this.lstSugerenciasAlbums.TabIndex = 74;
            this.lstSugerenciasAlbums.Visible = false;
            this.lstSugerenciasAlbums.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSugerenciasAlbums_MouseClick);
            this.lstSugerenciasAlbums.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSugerenciasAlbums_KeyDown);
            // 
            // pnlTextBoxContainer
            // 
            this.pnlTextBoxContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pnlTextBoxContainer.Controls.Add(this.btnlupa);
            this.pnlTextBoxContainer.Controls.Add(this.txtbuscar);
            this.pnlTextBoxContainer.Location = new System.Drawing.Point(141, 57);
            this.pnlTextBoxContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTextBoxContainer.Name = "pnlTextBoxContainer";
            this.pnlTextBoxContainer.Size = new System.Drawing.Size(761, 39);
            this.pnlTextBoxContainer.TabIndex = 73;
            // 
            // btnlupa
            // 
            this.btnlupa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnlupa.Image = ((System.Drawing.Image)(resources.GetObject("btnlupa.Image")));
            this.btnlupa.Location = new System.Drawing.Point(715, 6);
            this.btnlupa.Margin = new System.Windows.Forms.Padding(4);
            this.btnlupa.Name = "btnlupa";
            this.btnlupa.Size = new System.Drawing.Size(37, 28);
            this.btnlupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlupa.TabIndex = 17;
            this.btnlupa.TabStop = false;
            this.btnlupa.Click += new System.EventHandler(this.btnlupa_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbuscar.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.txtbuscar.Location = new System.Drawing.Point(4, 7);
            this.txtbuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtbuscar.Multiline = true;
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(748, 28);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.Text = "Buscar...";
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            this.txtbuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbuscar_KeyDown);
            this.txtbuscar.Leave += new System.EventHandler(this.txtbuscar_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(87, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 41);
            this.label9.TabIndex = 72;
            this.label9.Text = "ALBUMS";
            // 
            // lblTrend6
            // 
            this.lblTrend6.Font = new System.Drawing.Font("Corbel", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend6.ForeColor = System.Drawing.Color.Black;
            this.lblTrend6.Location = new System.Drawing.Point(854, 693);
            this.lblTrend6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrend6.Name = "lblTrend6";
            this.lblTrend6.Size = new System.Drawing.Size(136, 41);
            this.lblTrend6.TabIndex = 90;
            this.lblTrend6.Text = "------------";
            this.lblTrend6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrend5
            // 
            this.lblTrend5.Font = new System.Drawing.Font("Corbel", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend5.ForeColor = System.Drawing.Color.Black;
            this.lblTrend5.Location = new System.Drawing.Point(698, 693);
            this.lblTrend5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrend5.Name = "lblTrend5";
            this.lblTrend5.Size = new System.Drawing.Size(136, 41);
            this.lblTrend5.TabIndex = 89;
            this.lblTrend5.Text = "------------";
            this.lblTrend5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrend4
            // 
            this.lblTrend4.Font = new System.Drawing.Font("Corbel", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend4.ForeColor = System.Drawing.Color.Black;
            this.lblTrend4.Location = new System.Drawing.Point(550, 693);
            this.lblTrend4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrend4.Name = "lblTrend4";
            this.lblTrend4.Size = new System.Drawing.Size(136, 41);
            this.lblTrend4.TabIndex = 88;
            this.lblTrend4.Text = "------------";
            this.lblTrend4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrend3
            // 
            this.lblTrend3.Font = new System.Drawing.Font("Corbel", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend3.ForeColor = System.Drawing.Color.Black;
            this.lblTrend3.Location = new System.Drawing.Point(417, 693);
            this.lblTrend3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrend3.Name = "lblTrend3";
            this.lblTrend3.Size = new System.Drawing.Size(136, 41);
            this.lblTrend3.TabIndex = 87;
            this.lblTrend3.Text = "------------";
            this.lblTrend3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrend2
            // 
            this.lblTrend2.Font = new System.Drawing.Font("Corbel", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend2.ForeColor = System.Drawing.Color.Black;
            this.lblTrend2.Location = new System.Drawing.Point(258, 693);
            this.lblTrend2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrend2.Name = "lblTrend2";
            this.lblTrend2.Size = new System.Drawing.Size(136, 41);
            this.lblTrend2.TabIndex = 86;
            this.lblTrend2.Text = "------------";
            this.lblTrend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTrend1
            // 
            this.lblTrend1.Font = new System.Drawing.Font("Corbel", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrend1.ForeColor = System.Drawing.Color.Black;
            this.lblTrend1.Location = new System.Drawing.Point(104, 693);
            this.lblTrend1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrend1.Name = "lblTrend1";
            this.lblTrend1.Size = new System.Drawing.Size(136, 41);
            this.lblTrend1.TabIndex = 85;
            this.lblTrend1.Text = "------------";
            this.lblTrend1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox20.Image = global::Reproductor_de_Musica.Properties.Resources.Screenshot_2025_05_19_113551;
            this.pictureBox20.Location = new System.Drawing.Point(274, 576);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(111, 113);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 84;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox19.Image = global::Reproductor_de_Musica.Properties.Resources.Screenshot_2025_05_19_113551;
            this.pictureBox19.Location = new System.Drawing.Point(422, 576);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(111, 113);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 83;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox18.Image = global::Reproductor_de_Musica.Properties.Resources.Screenshot_2025_05_19_113551;
            this.pictureBox18.Location = new System.Drawing.Point(561, 576);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(111, 113);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 82;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox17.Image = global::Reproductor_de_Musica.Properties.Resources.Screenshot_2025_05_19_113551;
            this.pictureBox17.Location = new System.Drawing.Point(708, 576);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(111, 113);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 81;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox16.Image = global::Reproductor_de_Musica.Properties.Resources.Screenshot_2025_05_19_113551;
            this.pictureBox16.Location = new System.Drawing.Point(866, 576);
            this.pictureBox16.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(111, 113);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 80;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox15.Image = global::Reproductor_de_Musica.Properties.Resources.Screenshot_2025_05_19_113551;
            this.pictureBox15.Location = new System.Drawing.Point(115, 576);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(111, 113);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 79;
            this.pictureBox15.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(111, 540);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 23);
            this.label8.TabIndex = 78;
            this.label8.Text = "Albums recomendados para ti!";
            // 
            // dataGridViewAlbum
            // 
            this.dataGridViewAlbum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbum.Location = new System.Drawing.Point(76, 219);
            this.dataGridViewAlbum.Name = "dataGridViewAlbum";
            this.dataGridViewAlbum.RowHeadersWidth = 51;
            this.dataGridViewAlbum.RowTemplate.Height = 24;
            this.dataGridViewAlbum.Size = new System.Drawing.Size(901, 302);
            this.dataGridViewAlbum.TabIndex = 91;
            // 
            // lblAlbumNombre
            // 
            this.lblAlbumNombre.AutoSize = true;
            this.lblAlbumNombre.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumNombre.Location = new System.Drawing.Point(72, 193);
            this.lblAlbumNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlbumNombre.Name = "lblAlbumNombre";
            this.lblAlbumNombre.Size = new System.Drawing.Size(57, 21);
            this.lblAlbumNombre.TabIndex = 92;
            this.lblAlbumNombre.Text = "Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 93;
            this.label1.Text = "num # de canciones:";
            // 
            // lblNumCanciones
            // 
            this.lblNumCanciones.AutoSize = true;
            this.lblNumCanciones.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCanciones.Location = new System.Drawing.Point(922, 193);
            this.lblNumCanciones.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCanciones.Name = "lblNumCanciones";
            this.lblNumCanciones.Size = new System.Drawing.Size(40, 21);
            this.lblNumCanciones.TabIndex = 94;
            this.lblNumCanciones.Text = "-----";
            // 
            // lblCantante
            // 
            this.lblCantante.AutoSize = true;
            this.lblCantante.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantante.Location = new System.Drawing.Point(247, 193);
            this.lblCantante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantante.Name = "lblCantante";
            this.lblCantante.Size = new System.Drawing.Size(52, 21);
            this.lblCantante.TabIndex = 96;
            this.lblCantante.Text = "-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 97;
            this.label2.Text = "made by";
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 743);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCantante);
            this.Controls.Add(this.lblNumCanciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAlbumNombre);
            this.Controls.Add(this.dataGridViewAlbum);
            this.Controls.Add(this.lblTrend6);
            this.Controls.Add(this.lblTrend5);
            this.Controls.Add(this.lblTrend4);
            this.Controls.Add(this.lblTrend3);
            this.Controls.Add(this.lblTrend2);
            this.Controls.Add(this.lblTrend1);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstSugerenciasAlbums);
            this.Controls.Add(this.pnlTextBoxContainer);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAlbum";
            this.Text = "FormAlbum";
            this.Load += new System.EventHandler(this.FormAlbum_Load);
            this.pnlTextBoxContainer.ResumeLayout(false);
            this.pnlTextBoxContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnlupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSugerenciasAlbums;
        private System.Windows.Forms.Panel pnlTextBoxContainer;
        private System.Windows.Forms.PictureBox btnlupa;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTrend6;
        private System.Windows.Forms.Label lblTrend5;
        private System.Windows.Forms.Label lblTrend4;
        private System.Windows.Forms.Label lblTrend3;
        private System.Windows.Forms.Label lblTrend2;
        private System.Windows.Forms.Label lblTrend1;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewAlbum;
        private System.Windows.Forms.Label lblAlbumNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumCanciones;
        private System.Windows.Forms.Label lblCantante;
        private System.Windows.Forms.Label label2;
    }
}