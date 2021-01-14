using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models.AbilitiesEntity
{
    public class Inrelligence
    {
        public int TotalScore { get; set; }
        public int Modifier { get; set; }
        public int BaseScore { get; set; }
        public int RacialBonus { get; set; }
        public int AbilityImprovements { get; set; }
        public int MiscBonus { get; set; }
        public int SetScore { get; set; }
        public int OtherModifier { get; set; }
        public int OverrideScore { get; set; }
    }
}
