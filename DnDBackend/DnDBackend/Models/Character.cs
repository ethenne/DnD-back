using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models
{
    public class Character
    {
        public long Id { get; set; }
        public string Race { get; set;  }
        public string FightClass { get; set; }
        public object Abilities { get; set; }
        public object Description { get; set; }
        public object Equipment { get; set; }
    }
}
