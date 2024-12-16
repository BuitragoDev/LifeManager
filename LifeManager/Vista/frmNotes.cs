using LifeManager.Datos;
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
    public partial class frmNotes : Form
    {
        private frmContenedor contenedor;
        NotaLogica logica = new NotaLogica();

        public frmNotes(frmContenedor contenedor)
        {
            InitializeComponent();

            this.contenedor = contenedor;
        }

        public frmNotes()
        {
            InitializeComponent();
        }

        // -------------------------------------------------------------------------- Evento LOAD del formulario
        private void frmNotes_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarNotasEnDataGridView();

            // Limpiar el contenido al cargar el formulario
            lbNoteTitle.Text = string.Empty;
            txtContentNote.Clear();

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarNota.Visible = false; // Ocultar el botón de editar
            btnEditarNota.Visible = false; // Ocultar el botón de eliminar
            lbUltimaModificacion.Text = "";

            dgvListadoNotas.SelectionChanged += dgvListadoNotas_SelectionChanged; // Suscripción al evento SelectionChanged
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón CREAR NOTA
        private void btnCrearNota_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario frmCrearNota
            frmCrearNota formularioCrearNota = new frmCrearNota();

            // Mostrar el formulario frmCrearNota
            formularioCrearNota.ShowDialog();  // ShowDialog() lo abrirá de manera modal

            CargarNotasEnDataGridView();

            // Limpiar el contenido al cargar el formulario
            lbNoteTitle.Text = string.Empty;
            txtContentNote.Clear();
            lbUltimaModificacion.Text = "";
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener todas las notas de la base de datos
            List<Nota> notas = logica.MostrarNotasBusqueda(txtBuscador.Text.Trim());

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoNotas.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var nota in notas)
            {
                dgvListadoNotas.Rows.Add(nota.Id, nota.Titulo, nota.Contenido, nota.FechaModificacion); // Incluir contenido
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoNotas.ClearSelection();  // Desmarcar cualquier fila seleccionada

            // Limpiar el contenido al cargar el formulario
            lbNoteTitle.Text = string.Empty;
            txtContentNote.Clear();

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarNota.Visible = false; // Ocultar el botón de editar
            btnEditarNota.Visible = false; // Ocultar el botón de eliminar
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
            CargarNotasEnDataGridView();

            // Limpiar el contenido al cargar el formulario
            lbNoteTitle.Text = string.Empty;
            txtContentNote.Clear();

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarNota.Visible = false; // Ocultar el botón de editar
            btnEditarNota.Visible = false; // Ocultar el botón de eliminar

            txtBuscador.Text = ""; // Limpiar caja del buscador
            lbUltimaModificacion.Text = "";
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BORRAR NOTA
        private void btnBorrarNota_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvListadoNotas.SelectedRows.Count > 0)
            {
                // Obtener la ID de la nota seleccionada
                int idNota = Convert.ToInt32(dgvListadoNotas.SelectedRows[0].Cells["id_nota"].Value);

                // Mostrar un cuadro de confirmación antes de borrar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar esta nota?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                // Si el usuario selecciona "Sí", proceder a borrar la nota
                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método para borrar la nota
                    logica.BorrarUnaNota(idNota);

                    // Recargar las notas para reflejar la eliminación
                    CargarNotasEnDataGridView();

                    // Limpiar el contenido de los campos de texto
                    lbNoteTitle.Text = string.Empty;
                    txtContentNote.Clear();

                    // Ocultar los botones
                    btnBorrarNota.Visible = false;
                    btnEditarNota.Visible = false;

                    lbUltimaModificacion.Text = "";
                }
            }
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón EDITAR NOTA
        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoNotas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoNotas.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_nota"].Value);
                string titulo = selectedRow.Cells["titulo"].Value.ToString();
                string contenido = selectedRow.Cells["contenido"].Value.ToString();

                // Crear una instancia del formulario frmCrearNota
                frmCrearNota formularioCrearNota = new frmCrearNota();

                // Establecer el interruptor en 1 para indicar que estamos editando
                formularioCrearNota.Interruptor = 1; // Por ejemplo, 1 indica "editar", 0 indica "crear"

                // Pasar el título y contenido a los controles del formulario
                formularioCrearNota.Titulo = titulo;
                formularioCrearNota.Contenido = contenido;
                formularioCrearNota.IdNota = id;

                // Mostrar el formulario en modo modal
                formularioCrearNota.ShowDialog();

                // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
                CargarNotasEnDataGridView();

                // Limpiar el contenido al cargar el formulario
                lbNoteTitle.Text = string.Empty;
                txtContentNote.Clear();
                lbUltimaModificacion.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota para editar.");
            }
        }

        #region "Métodos"
        // Método que crea la configuración del DataGrid.
        public void ConfigurarDataGridView()
        {
            // Limpiar cualquier configuración previa
            dgvListadoNotas.Columns.Clear();
            dgvListadoNotas.Rows.Clear();

            // Agregar columnas
            dgvListadoNotas.Columns.Add("id_nota", "ID");
            dgvListadoNotas.Columns.Add("titulo", "Título de la Nota");
            dgvListadoNotas.Columns.Add("contenido", "Contenido");
            dgvListadoNotas.Columns.Add("fecha_modificacion", "FechaModificacion");

            // Configurar el ancho de las columnas
            dgvListadoNotas.Columns["id_nota"].Width = 0; // Ancho de la columna ID
            dgvListadoNotas.Columns["titulo"].Width = 381; // Ancho de la columna Título
            dgvListadoNotas.Columns["contenido"].Width = 0; // Ancho de la columna Contenido
            dgvListadoNotas.Columns["fecha_modificacion"].Width = 0; // Ancho de la columna Fecha Modificación

            // Ocultar la columna ID y Contenido
            dgvListadoNotas.Columns["id_nota"].Visible = false;
            dgvListadoNotas.Columns["contenido"].Visible = false;
            dgvListadoNotas.Columns["fecha_modificacion"].Visible = false;

            // Configurar la altura de las filas
            dgvListadoNotas.RowTemplate.Height = 32; // Altura de las filas
            dgvListadoNotas.ColumnHeadersHeight = 32; // Altura de las cabeceras

            // Configurar el estilo general del DataGridView
            dgvListadoNotas.BorderStyle = BorderStyle.None; // Sin bordes                                     
            dgvListadoNotas.CellBorderStyle = DataGridViewCellBorderStyle.None; // Quitar los bordes de las celdas
            dgvListadoNotas.BackgroundColor = Color.WhiteSmoke; // Fondo general
            dgvListadoNotas.DefaultCellStyle.BackColor = Color.WhiteSmoke; // Fondo de las celdas
            dgvListadoNotas.DefaultCellStyle.ForeColor = Color.FromArgb(35, 40, 45); // Texto negro
            dgvListadoNotas.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke; // Fondo al seleccionar
            dgvListadoNotas.DefaultCellStyle.SelectionForeColor = Color.Firebrick; // Texto al seleccionar
            dgvListadoNotas.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de las celdas

            // Configurar las cabeceras de columna
            dgvListadoNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 45); // Fondo de cabeceras
            dgvListadoNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto blanco en cabeceras
            dgvListadoNotas.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de cabeceras
            dgvListadoNotas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Borde en cabeceras                                                                   
            dgvListadoNotas.ColumnHeadersVisible = false; // Ocultar la cabecera

            // Opciones generales
            dgvListadoNotas.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados en cabeceras
            dgvListadoNotas.RowHeadersVisible = false; // Ocultar selector de filas
            dgvListadoNotas.AllowUserToResizeColumns = false; // Evitar que se redimensionen las columnas
            dgvListadoNotas.AllowUserToResizeRows = false; // Evitar que se redimensionen las filas
            dgvListadoNotas.AllowUserToAddRows = false; // Evitar que se agreguen filas manualmente
            dgvListadoNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa

            // Deshabilitar el resaltado de la cabecera al seleccionar celdas
            dgvListadoNotas.CellPainting += (sender, e) =>
            {
                if (e.RowIndex == -1) // Si es la cabecera
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(35, 40, 45)), e.CellBounds); // Aplicar color personalizado
                    e.PaintContent(e.ClipBounds); // Pintar el contenido de la cabecera
                    e.Handled = true; // Evitar el resaltado predeterminado
                }
            };
        }


        // Método que carga el DataGrid con todas las notas
        public void CargarNotasEnDataGridView()
        {
            // Obtener todas las notas de la base de datos
            List<Nota> notas = logica.MostrarTodasLasNotas();

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoNotas.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var nota in notas)
            {
                dgvListadoNotas.Rows.Add(nota.Id, nota.Titulo, nota.Contenido, nota.FechaModificacion); // Incluir contenido
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoNotas.ClearSelection();  // Desmarcar cualquier fila seleccionada
        }


        // Método que muestra el título y contenido de la nota seleccionada.
        private void dgvListadoNotas_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoNotas.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoNotas.SelectedRows[0];

                // Obtener el título y el contenido de la fila seleccionada
                string titulo = selectedRow.Cells["titulo"].Value.ToString();
                string contenido = selectedRow.Cells["contenido"].Value.ToString();
                string fechaUltimaModificacionRaw = selectedRow.Cells["fecha_modificacion"].Value.ToString();

                // Convertir la fecha a DateTime y formatearla
                if (DateTime.TryParse(fechaUltimaModificacionRaw, out DateTime fechaUltimaModificacion))
                {
                    string fechaFormateada = fechaUltimaModificacion.ToString("d 'de' MMMM 'de' yyyy 'a las' HH:mm");
                    lbUltimaModificacion.Text = "Última modificación: " + fechaFormateada;
                }
                else
                {
                    lbUltimaModificacion.Text = "Última modificación: Fecha inválida";
                }

                // Asignar el título al label y el contenido al richtextbox
                lbNoteTitle.Text = titulo;
                txtContentNote.Rtf = contenido;

                btnBorrarNota.Visible = true;
                btnEditarNota.Visible = true;
            }
        }
        #endregion
    }
}
