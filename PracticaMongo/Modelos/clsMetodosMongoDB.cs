using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMongo.Modelos
{
    public static class clsMetodosMongoDB
    {  

        /// <summary>
        /// Crear un usuario
        /// </summary>
        /// <param name="oUsuario"></param>
        public static void CrearUsuario(clsUsuarioModelo oUsuario)
        {
            var coleccionBD = clsConexionMongoDB.ObtenerUsuariosColeccion();
            coleccionBD.InsertOne(oUsuario);
        }

        /// <summary>
        /// Actualiza un usuario
        /// </summary>
        /// <param name="oUsuario"></param>
        /// <param name="sMatricula"></param>
        public static void ActualizarUsuario(clsUsuarioModelo oUsuario, String sMatricula)
        {
            var coleccionBD = clsConexionMongoDB.ObtenerUsuariosColeccion();
            coleccionBD.ReplaceOne(D => D.MatriculaUsuario == sMatricula, oUsuario);
        }

        /// <summary>
        /// Elimina un usuario
        /// </summary>
        /// <param name="oUsuario"></param>
        public static void Eliminarusuario(clsUsuarioModelo oUsuario)
        {
            var coleccionBD = clsConexionMongoDB.ObtenerUsuariosColeccion();
            coleccionBD.DeleteOne(D => D.MatriculaUsuario == oUsuario.MatriculaUsuario);
        }

       /// <summary>
       /// Obtiene usuario
       /// </summary>
       /// <param name="sMatricula"></param>
       /// <returns> UsuarioModel</returns>
        public static clsUsuarioModelo ObtenerUsuario(String sMatricula)
        {
            try
            {
                var coleccionDB = clsConexionMongoDB.ObtenerUsuariosColeccion();
                return coleccionDB.Find(D => D.MatriculaUsuario == sMatricula).First();
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }
     
    }
}
