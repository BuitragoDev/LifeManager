namespace LifeManager
{
    partial class frmPasswords
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
            this.panelContenidoNotes = new System.Windows.Forms.Panel();
            this.btnEditarPassword = new System.Windows.Forms.Button();
            this.btnBorrarPassword = new System.Windows.Forms.Button();
            this.panelDataGridNotes = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbUltimaModificacion = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnRecargar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListadoPasswords = new System.Windows.Forms.DataGridView();
            this.panelBotonesNotes = new System.Windows.Forms.Panel();
            this.panelBuscador = new System.Windows.Forms.Panel();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrearPassword = new System.Windows.Forms.Button();
            this.panelContenidoNotes.SuspendLayout();
            this.panelDataGridNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPasswords)).BeginInit();
            this.panelBotonesNotes.SuspendLayout();
            this.panelBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenidoNotes
            // 
            this.panelContenidoNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenidoNotes.Controls.Add(this.btnEditarPassword);
            this.panelContenidoNotes.Controls.Add(this.btnBorrarPassword);
            this.panelContenidoNotes.Controls.Add(this.panelDataGridNotes);
            this.panelContenidoNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenidoNotes.Location = new System.Drawing.Point(0, 75);
            this.panelContenidoNotes.Name = "panelContenidoNotes";
            this.panelContenidoNotes.Size = new System.Drawing.Size(1130, 725);
            this.panelContenidoNotes.TabIndex = 3;
            // 
            // btnEditarPassword
            // 
            this.btnEditarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnEditarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPassword.FlatAppearance.BorderSize = 0;
            this.btnEditarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEditarPassword.Image = global::LifeManager.Properties.Resources.editar_icon;
            this.btnEditarPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPassword.Location = new System.Drawing.Point(122, 665);
            this.btnEditarPassword.Name = "btnEditarPassword";
            this.btnEditarPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEditarPassword.Size = new System.Drawing.Size(341, 45);
            this.btnEditarPassword.TabIndex = 4;
            this.btnEditarPassword.Text = "EDITAR CONTRASEÑA";
            this.btnEditarPassword.UseVisualStyleBackColor = false;
            this.btnEditarPassword.Visible = false;
            this.btnEditarPassword.Click += new System.EventHandler(this.btnEditarPassword_Click);
            // 
            // btnBorrarPassword
            // 
            this.btnBorrarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnBorrarPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrarPassword.FlatAppearance.BorderSize = 0;
            this.btnBorrarPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarPassword.Image = global::LifeManager.Properties.Resources.borrar_icon;
            this.btnBorrarPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarPassword.Location = new System.Drawing.Point(23, 665);
            this.btnBorrarPassword.Name = "btnBorrarPassword";
            this.btnBorrarPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBorrarPassword.Size = new System.Drawing.Size(65, 45);
            this.btnBorrarPassword.TabIndex = 3;
            this.btnBorrarPassword.UseVisualStyleBackColor = false;
            this.btnBorrarPassword.Visible = false;
            this.btnBorrarPassword.Click += new System.EventHandler(this.btnBorrarPassword_Click);
            // 
            // panelDataGridNotes
            // 
            this.panelDataGridNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelDataGridNotes.Controls.Add(this.label8);
            this.panelDataGridNotes.Controls.Add(this.label7);
            this.panelDataGridNotes.Controls.Add(this.label6);
            this.panelDataGridNotes.Controls.Add(this.txtContrasena);
            this.panelDataGridNotes.Controls.Add(this.txtUsuario);
            this.panelDataGridNotes.Controls.Add(this.txtEmail);
            this.panelDataGridNotes.Controls.Add(this.lbUltimaModificacion);
            this.panelDataGridNotes.Controls.Add(this.pictureBox2);
            this.panelDataGridNotes.Controls.Add(this.btnRecargar);
            this.panelDataGridNotes.Controls.Add(this.label1);
            this.panelDataGridNotes.Controls.Add(this.panel3);
            this.panelDataGridNotes.Location = new System.Drawing.Point(23, 30);
            this.panelDataGridNotes.Name = "panelDataGridNotes";
            this.panelDataGridNotes.Size = new System.Drawing.Size(1082, 617);
            this.panelDataGridNotes.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(587, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(340, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(3, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Correo Electrónico:";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContrasena.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(590, 580);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.ReadOnly = true;
            this.txtContrasena.Size = new System.Drawing.Size(486, 29);
            this.txtContrasena.TabIndex = 7;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(343, 580);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(229, 29);
            this.txtUsuario.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(6, 580);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(321, 29);
            this.txtEmail.TabIndex = 5;
            // 
            // lbUltimaModificacion
            // 
            this.lbUltimaModificacion.AutoSize = true;
            this.lbUltimaModificacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUltimaModificacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbUltimaModificacion.Location = new System.Drawing.Point(3, 531);
            this.lbUltimaModificacion.Name = "lbUltimaModificacion";
            this.lbUltimaModificacion.Size = new System.Drawing.Size(141, 15);
            this.lbUltimaModificacion.TabIndex = 2;
            this.lbUltimaModificacion.Text = "Última modificación:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LifeManager.Properties.Resources.password_icon;
            this.pictureBox2.Location = new System.Drawing.Point(14, 9);
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
            this.btnRecargar.Location = new System.Drawing.Point(1044, 9);
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
            this.label1.Size = new System.Drawing.Size(315, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA DE CONTRASEÑAS";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.dgvListadoPasswords);
            this.panel3.Location = new System.Drawing.Point(6, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1070, 473);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 30);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(676, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(461, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(227, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Web / Programa";
            // 
            // dgvListadoPasswords
            // 
            this.dgvListadoPasswords.AllowUserToAddRows = false;
            this.dgvListadoPasswords.AllowUserToDeleteRows = false;
            this.dgvListadoPasswords.AllowUserToResizeColumns = false;
            this.dgvListadoPasswords.AllowUserToResizeRows = false;
            this.dgvListadoPasswords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoPasswords.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvListadoPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvListadoPasswords.Location = new System.Drawing.Point(12, 45);
            this.dgvListadoPasswords.MultiSelect = false;
            this.dgvListadoPasswords.Name = "dgvListadoPasswords";
            this.dgvListadoPasswords.ReadOnly = true;
            this.dgvListadoPasswords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListadoPasswords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoPasswords.Size = new System.Drawing.Size(1047, 417);
            this.dgvListadoPasswords.TabIndex = 0;
            // 
            // panelBotonesNotes
            // 
            this.panelBotonesNotes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBotonesNotes.Controls.Add(this.panelBuscador);
            this.panelBotonesNotes.Controls.Add(this.btnCrearPassword);
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
            // btnCrearPassword
            // 
            this.btnCrearPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnCrearPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPassword.FlatAppearance.BorderSize = 0;
            this.btnCrearPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCrearPassword.Image = global::LifeManager.Properties.Resources.anadir_icon;
            this.btnCrearPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearPassword.Location = new System.Drawing.Point(23, 12);
            this.btnCrearPassword.Name = "btnCrearPassword";
            this.btnCrearPassword.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCrearPassword.Size = new System.Drawing.Size(310, 50);
            this.btnCrearPassword.TabIndex = 1;
            this.btnCrearPassword.Text = "        CREAR UNA CONTRASEÑA";
            this.btnCrearPassword.UseVisualStyleBackColor = false;
            this.btnCrearPassword.Click += new System.EventHandler(this.btnCrearPassword_Click);
            // 
            // frmPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 800);
            this.Controls.Add(this.panelContenidoNotes);
            this.Controls.Add(this.panelBotonesNotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPasswords";
            this.Text = "frmPasswords";
            this.Load += new System.EventHandler(this.frmPasswords_Load);
            this.panelContenidoNotes.ResumeLayout(false);
            this.panelDataGridNotes.ResumeLayout(false);
            this.panelDataGridNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRecargar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoPasswords)).EndInit();
            this.panelBotonesNotes.ResumeLayout(false);
            this.panelBuscador.ResumeLayout(false);
            this.panelBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenidoNotes;
        private System.Windows.Forms.Label lbUltimaModificacion;
        private System.Windows.Forms.Button btnEditarPassword;
        private System.Windows.Forms.Button btnBorrarPassword;
        private System.Windows.Forms.Panel panelDataGridNotes;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnRecargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvListadoPasswords;
        private System.Windows.Forms.Panel panelBotonesNotes;
        private System.Windows.Forms.Panel panelBuscador;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrearPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
    }
}