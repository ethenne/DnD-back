using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnDBackend.Models.DescriptionEntitys
{
    public class Background
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProficiencyLanguageChoices { get; set; }
        public string BackgroundFeature { get; set; }
        public string BackgroundCharacteristics { get; set; }
    }
}