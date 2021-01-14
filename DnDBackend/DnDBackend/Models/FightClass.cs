using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models
{
    public class FightClass
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
        public string ClassFeatures { get; set; } //maybe not a string and not public
        public string Spells { get; set; } //maybe not a string and not public
        //Equip is not a string. Case: choose Equip or Gold
        //TODO rewrite Equipment class with knowledge, that equip and gold is a fightClass dependensies
        public string Equipment { get; set; }
        public int Gold { get; set; }
    }
}
