using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Agregar la libreria de la base de datos.


namespace clase08mdb
{
    internal class conexion
    {
        // Parámetros para la cadena de conexión
        public string servidor, usuario, clave, db;
        public string cadena;

        // Función que tendrá la cadena de conexión
        public void conec()
        {
            servidor = "3375898HP"; // Cambia por el nombre real de tu servidor
            db = "BD_PC260152";
            usuario = "sa";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;


        }
    }
}
