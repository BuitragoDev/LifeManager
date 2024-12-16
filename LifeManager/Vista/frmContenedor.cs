using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Vista
{
    public partial class frmContenedor : Form
    {
        public frmContenedor()
        {
            InitializeComponent();
        }

        // Evento LOAD del formulario
        private void frmContenedor_Load(object sender, EventArgs e)
        {
            // Configurar la base de datos en la carpeta "Mis Documentos"
            string dbPath = SetupDatabase();

            frmHome home = new frmHome(this); // Pasamos la instancia al formulario Home.

            AbrirFormInPanel(home);
            btnHome.BackColor = System.Drawing.Color.SandyBrown;
            ToggleButtons(panelSidebar, "btnHome"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón SALIR
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas salir de la aplicación?",
                                                         "Confirmación salida de la Aplicación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

            // Si el usuario selecciona "Sí", proceder a borrar la nota
            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        // Evento CLICK del botón MENU
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelSidebar.Width == 270)
            {
                panelSidebar.Width = 90;
            } else
            {
                panelSidebar.Width = 270;
            }
        }

        // Evento CLICK del botón HOME
        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome(this); // Pasamos la instancia al formulario Home.

            AbrirFormInPanel(home);

            ToggleButtons(panelSidebar, "btnHome"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón NOTES
        private void btnNotes_Click(object sender, EventArgs e)
        {
            frmNotes notes = new frmNotes(this); // Pasamos la instancia al formulario Home.
            AbrirFormInPanel(notes);

            ToggleButtons(panelSidebar, "btnNotes"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón BOOKS
        private void btnBooks_Click(object sender, EventArgs e)
        {
            frmBooks books = new frmBooks(this); // Pasamos la instancia al formulario Home.
            AbrirFormInPanel(books);

            ToggleButtons(panelSidebar, "btnBooks"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón MOVIES
        private void btnMovies_Click(object sender, EventArgs e)
        {
            frmMovies movies = new frmMovies(this); // Pasamos la instancia al formulario Home.
            AbrirFormInPanel(movies);

            ToggleButtons(panelSidebar, "btnMovies"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón TV SERIES
        private void btnTVseries_Click(object sender, EventArgs e)
        {
            frmSeries series = new frmSeries(this); // Pasamos la instancia al formulario Home.
            AbrirFormInPanel(series);

            ToggleButtons(panelSidebar, "btnTVseries"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón PASSWORDS
        private void btnPasswords_Click(object sender, EventArgs e)
        {
            frmPasswords passwords = new frmPasswords(this); // Pasamos la instancia al formulario Home.
            AbrirFormInPanel(passwords);

            ToggleButtons(panelSidebar, "btnPasswords"); // Llamada al botón que activa/desactiva botones
        }

        // Evento CLICK del botón SETTINGS
        private void btnSettings_Click(object sender, EventArgs e)
        {
            ToggleButtons(panelSidebar, "btnSettings"); // Llamada al botón que activa/desactiva botones
        }

        #region "Métodos"
        // Método que se encarga de abrir los formularios hijos
        public void AbrirFormInPanel(object FormHijo)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);

            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();
        }
        // Método que se encarga de desactivar el botón que pasamos por parámetro y activar el resto del Menu.
        private void ToggleButtons(Panel panel, string buttonToDisableName)
        {
            foreach (Control control in panel.Controls)
            {
                // Verificar que el control es un botón
                if (control is Button button)
                {
                    // Si el botón coincide con el que queremos desactivar
                    if (button.Name == buttonToDisableName && button.Name != "btnSettings")
                    {
                        button.Enabled = false; // Desactivar el botón
                        button.BackColor = System.Drawing.Color.SandyBrown;
                    }
                    else
                    {
                        button.Enabled = true; // Activar los demás
                        button.BackColor = System.Drawing.Color.FromArgb(35, 40, 45);
                    }
                }
            }
        }

        // Clase para manejar la inicialización de la base de datos
        public static string SetupDatabase()
        {
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbFolder = Path.Combine(documentsPath, "Life Manager", "db");
            string dbFileName = "lifeManagerDB.db";
            string dbFilePath = Path.Combine(dbFolder, dbFileName);

            // Verificar si la carpeta y el archivo existen
            if (!Directory.Exists(dbFolder))
            {
                Directory.CreateDirectory(dbFolder);
            }

            if (!File.Exists(dbFilePath))
            {
                string sourceDbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, dbFileName);
                File.Copy(sourceDbPath, dbFilePath);
            }

            return dbFilePath;
        }
        #endregion
    }
}
