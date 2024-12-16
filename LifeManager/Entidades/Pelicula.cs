using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Entidades
{
    public class Pelicula {
        // Atributos
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public int Duracion { get; set; }
        public DateTime? FechaVisionado { get; set; }
        public int? Puntuacion { get; set; }
        public string Trama { get; set; }

        // Constructor por defecto
        public Pelicula()
        {
        }

        // Constructor con todos los parámetros
        public Pelicula(int idPelicula, string titulo, int anio, string genero, int duracion, DateTime? fechaVisionado, int? puntuacion, string trama)
        {
            IdPelicula = idPelicula;
            Titulo = titulo;
            Anio = anio;
            Genero = genero;
            Duracion = duracion;
            FechaVisionado = fechaVisionado;
            Puntuacion = puntuacion;
            Trama = trama;
        }

        // Constructor sin IdPelicula (para nuevas películas)
        public Pelicula(string titulo, int anio, string genero, int duracion, DateTime? fechaVisionado, int? puntuacion, string trama)
        {
            Titulo = titulo;
            Anio = anio;
            Genero = genero;
            Duracion = duracion;
            FechaVisionado = fechaVisionado;
            Puntuacion = puntuacion;
            Trama = trama;
        }

        // Método ToString (opcional, para imprimir la información de la película)
        public override string ToString()
        {
            return $"ID: {IdPelicula}, Título: {Titulo}, Año: {Anio}, Género: {Genero}, Duración: {Duracion} min, " +
                   $"Fecha Visionado: {(FechaVisionado.HasValue ? FechaVisionado.Value.ToString("yyyy-MM-dd") : "No vista")}, " +
                   $"Puntuación: {(Puntuacion.HasValue ? Puntuacion.Value.ToString() : "Sin puntuación")}" + 
                   $"Trama: {Trama}";
        }
    }
}
