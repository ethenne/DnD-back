using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DnDBackend.Models
{
    public class Character
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        public string CharacterName { get; set; }
        public string Race { get; set;  }
        public string FightClass { get; set; }
        public object Abilities { get; set; }
        public object Description { get; set; }
        public object Equipment { get; set; }
    }
}
