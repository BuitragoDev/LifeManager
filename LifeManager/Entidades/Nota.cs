using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Entidades
{
    public class Nota {

        // Atributos
        private int id; // Identificador único de la nota
        private string titulo; // Título de la nota
        private string contenido; // Contenido de la nota
        private DateTime fechaCreacion; // Fecha de creación de la nota
        private DateTime? fechaModificacion; // Fecha de última modificación (opcional)

        // Constructor vacío
        public Nota()
        {
            fechaCreacion = DateTime.Now; // Se asigna automáticamente la fecha actual
        }

        // Constructor con parámetros
        public Nota(int id, string titulo, string contenido)
        {
            this.id = id;
            this.titulo = titulo;
            this.contenido = contenido;
            this.fechaCreacion = DateTime.Now; // Se asigna automáticamente la fecha actual
        }

        // Propiedades (getters y setters)
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Contenido
        {
            get { return contenido; }
            set { contenido = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
        }

        public DateTime? FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        // Método para actualizar el contenido y registrar la modificación
        public void ActualizarContenido(string nuevoContenido)
        {
            contenido = nuevoContenido;
            fechaModificacion = DateTime.Now;
        }

        // Método para mostrar la información de la nota como cadena
        public override string ToString()
        {
            return $"ID: {id}, Título: {titulo}, Creado: {fechaCreacion}, Modificado: {fechaModificacion}, Contenido: {contenido}";
        }
    }
}
