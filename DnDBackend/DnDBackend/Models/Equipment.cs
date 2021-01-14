using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models.EquipmentEntity
{
    public class Equipment
    {
        public Curency Curency { get; set; }
        public Encumbrance Encumbrance { get; set; }
        public Manage Manage { get; set; }
        public StartingEquipment StartingEquipment { get; set; }
    }
}
