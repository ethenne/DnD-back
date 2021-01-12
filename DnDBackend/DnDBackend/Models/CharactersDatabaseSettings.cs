using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models
{
    public class CharactersDatabaseSettings : ICharactersDatabaseSettings
    {
        public string CharactersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }

    public interface ICharactersDatabaseSettings
    {
        string CharactersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
