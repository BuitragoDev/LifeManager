namespace LifeManager.Vista
{
    partial class frmMovies
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
            this.panelBotonesNotes = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.txtTrama = new System.Windows.Forms.TextBox();
            this.lbTrama = new System.Windows.Forms.Label();
            this.lbFechaVisionado = new System.Windows.Forms.Label();
            this.lbDuracion = new System.Windows.Forms.Label();
            this.lbAnio = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbPuntuacion = new System.Windows.Forms.Label();
            this.panelDataGridNotes = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListadoPeliculas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarPelicula = new System.Windows.Forms.Button();
            this.btnBorrarPelicula = new System.Windows.Forms.Button();
            this.pbPortadaLibro = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrearPelicula = new System.Windows.Forms.Button();
            this.panelBotonesNotes.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.panelDataGridNotes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPeliculas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortadaLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotonesNotes
            // 
            this.panelBotonesNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotonesNotes.Controls.Add(this.panelBuscador);
            this.panelBotonesNotes.Controls.Add(this.btnCrearPelicula);
            this.panelBotonesNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesNotes.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesNotes.Name = "panelBotonesNotes";
            this.panelBotonesNotes.Size = new System.Drawing.Size(1130, 75);
            this.panelBotonesNotes.TabIndex = 2;
            // 
            // panelBuscador
            // 
            this.panelBuscador.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuscador.Controls.Add(this.txtBuscador);
            this.panelBuscador.Controls.Add(this.btnBuscar);
            this.panelBuscador.Location = new System.Drawing.Point(735, 12);
            this.panelBuscador.Name = "panelBuscador";
            this.panelBuscador.Size = new System.Drawing.Size(374, 50);
            this.panelBuscador.TabIndex = 2;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscador.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBuscador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscador.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscador.Location = new System.Drawing.Point(7, 13);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(307, 22);
            this.txtBuscador.TabIndex = 2;
            this.txtBuscador.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBuscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscador_KeyDown);
            // 
            // panelDetalles
            // 
            this.panelDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetalles.Controls.Add(this.btnEditarPelicula);
            this.panelDetalles.Controls.Add(this.btnBorrarPelicula);
            this.panelDetalles.Controls.Add(this.lb6);
            this.panelDetalles.Controls.Add(this.lb5);
            this.panelDetalles.Controls.Add(this.lb4);
            this.panelDetalles.Controls.Add(this.lb3);
            this.panelDetalles.Controls.Add(this.lb1);
            this.panelDetalles.Controls.Add(this.lb2);
            this.panelDetalles.Controls.Add(this.txtTrama);
            this.panelDetalles.Controls.Add(this.lbTrama);
            this.panelDetalles.Controls.Add(this.lbFechaVisionado);
            this.panelDetalles.Controls.Add(this.lbDuracion);
            this.panelDetalles.Controls.Add(this.lbAnio);
            this.panelDetalles.Controls.Add(this.lbGenero);
            this.panelDetalles.Controls.Add(this.lbTitulo);
            this.panelDetalles.Controls.Add(this.lbPuntuacion);
            this.panelDetalles.Controls.Add(this.pbPortadaLibro);
            this.panelDetalles.Location = new System.Drawing.Point(24, 451);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(1085, 338);
            this.panelDetalles.TabIndex = 3;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb6.Location = new System.Drawing.Point(198, 171);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(85, 15);
            this.lb6.TabIndex = 25;
            this.lb6.Text = "Puntuación:";
            this.lb6.Visible = false;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb5.Location = new System.Drawing.Point(198, 139);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(118, 15);
            this.lb5.TabIndex = 23;
            this.lb5.Text = "Fecha Visionado:";
            this.lb5.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb4.Location = new System.Drawing.Point(198, 107);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(71, 15);
            this.lb4.TabIndex = 22;
            this.lb4.Text = "Duración:";
            this.lb4.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb3.Location = new System.Drawing.Point(198, 75);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(36, 15);
            this.lb3.TabIndex = 21;
            this.lb3.Text = "Año:";
            this.lb3.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb1.Location = new System.Drawing.Point(198, 11);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(48, 15);
            this.lb1.TabIndex = 20;
            this.lb1.Text = "Titulo:";
            this.lb1.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb2.Location = new System.Drawing.Point(198, 43);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(59, 15);
            this.lb2.TabIndex = 19;
            this.lb2.Text = "Género:";
            this.lb2.Visible = false;
            // 
            // txtTrama
            // 
            this.txtTrama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrama.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTrama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrama.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtTrama.Location = new System.Drawing.Point(667, 30);
            this.txtTrama.Multiline = true;
            this.txtTrama.Name = "txtTrama";
            this.txtTrama.ReadOnly = true;
            this.txtTrama.Size = new System.Drawing.Size(403, 305);
            this.txtTrama.TabIndex = 18;
            this.txtTrama.Visible = false;
            // 
            // lbTrama
            // 
            this.lbTrama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTrama.AutoSize = true;
            this.lbTrama.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbTrama.Location = new System.Drawing.Point(667, 8);
            this.lbTrama.Name = "lbTrama";
            this.lbTrama.Size = new System.Drawing.Size(59, 18);
            this.lbTrama.TabIndex = 17;
            this.lbTrama.Text = "Trama";
            this.lbTrama.Visible = false;
            // 
            // lbFechaVisionado
            // 
            this.lbFechaVisionado.AutoSize = true;
            this.lbFechaVisionado.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaVisionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbFechaVisionado.Location = new System.Drawing.Point(322, 133);
            this.lbFechaVisionado.Name = "lbFechaVisionado";
            this.lbFechaVisionado.Size = new System.Drawing.Size(126, 21);
            this.lbFechaVisionado.TabIndex = 15;
            this.lbFechaVisionado.Text = "Paginas del libro";
            this.lbFechaVisionado.Visible = false;
            // 
            // lbDuracion
            // 
            this.lbDuracion.AutoSize = true;
            this.lbDuracion.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbDuracion.Location = new System.Drawing.Point(279, 101);
            this.lbDuracion.Name = "lbDuracion";
            this.lbDuracion.Size = new System.Drawing.Size(116, 21);
            this.lbDuracion.TabIndex = 13;
            this.lbDuracion.Text = "Idioma del libro";
            this.lbDuracion.Visible = false;
            // 
            // lbAnio
            // 
            this.lbAnio.AutoSize = true;
            this.lbAnio.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbAnio.Location = new System.Drawing.Point(242, 70);
            this.lbAnio.Name = "lbAnio";
            this.lbAnio.Size = new System.Drawing.Size(127, 21);
            this.lbAnio.TabIndex = 12;
            this.lbAnio.Text = "Formato del libro";
            this.lbAnio.Visible = false;
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbGenero.Location = new System.Drawing.Point(263, 38);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(124, 21);
            this.lbGenero.TabIndex = 11;
            this.lbGenero.Text = "Editorial del libro";
            this.lbGenero.Visible = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbTitulo.Location = new System.Drawing.Point(252, 6);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 21);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Titulo del libro";
            this.lbTitulo.Visible = false;
            // 
            // lbPuntuacion
            // 
            this.lbPuntuacion.AutoSize = true;
            this.lbPuntuacion.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPuntuacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbPuntuacion.Location = new System.Drawing.Point(289, 166);
            this.lbPuntuacion.Name = "lbPuntuacion";
            this.lbPuntuacion.Size = new System.Drawing.Size(106, 21);
            this.lbPuntuacion.TabIndex = 9;
            this.lbPuntuacion.Text = "Autor del libro";
            this.lbPuntuacion.Visible = false;
            // 
            // panelDataGridNotes
            // 
            this.panelDataGridNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelDataGridNotes.Controls.Add(this.pictureBox2);
            this.panelDataGridNotes.Controls.Add(this.btnRecargar);
            this.panelDataGridNotes.Controls.Add(this.label1);
            this.panelDataGridNotes.Controls.Add(this.panel3);
            this.panelDataGridNotes.Location = new System.Drawing.Point(24, 86);
            this.panelDataGridNotes.Name = "panelDataGridNotes";
            this.panelDataGridNotes.Size = new System.Drawing.Size(1085, 349);
            this.panelDataGridNotes.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE PELICULAS";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvListadoPeliculas);
            this.panel3.Location = new System.Drawing.Point(5, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1075, 295);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1065, 28);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(829, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Duración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(663, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Visionado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(420, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Género";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título de la Película";
            // 
            // dgvListadoPeliculas
            // 
            this.dgvListadoPeliculas.AllowUserToAddRows = false;
            this.dgvListadoPeliculas.AllowUserToDeleteRows = false;
            this.dgvListadoPeliculas.AllowUserToResizeColumns = false;
            this.dgvListadoPeliculas.AllowUserToResizeRows = false;
            this.dgvListadoPeliculas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoPeliculas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListadoPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListadoPeliculas.Location = new System.Drawing.Point(10, 38);
            this.dgvListadoPeliculas.MultiSelect = false;
            this.dgvListadoPeliculas.Name = "dgvListadoPeliculas";
            this.dgvListadoPeliculas.ReadOnly = true;
            this.dgvListadoPeliculas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPeliculas.Size = new System.Drawing.Size(1055, 243);
            this.dgvListadoPeliculas.TabIndex = 0;
            this.dgvListadoPeliculas.SelectionChanged += new System.EventHandler(this.dgvListadoPeliculas_SelectionChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(935, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Puntuación";
            // 
            // btnEditarPelicula
            // 
            this.btnEditarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnEditarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPelicula.FlatAppearance.BorderSize = 0;
            this.btnEditarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPelicula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarPelicula.Image = global::LifeManager.Properties.Resources.editar_icon;
            this.btnEditarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPelicula.Location = new System.Drawing.Point(246, 293);
            this.btnEditarPelicula.Name = "btnEditarPelicula";
            this.btnEditarPelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditarPelicula.Size = new System.Drawing.Size(222, 45);
            this.btnEditarPelicula.TabIndex = 28;
            this.btnEditarPelicula.Text = "        EDITAR PELICULA";
            this.btnEditarPelicula.UseVisualStyleBackColor = false;
            this.btnEditarPelicula.Visible = false;
            this.btnEditarPelicula.Click += new System.EventHandler(this.btnEditarPelicula_Click);
            // 
            // btnBorrarPelicula
            // 
            this.btnBorrarPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBorrarPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPelicula.FlatAppearance.BorderSize = 0;
            this.btnBorrarPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPelicula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarPelicula.Image = global::LifeManager.Properties.Resources.borrar_icon;
            this.btnBorrarPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarPelicula.Location = new System.Drawing.Point(0, 293);
            this.btnBorrarPelicula.Name = "btnBorrarPelicula";
            this.btnBorrarPelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrarPelicula.Size = new System.Drawing.Size(240, 45);
            this.btnBorrarPelicula.TabIndex = 27;
            this.btnBorrarPelicula.Text = "        BORRAR PELICULA";
            this.btnBorrarPelicula.UseVisualStyleBackColor = false;
            this.btnBorrarPelicula.Visible = false;
            this.btnBorrarPelicula.Click += new System.EventHandler(this.btnBorrarPelicula_Click);
            // 
            // pbPortadaLibro
            // 
            this.pbPortadaLibro.Location = new System.Drawing.Point(0, 0);
            this.pbPortadaLibro.Name = "pbPortadaLibro";
            this.pbPortadaLibro.Size = new System.Drawing.Size(192, 256);
            this.pbPortadaLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPortadaLibro.TabIndex = 0;
            this.pbPortadaLibro.TabStop = false;
            this.pbPortadaLibro.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LifeManager.Properties.Resources.peliculas_icon;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Image = global::LifeManager.Properties.Resources.recargar_icon;
            this.btnRecargar.Location = new System.Drawing.Point(1047, 7);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(32, 32);
            this.btnRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRecargar.TabIndex = 3;
            this.btnRecargar.TabStop = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Image = global::LifeManager.Properties.Resources.lupa_icon;
            this.btnBuscar.Location = new System.Drawing.Point(322, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 48);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCrearPelicula
            // 
            this.btnCrearPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCrearPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPelicula.FlatAppearance.BorderSize = 0;
            this.btnCrearPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPelicula.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPelicula.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearPelicula.Image = global::LifeManager.Properties.Resources.anadir_icon;
            this.btnCrearPelicula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPelicula.Location = new System.Drawing.Point(23, 12);
            this.btnCrearPelicula.Name = "btnCrearPelicula";
            this.btnCrearPelicula.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCrearPelicula.Size = new System.Drawing.Size(333, 50);
            this.btnCrearPelicula.TabIndex = 1;
            this.btnCrearPelicula.Text = "        AÑADIR UNA PELICULA NUEVA";
            this.btnCrearPelicula.UseVisualStyleBackColor = false;
            this.btnCrearPelicula.Click += new System.EventHandler(this.btnCrearPelicula_Click);
            // 
            // frmMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1130, 800);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelDataGridNotes);
            this.Controls.Add(this.panelBotonesNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMovies";
            this.Text = "frmMovies";
            this.Load += new System.EventHandler(this.frmMovies_Load);
            this.panelBotonesNotes.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.panelDataGridNotes.ResumeLayout(false);
            this.panelDataGridNotes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPeliculas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortadaLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonesNotes;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearPelicula;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Button btnEditarPelicula;
        private System.Windows.Forms.Button btnBorrarPelicula;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox txtTrama;
        private System.Windows.Forms.Label lbTrama;
        private System.Windows.Forms.Label lbFechaVisionado;
        private System.Windows.Forms.Label lbDuracion;
        private System.Windows.Forms.Label lbAnio;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbPuntuacion;
        private System.Windows.Forms.PictureBox pbPortadaLibro;
        private System.Windows.Forms.Panel panelDataGridNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvListadoPeliculas;
        private System.Windows.Forms.Label label6;
    }
}