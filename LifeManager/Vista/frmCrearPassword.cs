using LifeManager.Entidades;
using LifeManager.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Vista
{
    public partial class frmCrearPassword : Form
    {

        PasswordLogica logica = new PasswordLogica();
        public event Action OnFormClosedEvent;  // Evento para notificar el cierre
        public int Interruptor { get; set; }  // Esta propiedad indicará si estamos creando o editando
        public int IdPass { get; set; }
        public string Titulo { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }

        public frmCrearPassword()
        {
            InitializeComponent();
        }

        private void frmCrearPassword_Load(object sender, EventArgs e)
        {
            // Suscribirse a los eventos TextChanged de los campos de texto
            txtTitulo.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtEmail.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtUsuario.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtContrasena.TextChanged += new EventHandler(txtCampos_TextChanged);

            if (Interruptor == 1) // Si estamos editando
            {
                txtTitulo.Text = Titulo;
                txtEmail.Text = Email;
                txtUsuario.Text = Usuario;
                txtContrasena.Text = Pass;
;
                btnGuardarContrasena.Text = "        EDITAR CONTRASEÑA";
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            // Verificar si tanto el título como el contenido tienen texto
            if (!string.IsNullOrWhiteSpace(txtTitulo.Text) && (!string.IsNullOrWhiteSpace(txtEmail.Text) || !string.IsNullOrWhiteSpace(txtUsuario.Text)) && !string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                // Mostrar el botón si ambos campos tienen texto
                btnGuardarContrasena.Visible = true;
            }
            else
            {
                // Si alguno de los campos está vacío, ocultar el botón
                btnGuardarContrasena.Visible = false;
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón GUARDAR CONTRASEÑA
        private void btnGuardarContrasena_Click(object sender, EventArgs e)
        {
            frmPasswords passwords = new frmPasswords();

            // Crear la nota
            Password nuevaContrasena = new Password
            {
                idPass = IdPass,
                titulo = txtTitulo.Text,
                email = txtEmail.Text,
                usuario = txtUsuario.Text,
                pass = txtContrasena.Text,
                fechaModificacion = null // Inicialmente, no modificada
            };

            if (Interruptor == 1) // Si estamos editando
            {
                logica.ActualizarUnaContrasena(nuevaContrasena);

                MessageBox.Show("Contraseña actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else // Si estamos creando una nueva nota
            {
                // Aquí puedes guardar la nota en la base de datos
                logica.CrearContrasena(nuevaContrasena);

                MessageBox.Show("Contraseña guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
