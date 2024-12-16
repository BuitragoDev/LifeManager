using LifeManager.Datos;
using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Logica
{
    public class PeliculaLogica {
        PeliculaDatos datos = new PeliculaDatos();

        // Llamada al método que devuelve el último ID
        public int ObtenerUltimoIdPelicula()
        {
            return datos.ObtenerUltimoIdPelicula();
        }

        // Llamada al método que crea una pelicula
        public void CrearUnaPelicula(Pelicula pelicula)
        {
            datos.CrearUnaPelicula(pelicula);
        }

        // Llamada al método que muestra todas las películas
        public List<Pelicula> MostrarTodasLasPeliculas()
        {
            return datos.MostrarTodasLasPeliculas();
        }

        // Llamada al método que muestra los detalles de una película por su ID
        public Pelicula MostrarDetallesPelicula(int id)
        {
            return datos.MostrarDetallesPelicula(id);
        }

        // Llamada al método que borra una película por su ID
        public void BorrarUnaPelicula(int id)
        {
            datos.BorrarUnaPelicula(id);
        }

        // Llamada el método que hace la búsqueda del buscador
        public List<Pelicula> MostrarPeliculasBusqueda(string valor)
        {
            return datos.MostrarPeliculasBusqueda(valor);
        }

        // Llamada al método que actualiza una película por su ID
        public void ActualizarUnaPelicula(Pelicula pelicula)
        {
            datos.ActualizarUnaPelicula(pelicula);
        }
    }
}
