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
    public partial class frmCrearNota : Form
    {
        NotaLogica logica = new NotaLogica();
        public event Action OnFormClosedEvent;  // Evento para notificar el cierre
        public int Interruptor { get; set; }  // Esta propiedad indicará si estamos creando o editando
        public int IdNota { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }

        public frmCrearNota()
        {
            InitializeComponent();
        }

        private void frmCrearNota_Load(object sender, EventArgs e)
        {
            // Suscribirse a los eventos TextChanged de los campos de texto
            txtTitulo.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtContenido.TextChanged += new EventHandler(txtCampos_TextChanged);

            if (Interruptor == 1) // Si estamos editando
            {
                txtTitulo.Text = Titulo;
                txtContenido.Rtf = Contenido;
                btnGuardarNota.Text = "        EDITAR NOTA";
            }
        }

        private void frmCrearNota_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosedEvent?.Invoke(); // Notificar a frmNotes para recargar el DataGrid
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón GUARDAR NOTA
        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            frmNotes notas = new frmNotes();

            // Crear la nota
            Nota nuevaNota = new Nota
            {
                Id = IdNota,
                Titulo = txtTitulo.Text,
                Contenido = txtContenido.Rtf,
                FechaModificacion = null // Inicialmente, no modificada
            };

            if (Interruptor == 1) // Si estamos editando
            {
                logica.ActualizarUnaNota(nuevaNota);

                MessageBox.Show("Nota actualizada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else // Si estamos creando una nueva nota
            {
                // Aquí puedes guardar la nota en la base de datos
                logica.CrearNota(nuevaNota);

                MessageBox.Show("Nota guardada exitosamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtContenido.Text = "";
        }

        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            // Verificar si tanto el título como el contenido tienen texto
            if (!string.IsNullOrWhiteSpace(txtTitulo.Text) && !string.IsNullOrWhiteSpace(txtContenido.Text))
            {
                // Mostrar el botón si ambos campos tienen texto
                btnGuardarNota.Visible = true;
            }
            else
            {
                // Si alguno de los campos está vacío, ocultar el botón
                btnGuardarNota.Visible = false;
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón NEGRITA
        private void btnNegrita_Click(object sender, EventArgs e)
        {
            if (txtContenido.SelectionFont != null)
            {
                // Cambiar la fuente a negrita
                FontStyle newStyle = txtContenido.SelectionFont.Style ^ FontStyle.Bold;
                txtContenido.SelectionFont = new Font(txtContenido.SelectionFont, newStyle);
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CURSIVA
        private void btnCursiva_Click(object sender, EventArgs e)
        {
            if (txtContenido.SelectionFont != null)
            {
                // Cambiar la fuente a cursiva
                FontStyle newStyle = txtContenido.SelectionFont.Style ^ FontStyle.Italic;
                txtContenido.SelectionFont = new Font(txtContenido.SelectionFont, newStyle);
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón FUENTE
        private void btnFuente_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para seleccionar la fuente
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cambiar la fuente del texto seleccionado
                    txtContenido.SelectionFont = fontDialog.Font;
                }
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón COLOR
        private void btnColor_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para seleccionar un color
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Cambiar el color del texto seleccionado
                    txtContenido.SelectionColor = colorDialog.Color;
                }
            }
        }
    }
}
