﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Servicios.Api.Libreria.Core.Entities
{
    public class Autor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("apellido")]
        public string Apellido { get; set; }

        [BsonElement("gradoAcademico")]
        public string GradoAcademico { get; set; }
    }
}
