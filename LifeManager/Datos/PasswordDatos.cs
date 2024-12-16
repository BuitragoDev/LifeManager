using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LifeManager.Datos
{
    public class PasswordDatos : Conexion
    {
        // ----------------------------------------------------------------------------- MÉTODO QUE CREA UNA CONTRASEÑA NUEVA
        public void CrearUnaContrasena(Password pass)
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "INSERT INTO Passwords (titulo, email, usuario, pass, fecha_creacion, fecha_modificacion) VALUES (@Titulo, @Email, @Usuario, @Pass, @FechaCreacion, @FechaModificacion)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", pass.titulo);
                    cmd.Parameters.AddWithValue("@Email", pass.email);
                    cmd.Parameters.AddWithValue("@Usuario", pass.usuario);
                    cmd.Parameters.AddWithValue("@Pass", pass.pass);
                    cmd.Parameters.AddWithValue("@FechaCreacion", pass.fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@FechaModificacion", pass.fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA TODAS LAS CONTRASEÑAS
        public List<Password> MostrarTodasLasPasswords()
        {
            // Crear una lista para almacenar las notas
            List<Password> listaPasswords = new List<Password>();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para recuperar todas las notas
                string query = "SELECT id_pass, titulo, email, usuario, pass, fecha_creacion, fecha_modificacion FROM Passwords";

                using (var command = new SQLiteCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Leer todas las filas de resultados
                        while (reader.Read())
                        {
                            // Crear una nueva nota con los datos de la fila actual
                            Password pass = new Password
                            {
                                idPass = reader.GetInt32(0),            // ID
                                titulo = reader.GetString(1),           // Título
                                email = reader.GetString(2),            // Email
                                usuario = reader.GetString(3),          // Usuario
                                pass = reader.GetString(4),             // Contraseña
                                fechaModificacion = reader.IsDBNull(6)
                                    ? (DateTime?)null
                                    : reader.GetDateTime(6)             // Fecha de modificación (si no es nula)
                            };

                            // Agregar la nota a la lista
                            listaPasswords.Add(pass);
                        }
                    }
                }
            }

            // Devolver la lista de notas
            return listaPasswords;
        }

        // ----------------------------------------------------------- MÉTODO QUE RECUPERA LAS CONTRASEÑAS QUE CONCUERDAN CON LA BÚSQUEDA
        public List<Password> MostrarNotasBusqueda(string valor)
        {
            List<Password> listaPasswords = new List<Password>();

            // Asegurarse de que el valor de búsqueda no esté vacío
            if (!string.IsNullOrEmpty(valor))
            {
                // Consulta SQL para buscar en los campos título y contenido
                string query = "SELECT id_pass, titulo, email, usuario, pass, fecha_creacion, fecha_modificacion FROM Passwords WHERE titulo LIKE @valor";

                using (SQLiteConnection conn = new SQLiteConnection(cadena)) // Suponiendo que 'cadena' es tu cadena de conexión
                {
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        // Agregar el parámetro con los valores de búsqueda
                        cmd.Parameters.AddWithValue("@valor", "%" + valor + "%");

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            // Leer los resultados y agregarlos a la lista
                            while (reader.Read())
                            {
                                // Crear un objeto Password con los datos de la base de datos
                                Password pass = new Password
                                {
                                    idPass = reader.GetInt32(0),            // ID
                                    titulo = reader.GetString(1),           // Título
                                    email = reader.GetString(2),            // Email
                                    usuario = reader.GetString(3),          // Usuario
                                    pass = reader.GetString(4),             // Contraseña
                                    fechaModificacion = reader.IsDBNull(6)
                                        ? (DateTime?)null
                                        : reader.GetDateTime(6)             // Fecha de modificación (si no es nula)
                                };

                                // Agregar la nota a la lista
                                listaPasswords.Add(pass);
                            }
                        }
                    }
                }
            }

            return listaPasswords;
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA UNA CONTRASEÑA POR SU ID_PASS
        public Nota MostrarUnaNota(int id)
        {
            // Crear una instancia vacía de Nota para almacenar los datos
            Nota nota = null;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para obtener una nota por su ID
                string query = "SELECT id_nota, titulo, contenido, fecha_creacion, fecha_modificacion FROM Notas WHERE id_nota = @Id";

                using (var command = new SQLiteCommand(query, conn))
                {
                    // Asignar el parámetro ID
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        // Verificar si se obtuvieron resultados
                        if (reader.Read())
                        {
                            // Crear la nota con los datos de la consulta
                            nota = new Nota
                            {
                                Id = reader.GetInt32(0), // ID
                                Titulo = reader.GetString(1), // Título
                                Contenido = reader.GetString(2), // Contenido (formato RTF)
                                FechaModificacion = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4) // Fecha de modificación (si no es nula)
                            };
                        }
                    }
                }
            }

            // Devolver la nota encontrada o null si no existe
            return nota;
        }

        // ----------------------------------------------------------- MÉTODO QUE BORRA UNA CONTRASEÑA
        public void BorrarUnaContrasena(int id)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para eliminar la nota por su ID
                string query = "DELETE FROM Passwords WHERE id_pass = @Id";

                // Crear el comando con la consulta SQL y la conexión
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar el valor del parámetro @Id
                    cmd.Parameters.AddWithValue("@Id", id);

                    // Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------- MÉTODO QUE ACTUALIZA UNA CONTRASEÑA
        public void ActualizarUnaContrasena(Password pass)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para eliminar la nota por su ID
                string query = "UPDATE Passwords SET titulo = @Titulo, email = @Email, usuario = @Usuario, pass = @Pass, fecha_modificacion = @FechaModificacion WHERE id_pass = @Id";

                // Crear el comando con la consulta SQL y la conexión
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar el valor del parámetro @Id
                    cmd.Parameters.AddWithValue("@Id", pass.idPass);
                    cmd.Parameters.AddWithValue("@Titulo", pass.titulo);
                    cmd.Parameters.AddWithValue("@Email", pass.email);
                    cmd.Parameters.AddWithValue("@Usuario", pass.usuario);
                    cmd.Parameters.AddWithValue("@Pass", pass.pass);
                    cmd.Parameters.AddWithValue("@FechaModificacion", pass.fechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));

                    // Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
