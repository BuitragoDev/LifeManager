using LifeManager.Datos;
using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Logica
{
    public class SerieLogica
    {
        SerieDatos datos = new SerieDatos();

        // Llamada al método que devuelve el último ID
        public int ObtenerUltimoIdSerie()
        {
            return datos.ObtenerUltimoIdSerie();
        }

        // Llamada al método que crea una serie
        public void CrearUnaSerie(Serie serie)
        {
            datos.CrearUnaSerie(serie);
        }

        // Llamada al método que muestra todas las series
        public List<Serie> MostrarTodasLasSeries()
        {
            return datos.MostrarTodasLasSeries();
        }

        // Llamada al método que muestra los detalles de una serie por su ID
        public Serie MostrarDetallesSerie(int id)
        {
            return datos.MostrarDetallesSerie(id);
        }

        // Llamada al método que borra una serie por su ID
        public void BorrarUnaSerie(int id)
        {
            datos.BorrarUnaSerie(id);
        }

        // Llamada el método que hace la búsqueda del buscador
        public List<Serie> MostrarSeriesBusqueda(string valor)
        {
            return datos.MostrarSeriesBusqueda(valor);
        }

        // Llamada al método que actualiza una serie por su ID
        public void ActualizarUnaSerie(Serie serie)
        {
            datos.ActualizarUnaSerie(serie);
        }
    }
}
