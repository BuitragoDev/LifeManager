using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Datos
{
    public class LibroDatos : Conexion {

        // ----------------------------------------------------------------------------- MÉTODO QUE DEVUELVE EL ÚLTIMO ID
        public int ObtenerUltimoIdLibro()
        {
            int ultimoId = 0;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "SELECT MAX(id_libro) FROM libros";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    var result = cmd.ExecuteScalar();
                    // Verificar si el resultado no es nulo y convertirlo a int
                    if (result != DBNull.Value && result != null)
                    {
                        ultimoId = Convert.ToInt32(result);
                    }
                }
            }

            return ultimoId;
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE CREA UN LIBRO NUEVO
        public void CrearUnLibro(Libro libro)
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = @"
            INSERT INTO libros 
            (isbn, titulo, autor, editorial, paginas, idioma, formato, fechaLectura, sinopsis)
            VALUES 
            (@isbn, @titulo, @autor, @editorial, @paginas, @idioma, @formato, @fechaLectura, @sinopsis)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@isbn", libro.Isbn);
                    cmd.Parameters.AddWithValue("@titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@editorial", libro.Editorial ?? (object)DBNull.Value); // Manejar null
                    cmd.Parameters.AddWithValue("@paginas", libro.Paginas);
                    cmd.Parameters.AddWithValue("@idioma", libro.Idioma ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@formato", libro.Formato ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@fechaLectura", libro.FechaLectura.HasValue ? libro.FechaLectura.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@sinopsis", libro.Sinopsis ?? (object)DBNull.Value);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA TODOS LOS LIBROS
        public List<Libro> MostrarTodosLosLibros()
        {
            // Crear una lista para almacenar las notas
            List<Libro> listaLibros = new List<Libro>();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para recuperar todas las notas
                string query = "SELECT isbn, titulo, autor, editorial, paginas, idioma, formato, fechaLectura, sinopsis FROM Libros";

                using (var command = new SQLiteCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Leer todas las filas de resultados
                        while (reader.Read())
                        {
                            // Crear una nueva nota con los datos de la fila actual
                            Libro libro = new Libro
                            {
                                Isbn = reader["isbn"].ToString(),
                                Titulo = reader["titulo"].ToString(),
                                Autor = reader["autor"].ToString(),
                                Editorial = reader["editorial"].ToString(),
                                Paginas = reader["paginas"] != DBNull.Value ? Convert.ToInt32(reader["paginas"]) : 0,
                                Idioma = reader["idioma"].ToString(),
                                Formato = reader["formato"].ToString(),
                                FechaLectura = reader["fechaLectura"] != DBNull.Value ? Convert.ToDateTime(reader["fechaLectura"]) : (DateTime?)null,
                                Sinopsis = reader["sinopsis"].ToString()
                            };

                            // Agregar la nota a la lista
                            listaLibros.Add(libro);
                        }
                    }
                }
            }

            // Devolver la lista de notas
            return listaLibros;
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA UN LIBRO POR SU ISBN
        public Libro MostrarDetallesLibro(string isbn)
        {
            // Crear un objeto Libro para almacenar los detalles
            Libro libro = null; // Inicializamos como null para indicar que no se ha encontrado aún

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para recuperar el libro por su ISBN
                string query = "SELECT isbn, titulo, autor, editorial, paginas, idioma, formato, fechaLectura, sinopsis FROM Libros WHERE isbn = @Isbn";

                using (var command = new SQLiteCommand(query, conn))
                {
                    // Añadir el parámetro para la consulta SQL
                    command.Parameters.AddWithValue("@Isbn", isbn);

                    // Ejecutar la consulta y leer los resultados
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Verificamos si se encuentra un libro con el ISBN proporcionado
                        {
                            libro = new Libro
                            {
                                Isbn = reader["isbn"].ToString(),
                                Titulo = reader["titulo"].ToString(),
                                Autor = reader["autor"].ToString(),
                                Editorial = reader["editorial"].ToString(),
                                Paginas = reader["paginas"] != DBNull.Value ? Convert.ToInt32(reader["paginas"]) : 0,
                                Idioma = reader["idioma"].ToString(),
                                Formato = reader["formato"].ToString(),
                                FechaLectura = reader["fechaLectura"] != DBNull.Value ? Convert.ToDateTime(reader["fechaLectura"]) : (DateTime?)null,
                                Sinopsis = reader["sinopsis"].ToString()
                            };
                        }
                    }
                }
            }

            // Devolver el objeto Libro con los detalles o null si no se encontró
            return libro;
        }

        // ----------------------------------------------------------- MÉTODO QUE BORRA UN LIBRO
        public void BorrarUnLibro(string isbn)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para eliminar la nota por su ID
                string query = "DELETE FROM Libros WHERE isbn = @Isbn";

                // Crear el comando con la consulta SQL y la conexión
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar el valor del parámetro @Id
                    cmd.Parameters.AddWithValue("@Isbn", isbn);

                    // Ejecutar el comando de eliminación
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------- MÉTODO QUE RECUPERA LOS LIBROS QUE CONCUERDAN CON LA BÚSQUEDA
        public List<Libro> MostrarLibrosBusqueda(string valor)
        {
            List<Libro> libros = new List<Libro>();

            // Asegurarse de que el valor de búsqueda no esté vacío
            if (!string.IsNullOrEmpty(valor))
            {
                // Consulta SQL para buscar en los campos título y contenido
                string query = "SELECT isbn, titulo, autor, editorial, paginas, idioma, formato, fechaLectura, sinopsis FROM Libros WHERE titulo LIKE @valor OR autor LIKE @valor OR editorial LIKE @valor OR sinopsis LIKE @valor";

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
                                // Crear un objeto Libro con los datos de la base de datos
                                Libro oLibro = new Libro
                                {
                                    Isbn = reader["isbn"].ToString(),
                                    Titulo = reader["titulo"].ToString(),
                                    Autor = reader["autor"].ToString(),
                                    Editorial = reader["editorial"].ToString(),
                                    Paginas = reader["paginas"] != DBNull.Value ? Convert.ToInt32(reader["paginas"]) : 0,
                                    Idioma = reader["idioma"].ToString(),
                                    Formato = reader["formato"].ToString(),
                                    FechaLectura = reader["fechaLectura"] != DBNull.Value ? Convert.ToDateTime(reader["fechaLectura"]) : (DateTime?)null,
                                    Sinopsis = reader["sinopsis"].ToString()
                                };

                                // Agregar la nota a la lista
                                libros.Add(oLibro);
                            }
                        }
                    }
                }
            }

            return libros;
        }

        // ----------------------------------------------------------- MÉTODO QUE ACTUALIZA UN LIBRO
        public void ActualizarUnLibro(Libro libro)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para actualizar los campos del libro según su ISBN
                string query = "UPDATE Libros SET " +
                               "titulo = @Titulo, " +
                               "autor = @Autor, " +
                               "editorial = @Editorial, " +
                               "paginas = @Paginas, " +
                               "idioma = @Idioma, " +
                               "formato = @Formato, " +
                               "fechaLectura = @FechaLectura, " +
                               "sinopsis = @Sinopsis " +
                               "WHERE isbn = @Isbn";

                // Crear el comando con la consulta SQL y la conexión
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar los valores de los parámetros
                    cmd.Parameters.AddWithValue("@Isbn", libro.Isbn);
                    cmd.Parameters.AddWithValue("@Titulo", libro.Titulo);
                    cmd.Parameters.AddWithValue("@Autor", libro.Autor);
                    cmd.Parameters.AddWithValue("@Editorial", libro.Editorial);
                    cmd.Parameters.AddWithValue("@Paginas", libro.Paginas);
                    cmd.Parameters.AddWithValue("@Idioma", libro.Idioma);
                    cmd.Parameters.AddWithValue("@Formato", libro.Formato);
                    cmd.Parameters.AddWithValue("@FechaLectura", libro.FechaLectura.HasValue ? (object)libro.FechaLectura.Value : DBNull.Value); // Si es null, asignar DBNull
                    cmd.Parameters.AddWithValue("@Sinopsis", libro.Sinopsis);

                    // Ejecutar el comando para actualizar el libro
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
