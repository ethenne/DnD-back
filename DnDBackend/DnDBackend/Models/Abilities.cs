using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnDBackend.Models.AbilitiesEntity;

namespace DnDBackend.Models.AbilitiesEntity
{
    public class Abilities
    {
        public Strength Strength { get; set; }
        public Dexterity Dexterity { get; set; }
        public Constitution Constitution { get; set; }
        public Inrelligence Inrelligence { get; set; }
        public Wisdom Wisdom { get; set; }
        public Charisma Charisma { get; set; }
    }
}
