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
        public FightClassEntity.ClassFeature ClassFeatures { get; set; }
    }
}
