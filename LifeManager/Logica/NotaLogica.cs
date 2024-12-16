using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeManager.Datos;
using LifeManager.Entidades;

namespace LifeManager.Logica
{
    public class NotaLogica {

        NotaDatos datos = new NotaDatos();

        // Llamada al método que crea una nota
        public void CrearNota(Nota nota)
        {
            datos.CrearUnaNota(nota);
        }

        // Llama al método que muestra todas las notas
        public List<Nota> MostrarTodasLasNotas()
        {
            return datos.MostrarTodasLasNotas();
        }

        // Llama al método que busca los resultados de la búsqueda
        public List<Nota> MostrarNotasBusqueda(string valor)
        {
            return datos.MostrarNotasBusqueda(valor);
        }

        // Llama al método que borra una nota
        public void BorrarUnaNota(int id)
        {
            datos.BorrarUnaNota(id);
        }

        // Llama al método que actualiza una nota
        public void ActualizarUnaNota(Nota nota)
        {
            datos.ActualizarUnaNota(nota);
        }
    }
}
