using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaMongo.Modelos
{
    public class clsUsuarioModelo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String Id;
        [BsonElement]
        public String MatriculaUsuario;
        [BsonElement]
        public String Nombre;
        [BsonElement]
        public String ApellidoP;
        [BsonElement]
        public String ApellidoM;
        [BsonElement]
        public List<string> Permisos;
        [BsonElement]
        public String FechaHoraEntrada;
        [BsonElement]
        public String FechaHoraSalida;
    }
}
