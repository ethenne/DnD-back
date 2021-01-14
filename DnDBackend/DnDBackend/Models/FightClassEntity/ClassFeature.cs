using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models.FightClassEntity
{
    public class ClassFeature
    {
        public static string HitPounts;
        public string Proficiencies { get; set; } //with 6 choises with dropdowns; probably not a string
        public static string Spellcasting; //depense from FightClass
        public static string ClassInspiration; //maybe not for all FightClasses
        public static string AvailableAtHigherLevels; //array of name-description
    }
}
