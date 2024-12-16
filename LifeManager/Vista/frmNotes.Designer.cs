namespace LifeManager.Vista
{
    partial class frmNotes
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
            this.btnCrearNota = new System.Windows.Forms.Button();
            this.panelContenidoNotes = new System.Windows.Forms.Panel();
            this.lbUltimaModificacion = new System.Windows.Forms.Label();
            this.btnEditarNota = new System.Windows.Forms.Button();
            this.btnBorrarNota = new System.Windows.Forms.Button();
            this.panelNoteDetails = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtContentNote = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNoteTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbNoteTitle = new System.Windows.Forms.Label();
            this.panelDataGridNotes = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvListadoNotas = new System.Windows.Forms.DataGridView();
            this.panelBotonesNotes.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.panelContenidoNotes.SuspendLayout();
            this.panelNoteDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNoteTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDataGridNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotonesNotes
            // 
            this.panelBotonesNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotonesNotes.Controls.Add(this.panelBuscador);
            this.panelBotonesNotes.Controls.Add(this.btnCrearNota);
            this.panelBotonesNotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBotonesNotes.Location = new System.Drawing.Point(0, 0);
            this.panelBotonesNotes.Name = "panelBotonesNotes";
            this.panelBotonesNotes.Size = new System.Drawing.Size(1130, 75);
            this.panelBotonesNotes.TabIndex = 0;
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
            this.txtBuscador.MaxLength = 25;
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
            // btnCrearNota
            // 
            this.btnCrearNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCrearNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearNota.FlatAppearance.BorderSize = 0;
            this.btnCrearNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearNota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearNota.Image = global::LifeManager.Properties.Resources.anadir_icon;
            this.btnCrearNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearNota.Location = new System.Drawing.Point(23, 12);
            this.btnCrearNota.Name = "btnCrearNota";
            this.btnCrearNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCrearNota.Size = new System.Drawing.Size(232, 50);
            this.btnCrearNota.TabIndex = 1;
            this.btnCrearNota.Text = "        CREAR UNA NOTA";
            this.btnCrearNota.UseVisualStyleBackColor = false;
            this.btnCrearNota.Click += new System.EventHandler(this.btnCrearNota_Click);
            // 
            // panelContenidoNotes
            // 
            this.panelContenidoNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenidoNotes.Controls.Add(this.lbUltimaModificacion);
            this.panelContenidoNotes.Controls.Add(this.btnEditarNota);
            this.panelContenidoNotes.Controls.Add(this.btnBorrarNota);
            this.panelContenidoNotes.Controls.Add(this.panelNoteDetails);
            this.panelContenidoNotes.Controls.Add(this.panelDataGridNotes);
            this.panelContenidoNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoNotes.Location = new System.Drawing.Point(0, 75);
            this.panelContenidoNotes.Name = "panelContenidoNotes";
            this.panelContenidoNotes.Size = new System.Drawing.Size(1130, 725);
            this.panelContenidoNotes.TabIndex = 1;
            // 
            // lbUltimaModificacion
            // 
            this.lbUltimaModificacion.AutoSize = true;
            this.lbUltimaModificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltimaModificacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.lbUltimaModificacion.Location = new System.Drawing.Point(489, 665);
            this.lbUltimaModificacion.Name = "lbUltimaModificacion";
            this.lbUltimaModificacion.Size = new System.Drawing.Size(141, 15);
            this.lbUltimaModificacion.TabIndex = 2;
            this.lbUltimaModificacion.Text = "Última modificación:";
            // 
            // btnEditarNota
            // 
            this.btnEditarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnEditarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarNota.FlatAppearance.BorderSize = 0;
            this.btnEditarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarNota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarNota.Image = global::LifeManager.Properties.Resources.editar_icon;
            this.btnEditarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarNota.Location = new System.Drawing.Point(250, 668);
            this.btnEditarNota.Name = "btnEditarNota";
            this.btnEditarNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditarNota.Size = new System.Drawing.Size(209, 45);
            this.btnEditarNota.TabIndex = 4;
            this.btnEditarNota.Text = "        EDITAR NOTA";
            this.btnEditarNota.UseVisualStyleBackColor = false;
            this.btnEditarNota.Visible = false;
            this.btnEditarNota.Click += new System.EventHandler(this.btnEditarNota_Click);
            // 
            // btnBorrarNota
            // 
            this.btnBorrarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBorrarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarNota.FlatAppearance.BorderSize = 0;
            this.btnBorrarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarNota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarNota.Image = global::LifeManager.Properties.Resources.borrar_icon;
            this.btnBorrarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarNota.Location = new System.Drawing.Point(23, 668);
            this.btnBorrarNota.Name = "btnBorrarNota";
            this.btnBorrarNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrarNota.Size = new System.Drawing.Size(209, 45);
            this.btnBorrarNota.TabIndex = 3;
            this.btnBorrarNota.Text = "        BORRAR NOTA";
            this.btnBorrarNota.UseVisualStyleBackColor = false;
            this.btnBorrarNota.Visible = false;
            this.btnBorrarNota.Click += new System.EventHandler(this.btnBorrarNota_Click);
            // 
            // panelNoteDetails
            // 
            this.panelNoteDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNoteDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelNoteDetails.Controls.Add(this.panel2);
            this.panelNoteDetails.Controls.Add(this.panel1);
            this.panelNoteDetails.Controls.Add(this.panelNoteTitle);
            this.panelNoteDetails.Location = new System.Drawing.Point(492, 30);
            this.panelNoteDetails.Name = "panelNoteDetails";
            this.panelNoteDetails.Size = new System.Drawing.Size(616, 631);
            this.panelNoteDetails.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.txtContentNote);
            this.panel2.Location = new System.Drawing.Point(6, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 577);
            this.panel2.TabIndex = 0;
            // 
            // txtContentNote
            // 
            this.txtContentNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContentNote.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContentNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContentNote.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContentNote.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtContentNote.Location = new System.Drawing.Point(14, 13);
            this.txtContentNote.Name = "txtContentNote";
            this.txtContentNote.ReadOnly = true;
            this.txtContentNote.Size = new System.Drawing.Size(576, 551);
            this.txtContentNote.TabIndex = 0;
            this.txtContentNote.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 577);
            this.panel1.TabIndex = 6;
            // 
            // panelNoteTitle
            // 
            this.panelNoteTitle.Controls.Add(this.pictureBox1);
            this.panelNoteTitle.Controls.Add(this.lbNoteTitle);
            this.panelNoteTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoteTitle.Location = new System.Drawing.Point(0, 0);
            this.panelNoteTitle.Name = "panelNoteTitle";
            this.panelNoteTitle.Size = new System.Drawing.Size(616, 43);
            this.panelNoteTitle.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LifeManager.Properties.Resources.chincheta_icon;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbNoteTitle
            // 
            this.lbNoteTitle.AutoSize = true;
            this.lbNoteTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoteTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNoteTitle.Location = new System.Drawing.Point(43, 14);
            this.lbNoteTitle.Name = "lbNoteTitle";
            this.lbNoteTitle.Size = new System.Drawing.Size(158, 22);
            this.lbNoteTitle.TabIndex = 1;
            this.lbNoteTitle.Text = "Título de la Nota";
            // 
            // panelDataGridNotes
            // 
            this.panelDataGridNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelDataGridNotes.Controls.Add(this.pictureBox2);
            this.panelDataGridNotes.Controls.Add(this.btnRecargar);
            this.panelDataGridNotes.Controls.Add(this.label1);
            this.panelDataGridNotes.Controls.Add(this.panel3);
            this.panelDataGridNotes.Location = new System.Drawing.Point(23, 30);
            this.panelDataGridNotes.Name = "panelDataGridNotes";
            this.panelDataGridNotes.Size = new System.Drawing.Size(440, 631);
            this.panelDataGridNotes.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LifeManager.Properties.Resources.libreta_icon;
            this.pictureBox2.Location = new System.Drawing.Point(14, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnRecargar
            // 
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.Image = global::LifeManager.Properties.Resources.recargar_icon;
            this.btnRecargar.Location = new System.Drawing.Point(395, 8);
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
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE ANOTACIONES";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.dgvListadoNotas);
            this.panel3.Location = new System.Drawing.Point(5, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(429, 577);
            this.panel3.TabIndex = 0;
            // 
            // dgvListadoNotas
            // 
            this.dgvListadoNotas.AllowUserToAddRows = false;
            this.dgvListadoNotas.AllowUserToDeleteRows = false;
            this.dgvListadoNotas.AllowUserToResizeColumns = false;
            this.dgvListadoNotas.AllowUserToResizeRows = false;
            this.dgvListadoNotas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListadoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListadoNotas.Location = new System.Drawing.Point(8, 13);
            this.dgvListadoNotas.MultiSelect = false;
            this.dgvListadoNotas.Name = "dgvListadoNotas";
            this.dgvListadoNotas.ReadOnly = true;
            this.dgvListadoNotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoNotas.Size = new System.Drawing.Size(413, 551);
            this.dgvListadoNotas.TabIndex = 0;
            this.dgvListadoNotas.SelectionChanged += new System.EventHandler(this.dgvListadoNotas_SelectionChanged);
            // 
            // frmNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1130, 800);
            this.Controls.Add(this.panelContenidoNotes);
            this.Controls.Add(this.panelBotonesNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotes";
            this.Text = "frmNotes";
            this.Load += new System.EventHandler(this.frmNotes_Load);
            this.panelBotonesNotes.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.panelContenidoNotes.ResumeLayout(false);
            this.panelContenidoNotes.PerformLayout();
            this.panelNoteDetails.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelNoteTitle.ResumeLayout(false);
            this.panelNoteTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDataGridNotes.ResumeLayout(false);
            this.panelDataGridNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotonesNotes;
        private System.Windows.Forms.Panel panelContenidoNotes;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearNota;
        private System.Windows.Forms.Panel panelNoteDetails;
        private System.Windows.Forms.Panel panelDataGridNotes;
        private System.Windows.Forms.Button btnBorrarNota;
        private System.Windows.Forms.Button btnEditarNota;
        private System.Windows.Forms.RichTextBox txtContentNote;
        private System.Windows.Forms.Panel panelNoteTitle;
        private System.Windows.Forms.DataGridView dgvListadoNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoteTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.Label lbUltimaModificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}