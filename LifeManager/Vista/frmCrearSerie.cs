using LifeManager.Entidades;
using LifeManager.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Vista
{
    public partial class frmCrearSerie : Form
    {

        SerieLogica logica = new SerieLogica();
        int numero;
        private System.Drawing.Image nuevaImagenPortada = null; // Variable para almacenar la nueva imagen temporalmente
        public event Action OnFormClosedEvent;  // Evento para notificar el cierre
        public int Interruptor { get; set; }  // Esta propiedad indicará si estamos creando o editando
        public int Id { get; set; }

        public frmCrearSerie()
        {
            InitializeComponent();

            txtTituloSerie.TextChanged += new EventHandler(txtCampos_TextChanged);
            cbGenero.TextChanged += new EventHandler(txtCampos_TextChanged);
            cbPuntuacion.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtEpisodios.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtAnio.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtFechaVisionado.TextChanged += new EventHandler(txtCampos_TextChanged);
            txtTrama.TextChanged += new EventHandler(txtCampos_TextChanged);
        }

        private void frmCrearSerie_Load(object sender, EventArgs e)
        {
            numero = logica.ObtenerUltimoIdSerie(); // Cargamos el último ID en la base de datos
            cbPuntuacion.SelectedIndex = 0;
            cbGenero.SelectedIndex = 0;

            if (Interruptor == 1) // Si estamos editando
            {
                // Crear un objeto Libro con los datos de la base de datos
                Serie editarSerie = logica.MostrarDetallesSerie(Id);

                // Cargar el formulario
                txtTituloSerie.Text = editarSerie.Titulo.ToString();
                cbGenero.Text = editarSerie.Genero.ToString();
                txtAnio.Text = editarSerie.Anio.ToString();
                txtEpisodios.Text = editarSerie.Episodios.ToString();
                cbPuntuacion.Text = editarSerie.Puntuacion.ToString();
                txtTrama.Text = editarSerie.Trama.ToString();
                txtFechaVisionado.Text = editarSerie.FechaVisionado.Value.ToString("yyyy/MM/dd");

                // Imagen Portada
                string rutaPortadas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "series_portadas");
                string nombreArchivo = $"{editarSerie.IdSerie}.png";
                string rutaDestino = Path.Combine(rutaPortadas, nombreArchivo);
                pbPortadaSerie.Visible = true;
                pbPortadaSerie.Image = CargarImagenSinBloqueo(rutaDestino);
                nuevaImagenPortada = CargarImagenSinBloqueo(rutaDestino);

                btnGuardarSerie.Visible = true;
                btnGuardarSerie.Text = "        EDITAR PELICULA";
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CERRAR
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón CALENDARIO
        private void btnCalendario_Click(object sender, EventArgs e)
        {
            // Mostrar el DateTimePicker cerca del botón o el campo de texto
            dateTimePickerVisionado.Visible = true;
            dateTimePickerVisionado.Focus();
        }

        private void dateTimePickerVisionado_CloseUp(object sender, EventArgs e)
        {
            // Actualizar el campo de texto con la fecha seleccionada
            txtFechaVisionado.Text = dateTimePickerVisionado.Value.ToString("yyyy-MM-dd");

            // Ocultar el DateTimePicker después de seleccionar la fecha
            dateTimePickerVisionado.Visible = false;
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
                        pbPortadaSerie.Image = nuevaImagenPortada;

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

        // -------------------------------------------------------------------------------- Eventos KEYPRESS de las cajas de texto
        private void txtAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número (0-9) ni Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Cancela la acción de la tecla si no es un número ni Backspace
            }
        }

        private void txtEpisodios_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un número (0-9) ni Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Cancela la acción de la tecla si no es un número ni Backspace
            }
        }

        // -------------------------------------------------------------------------------- Evento TEXT_CHANGED de los cajas de texto
        private void txtCampos_TextChanged(object sender, EventArgs e)
        {
            // Verificar si los campos no están vacíos
            if (!string.IsNullOrWhiteSpace(txtTituloSerie.Text) &&
                !string.IsNullOrWhiteSpace(cbGenero.Text) &&
                !string.IsNullOrWhiteSpace(txtEpisodios.Text) &&
                !string.IsNullOrWhiteSpace(txtAnio.Text) &&
                !string.IsNullOrWhiteSpace(cbPuntuacion.Text) &&
                !string.IsNullOrWhiteSpace(txtTrama.Text) &&
                !string.IsNullOrWhiteSpace(txtFechaVisionado.Text) &&
                pbPortadaSerie.Image != null)
            {
                // Mostrar el botón si ambos campos tienen texto
                btnGuardarSerie.Visible = true;
            }
            else
            {
                // Si alguno de los campos está vacío, ocultar el botón
                btnGuardarSerie.Visible = false;
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón GUARDAR SERIE
        private void btnGuardarSerie_Click(object sender, EventArgs e)
        {
            if (Interruptor == 1) // Si estamos editando
            {
                // Crear un objeto Libro con los datos del formulario
                Serie nuevaSerie = new Serie
                {
                    IdSerie = Id,
                    Titulo = txtTituloSerie.Text.Trim(),
                    Genero = cbGenero.Text.Trim(),
                    Episodios = int.TryParse(txtEpisodios.Text.Trim(), out int duracion) ? duracion : throw new FormatException("Número episodios no válido."),
                    Puntuacion = int.TryParse(cbPuntuacion.Text.Trim(), out int puntuacion) ? puntuacion : throw new FormatException("Puntuación no válida."),
                    Anio = int.TryParse(txtAnio.Text.Trim(), out int anio) ? anio : throw new FormatException("Año no válido."),
                    FechaVisionado = DateTime.TryParse(txtFechaVisionado.Text.Trim(), out DateTime fecha) ? fecha : (DateTime?)null,
                    Trama = txtTrama.Text.Trim()
                };

                try
                {
                    // Verificar si la imagen temporal nuevaImagenPortada está cargada
                    if (nuevaImagenPortada != null)
                    {
                        // Verificar la ruta de destino
                        string rutaEscudos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "series_portadas");
                        string nombreArchivo = $"{nuevaSerie.IdSerie}.png";
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

                    // Llamar al método para actualizar una serie en la base de datos
                    logica.ActualizarUnaSerie(nuevaSerie);

                    // Confirmar que el libro fue guardado
                    MessageBox.Show("Serie editada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el Formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    MessageBox.Show($"Ocurrió un error al guardar la serie: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // Si estamos creando un nuevo libro
            {
                try
                {
                    // Crear un objeto Libro con los datos del formulario
                    Serie nuevaSerie = new Serie
                    {
                        IdSerie = logica.ObtenerUltimoIdSerie() + 1,
                        Titulo = txtTituloSerie.Text.Trim(),
                        Genero = cbGenero.Text.Trim(),
                        Episodios = int.TryParse(txtEpisodios.Text.Trim(), out int duracion) ? duracion : throw new FormatException("Número episodios no válido."),
                        Puntuacion = int.TryParse(cbPuntuacion.Text.Trim(), out int puntuacion) ? puntuacion : throw new FormatException("Puntuación no válida."),
                        Anio = int.TryParse(txtAnio.Text.Trim(), out int anio) ? anio : throw new FormatException("Año no válido."),
                        FechaVisionado = DateTime.TryParse(txtFechaVisionado.Text.Trim(), out DateTime fecha) ? fecha : (DateTime?)null,
                        Trama = txtTrama.Text.Trim()
                    };

                    // Verificar si la imagen temporal nuevaImagenPortada está cargada
                    if (nuevaImagenPortada != null)
                    {
                        numero = logica.ObtenerUltimoIdSerie();
                        // Verificar la ruta de destino
                        string rutaEscudos = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "series_portadas");
                        string nombreArchivo = $"{numero + 1}.png";
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
                    logica.CrearUnaSerie(nuevaSerie);

                    // Confirmar que el libro fue guardado
                    MessageBox.Show("Serie guardada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cerrar el formulario
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Manejar errores
                    MessageBox.Show($"Ocurrió un error al guardar la serie: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // -------------------------------------------------------------------------------- Evento CLICK del botón LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        #region "Métodos"
        // Método para limpiar el formulario
        private void LimpiarFormulario()
        {
            txtTituloSerie.Text = "";
            cbGenero.Text = "";
            txtAnio.Text = "";
            txtEpisodios.Text = "";
            cbPuntuacion.Text = "";
            txtTrama.Text = "";
            txtFechaVisionado.Text = "";
            pbPortadaSerie.Image = null;
            nuevaImagenPortada = null;
        }

        // Método que libera la imagen de la portada
        private void LiberarImagenes()
        {
            // Limpiar el panel eliminando todos los PictureBox (controles) agregados previamente
            foreach (Control control in panelCrearSerieNueva.Controls)
            {
                if (control is PictureBox pictureBox)
                {
                    pictureBox.Image?.Dispose(); // Liberar recursos de la imagen.
                    pictureBox.Dispose();        // Liberar el PictureBox.
                }
            }
            panelCrearSerieNueva.Controls.Clear(); // Limpiar el panel.
            panelCrearSerieNueva.Invalidate();  // Esto fuerza al panel a redibujarse.
            panelCrearSerieNueva.Refresh();     // Actualiza el panel inmediatamente.
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
