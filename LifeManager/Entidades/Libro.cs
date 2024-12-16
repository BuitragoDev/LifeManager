using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Entidades
{
    public class Libro {
        // Atributos
        public int IdLibro { get; set; }
        public string Isbn { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int Paginas { get; set; }
        public string Idioma { get; set; }
        public string Formato { get; set; }
        public DateTime? FechaLectura { get; set; }
        public string Sinopsis { get; set; }

        // Constructor vacío
        public Libro()
        {
        }

        // Constructor con todos los atributos
        public Libro(int idLibro, string isbn, string titulo, string autor, string editorial, int paginas, string idioma, string formato, DateTime? fechaLectura, string sinopsis)
        {
            IdLibro = idLibro;
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Paginas = paginas;
            Idioma = idioma;
            Formato = formato;
            FechaLectura = fechaLectura;
            Sinopsis = sinopsis;
        }

        // Constructor parcial (sin ID, ideal para nuevos libros)
        public Libro(string isbn, string titulo, string autor, string editorial, int paginas, string idioma, string formato, DateTime? fechaLectura, string sinopsis)
        {
            Isbn = isbn;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Paginas = paginas;
            Idioma = idioma;
            Formato = formato;
            FechaLectura = fechaLectura;
            Sinopsis = sinopsis;
        }

        // Método ToString para facilitar la visualización de datos
        public override string ToString()
        {
            return $"ID: {IdLibro}, ISBN: {Isbn}, Título: {Titulo}, Autor: {Autor}, Editorial: {Editorial}, Páginas: {Paginas}, Idioma: {Idioma}, Formato: {Formato}, Fecha de Lectura: {FechaLectura?.ToString("yyyy-MM-dd") ?? "No leído"}, Sinopsis: {Sinopsis}";
        }
    }
}
