using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeManager.Datos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;


        private static Conexion conn = null;

        public Conexion() { }

        public static Conexion Instancia
        {
            get
            {
                if (conn == null)
                {
                    conn = new Conexion();
                }
                return conn;
            }
        }

    }
}
