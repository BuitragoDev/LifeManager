using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Entidades
{
    public class Serie
    {
        // Atributos
        public int IdSerie { get; set; }
        public string Titulo { get; set; }
        public int Anio { get; set; }
        public string Genero { get; set; }
        public int Episodios { get; set; }
        public DateTime? FechaVisionado { get; set; }
        public int? Puntuacion { get; set; }
        public string Trama { get; set; }

        // Constructor por defecto
        public Serie()
        {
        }

        // Constructor con todos los parámetros
        public Serie(int idSerie, string titulo, int anio, string genero, int episodios, DateTime? fechaVisionado, int? puntuacion, string trama)
        {
            IdSerie = idSerie;
            Titulo = titulo;
            Anio = anio;
            Genero = genero;
            Episodios = episodios;
            FechaVisionado = fechaVisionado;
            Puntuacion = puntuacion;
            Trama = trama;
        }

        // Constructor sin IdPelicula (para nuevas películas)
        public Serie(string titulo, int anio, string genero, int episodios, DateTime? fechaVisionado, int? puntuacion, string trama)
        {
            Titulo = titulo;
            Anio = anio;
            Genero = genero;
            Episodios = episodios;
            FechaVisionado = fechaVisionado;
            Puntuacion = puntuacion;
            Trama = trama;
        }

        // Método ToString (opcional, para imprimir la información de la película)
        public override string ToString()
        {
            return $"ID: {IdSerie}, Título: {Titulo}, Año: {Anio}, Género: {Genero}, Episodios: {Episodios} min, " +
                   $"Fecha Visionado: {(FechaVisionado.HasValue ? FechaVisionado.Value.ToString("yyyy-MM-dd") : "No vista")}, " +
                   $"Puntuación: {(Puntuacion.HasValue ? Puntuacion.Value.ToString() : "Sin puntuación")}" +
                   $"Trama: {Trama}";
        }
    }
}
