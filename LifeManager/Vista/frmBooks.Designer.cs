namespace LifeManager.Vista
{
    partial class frmBooks
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrearLibro = new System.Windows.Forms.Button();
            this.panelDataGridNotes = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListadoLibros = new System.Windows.Forms.DataGridView();
            this.pbPortadaLibro = new System.Windows.Forms.PictureBox();
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbEditorial = new System.Windows.Forms.Label();
            this.lbFormato = new System.Windows.Forms.Label();
            this.lbIdioma = new System.Windows.Forms.Label();
            this.lbISBN = new System.Windows.Forms.Label();
            this.lbPaginas = new System.Windows.Forms.Label();
            this.lbFechaLectura = new System.Windows.Forms.Label();
            this.lbSinopsis = new System.Windows.Forms.Label();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.btnBorrarLibro = new System.Windows.Forms.Button();
            this.lb8 = new System.Windows.Forms.Label();
            this.lb7 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.panelBotonesNotes.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.panelDataGridNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortadaLibro)).BeginInit();
            this.panelDetalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBotonesNotes
            // 
            this.panelBotonesNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotonesNotes.Controls.Add(this.panelBuscador);
            this.panelBotonesNotes.Controls.Add(this.btnCrearLibro);
            this.panelBotonesNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesNotes.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesNotes.Name = "panelBotonesNotes";
            this.panelBotonesNotes.Size = new System.Drawing.Size(1130, 75);
            this.panelBotonesNotes.TabIndex = 1;
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
            // btnCrearLibro
            // 
            this.btnCrearLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCrearLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearLibro.FlatAppearance.BorderSize = 0;
            this.btnCrearLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearLibro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearLibro.Image = global::LifeManager.Properties.Resources.anadir_icon;
            this.btnCrearLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearLibro.Location = new System.Drawing.Point(23, 12);
            this.btnCrearLibro.Name = "btnCrearLibro";
            this.btnCrearLibro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCrearLibro.Size = new System.Drawing.Size(289, 50);
            this.btnCrearLibro.TabIndex = 1;
            this.btnCrearLibro.Text = "        AÑADIR UN LIBRO NUEVO";
            this.btnCrearLibro.UseVisualStyleBackColor = false;
            this.btnCrearLibro.Click += new System.EventHandler(this.btnCrearLibro_Click);
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
            this.panelDataGridNotes.Location = new System.Drawing.Point(23, 85);
            this.panelDataGridNotes.Name = "panelDataGridNotes";
            this.panelDataGridNotes.Size = new System.Drawing.Size(1085, 349);
            this.panelDataGridNotes.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LifeManager.Properties.Resources.libros_icon;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(45, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE LIBROS";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvListadoLibros);
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
            this.label5.Location = new System.Drawing.Point(818, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Páginas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(911, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha de Lectura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(420, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor del Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título del Libro";
            // 
            // dgvListadoLibros
            // 
            this.dgvListadoLibros.AllowUserToAddRows = false;
            this.dgvListadoLibros.AllowUserToDeleteRows = false;
            this.dgvListadoLibros.AllowUserToResizeColumns = false;
            this.dgvListadoLibros.AllowUserToResizeRows = false;
            this.dgvListadoLibros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoLibros.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListadoLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoLibros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListadoLibros.Location = new System.Drawing.Point(10, 38);
            this.dgvListadoLibros.MultiSelect = false;
            this.dgvListadoLibros.Name = "dgvListadoLibros";
            this.dgvListadoLibros.ReadOnly = true;
            this.dgvListadoLibros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoLibros.Size = new System.Drawing.Size(1055, 243);
            this.dgvListadoLibros.TabIndex = 0;
            this.dgvListadoLibros.SelectionChanged += new System.EventHandler(this.dgvListadoLibros_SelectionChanged);
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
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbAutor.Location = new System.Drawing.Point(262, 73);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(106, 21);
            this.lbAutor.TabIndex = 9;
            this.lbAutor.Text = "Autor del libro";
            this.lbAutor.Visible = false;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbTitulo.Location = new System.Drawing.Point(261, 41);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(106, 21);
            this.lbTitulo.TabIndex = 10;
            this.lbTitulo.Text = "Titulo del libro";
            this.lbTitulo.Visible = false;
            // 
            // lbEditorial
            // 
            this.lbEditorial.AutoSize = true;
            this.lbEditorial.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditorial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbEditorial.Location = new System.Drawing.Point(283, 105);
            this.lbEditorial.Name = "lbEditorial";
            this.lbEditorial.Size = new System.Drawing.Size(124, 21);
            this.lbEditorial.TabIndex = 11;
            this.lbEditorial.Text = "Editorial del libro";
            this.lbEditorial.Visible = false;
            // 
            // lbFormato
            // 
            this.lbFormato.AutoSize = true;
            this.lbFormato.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbFormato.Location = new System.Drawing.Point(284, 137);
            this.lbFormato.Name = "lbFormato";
            this.lbFormato.Size = new System.Drawing.Size(127, 21);
            this.lbFormato.TabIndex = 12;
            this.lbFormato.Text = "Formato del libro";
            this.lbFormato.Visible = false;
            // 
            // lbIdioma
            // 
            this.lbIdioma.AutoSize = true;
            this.lbIdioma.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdioma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbIdioma.Location = new System.Drawing.Point(270, 169);
            this.lbIdioma.Name = "lbIdioma";
            this.lbIdioma.Size = new System.Drawing.Size(116, 21);
            this.lbIdioma.TabIndex = 13;
            this.lbIdioma.Text = "Idioma del libro";
            this.lbIdioma.Visible = false;
            // 
            // lbISBN
            // 
            this.lbISBN.AutoSize = true;
            this.lbISBN.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISBN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbISBN.Location = new System.Drawing.Point(257, 9);
            this.lbISBN.Name = "lbISBN";
            this.lbISBN.Size = new System.Drawing.Size(107, 21);
            this.lbISBN.TabIndex = 14;
            this.lbISBN.Text = "ISBN del libro";
            this.lbISBN.Visible = false;
            // 
            // lbPaginas
            // 
            this.lbPaginas.AutoSize = true;
            this.lbPaginas.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPaginas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbPaginas.Location = new System.Drawing.Point(281, 201);
            this.lbPaginas.Name = "lbPaginas";
            this.lbPaginas.Size = new System.Drawing.Size(126, 21);
            this.lbPaginas.TabIndex = 15;
            this.lbPaginas.Text = "Paginas del libro";
            this.lbPaginas.Visible = false;
            // 
            // lbFechaLectura
            // 
            this.lbFechaLectura.AutoSize = true;
            this.lbFechaLectura.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaLectura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbFechaLectura.Location = new System.Drawing.Point(324, 233);
            this.lbFechaLectura.Name = "lbFechaLectura";
            this.lbFechaLectura.Size = new System.Drawing.Size(112, 21);
            this.lbFechaLectura.TabIndex = 16;
            this.lbFechaLectura.Text = "Fecha Lectura";
            this.lbFechaLectura.Visible = false;
            // 
            // lbSinopsis
            // 
            this.lbSinopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSinopsis.AutoSize = true;
            this.lbSinopsis.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbSinopsis.Location = new System.Drawing.Point(667, 8);
            this.lbSinopsis.Name = "lbSinopsis";
            this.lbSinopsis.Size = new System.Drawing.Size(75, 18);
            this.lbSinopsis.TabIndex = 17;
            this.lbSinopsis.Text = "Sinopsis";
            this.lbSinopsis.Visible = false;
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSinopsis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSinopsis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSinopsis.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinopsis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtSinopsis.Location = new System.Drawing.Point(667, 30);
            this.txtSinopsis.Multiline = true;
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.ReadOnly = true;
            this.txtSinopsis.Size = new System.Drawing.Size(403, 305);
            this.txtSinopsis.TabIndex = 18;
            this.txtSinopsis.Visible = false;
            // 
            // panelDetalles
            // 
            this.panelDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelDetalles.Controls.Add(this.btnEditarLibro);
            this.panelDetalles.Controls.Add(this.btnBorrarLibro);
            this.panelDetalles.Controls.Add(this.lb8);
            this.panelDetalles.Controls.Add(this.lb7);
            this.panelDetalles.Controls.Add(this.lb1);
            this.panelDetalles.Controls.Add(this.lb6);
            this.panelDetalles.Controls.Add(this.lb5);
            this.panelDetalles.Controls.Add(this.lb4);
            this.panelDetalles.Controls.Add(this.lb2);
            this.panelDetalles.Controls.Add(this.lb3);
            this.panelDetalles.Controls.Add(this.txtSinopsis);
            this.panelDetalles.Controls.Add(this.lbSinopsis);
            this.panelDetalles.Controls.Add(this.lbFechaLectura);
            this.panelDetalles.Controls.Add(this.lbPaginas);
            this.panelDetalles.Controls.Add(this.lbISBN);
            this.panelDetalles.Controls.Add(this.lbIdioma);
            this.panelDetalles.Controls.Add(this.lbFormato);
            this.panelDetalles.Controls.Add(this.lbEditorial);
            this.panelDetalles.Controls.Add(this.lbTitulo);
            this.panelDetalles.Controls.Add(this.lbAutor);
            this.panelDetalles.Controls.Add(this.pbPortadaLibro);
            this.panelDetalles.Location = new System.Drawing.Point(23, 450);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(1085, 338);
            this.panelDetalles.TabIndex = 0;
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnEditarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarLibro.FlatAppearance.BorderSize = 0;
            this.btnEditarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLibro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarLibro.Image = global::LifeManager.Properties.Resources.editar_icon;
            this.btnEditarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarLibro.Location = new System.Drawing.Point(227, 293);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditarLibro.Size = new System.Drawing.Size(209, 45);
            this.btnEditarLibro.TabIndex = 28;
            this.btnEditarLibro.Text = "        EDITAR LIBRO";
            this.btnEditarLibro.UseVisualStyleBackColor = false;
            this.btnEditarLibro.Visible = false;
            this.btnEditarLibro.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // btnBorrarLibro
            // 
            this.btnBorrarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBorrarLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarLibro.FlatAppearance.BorderSize = 0;
            this.btnBorrarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarLibro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarLibro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarLibro.Image = global::LifeManager.Properties.Resources.borrar_icon;
            this.btnBorrarLibro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarLibro.Location = new System.Drawing.Point(0, 293);
            this.btnBorrarLibro.Name = "btnBorrarLibro";
            this.btnBorrarLibro.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrarLibro.Size = new System.Drawing.Size(209, 45);
            this.btnBorrarLibro.TabIndex = 27;
            this.btnBorrarLibro.Text = "        BORRAR LIBRO";
            this.btnBorrarLibro.UseVisualStyleBackColor = false;
            this.btnBorrarLibro.Visible = false;
            this.btnBorrarLibro.Click += new System.EventHandler(this.btnBorrarLibro_Click);
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb8.Location = new System.Drawing.Point(198, 238);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(105, 15);
            this.lb8.TabIndex = 26;
            this.lb8.Text = "Fecha Lectura:";
            this.lb8.Visible = false;
            // 
            // lb7
            // 
            this.lb7.AutoSize = true;
            this.lb7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb7.Location = new System.Drawing.Point(198, 206);
            this.lb7.Name = "lb7";
            this.lb7.Size = new System.Drawing.Size(63, 15);
            this.lb7.TabIndex = 25;
            this.lb7.Text = "Páginas:";
            this.lb7.Visible = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb1.Location = new System.Drawing.Point(197, 14);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(43, 15);
            this.lb1.TabIndex = 24;
            this.lb1.Text = "ISBN:";
            this.lb1.Visible = false;
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb6.Location = new System.Drawing.Point(198, 174);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(55, 15);
            this.lb6.TabIndex = 23;
            this.lb6.Text = "Idioma:";
            this.lb6.Visible = false;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb5.Location = new System.Drawing.Point(198, 142);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(66, 15);
            this.lb5.TabIndex = 22;
            this.lb5.Text = "Formato:";
            this.lb5.Visible = false;
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb4.Location = new System.Drawing.Point(198, 110);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(67, 15);
            this.lb4.TabIndex = 21;
            this.lb4.Text = "Editorial:";
            this.lb4.Visible = false;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb2.Location = new System.Drawing.Point(198, 46);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(48, 15);
            this.lb2.TabIndex = 20;
            this.lb2.Text = "Titulo:";
            this.lb2.Visible = false;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lb3.Location = new System.Drawing.Point(198, 78);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(47, 15);
            this.lb3.TabIndex = 19;
            this.lb3.Text = "Autor:";
            this.lb3.Visible = false;
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1130, 800);
            this.Controls.Add(this.panelDetalles);
            this.Controls.Add(this.panelDataGridNotes);
            this.Controls.Add(this.panelBotonesNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBooks";
            this.Text = "frmBooks";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.panelBotonesNotes.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelDataGridNotes.ResumeLayout(false);
            this.panelDataGridNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPortadaLibro)).EndInit();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonesNotes;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearLibro;
        private System.Windows.Forms.Panel panelDataGridNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvListadoLibros;
        private System.Windows.Forms.PictureBox pbPortadaLibro;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFechaLectura;
        private System.Windows.Forms.Label lbPaginas;
        private System.Windows.Forms.Label lbISBN;
        private System.Windows.Forms.Label lbIdioma;
        private System.Windows.Forms.Label lbFormato;
        private System.Windows.Forms.Label lbEditorial;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label lbSinopsis;
        private System.Windows.Forms.Panel panelDetalles;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lb7;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btnEditarLibro;
        private System.Windows.Forms.Button btnBorrarLibro;
    }
}