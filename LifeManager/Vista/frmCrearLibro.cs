using LifeManager.Entidades;
using LifeManager.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LifeManager.Vista
{
    public partial class frmCrearLibro : Form
    {
        LibroLogica logica = new LibroLogica();
        int numero;
        private System.Drawing.Image nuevaImagenPortada = null; // Variable para almacenar la nueva imagen temporalmente

        public event Action OnFormClosedEvent;  // Evento para notificar el cierre
        public int Interruptor { get; set; }  // Esta propiedad indicará si estamos creando o editando
        public string Isbn { get; set; }

        public frmCrearLibro()
        {
            InitializeComponent();

            txtTituloLibro.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtAutorLibro.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtEditorial.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtPaginas.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtFechaLectura.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtISBN.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtSinopsis.TextChanged += new EventHandler(txtCampos_TextChanged);
            cbIdioma.TextChanged += new EventHandler(txtCampos_TextChanged);
            cbFormato.TextChanged += new EventHandler(txtCampos_TextChanged);
        }

        // -------------------------------------------------------------------------------- Evento LOAD del formulario
        private void frmCrearLibro_Load(object sender, EventArgs e)
        {
            numero = logica.ObtenerUltimoIdLibro(); // Cargamos el último ID en la base de datos
            cbFormato.SelectedIndex = 0;
            cbIdioma.SelectedIndex = 0;

            if (Interruptor == 1) // Si estamos editando
            {
                txtISBN.Enabled = false;
                
                // Crear un objeto Libro con los datos de la base de datos
                Libro editarLibro = logica.MostrarDetallesLibro(Isbn);

                // Cargar el formulario
                txtISBN.Text = editarLibro.Isbn;
                txtTituloLibro.Text = editarLibro.Titulo;
                txtAutorLibro.Text = editarLibro.Autor;
                txtEditorial.Text = editarLibro.Editorial;
                txtPaginas.Text = editarLibro.Paginas.ToString();
                cbIdioma.Text = editarLibro.Idioma;
                cbFormato.Text = editarLibro.Formato;
                txtFechaLectura.Text = editarLibro.FechaLectura.Value.ToString("yyyy/MM/dd");
                txtSinopsis.Text = editarLibro.Sinopsis;

                // Imagen Portada
                string rutaPortadas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "libros_portadas");
                string nombreArchivo = $"{editarLibro.Isbn}.png";
                string rutaDestino = Path.Combine(rutaPortadas, nombreArchivo);
                pbPortadaLibro.Visible = true;
                pbPortadaLibro.Image = CargarImagenSinBloqueo(rutaDestino);
                nuevaImagenPortada = CargarImagenSinBloqueo(rutaDestino);

                btnGuardarLibro.Visible = true;
                btnGuardarLibro.Text = "        EDITAR LIBRO";
            }
        }

        private void frmCrearLibro_FormClosed(object sender, FormClosedEventArgs e)
        {
            OnFormClosedEvent?.Invoke();
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CARGAR IMAGEN
        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Filtrar solo imágenes PNG
                openFileDialog.Filter = "Imagenes PNG (*.png)|*.png";
                openFileDialog.Title = "Seleccionar imagen PNG";

                // Mostrar el cuadro de diálogo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Cargar la imagen seleccionada en la variable temporal
                        nuevaImagenPortada = System.Drawing.Image.FromFile(openFileDialog.FileName);

                        // Asignar la nueva imagen al PictureBox para mostrarla al usuario
                        pbPortadaLibro.Image = nuevaImagenPortada;

                        // Llamar a la función de validación para verificar los cambios
                        txtCampos_TextChanged(null, null);  // Llamamos manualmente al evento de cambio de texto
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                    }
                }
            }

        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CALENDARIO
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            // Mostrar el DateTimePicker cerca del botón o el campo de texto
            dateTimePickerLectura.Visible = true;
            dateTimePickerLectura.Focus();
        }

        private void dateTimePickerLectura_CloseUp(object sender, EventArgs e)
        {
            // Actualizar el campo de texto con la fecha seleccionada
            txtFechaLectura.Text = dateTimePickerLectura.Value.ToString("yyyy-MM-dd");

            // Ocultar el DateTimePicker después de seleccionar la fecha
            dateTimePickerLectura.Visible = false;
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón GUARDAR LIBRO
        private void btnGuardarLibro_Click(object sender, EventArgs e)
        {
            // Crear un objeto Libro con los datos del formulario
            Libro nuevoLibro = new Libro
            {
                Isbn = txtISBN.Text.Trim(),
                Titulo = txtTituloLibro.Text.Trim(),
                Autor = txtAutorLibro.Text.Trim(),
                Editorial = txtEditorial.Text.Trim(),
                Paginas = int.TryParse(txtPaginas.Text.Trim(), out int paginas) ? paginas : 0,
                Idioma = cbIdioma.Text.Trim(),
                Formato = cbFormato.Text.Trim(),
                FechaLectura = DateTime.TryParse(txtFechaLectura.Text.Trim(), out DateTime fecha) ? fecha : (DateTime?)null,
                Sinopsis = txtSinopsis.Text.Trim() // Si tienes un campo para la sinopsis
            };

            if (Interruptor == 1) // Si estamos editando
            {
                try
                {
                    // Verificar si la imagen temporal nuevaImagenPortada está cargada
                    if (nuevaImagenPortada != null)
                    {
                        // Verificar la ruta de destino
                        string rutaEscudos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "libros_portadas");
                        string nombreArchivo = $"{nuevoLibro.Isbn}.png";
                        string rutaDestino = Path.Combine(rutaEscudos, nombreArchivo);

                        // Verificar si la carpeta de destino existe
                        if (!Directory.Exists(rutaEscudos))
                        {
                            try
                            {
                                Directory.CreateDirectory(rutaEscudos); // Crear carpeta si no existe
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al crear la carpeta de destino: {ex.Message}");
                                return;
                            }
                        }

                        try
                        {
                            // Verificar si la imagen es válida antes de intentar guardarla
                            if (nuevaImagenPortada == null)
                            {
                                MessageBox.Show("La imagen cargada no es válida.");
                                return;
                            }

                            // Intentar guardar la imagen
                            nuevaImagenPortada.Save(rutaDestino, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha cargado ninguna imagen.");
                    }

                    // Llamar al método para guardar el libro en la base de datos
                    logica.ActualizarUnLibro(nuevoLibro);

                    // Confirmar que el libro fue guardado
                    MessageBox.Show("Libro editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el Formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    MessageBox.Show($"Ocurrió un error al guardar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Si estamos creando un nuevo libro
            {
                try
                {
                    // Verificar si la imagen temporal nuevaImagenPortada está cargada
                    if (nuevaImagenPortada != null)
                    {
                        // Verificar la ruta de destino
                        string rutaEscudos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "libros_portadas");
                        string nombreArchivo = $"{nuevoLibro.Isbn}.png";
                        string rutaDestino = Path.Combine(rutaEscudos, nombreArchivo);

                        // Verificar si la carpeta de destino existe
                        if (!Directory.Exists(rutaEscudos))
                        {
                            try
                            {
                                Directory.CreateDirectory(rutaEscudos); // Crear carpeta si no existe
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error al crear la carpeta de destino: {ex.Message}");
                                return;
                            }
                        }

                        try
                        {
                            // Verificar si la imagen es válida antes de intentar guardarla
                            if (nuevaImagenPortada == null)
                            {
                                MessageBox.Show("La imagen cargada no es válida.");
                                return;
                            }

                            // Intentar guardar la imagen
                            nuevaImagenPortada.Save(rutaDestino, System.Drawing.Imaging.ImageFormat.Png);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha cargado ninguna imagen.");
                    }

                    // Llamar al método para guardar el libro en la base de datos
                    logica.CrearUnLibro(nuevoLibro);

                    // Confirmar que el libro fue guardado
                    MessageBox.Show("Libro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    MessageBox.Show($"Ocurrió un error al guardar el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        // -------------------------------------------------------------------------------- Evento TEXT_CHANGED de los cajas de texto
        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            // Verificar si los campos no están vacíos
            if (!string.IsNullOrWhiteSpace(txtTituloLibro.Text) && 
                !string.IsNullOrWhiteSpace(txtAutorLibro.Text) &&
                !string.IsNullOrWhiteSpace(txtEditorial.Text) &&
                !string.IsNullOrWhiteSpace(txtPaginas.Text) &&
                !string.IsNullOrWhiteSpace(cbIdioma.Text) &&
                !string.IsNullOrWhiteSpace(cbFormato.Text) &&
                !string.IsNullOrWhiteSpace(txtISBN.Text) &&
                !string.IsNullOrWhiteSpace(txtFechaLectura.Text) &&
                !string.IsNullOrWhiteSpace(txtSinopsis.Text) &&
                pbPortadaLibro.Image != null)
            {
                // Mostrar el botón si ambos campos tienen texto
                btnGuardarLibro.Visible = true;
            }
            else
            {
                // Si alguno de los campos está vacío, ocultar el botón
                btnGuardarLibro.Visible = false;
            }
        }

        // -------------------------------------------------------------------------------- Eventos KEYPRESS de las cajas de texto 
        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número (0-9) ni Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Cancela la acción de la tecla si no es un número ni Backspace
            }
        }

        private void txtISBN_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si el atajo Ctrl+V fue presionado
            if (e.Control && e.KeyCode == Keys.V)
            {
                // Permitir el pegado
                e.Handled = false; // No cancelar la acción (permitir pegar)
            }
            else
            {
                e.Handled = true; // En otros casos, bloquear la acción
            }
        }

        private void txtAutorLibro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es una letra, espacio o es la tecla de retroceso (Backspace)
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ' ') // ' ' es el espacio
            {
                e.Handled = true; // Cancela la acción de la tecla si no es una letra, espacio ni Backspace
            }
        }

        private void txtPaginas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número (0-9) y no es una tecla de control (como Backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8) // 8 es el código ASCII para Backspace
            {
                e.Handled = true; // Cancela la acción de la tecla si no es un número ni Backspace
            }
        }

        #region "Métodos"
        // Método para limpiar el formulario
        private void LimpiarFormulario()
        {
            txtISBN.Text = "";
            txtTituloLibro.Text = "";
            txtAutorLibro.Text = "";
            txtEditorial.Text = "";
            txtPaginas.Text = "";
            cbIdioma.Text = "";
            cbFormato.Text = "";
            txtFechaLectura.Text = "";
            txtSinopsis.Text = "";
            pbPortadaLibro.Image = null;
            nuevaImagenPortada = null;
        }

        // Método que libera la imagen de la portada
        private void LiberarImagenes()
        {
            // Limpiar el panel eliminando todos los PictureBox (controles) agregados previamente
            foreach (Control control in panelCrearLibroNuevo.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image?.Dispose(); // Liberar recursos de la imagen.
                    pictureBox.Dispose();        // Liberar el PictureBox.
                }
            }
            panelCrearLibroNuevo.Controls.Clear(); // Limpiar el panel.
            panelCrearLibroNuevo.Invalidate();  // Esto fuerza al panel a redibujarse.
            panelCrearLibroNuevo.Refresh();     // Actualiza el panel inmediatamente.
        }

        // -------------------------------------------------------------------------- Métodos para la liberación de las imágenes
        private System.Drawing.Image CargarImagenSinBloqueo(string ruta)
        {
            try
            {
                using (var stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return System.Drawing.Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show($"No se pudo cargar la imagen: {ex.Message}");
                return null;
            }
        }
        #endregion
    }
}
