namespace LifeManager.Vista
{
    partial class frmCrearPelicula
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
            this.panelCrearPeliculaNueva = new System.Windows.Forms.Panel();
            this.dateTimePickerVisionado = new System.Windows.Forms.DateTimePicker();
            this.txtTrama = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.pbPortadaPelicula = new System.Windows.Forms.PictureBox();
            this.btnCalendario = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFechaVisionado = new System.Windows.Forms.TextBox();
            this.cbPuntuacion = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarPelicula = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCrearPeliculaNueva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortadaPelicula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendario)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCrearPeliculaNueva
            // 
            this.panelCrearPeliculaNueva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelCrearPeliculaNueva.Controls.Add(this.dateTimePickerVisionado);
            this.panelCrearPeliculaNueva.Controls.Add(this.txtTrama);
            this.panelCrearPeliculaNueva.Controls.Add(this.label10);
            this.panelCrearPeliculaNueva.Controls.Add(this.btnCargarImagen);
            this.panelCrearPeliculaNueva.Controls.Add(this.pbPortadaPelicula);
            this.panelCrearPeliculaNueva.Controls.Add(this.btnCalendario);
            this.panelCrearPeliculaNueva.Controls.Add(this.label9);
            this.panelCrearPeliculaNueva.Controls.Add(this.txtFechaVisionado);
            this.panelCrearPeliculaNueva.Controls.Add(this.cbPuntuacion);
            this.panelCrearPeliculaNueva.Controls.Add(this.label8);
            this.panelCrearPeliculaNueva.Controls.Add(this.cbGenero);
            this.panelCrearPeliculaNueva.Controls.Add(this.label5);
            this.panelCrearPeliculaNueva.Controls.Add(this.txtAnio);
            this.panelCrearPeliculaNueva.Controls.Add(this.label4);
            this.panelCrearPeliculaNueva.Controls.Add(this.txtDuracion);
            this.panelCrearPeliculaNueva.Controls.Add(this.label3);
            this.panelCrearPeliculaNueva.Controls.Add(this.btnLimpiar);
            this.panelCrearPeliculaNueva.Controls.Add(this.btnGuardarPelicula);
            this.panelCrearPeliculaNueva.Controls.Add(this.label2);
            this.panelCrearPeliculaNueva.Controls.Add(this.txtTituloPelicula);
            this.panelCrearPeliculaNueva.Controls.Add(this.panel2);
            this.panelCrearPeliculaNueva.Location = new System.Drawing.Point(12, 12);
            this.panelCrearPeliculaNueva.Name = "panelCrearPeliculaNueva";
            this.panelCrearPeliculaNueva.Size = new System.Drawing.Size(958, 526);
            this.panelCrearPeliculaNueva.TabIndex = 2;
            // 
            // dateTimePickerVisionado
            // 
            this.dateTimePickerVisionado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerVisionado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerVisionado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVisionado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVisionado.Location = new System.Drawing.Point(751, 169);
            this.dateTimePickerVisionado.Name = "dateTimePickerVisionado";
            this.dateTimePickerVisionado.Size = new System.Drawing.Size(159, 23);
            this.dateTimePickerVisionado.TabIndex = 33;
            this.dateTimePickerVisionado.Visible = false;
            this.dateTimePickerVisionado.CloseUp += new System.EventHandler(this.dateTimePickerVisionado_CloseUp);
            // 
            // txtTrama
            // 
            this.txtTrama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrama.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtTrama.Location = new System.Drawing.Point(276, 210);
            this.txtTrama.MaxLength = 650;
            this.txtTrama.Multiline = true;
            this.txtTrama.Name = "txtTrama";
            this.txtTrama.Size = new System.Drawing.Size(665, 251);
            this.txtTrama.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label10.Location = new System.Drawing.Point(273, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Trama:";
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCargarImagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarImagen.FlatAppearance.BorderSize = 0;
            this.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImagen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarImagen.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCargarImagen.Image = global::LifeManager.Properties.Resources.imagen_icon;
            this.btnCargarImagen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarImagen.Location = new System.Drawing.Point(12, 478);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCargarImagen.Size = new System.Drawing.Size(201, 40);
            this.btnCargarImagen.TabIndex = 8;
            this.btnCargarImagen.Text = "        CARGAR";
            this.btnCargarImagen.UseVisualStyleBackColor = false;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // pbPortadaPelicula
            // 
            this.pbPortadaPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPortadaPelicula.Location = new System.Drawing.Point(11, 189);
            this.pbPortadaPelicula.Name = "pbPortadaPelicula";
            this.pbPortadaPelicula.Size = new System.Drawing.Size(202, 274);
            this.pbPortadaPelicula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortadaPelicula.TabIndex = 29;
            this.pbPortadaPelicula.TabStop = false;
            // 
            // btnCalendario
            // 
            this.btnCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCalendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendario.Image = global::LifeManager.Properties.Resources.calendario_icon;
            this.btnCalendario.Location = new System.Drawing.Point(913, 134);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(29, 29);
            this.btnCalendario.TabIndex = 28;
            this.btnCalendario.TabStop = false;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label9.Location = new System.Drawing.Point(749, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 18);
            this.label9.TabIndex = 26;
            this.label9.Text = "Fecha Visionado:";
            // 
            // txtFechaVisionado
            // 
            this.txtFechaVisionado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVisionado.Enabled = false;
            this.txtFechaVisionado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVisionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtFechaVisionado.Location = new System.Drawing.Point(751, 134);
            this.txtFechaVisionado.MaxLength = 10;
            this.txtFechaVisionado.Name = "txtFechaVisionado";
            this.txtFechaVisionado.ReadOnly = true;
            this.txtFechaVisionado.Size = new System.Drawing.Size(159, 29);
            this.txtFechaVisionado.TabIndex = 6;
            this.txtFechaVisionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbPuntuacion
            // 
            this.cbPuntuacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuntuacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPuntuacion.FormattingEnabled = true;
            this.cbPuntuacion.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbPuntuacion.Location = new System.Drawing.Point(629, 134);
            this.cbPuntuacion.Name = "cbPuntuacion";
            this.cbPuntuacion.Size = new System.Drawing.Size(99, 30);
            this.cbPuntuacion.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label8.Location = new System.Drawing.Point(626, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Puntuación:";
            // 
            // cbGenero
            // 
            this.cbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenero.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Acción",
            "Aventura",
            "Animación",
            "Comedia",
            "Drama",
            "Ciencia Ficción",
            "Fantasía",
            "Terror",
            "Suspense",
            "Romance"});
            this.cbGenero.Location = new System.Drawing.Point(523, 72);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(273, 30);
            this.cbGenero.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label5.Location = new System.Drawing.Point(819, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "Año:";
            // 
            // txtAnio
            // 
            this.txtAnio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtAnio.Location = new System.Drawing.Point(821, 72);
            this.txtAnio.MaxLength = 4;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(120, 29);
            this.txtAnio.TabIndex = 3;
            this.txtAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnio_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label4.Location = new System.Drawing.Point(521, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Duración:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDuracion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtDuracion.Location = new System.Drawing.Point(523, 135);
            this.txtDuracion.MaxLength = 3;
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(84, 29);
            this.txtDuracion.TabIndex = 4;
            this.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDuracion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(520, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Género:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Image = global::LifeManager.Properties.Resources.limpiar_icon;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(766, 467);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(175, 51);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "        LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarPelicula
            // 
            this.btnGuardarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnGuardarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPelicula.FlatAppearance.BorderSize = 0;
            this.btnGuardarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPelicula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarPelicula.Image = global::LifeManager.Properties.Resources.guardar_icon;
            this.btnGuardarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarPelicula.Location = new System.Drawing.Point(491, 467);
            this.btnGuardarPelicula.Name = "btnGuardarPelicula";
            this.btnGuardarPelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardarPelicula.Size = new System.Drawing.Size(259, 51);
            this.btnGuardarPelicula.TabIndex = 9;
            this.btnGuardarPelicula.Text = "        GUARDAR PELICULA";
            this.btnGuardarPelicula.UseVisualStyleBackColor = false;
            this.btnGuardarPelicula.Visible = false;
            this.btnGuardarPelicula.Click += new System.EventHandler(this.btnGuardarPelicula_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(11, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título de la Película:";
            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTituloPelicula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTituloPelicula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtTituloPelicula.Location = new System.Drawing.Point(13, 72);
            this.txtTituloPelicula.MaxLength = 100;
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(485, 29);
            this.txtTituloPelicula.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 32);
            this.panel2.TabIndex = 8;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::LifeManager.Properties.Resources.cerrar64px;
            this.btnCerrar.Location = new System.Drawing.Point(896, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 32);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR UNA NUEVA PELICULA";
            // 
            // frmCrearPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(982, 550);
            this.Controls.Add(this.panelCrearPeliculaNueva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearPelicula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearPelicula";
            this.Load += new System.EventHandler(this.frmCrearPelicula_Load);
            this.panelCrearPeliculaNueva.ResumeLayout(false);
            this.panelCrearPeliculaNueva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortadaPelicula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCalendario)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearPeliculaNueva;
        private System.Windows.Forms.DateTimePicker dateTimePickerVisionado;
        private System.Windows.Forms.TextBox txtTrama;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.PictureBox pbPortadaPelicula;
        private System.Windows.Forms.PictureBox btnCalendario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFechaVisionado;
        private System.Windows.Forms.ComboBox cbPuntuacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarPelicula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label1;
    }
}