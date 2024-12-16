using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Entidades
{
    public class Password {

        // Atributos
        public int idPass { get; set; } // Identificador único de la contraseña
        public string titulo { get; set; } // Título de la contraseña
        public string email { get; set; } // Email del usuario
        public string usuario { get; set; } // Usuario de la contraseña
        public string pass { get; set; } // Contraseña
        public DateTime fechaCreacion { get; set; } // Fecha de creación de la contraseña
        public DateTime? fechaModificacion { get; set; } // Fecha de última modificación (opcional)

        // Constructor vacío
        public Password()
        {
            fechaCreacion = DateTime.Now; // Se asigna automáticamente la fecha actual
        }

        // Constructor con parámetros
        public Password(int id, string titulo, string email, string usuario, string pass)
        {
            this.idPass = id;
            this.titulo = titulo;
            this.email = email;
            this.usuario = usuario;
            this.pass = pass;
            this.fechaCreacion = DateTime.Now; // Se asigna automáticamente la fecha actual
        }

        // Método para actualizar el usuario y registrar la modificación
        public void Actualizarusuario(int id, string titulo, string email, string usuario, string pass, string fechaModificacion)
        {
            this.idPass = id;
            this.titulo = titulo;
            this.email = email;
            this.usuario = usuario;
            this.pass = pass;
            this.fechaModificacion = DateTime.Now; // Se asigna automáticamente la fecha actual
        }

        // Método para mostrar la información de la nota como cadena
        public override string ToString()
        {
            return $"ID: {idPass}, Título: {titulo}, email: {email}, usuario: {usuario}, Pass: {pass}, Creado: {fechaCreacion}, Modificado: {fechaModificacion}";
        }
    }
}
