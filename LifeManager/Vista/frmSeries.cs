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
using LifeManager.Entidades;
using LifeManager.Logica;

namespace LifeManager.Vista
{
    public partial class frmSeries : Form
    {
        private frmContenedor contenedor;
        SerieLogica logica = new SerieLogica();

        public frmSeries(frmContenedor contenedor)
        {
            InitializeComponent();

            this.contenedor = contenedor;
        }

        public frmSeries()
        {
            InitializeComponent();
        }

        private void frmSeries_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarSeriesEnDataGridView();

            LimpiarDetalles();
            dgvListadoSeries.SelectionChanged += dgvListadoSeries_SelectionChanged; // Suscripción al evento SelectionChanged

            btnBorrarSerie.Visible = false;
            btnEditarSerie.Visible = false;
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón CREAR SERIE
        private void btnCrearSerie_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario frmCrearNota
            frmCrearSerie formularioCrearSerie = new frmCrearSerie();

            // Mostrar el formulario frmCrearNota
            formularioCrearSerie.ShowDialog();  // ShowDialog() lo abrirá de manera modal

            // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
            CargarSeriesEnDataGridView();
            LimpiarDetalles();
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón RECARGAR
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarSeriesEnDataGridView();
            LimpiarDetalles();
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener todas las notas de la base de datos
            List<Serie> series = logica.MostrarSeriesBusqueda(txtBuscador.Text.Trim());

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoSeries.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var serie in series)
            {
                // Formatear la fecha en "dd/MM/yyyy"
                string fechaFormateada = serie.FechaVisionado?.ToString("dd/MM/yyyy") ?? "Sin Fecha";

                // Agregar los datos al DataGridView
                dgvListadoSeries.Rows.Add(serie.IdSerie, serie.Titulo, serie.Genero, fechaFormateada, serie.Episodios, serie.Puntuacion + " / 10");
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoSeries.ClearSelection();  // Desmarcar cualquier fila seleccionada

            LimpiarDetalles();
        }

        // -------------------------------------------------------------------------- Evento KEY DOWN de la caja de texto del BUSCADOR
        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si la tecla presionada es Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Llamar al método de búsqueda que ya tienes asociado al botón btnBuscar
                btnBuscar.PerformClick();
            }
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón EDITAR SERIE
        private void btnEditarSerie_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoSeries.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoSeries.SelectedRows[0];
                int id = int.Parse(selectedRow.Cells["id_serie"].Value.ToString());

                // Crear una instancia del formulario frmCrearLibro
                frmCrearSerie formularioCrearSerie = new frmCrearSerie();

                // Establecer el interruptor en 1 para indicar que estamos editando
                formularioCrearSerie.Interruptor = 1; // Por ejemplo, 1 indica "editar", 0 indica "crear"

                // Pasar el ISBN a los controles del formulario
                formularioCrearSerie.Id = id;

                // Mostrar el formulario en modo modal
                formularioCrearSerie.ShowDialog();

                // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
                CargarSeriesEnDataGridView();
                LimpiarDetalles();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota para editar.");
            }
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BORRAR SERIE
        private void btnBorrarSerie_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoSeries.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dgvListadoSeries.SelectedRows[0];

                    // Obtener el título y el contenido de la fila seleccionada
                    int id = int.Parse(selectedRow.Cells["id_serie"].Value.ToString());

                    // Mostrar un cuadro de confirmación antes de borrar
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar esta serie de TV?",
                                                             "Confirmar eliminación",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                    // Si el usuario selecciona "Sí", proceder a borrar el libro
                    if (resultado == DialogResult.Yes)
                    {
                        // Llamar al método para borrar el libro
                        logica.BorrarUnaSerie(id);

                        // Ruta donde se encuentran las imágenes de las portadas
                        string rutaImagen = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                          "Life Manager", "Recursos", "series_portadas", id + ".png");
                        // Verificar si la imagen existe y eliminarla
                        if (File.Exists(rutaImagen))
                        {
                            File.Delete(rutaImagen);  // Elimina la imagen
                        }

                        // Recargar los libros para reflejar la eliminación
                        CargarSeriesEnDataGridView();

                        // Limpiar el contenido de los detalles
                        LimpiarDetalles();
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    MessageBox.Show($"No se pudo borrar la imagen: {ex.Message}");
                }
            }
        }

        #region "Métodos"
        // Método que crea la configuración del DataGrid.
        private void ConfigurarDataGridView()
        {
            // Limpiar cualquier configuración previa
            dgvListadoSeries.Columns.Clear();
            dgvListadoSeries.Rows.Clear();

            // Agregar columnas
            dgvListadoSeries.Columns.Add("id_serie", "ID");
            dgvListadoSeries.Columns.Add("titulo", "Título");
            dgvListadoSeries.Columns.Add("genero", "Género");
            dgvListadoSeries.Columns.Add("fechaVisionado", "Fecha Visionado");
            dgvListadoSeries.Columns.Add("episodios", "Episodios");
            dgvListadoSeries.Columns.Add("puntuacion", "Puntuación");


            // Configurar el ancho de las columnas
            dgvListadoSeries.Columns["id_serie"].Width = 0; // Ancho de la columna Id Serie
            dgvListadoSeries.Columns["titulo"].Width = 415; // Ancho de la columna Título
            dgvListadoSeries.Columns["genero"].Width = 265; // Ancho de la columna Género
            dgvListadoSeries.Columns["fechaVisionado"].Width = 150; // Ancho de la columna Fecha Visionado
            dgvListadoSeries.Columns["episodios"].Width = 100; // Ancho de la columna Episodios
            dgvListadoSeries.Columns["puntuacion"].Width = 100; // Ancho de la columna Puntuacion

            dgvListadoSeries.Columns["episodios"].DefaultCellStyle.Padding = new Padding(17, 0, 0, 0);
            dgvListadoSeries.Columns["puntuacion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ocultar la columna ID y Contenido
            dgvListadoSeries.Columns["id_serie"].Visible = false;

            // Configurar la altura de las filas
            dgvListadoSeries.RowTemplate.Height = 32; // Altura de las filas
            dgvListadoSeries.ColumnHeadersHeight = 32; // Altura de las cabeceras

            // Configurar el estilo general del DataGridView
            dgvListadoSeries.BorderStyle = BorderStyle.None; // Sin bordes                                     
            dgvListadoSeries.CellBorderStyle = DataGridViewCellBorderStyle.None; // Quitar los bordes de las celdas
            dgvListadoSeries.BackgroundColor = Color.WhiteSmoke; // Fondo general
            dgvListadoSeries.DefaultCellStyle.BackColor = Color.WhiteSmoke; // Fondo de las celdas
            dgvListadoSeries.DefaultCellStyle.ForeColor = Color.FromArgb(35, 40, 45); // Texto negro
            dgvListadoSeries.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke; // Fondo al seleccionar
            dgvListadoSeries.DefaultCellStyle.SelectionForeColor = Color.Firebrick; // Texto al seleccionar
            dgvListadoSeries.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de las celdas

            // Configurar las cabeceras de columna
            dgvListadoSeries.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 45); // Fondo de cabeceras
            dgvListadoSeries.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto blanco en cabeceras
            dgvListadoSeries.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de cabeceras
            dgvListadoSeries.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Borde en cabeceras                                                                   
            dgvListadoSeries.ColumnHeadersVisible = false; // Ocultar la cabecera

            // Opciones generales
            dgvListadoSeries.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados en cabeceras
            dgvListadoSeries.RowHeadersVisible = false; // Ocultar selector de filas
            dgvListadoSeries.AllowUserToResizeColumns = false; // Evitar que se redimensionen las columnas
            dgvListadoSeries.AllowUserToResizeRows = false; // Evitar que se redimensionen las filas
            dgvListadoSeries.AllowUserToAddRows = false; // Evitar que se agreguen filas manualmente
            dgvListadoSeries.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa

            // Deshabilitar el resaltado de la cabecera al seleccionar celdas
            dgvListadoSeries.CellPainting += (sender, e) =>
            {
                if (e.RowIndex == -1) // Si es la cabecera
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(35, 40, 45)), e.CellBounds); // Aplicar color personalizado
                    e.PaintContent(e.ClipBounds); // Pintar el contenido de la cabecera
                    e.Handled = true; // Evitar el resaltado predeterminado
                }
            };
        }

        // Método que carga el DataGrid con todos los libros
        public void CargarSeriesEnDataGridView()
        {
            // Obtener todas las notas de la base de datos
            List<Serie> series = logica.MostrarTodasLasSeries();

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoSeries.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var serie in series)
            {
                // Formatear la fecha en "dd/MM/yyyy"
                string fechaFormateada = serie.FechaVisionado?.ToString("dd/MM/yyyy") ?? "Sin Fecha";

                // Agregar los datos al DataGridView
                dgvListadoSeries.Rows.Add(serie.IdSerie, serie.Titulo, serie.Genero, fechaFormateada, serie.Episodios, serie.Puntuacion + " / 10");
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoSeries.ClearSelection();  // Desmarcar cualquier fila seleccionada
        }

        // Método que muestra los datos del libro seleccionado
        private void dgvListadoSeries_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoSeries.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoSeries.SelectedRows[0];

                // Obtener el título y el contenido de la fila seleccionada
                int Id = int.Parse(selectedRow.Cells["id_serie"].Value.ToString());

                Serie detallesSerie = null;
                detallesSerie = logica.MostrarDetallesSerie(Id);

                // Mostrar datos en los label correspondientes
                lb1.Visible = true;
                lb2.Visible = true;
                lb3.Visible = true;
                lb4.Visible = true;
                lb5.Visible = true;
                lb6.Visible = true;

                lbTitulo.Text = detallesSerie.Titulo;
                lbTitulo.Visible = true;
                lbPuntuacion.Text = detallesSerie.Puntuacion.ToString() + " / 10";
                lbPuntuacion.Visible = true;
                lbGenero.Text = detallesSerie.Genero;
                lbGenero.Visible = true;
                lbAnio.Text = detallesSerie.Anio.ToString();
                lbAnio.Visible = true;
                lbEpisodios.Text = detallesSerie.Episodios.ToString();
                lbEpisodios.Visible = true;
                lbFechaVisionado.Text = detallesSerie.FechaVisionado.ToString();
                lbFechaVisionado.Visible = true;
                if (detallesSerie.FechaVisionado.HasValue)
                {
                    lbFechaVisionado.Text = detallesSerie.FechaVisionado.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    lbFechaVisionado.Text = "Fecha no disponible"; // O el texto que desees mostrar cuando la fecha sea null
                }
                lbFechaVisionado.Visible = true;
                txtTrama.Text = detallesSerie.Trama;
                lbTrama.Visible = true;
                txtTrama.Visible = true;

                // Imagen Portada
                string rutaPortadas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "series_portadas");
                string nombreArchivo = $"{detallesSerie.IdSerie}.png";
                string rutaDestino = Path.Combine(rutaPortadas, nombreArchivo);
                pbPortadaLibro.Visible = true;
                pbPortadaLibro.Image = CargarImagenSinBloqueo(rutaDestino);

                btnBorrarSerie.Visible = true;
                btnEditarSerie.Visible = true;
            }
        }

        // -------------------------------------------------------------------------- Métodos para la liberación de las imágenes
        private Image CargarImagenSinBloqueo(string ruta)
        {
            try
            {
                using (var stream = new FileStream(ruta, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    return Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show($"No se pudo cargar la imagen: {ex.Message}");
                return null;
            }
        }

        // -------------------------------------------------------------------------- Método que limpia el panel de detalles
        private void LimpiarDetalles()
        {
            foreach (Control control in panelDetalles.Controls)
            {
                control.Visible = false;
            }
            txtBuscador.Text = "";
        }
        #endregion
    }
}
