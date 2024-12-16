namespace LifeManager.Vista
{
    partial class frmContenedor
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
            this.panelSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnTVseries = new System.Windows.Forms.Button();
            this.btnPasswords = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panelSidebar.Controls.Add(this.panel1);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Controls.Add(this.btnNotes);
            this.panelSidebar.Controls.Add(this.btnBooks);
            this.panelSidebar.Controls.Add(this.btnMovies);
            this.panelSidebar.Controls.Add(this.btnTVseries);
            this.panelSidebar.Controls.Add(this.btnPasswords);
            this.panelSidebar.Controls.Add(this.btnSettings);
            this.panelSidebar.Controls.Add(this.btnSalir);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(270, 800);
            this.panelSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 91);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LifeManager.Properties.Resources.logoMini;
            this.pictureBox1.Location = new System.Drawing.Point(78, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::LifeManager.Properties.Resources.menu_icon;
            this.btnMenu.Location = new System.Drawing.Point(23, 29);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 32);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHome.Image = global::LifeManager.Properties.Resources.home_icon;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 100);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(267, 74);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "              Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotes.FlatAppearance.BorderSize = 0;
            this.btnNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNotes.Image = global::LifeManager.Properties.Resources.notebook_icon;
            this.btnNotes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.Location = new System.Drawing.Point(3, 180);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNotes.Size = new System.Drawing.Size(267, 74);
            this.btnNotes.TabIndex = 3;
            this.btnNotes.Text = "              Notas";
            this.btnNotes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBooks.Image = global::LifeManager.Properties.Resources.books_icon;
            this.btnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.Location = new System.Drawing.Point(3, 260);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnBooks.Size = new System.Drawing.Size(267, 74);
            this.btnBooks.TabIndex = 4;
            this.btnBooks.Text = "              Libros";
            this.btnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnMovies
            // 
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMovies.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMovies.Image = global::LifeManager.Properties.Resources.movies_icon;
            this.btnMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.Location = new System.Drawing.Point(3, 340);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnMovies.Size = new System.Drawing.Size(267, 74);
            this.btnMovies.TabIndex = 5;
            this.btnMovies.Text = "              Películas";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnTVseries
            // 
            this.btnTVseries.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTVseries.FlatAppearance.BorderSize = 0;
            this.btnTVseries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTVseries.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTVseries.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTVseries.Image = global::LifeManager.Properties.Resources.tvseries_icon;
            this.btnTVseries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTVseries.Location = new System.Drawing.Point(3, 420);
            this.btnTVseries.Name = "btnTVseries";
            this.btnTVseries.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnTVseries.Size = new System.Drawing.Size(267, 74);
            this.btnTVseries.TabIndex = 6;
            this.btnTVseries.Text = "              Series TV";
            this.btnTVseries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTVseries.UseVisualStyleBackColor = true;
            this.btnTVseries.Click += new System.EventHandler(this.btnTVseries_Click);
            // 
            // btnPasswords
            // 
            this.btnPasswords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPasswords.FlatAppearance.BorderSize = 0;
            this.btnPasswords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPasswords.Image = global::LifeManager.Properties.Resources.password_icon;
            this.btnPasswords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswords.Location = new System.Drawing.Point(3, 500);
            this.btnPasswords.Name = "btnPasswords";
            this.btnPasswords.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPasswords.Size = new System.Drawing.Size(267, 74);
            this.btnPasswords.TabIndex = 7;
            this.btnPasswords.Text = "              Contraseñas";
            this.btnPasswords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswords.UseVisualStyleBackColor = true;
            this.btnPasswords.Click += new System.EventHandler(this.btnPasswords_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnSettings.Enabled = false;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 580);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(267, 138);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Image = global::LifeManager.Properties.Resources.salir_icon;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(3, 724);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(267, 74);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "              Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(270, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1130, 800);
            this.panelPrincipal.TabIndex = 2;
            // 
            // frmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmContenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmContenedor";
            this.Load += new System.EventHandler(this.frmContenedor_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnTVseries;
        private System.Windows.Forms.Button btnPasswords;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
    }
}