using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace PracticaMongo.Modelos
{
    public static class clsConexionMongoDB
    {
        /// <summary>
        /// Obteiene la coleccion de usuarios
        /// </summary>
        /// <returns> IMongoCollection<clsUsuarioModelo> </returns>
        public static IMongoCollection<clsUsuarioModelo> ObtenerUsuariosColeccion()
        {
            MongoClient oClienteBD = new MongoClient("mongodb://localhost");
            var db = oClienteBD.GetDatabase("control");
            return db.GetCollection<clsUsuarioModelo>("usuario");
        }

    }
}
