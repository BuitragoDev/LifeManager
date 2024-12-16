using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Datos
{
    public class SerieDatos : Conexion {

        // ----------------------------------------------------------------------------- MÉTODO QUE DEVUELVE EL ÚLTIMO ID
        public int ObtenerUltimoIdSerie()
        {
            int ultimoId = 0;

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = "SELECT MAX(id_serie) FROM Series";

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

        // ----------------------------------------------------------------------------- MÉTODO QUE CREA UNA SERIE NUEVA
        public void CrearUnaSerie(Serie serie)
        {
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();
                string query = @"INSERT INTO Series (id_serie, titulo, anio, genero, episodios, fechaVisionado, puntuacion, trama)
                               VALUES (@idSerie, @titulo, @anio, @genero, @episodios, @fechaVisionado, @puntuacion, @trama)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar parámetros
                    cmd.Parameters.AddWithValue("@idSerie", serie.IdSerie);
                    cmd.Parameters.AddWithValue("@titulo", serie.Titulo);
                    cmd.Parameters.AddWithValue("@anio", serie.Anio);
                    cmd.Parameters.AddWithValue("@genero", serie.Genero);
                    cmd.Parameters.AddWithValue("@episodios", serie.Episodios);
                    cmd.Parameters.AddWithValue("@puntuacion", serie.Puntuacion);
                    cmd.Parameters.AddWithValue("@fechaVisionado", serie.FechaVisionado.HasValue ? serie.FechaVisionado.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@trama", serie.Trama);

                    // Ejecutar la consulta
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA TODAS LAS SERIES
        public List<Serie> MostrarTodasLasSeries()
        {
            // Crear una lista para almacenar las notas
            List<Serie> listaSeries = new List<Serie>();

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para recuperar todas las notas
                string query = "SELECT id_serie, titulo, anio, genero, episodios, fechaVisionado, puntuacion, trama FROM Series";

                using (var command = new SQLiteCommand(query, conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        // Leer todas las filas de resultados
                        while (reader.Read())
                        {
                            // Crear una nueva nota con los datos de la fila actual
                            Serie serie = new Serie
                            {
                                IdSerie = Convert.ToInt32(reader["id_serie"]),
                                Titulo = reader["titulo"].ToString(),
                                Genero = reader["genero"].ToString(),
                                Episodios = Convert.ToInt32(reader["episodios"]),
                                Anio = Convert.ToInt32(reader["anio"]),
                                Puntuacion = reader["puntuacion"] != DBNull.Value ? Convert.ToInt32(reader["puntuacion"]) : (int?)null,
                                FechaVisionado = reader["fechaVisionado"] != DBNull.Value ? Convert.ToDateTime(reader["fechaVisionado"]) : (DateTime?)null,
                                Trama = reader["trama"].ToString()
                            };


                            // Agregar la nota a la lista
                            listaSeries.Add(serie);
                        }
                    }
                }
            }

            // Devolver la lista de notas
            return listaSeries;
        }

        // ----------------------------------------------------------------------------- MÉTODO QUE RECUPERA UNA SERIE POR SU ID
        public Serie MostrarDetallesSerie(int id)
        {
            // Crear un objeto Libro para almacenar los detalles
            Serie serie = null; // Inicializamos como null para indicar que no se ha encontrado aún

            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                conn.Open();

                // Consulta SQL para recuperar el libro por su ISBN
                string query = "SELECT id_serie, titulo, anio, genero, episodios, fechaVisionado, puntuacion, trama FROM Series WHERE id_serie = @IdSerie";

                using (var command = new SQLiteCommand(query, conn))
                {
                    // Añadir el parámetro para la consulta SQL
                    command.Parameters.AddWithValue("@IdSerie", id);

                    // Ejecutar la consulta y leer los resultados
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Verificamos si se encuentra un libro con el ISBN proporcionado
                        {
                            // Crear una nueva nota con los datos de la fila actual
                            serie = new Serie
                            {
                                IdSerie = Convert.ToInt32(reader["id_serie"]),
                                Titulo = reader["titulo"].ToString(),
                                Genero = reader["genero"].ToString(),
                                Episodios = Convert.ToInt32(reader["episodios"]),
                                Anio = Convert.ToInt32(reader["anio"]),
                                Puntuacion = reader["puntuacion"] != DBNull.Value ? Convert.ToInt32(reader["puntuacion"]) : (int?)null,
                                FechaVisionado = reader["fechaVisionado"] != DBNull.Value ? Convert.ToDateTime(reader["fechaVisionado"]) : (DateTime?)null,
                                Trama = reader["trama"].ToString()
                            };
                        }
                    }
                }
            }

            // Devolver el objeto Libro con los detalles o null si no se encontró
            return serie;
        }

        // ----------------------------------------------------------- MÉTODO QUE BORRA UNA SERIE
        public void BorrarUnaSerie(int id)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para eliminar la nota por su ID
                string query = "DELETE FROM Series WHERE id_serie = @Id";

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

        // ----------------------------------------------------------- MÉTODO QUE ACTUALIZA UNA PELICULA
        public void ActualizarUnaSerie(Serie serie)
        {
            // Establecer la conexión con la base de datos
            using (SQLiteConnection conn = new SQLiteConnection(cadena))
            {
                // Abrir la conexión
                conn.Open();

                // Consulta SQL para actualizar los campos de la película
                string query = @"UPDATE Series SET titulo = @titulo, 
                                                      anio = @anio, 
                                                      genero = @genero, 
                                                      episodios = @episodios, 
                                                      fechaVisionado = @fechaVisionado, 
                                                      puntuacion = @puntuacion, 
                                                      trama = @trama
                                                  WHERE id_serie = @id_serie";

                // Crear el comando con la consulta SQL y la conexión
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    // Asignar los valores de los parámetros
                    cmd.Parameters.AddWithValue("@titulo", serie.Titulo);
                    cmd.Parameters.AddWithValue("@anio", serie.Anio);
                    cmd.Parameters.AddWithValue("@genero", serie.Genero);
                    cmd.Parameters.AddWithValue("@episodios", serie.Episodios);
                    cmd.Parameters.AddWithValue("@fechaVisionado", serie.FechaVisionado.HasValue ? serie.FechaVisionado.Value.ToString("yyyy-MM-dd") : (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@puntuacion", serie.Puntuacion);
                    cmd.Parameters.AddWithValue("@trama", serie.Trama);
                    cmd.Parameters.AddWithValue("@id_serie", serie.IdSerie);

                    // Ejecutar el comando para actualizar la película
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ----------------------------------------------------------- MÉTODO QUE RECUPERA LAS PELICULAS QUE CONCUERDAN CON LA BÚSQUEDA
        public List<Serie> MostrarSeriesBusqueda(string valor)
        {
            List<Serie> series = new List<Serie>();

            // Asegurarse de que el valor de búsqueda no esté vacío
            if (!string.IsNullOrEmpty(valor))
            {
                // Consulta SQL para buscar en los campos título y contenido
                string query = "SELECT id_serie, titulo, genero, episodios, puntuacion, anio, fechaVisionado, trama FROM Series WHERE titulo LIKE @valor OR genero LIKE @valor OR trama LIKE @valor";

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
                                Serie oSerie = new Serie
                                {
                                    IdSerie = Convert.ToInt32(reader["id_serie"]),
                                    Titulo = reader["titulo"].ToString(),
                                    Genero = reader["genero"].ToString(),
                                    Episodios = Convert.ToInt32(reader["episodios"]),
                                    Anio = Convert.ToInt32(reader["anio"]),
                                    Puntuacion = reader["puntuacion"] != DBNull.Value ? Convert.ToInt32(reader["puntuacion"]) : (int?)null,
                                    FechaVisionado = reader["fechaVisionado"] != DBNull.Value ? Convert.ToDateTime(reader["fechaVisionado"]) : (DateTime?)null,
                                    Trama = reader["trama"].ToString()
                                };

                                // Agregar la nota a la lista
                                series.Add(oSerie);
                            }
                        }
                    }
                }
            }

            return series;
        }
    }
}
