using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeManager.Entidades;

namespace LifeManager.Datos
{
    public class NotaDatos : Conexion {

        // ----------------------------------------------------------------------------- MÉTODO QUE CREA UNA NOTA NUEVA
        public void CrearUnaNota(Nota nota)
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "INSERT INTO Notas (titulo, contenido, fecha_creacion, fecha_modificacion) VALUES (@Titulo, @Contenido, @FechaCreacion, @FechaModificacion)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Titulo", nota.Titulo);
                    cmd.Parameters.AddWithValue("@Contenido", nota.Contenido);
                    cmd.Parameters.AddWithValue("@FechaCreacion", nota.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.Parameters.AddWithValue("@FechaModificacion", nota.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA TODAS LAS NOTAS
        public List<Nota> MostrarTodasLasNotas()
        {
            // Crear una lista para almacenar las notas
            List<Nota> listaNotas = new List<Nota>();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para recuperar todas las notas
                string query = "SELECT id_nota, titulo, contenido, fecha_creacion, fecha_modificacion FROM Notas";

                using (var command = new SQLiteCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Leer todas las filas de resultados
                        while (reader.Read())
                        {
                            // Crear una nueva nota con los datos de la fila actual
                            Nota nota = new Nota
                            {
                                Id = reader.GetInt32(0),                // ID
                                Titulo = reader.GetString(1),           // Título
                                Contenido = reader.GetString(2),        // Contenido (formato RTF)
                                FechaModificacion = reader.IsDBNull(4)
                                    ? (DateTime?)null
                                    : reader.GetDateTime(4)             // Fecha de modificación (si no es nula)
                            };

                            // Agregar la nota a la lista
                            listaNotas.Add(nota);
                        }
                    }
                }
            }

            // Devolver la lista de notas
            return listaNotas;
        }

        // ----------------------------------------------------------- MÉTODO QUE RECUPERA LAS NOTAS QUE CONCUERDAN CON LA BÚSQUEDA
        public List<Nota> MostrarNotasBusqueda(string valor)
        {
            List<Nota> notas = new List<Nota>();

            // Asegurarse de que el valor de búsqueda no esté vacío
            if (!string.IsNullOrEmpty(valor))
            {
                // Consulta SQL para buscar en los campos título y contenido
                string query = "SELECT id_nota, titulo, contenido, fecha_creacion, fecha_modificacion FROM Notas WHERE titulo LIKE @valor OR contenido LIKE @valor";

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
                                // Crear un objeto Nota con los datos de la base de datos
                                Nota nota = new Nota
                                {
                                    Id = Convert.ToInt32(reader["id_nota"]),
                                    Titulo = reader["titulo"].ToString(),
                                    Contenido = reader["contenido"].ToString(),
                                    FechaModificacion = reader.IsDBNull(4)
                                    ? (DateTime?)null
                                    : reader.GetDateTime(4)             // Fecha de modificación (si no es nula)
                                };

                                // Agregar la nota a la lista
                                notas.Add(nota);
                            }
                        }
                    }
                }
            }

            return notas;
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA UNA NOTA POR SU ID_NOTA
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

        // ----------------------------------------------------------- MÉTODO QUE BORRA UNA NOTA
        public void BorrarUnaNota(int id)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para eliminar la nota por su ID
                string query = "DELETE FROM Notas WHERE id_nota = @Id";

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

        // ----------------------------------------------------------- MÉTODO QUE ACTUALIZA UNA NOTA
        public void ActualizarUnaNota(Nota nota)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para eliminar la nota por su ID
                string query = "UPDATE Notas SET titulo = @Titulo, contenido = @Contenido, fecha_modificacion = @FechaModificacion WHERE id_nota = @Id";

                // Crear el comando con la consulta SQL y la conexión
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar el valor del parámetro @Id
                    cmd.Parameters.AddWithValue("@Id", nota.Id);
                    cmd.Parameters.AddWithValue("@Titulo", nota.Titulo);
                    cmd.Parameters.AddWithValue("@Contenido", nota.Contenido);
                    cmd.Parameters.AddWithValue("@FechaModificacion", nota.FechaCreacion.ToString("yyyy-MM-dd HH:mm:ss"));

                    // Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
