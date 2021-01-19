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
        public int Level { get; set; }
        public Race Race { get; set;  }
        public FightClass FightClass { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdon { get; set; }
        public string Hair { get; set; }
        public string Skin { get; set; }
        public string Eyes { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string PersonalityTraits { get; set; }
        public string Ideas { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string Organizations { get; set; }
        public string Allies { get; set; }
        public string Enemies { get; set; }
        public string Backstory { get; set; }
        public string Other { get; set; }
        public string Aligment { get; set; }
        public string Faith { get; set; }
        public string Lifestyle { get; set; }
        public string Description { get; set; }
        public string ProficiencyLanguageChoices { get; set; }
        public string BackgroundFeature { get; set; }
        public string BackgroundCharacteristics { get; set; }
        public string AttunedMagicItems { get; set; }
        public string StartingEquipment { get; set; }
        public string ActiveItems { get; set; }
        public string OtherPosessions { get; set; }
        public string AddItems { get; set; }
    }
}
