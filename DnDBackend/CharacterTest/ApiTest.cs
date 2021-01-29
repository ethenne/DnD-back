using DnDBackend.Controllers;
using DnDBackend.Models;
using DnDBackend.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CharacterTest
{
    [TestClass]
    public class ApiTest
    {
        [TestMethod]
        public async void PostCharacterTest()
        {
            var testData = GetCharacter();

            await new RequestGenerator().PostCharacter(testData);

        }
        [TestMethod]
        public void GetCharacterTest()
        {
            var testData = GetCharacter();

            var res = new RequestGenerator().PostCharacter(testData);

            var character = new RequestGenerator().GetCharacter(testData.PersonId);

        }
        private static Character GetCharacter()
        {
            return new Character()
            {
                PersonId = Guid.NewGuid().ToString(),
                CharacterName = "Abaddon",
                Level = 1,
                Race = GetRace(),
                FightClass = GetFightClass(),
                Charisma = 15,
                Constitution = 10,
                Dexterity = 14,
                Intelligence = 15,
                Strength = 10,
                Wisdon = 14,
                Hair = "Long golden streight",
                Skin = "Bronze soft matt",
                Eyes = "Normal sea-green",
                Height = "1,9",
                Weight = "70",
                Age = "150",
                Gender = "male",
                PersonalityTraits = "",
                Ideas = "neutral good",
                Bonds = "",
                Flaws = "",
                Organizations = "",
                Allies = "",
                Enemies = "orks",
                Backstory = "",
                Other = "",
                Aligment = "",
                Faith = "",
                Lifestyle = "",
                Description = "",
                ProficiencyLanguageChoices = "Magician, Bard, Abyss",
                BackgroundFeature = "",
                BackgroundCharacteristics = "",
                AttunedMagicItems = "Demons grimuar of Dragons",
                StartingEquipment = "Demons grimuar of Dragons, Elvish magician robe",
                ActiveItems = "",
                OtherPosessions = "",
                AddItems = "",
            };
        }

        private static Race GetRace()
        {
            return new Race()
            { 
                Id = "1",
                Name = "High Elf" 
            };
        }

        private static FightClass GetFightClass()
        {
            return new FightClass()
            {
                ClassFeatures = new DnDBackend.Models.FightClassEntity.ClassFeature(),
                Id = "1",
                Name = "Magician"
            };
        }
    }
}
