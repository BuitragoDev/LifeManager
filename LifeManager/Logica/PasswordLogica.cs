using LifeManager.Datos;
using LifeManager.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeManager.Logica
{
    public class PasswordLogica
    {
        PasswordDatos datos = new PasswordDatos();

        // Llamada al método que crea una contraseña
        public void CrearContrasena(Password pass)
        {
            datos.CrearUnaContrasena(pass);
        }

        // Llama al método que muestra todas las contraseñas
        public List<Password> MostrarTodasLasPasswords()
        {
            return datos.MostrarTodasLasPasswords();
        }

        // Llama al método que busca los resultados de la búsqueda
        public List<Password> MostrarNotasBusqueda(string valor)
        {
            return datos.MostrarNotasBusqueda(valor);
        }

        // Llama al método que borra una contraseña
        public void BorrarUnaContrasena(int id)
        {
            datos.BorrarUnaContrasena(id);
        }

        // Llama al método que actualiza una contraseña
        public void ActualizarUnaContrasena(Password pass)
        {
            datos.ActualizarUnaContrasena(pass);
        }
    }
}
