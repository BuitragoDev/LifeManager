using LifeManager.Entidades;
using LifeManager.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Vista
{
    public partial class frmBooks : Form
    {
        private frmContenedor contenedor;
        LibroLogica logica = new LibroLogica();

        public frmBooks(frmContenedor contenedor)
        {
            InitializeComponent();

            this.contenedor = contenedor;
        }

        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarLibrosEnDataGridView();

            LimpiarDetalles();
            dgvListadoLibros.SelectionChanged += dgvListadoLibros_SelectionChanged; // Suscripción al evento SelectionChanged

            btnBorrarLibro.Visible = false;
            btnEditarLibro.Visible = false;
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón CREAR LIBRO
        private void btnCrearLibro_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario frmCrearNota
            frmCrearLibro formularioCrearLibro = new frmCrearLibro();

            // Mostrar el formulario frmCrearNota
            formularioCrearLibro.ShowDialog();  // ShowDialog() lo abrirá de manera modal

            // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
            CargarLibrosEnDataGridView();
            LimpiarDetalles();
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener todas las notas de la base de datos
            List<Libro> libros = logica.MostrarLibrosBusqueda(txtBuscador.Text.Trim());
            
            // Limpiar el DataGridView antes de llenarlo
            dgvListadoLibros.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var libro in libros)
            {
                // Formatear la fecha en "dd/MM/yyyy"
                string fechaFormateada = libro.FechaLectura?.ToString("dd/MM/yyyy") ?? "Sin Fecha";

                // Agregar los datos al DataGridView
                dgvListadoLibros.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Paginas, fechaFormateada);
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoLibros.ClearSelection();  // Desmarcar cualquier fila seleccionada

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

        // -------------------------------------------------------------------------- Evento CLICK del botón RECARGAR
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarLibrosEnDataGridView();
            LimpiarDetalles();
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BORRAR LIBRO
        private void btnBorrarLibro_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoLibros.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dgvListadoLibros.SelectedRows[0];

                    // Obtener el título y el contenido de la fila seleccionada
                    string ISBN = selectedRow.Cells["isbn"].Value.ToString();

                    // Mostrar un cuadro de confirmación antes de borrar
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar este libro?",
                                                             "Confirmar eliminación",
                                                             MessageBoxButtons.YesNo,
                                                             MessageBoxIcon.Warning);

                    // Si el usuario selecciona "Sí", proceder a borrar el libro
                    if (resultado == DialogResult.Yes)
                    {
                        // Llamar al método para borrar el libro
                        logica.BorrarUnLibro(ISBN);

                        // Ruta donde se encuentran las imágenes de las portadas
                        string rutaImagen = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                          "Life Manager", "Recursos", "libros_portadas", ISBN + ".png");
                        // Verificar si la imagen existe y eliminarla
                        if (File.Exists(rutaImagen))
                        {
                            File.Delete(rutaImagen);  // Elimina la imagen
                        }

                        // Recargar los libros para reflejar la eliminación
                        CargarLibrosEnDataGridView();

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

        // -------------------------------------------------------------------------- Evento CLICK del botón EDITAR LIBRO
        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoLibros.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoLibros.SelectedRows[0];
                string isbn = selectedRow.Cells["isbn"].Value.ToString();

                // Crear una instancia del formulario frmCrearLibro
                frmCrearLibro formularioCrearLibro = new frmCrearLibro();

                // Establecer el interruptor en 1 para indicar que estamos editando
                formularioCrearLibro.Interruptor = 1; // Por ejemplo, 1 indica "editar", 0 indica "crear"

                // Pasar el ISBN a los controles del formulario
                formularioCrearLibro.Isbn = isbn;

                // Mostrar el formulario en modo modal
                formularioCrearLibro.ShowDialog();

                // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
                CargarLibrosEnDataGridView();
                LimpiarDetalles();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota para editar.");
            }
        }

        #region "Métodos"
        // Método que crea la configuración del DataGrid.
        private void ConfigurarDataGridView()
        {
            // Limpiar cualquier configuración previa
            dgvListadoLibros.Columns.Clear();
            dgvListadoLibros.Rows.Clear();

            // Agregar columnas
            dgvListadoLibros.Columns.Add("isbn", "ISBN");
            dgvListadoLibros.Columns.Add("titulo", "Título del Libro");
            dgvListadoLibros.Columns.Add("autor", "Autor");
            dgvListadoLibros.Columns.Add("paginas", "Paginas");
            dgvListadoLibros.Columns.Add("fechaLectura", "Fecha Lectura");
            

            // Configurar el ancho de las columnas
            dgvListadoLibros.Columns["isbn"].Width = 0; // Ancho de la columna ISBN
            dgvListadoLibros.Columns["titulo"].Width = 415; // Ancho de la columna Título
            dgvListadoLibros.Columns["autor"].Width = 415; // Ancho de la columna Autor
            dgvListadoLibros.Columns["paginas"].Width = 100; // Ancho de la columna Páginas
            dgvListadoLibros.Columns["fechaLectura"].Width = 100; // Ancho de la columna FechaLectura
            
            // Ocultar la columna ID y Contenido
            dgvListadoLibros.Columns["isbn"].Visible = false;

            // Configurar la altura de las filas
            dgvListadoLibros.RowTemplate.Height = 32; // Altura de las filas
            dgvListadoLibros.ColumnHeadersHeight = 32; // Altura de las cabeceras

            // Configurar el estilo general del DataGridView
            dgvListadoLibros.BorderStyle = BorderStyle.None; // Sin bordes                                     
            dgvListadoLibros.CellBorderStyle = DataGridViewCellBorderStyle.None; // Quitar los bordes de las celdas
            dgvListadoLibros.BackgroundColor = Color.WhiteSmoke; // Fondo general
            dgvListadoLibros.DefaultCellStyle.BackColor = Color.WhiteSmoke; // Fondo de las celdas
            dgvListadoLibros.DefaultCellStyle.ForeColor = Color.FromArgb(35, 40, 45); // Texto negro
            dgvListadoLibros.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke; // Fondo al seleccionar
            dgvListadoLibros.DefaultCellStyle.SelectionForeColor = Color.Firebrick; // Texto al seleccionar
            dgvListadoLibros.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de las celdas

            // Configurar las cabeceras de columna
            dgvListadoLibros.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 45); // Fondo de cabeceras
            dgvListadoLibros.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto blanco en cabeceras
            dgvListadoLibros.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de cabeceras
            dgvListadoLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Borde en cabeceras                                                                   
            dgvListadoLibros.ColumnHeadersVisible = false; // Ocultar la cabecera

            // Opciones generales
            dgvListadoLibros.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados en cabeceras
            dgvListadoLibros.RowHeadersVisible = false; // Ocultar selector de filas
            dgvListadoLibros.AllowUserToResizeColumns = false; // Evitar que se redimensionen las columnas
            dgvListadoLibros.AllowUserToResizeRows = false; // Evitar que se redimensionen las filas
            dgvListadoLibros.AllowUserToAddRows = false; // Evitar que se agreguen filas manualmente
            dgvListadoLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa

            // Deshabilitar el resaltado de la cabecera al seleccionar celdas
            dgvListadoLibros.CellPainting += (sender, e) =>
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
        public void CargarLibrosEnDataGridView()
        {
            // Obtener todas las notas de la base de datos
            List<Libro> libros = logica.MostrarTodosLosLibros();

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoLibros.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var libro in libros)
            {
                // Formatear la fecha en "dd/MM/yyyy"
                string fechaFormateada = libro.FechaLectura?.ToString("dd/MM/yyyy") ?? "Sin Fecha";

                // Agregar los datos al DataGridView
                dgvListadoLibros.Rows.Add(libro.Isbn, libro.Titulo, libro.Autor, libro.Paginas, fechaFormateada);
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoLibros.ClearSelection();  // Desmarcar cualquier fila seleccionada
        }

        // Método que muestra los datos del libro seleccionado
        private void dgvListadoLibros_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoLibros.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoLibros.SelectedRows[0];

                // Obtener el título y el contenido de la fila seleccionada
                string ISBN = selectedRow.Cells["isbn"].Value.ToString();

                Libro detallesLibro = null;
                detallesLibro = logica.MostrarDetallesLibro(ISBN);

                // Mostrar datos en los label correspondientes
                lb1.Visible = true;
                lb2.Visible = true;
                lb3.Visible = true;
                lb4.Visible = true;
                lb5.Visible = true;
                lb6.Visible = true;
                lb7.Visible = true;
                lb8.Visible = true;
                lbISBN.Text = detallesLibro.Isbn;
                lbISBN.Visible = true;
                lbTitulo.Text = detallesLibro.Titulo;
                lbTitulo.Visible = true;
                lbAutor.Text = detallesLibro.Autor;
                lbAutor.Visible = true;
                lbEditorial.Text = detallesLibro.Editorial;
                lbEditorial.Visible = true;
                lbFormato.Text = detallesLibro.Formato;
                lbFormato.Visible = true;
                lbIdioma.Text = detallesLibro.Idioma;
                lbIdioma.Visible = true;
                lbPaginas.Text = detallesLibro.Paginas.ToString();
                lbPaginas.Visible = true;
                if (detallesLibro.FechaLectura.HasValue)
                {
                    lbFechaLectura.Text = detallesLibro.FechaLectura.Value.ToString("dd/MM/yyyy");
                }
                else
                {
                    lbFechaLectura.Text = "Fecha no disponible"; // O el texto que desees mostrar cuando la fecha sea null
                }
                lbFechaLectura.Visible = true;
                txtSinopsis.Text = detallesLibro.Sinopsis;
                lbSinopsis.Visible = true;
                txtSinopsis.Visible = true;

                // Imagen Portada
                string rutaPortadas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Life Manager", "Recursos", "libros_portadas");
                string nombreArchivo = $"{detallesLibro.Isbn}.png";
                string rutaDestino = Path.Combine(rutaPortadas, nombreArchivo);
                pbPortadaLibro.Visible = true;
                pbPortadaLibro.Image = CargarImagenSinBloqueo(rutaDestino);

                btnBorrarLibro.Visible = true;
                btnEditarLibro.Visible = true;
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
