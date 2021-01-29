using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDBackend.Models;
using MongoDB.Driver;

namespace DnDBackend.Services
{
    public class CharactersService
    {
        private readonly IMongoCollection<Character> _characters;

        public CharactersService(ICharactersDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _characters = database.GetCollection<Character>(settings.CharactersCollectionName);
        }

        public List<Character> Get()
        {
            return _characters.Find(character => true).ToList();
        }

        public Character Get(string id) => _characters.Find<Character>(character => character.PersonId == id).FirstOrDefault();

        public Character Create(Character character)
        {
            _characters.InsertOne(character);
            return character;
        }

        public void Update(string id, Character characterIn) => _characters.ReplaceOne(character => character.PersonId == id, characterIn);

        public void Remove(Character characterIn) => _characters.DeleteOne(character => character.PersonId == characterIn.PersonId);

        public void Remove(string id) => _characters.DeleteOne(character => character.PersonId == id);

    }
}
