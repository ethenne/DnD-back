using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models.DescriptionEntitys
{
    public class Description
    {
        public Background Background { get; set; }
        public CharacterDetails CharacterDetails { get; set; }
        public Notes Notes { get; set; }
        public PersonalCharacteristics PersonalCharacteristics { get; set; }
        public PhysicalCharacteristics PhysicalCharacteristics { get; set; }
    }
}
