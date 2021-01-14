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
        public Race Race { get; set;  }
        public FightClass FightClass { get; set; }
        public AbilitiesEntity.Abilities Abilities { get; set; }
        public DescriptionEntitys.Description Description { get; set; }
        public Equipment Equipment { get; set; }
    }
}
