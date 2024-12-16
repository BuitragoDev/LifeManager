namespace LifeManager.Vista
{
    partial class frmCrearNota
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFuente = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardarNota = new System.Windows.Forms.Button();
            this.txtContenido = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnFuente);
            this.panel1.Controls.Add(this.btnCursiva);
            this.panel1.Controls.Add(this.btnNegrita);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnGuardarNota);
            this.panel1.Controls.Add(this.txtContenido);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTitulo);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 526);
            this.panel1.TabIndex = 0;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Image = global::LifeManager.Properties.Resources.color_icon;
            this.btnColor.Location = new System.Drawing.Point(899, 107);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(45, 45);
            this.btnColor.TabIndex = 17;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFuente
            // 
            this.btnFuente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFuente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuente.Image = global::LifeManager.Properties.Resources.fuente_icon;
            this.btnFuente.Location = new System.Drawing.Point(848, 107);
            this.btnFuente.Name = "btnFuente";
            this.btnFuente.Size = new System.Drawing.Size(45, 45);
            this.btnFuente.TabIndex = 16;
            this.btnFuente.UseVisualStyleBackColor = false;
            this.btnFuente.Click += new System.EventHandler(this.btnFuente_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCursiva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCursiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursiva.Image = global::LifeManager.Properties.Resources.cursiva_icon;
            this.btnCursiva.Location = new System.Drawing.Point(797, 107);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(45, 45);
            this.btnCursiva.TabIndex = 15;
            this.btnCursiva.UseVisualStyleBackColor = false;
            this.btnCursiva.Click += new System.EventHandler(this.btnCursiva_Click);
            // 
            // btnNegrita
            // 
            this.btnNegrita.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNegrita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNegrita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegrita.Image = global::LifeManager.Properties.Resources.negrita_icon;
            this.btnNegrita.Location = new System.Drawing.Point(746, 107);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(45, 45);
            this.btnNegrita.TabIndex = 14;
            this.btnNegrita.UseVisualStyleBackColor = false;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(13, 467);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(175, 51);
            this.btnLimpiar.TabIndex = 13;
            this.btnLimpiar.Text = "        LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarNota
            // 
            this.btnGuardarNota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnGuardarNota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarNota.FlatAppearance.BorderSize = 0;
            this.btnGuardarNota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNota.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarNota.Image = global::LifeManager.Properties.Resources.guardar_icon;
            this.btnGuardarNota.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarNota.Location = new System.Drawing.Point(735, 467);
            this.btnGuardarNota.Name = "btnGuardarNota";
            this.btnGuardarNota.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGuardarNota.Size = new System.Drawing.Size(209, 51);
            this.btnGuardarNota.TabIndex = 12;
            this.btnGuardarNota.Text = "        GUARDAR NOTA";
            this.btnGuardarNota.UseVisualStyleBackColor = false;
            this.btnGuardarNota.Visible = false;
            this.btnGuardarNota.Click += new System.EventHandler(this.btnGuardarNota_Click);
            // 
            // txtContenido
            // 
            this.txtContenido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContenido.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenido.Location = new System.Drawing.Point(13, 156);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(931, 295);
            this.txtContenido.TabIndex = 11;
            this.txtContenido.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label3.Location = new System.Drawing.Point(11, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contenido de la nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Título de la nota (máx. 40 caracteres):";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.txtTitulo.Location = new System.Drawing.Point(13, 70);
            this.txtTitulo.MaxLength = 40;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(931, 29);
            this.txtTitulo.TabIndex = 9;
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
            this.label1.Size = new System.Drawing.Size(259, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREAR UNA NUEVA NOTA";
            // 
            // frmCrearNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(982, 550);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearNota";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCrearNota_FormClosed);
            this.Load += new System.EventHandler(this.frmCrearNota_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtContenido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardarNota;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnFuente;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnColor;
    }
}