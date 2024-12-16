using LifeManager.Entidades;
using LifeManager.Logica;
using LifeManager.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager
{
    public partial class frmPasswords : Form
    {
        private frmContenedor contenedor;
        PasswordLogica logica = new PasswordLogica();

        public frmPasswords(frmContenedor contenedor)
        {
            InitializeComponent();

            this.contenedor = contenedor;
        }

        public frmPasswords()
        {
            InitializeComponent();
        }

        private void frmPasswords_Load(object sender, EventArgs e)
        {
            ConfigurarDataGridView();
            CargarPasswordsEnDataGridView();

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarPassword.Visible = false; // Ocultar el botón de editar
            btnEditarPassword.Visible = false; // Ocultar el botón de eliminar
            lbUltimaModificacion.Text = "";

            dgvListadoPasswords.SelectionChanged += dgvListadoPasswords_SelectionChanged; // Suscripción al evento SelectionChanged
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón CREAR CONTRASEÑA
        private void btnCrearPassword_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario frmCrearNota
            frmCrearPassword formularioCrearContrasena = new frmCrearPassword();

            // Mostrar el formulario en modo modal
            formularioCrearContrasena.ShowDialog();

            // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
            CargarPasswordsEnDataGridView();

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarPassword.Visible = false; // Ocultar el botón de editar
            btnEditarPassword.Visible = false; // Ocultar el botón de eliminar

            lbUltimaModificacion.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón RECARGAR
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            CargarPasswordsEnDataGridView();

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarPassword.Visible = false; // Ocultar el botón de editar
            btnEditarPassword.Visible = false; // Ocultar el botón de eliminar

            txtBuscador.Text = ""; // Limpiar caja del buscador
            lbUltimaModificacion.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";

        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BUSCAR
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtener todas las notas de la base de datos
            List<Password> passwords = logica.MostrarNotasBusqueda(txtBuscador.Text.Trim());

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoPasswords.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var pass in passwords)
            {
                dgvListadoPasswords.Rows.Add(pass.idPass, pass.titulo, pass.email, pass.usuario, pass.pass, pass.fechaModificacion); // Incluir contenido
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoPasswords.ClearSelection();  // Desmarcar cualquier fila seleccionada

            // Asegurarse de que los botones estén ocultos al cargar el formulario
            btnBorrarPassword.Visible = false; // Ocultar el botón de editar
            btnEditarPassword.Visible = false; // Ocultar el botón de eliminar

            lbUltimaModificacion.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón BORRAR 
        private void btnBorrarPassword_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvListadoPasswords.SelectedRows.Count > 0)
            {
                // Obtener la ID de la nota seleccionada
                int idNota = Convert.ToInt32(dgvListadoPasswords.SelectedRows[0].Cells["id_pass"].Value);

                // Mostrar un cuadro de confirmación antes de borrar
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que quieres eliminar esta contraseña?",
                                                         "Confirmar eliminación",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning);

                // Si el usuario selecciona "Sí", proceder a borrar la nota
                if (resultado == DialogResult.Yes)
                {
                    // Llamar al método para borrar la nota
                    logica.BorrarUnaContrasena(idNota);

                    // Recargar las notas para reflejar la eliminación
                    CargarPasswordsEnDataGridView();

                    // Asegurarse de que los botones estén ocultos al cargar el formulario
                    btnBorrarPassword.Visible = false; // Ocultar el botón de editar
                    btnEditarPassword.Visible = false; // Ocultar el botón de eliminar

                    lbUltimaModificacion.Text = "";
                    txtEmail.Text = "";
                    txtUsuario.Text = "";
                    txtContrasena.Text = "";
                }
            }
        }

        // -------------------------------------------------------------------------- Evento CLICK del botón EDITAR CONTRASEÑA
        private void btnEditarPassword_Click(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoPasswords.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoPasswords.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_pass"].Value);
                string titulo = selectedRow.Cells["titulo"].Value.ToString();
                string mail = selectedRow.Cells["email"].Value.ToString();
                string user = selectedRow.Cells["usuario"].Value.ToString();
                string contrasena = selectedRow.Cells["pass"].Value.ToString();

                // Crear una instancia del formulario frmCrearNota
                frmCrearPassword formularioCrearContrasena = new frmCrearPassword();

                // Establecer el interruptor en 1 para indicar que estamos editando
                formularioCrearContrasena.Interruptor = 1; // Por ejemplo, 1 indica "editar", 0 indica "crear"

                // Pasar el título y contenido a los controles del formulario
                formularioCrearContrasena.Titulo = titulo;
                formularioCrearContrasena.Email = mail;
                formularioCrearContrasena.Usuario = user;
                formularioCrearContrasena.Pass = contrasena;
                formularioCrearContrasena.IdPass = id;

                // Mostrar el formulario en modo modal
                formularioCrearContrasena.ShowDialog();

                // Después de cerrar el formulario, puedes hacer algo, como recargar el DataGridView
                CargarPasswordsEnDataGridView();

                // Asegurarse de que los botones estén ocultos al cargar el formulario
                btnBorrarPassword.Visible = false; // Ocultar el botón de editar
                btnEditarPassword.Visible = false; // Ocultar el botón de eliminar

                lbUltimaModificacion.Text = "";
                txtEmail.Text = "";
                txtUsuario.Text = "";
                txtContrasena.Text = "";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una nota para editar.");
            }
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

        #region "Métodos"
        // Método que crea la configuración del DataGrid.
        public void ConfigurarDataGridView()
        {
            // Limpiar cualquier configuración previa
            dgvListadoPasswords.Columns.Clear();
            dgvListadoPasswords.Rows.Clear();

            // Agregar columnas
            dgvListadoPasswords.Columns.Add("id_pass", "ID");
            dgvListadoPasswords.Columns.Add("titulo", "Título de la Contraseña");
            dgvListadoPasswords.Columns.Add("email", "Email");
            dgvListadoPasswords.Columns.Add("usuario", "Usuario");
            dgvListadoPasswords.Columns.Add("pass", "Contraseña");
            dgvListadoPasswords.Columns.Add("fecha_modificacion", "FechaModificacion");

            // Configurar el ancho de las columnas
            dgvListadoPasswords.Columns["id_pass"].Width = 0; // Ancho de la columna ID
            dgvListadoPasswords.Columns["titulo"].Width = 220; // Ancho de la columna Título
            dgvListadoPasswords.Columns["email"].Width = 235; // Ancho de la columna Contenido
            dgvListadoPasswords.Columns["usuario"].Width = 215; // Ancho de la columna Contenido
            dgvListadoPasswords.Columns["pass"].Width = 360; // Ancho de la columna Contraseña
            dgvListadoPasswords.Columns["fecha_modificacion"].Width = 0; // Ancho de la columna Fecha Modificación

            // Ocultar la columna ID y Contenido
            dgvListadoPasswords.Columns["id_pass"].Visible = false;
            dgvListadoPasswords.Columns["fecha_modificacion"].Visible = false;

            // Configurar la altura de las filas
            dgvListadoPasswords.RowTemplate.Height = 32; // Altura de las filas
            dgvListadoPasswords.ColumnHeadersHeight = 32; // Altura de las cabeceras

            // Configurar el estilo general del DataGridView
            dgvListadoPasswords.BorderStyle = BorderStyle.None; // Sin bordes                                     
            dgvListadoPasswords.CellBorderStyle = DataGridViewCellBorderStyle.None; // Quitar los bordes de las celdas
            dgvListadoPasswords.BackgroundColor = Color.WhiteSmoke; // Fondo general
            dgvListadoPasswords.DefaultCellStyle.BackColor = Color.WhiteSmoke; // Fondo de las celdas
            dgvListadoPasswords.DefaultCellStyle.ForeColor = Color.FromArgb(35, 40, 45); // Texto negro
            dgvListadoPasswords.DefaultCellStyle.SelectionBackColor = Color.WhiteSmoke; // Fondo al seleccionar
            dgvListadoPasswords.DefaultCellStyle.SelectionForeColor = Color.Firebrick; // Texto al seleccionar
            dgvListadoPasswords.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de las celdas

            // Configurar las cabeceras de columna
            dgvListadoPasswords.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 40, 45); // Fondo de cabeceras
            dgvListadoPasswords.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Texto blanco en cabeceras
            dgvListadoPasswords.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12); // Fuente de cabeceras
            dgvListadoPasswords.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // Borde en cabeceras                                                                   
            dgvListadoPasswords.ColumnHeadersVisible = false; // Ocultar la cabecera

            // Opciones generales
            dgvListadoPasswords.EnableHeadersVisualStyles = false; // Habilitar estilos personalizados en cabeceras
            dgvListadoPasswords.RowHeadersVisible = false; // Ocultar selector de filas
            dgvListadoPasswords.AllowUserToResizeColumns = false; // Evitar que se redimensionen las columnas
            dgvListadoPasswords.AllowUserToResizeRows = false; // Evitar que se redimensionen las filas
            dgvListadoPasswords.AllowUserToAddRows = false; // Evitar que se agreguen filas manualmente
            dgvListadoPasswords.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Seleccionar fila completa

            // Deshabilitar el resaltado de la cabecera al seleccionar celdas
            dgvListadoPasswords.CellPainting += (sender, e) =>
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
        public void CargarPasswordsEnDataGridView()
        {
            // Obtener todas las notas de la base de datos
            List<Password> passwords = logica.MostrarTodasLasPasswords();

            // Limpiar el DataGridView antes de llenarlo
            dgvListadoPasswords.Rows.Clear();

            // Agregar cada nota al DataGridView
            foreach (var pass in passwords)
            {
                dgvListadoPasswords.Rows.Add(pass.idPass, pass.titulo, pass.email, pass.usuario, pass.pass, pass.fechaModificacion); // Incluir contenido
            }

            // Asegurarse de que no haya ninguna fila seleccionada al cargar
            dgvListadoPasswords.ClearSelection();  // Desmarcar cualquier fila seleccionada
        }


        // Método que muestra el título y contenido de la nota seleccionada.
        private void dgvListadoPasswords_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay alguna fila seleccionada
            if (dgvListadoPasswords.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow selectedRow = dgvListadoPasswords.SelectedRows[0];

                // Obtener el título y el contenido de la fila seleccionada
                string titulo = selectedRow.Cells["titulo"].Value.ToString();
                string correo = selectedRow.Cells["email"].Value.ToString();
                string user = selectedRow.Cells["usuario"].Value.ToString();
                string pass = selectedRow.Cells["pass"].Value.ToString();
                string fechaUltimaModificacionRaw = selectedRow.Cells["fecha_modificacion"].Value.ToString();

                txtEmail.Text = correo;
                txtUsuario.Text = user;
                txtContrasena.Text = pass;

                // Convertir la fecha a DateTime y formatearla
                if (DateTime.TryParse(fechaUltimaModificacionRaw, out DateTime fechaUltimaModificacion))
                {
                    string fechaFormateada = fechaUltimaModificacion.ToString("d 'de' MMMM 'de' yyyy 'a las' HH:mm");
                    string contrasena = pass;
                    lbUltimaModificacion.Text = "Última modificación: " + fechaFormateada;
                }
                else
                {
                    lbUltimaModificacion.Text = "Última modificación: Fecha inválida";
                }

                btnBorrarPassword.Visible = true;
                btnEditarPassword.Visible = true;
            }
        }
        #endregion
    }
}
