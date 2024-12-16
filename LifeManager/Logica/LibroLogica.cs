using LifeManager.Datos;
using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Logica
{
    public class LibroLogica {
        LibroDatos datos = new LibroDatos();

        // Llamada al método que devuelve el último ID
        public int ObtenerUltimoIdLibro()
        {
            return datos.ObtenerUltimoIdLibro();
        }

        // Llamada al método que crea un libro
        public void CrearUnLibro(Libro libro)
        {
            datos.CrearUnLibro(libro);
        }

        // Llamada al método que muestra todos los libros
        public List<Libro> MostrarTodosLosLibros()
        {
            return datos.MostrarTodosLosLibros();
        }

        // Llamada al método que muestra los detalles de un libro por su ISBN
        public Libro MostrarDetallesLibro(string isbn)
        {
            return datos.MostrarDetallesLibro(isbn);
        }

        // Llamada al método que borra un libro por su ISBN
        public void BorrarUnLibro(string isbn)
        {
            datos.BorrarUnLibro(isbn);
        }

        // Llamada el método que hace la búsqueda del buscador
        public List<Libro> MostrarLibrosBusqueda(string valor)
        {
            return datos.MostrarLibrosBusqueda(valor);
        }

        // Llamada al método que actualiza un libro por su ISBN
        public void ActualizarUnLibro(Libro libro)
        {
            datos.ActualizarUnLibro(libro);
        }
    }
}
