using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CryptidCodex
{
    public class Vampire
    {
        // The Vampire class is a subclass of the Cryptid class
        public string Name { get; set; }
        public string Encounter { get; set; }

        public Vampire()
        {
            getRandomVampire();
        }

        /// <summary>
        /// This method will randomly select a Vampire from the lists, it will also give them a name and rarity
        /// aka, (Encounter).
        /// </summary>
        private void getRandomVampire()
        {
            string[] commonVampires = {"Vladimir", "Blade", "Maximillian" };
            string[] uncommonVampires = {"Fledgling Vampire", "Hybrid Vampire", };
            string[] rareVampires = { "Akasha", "Barnabas Collins", "Kinski" };
            string[] epicVampires = { "Nosferatu", "Count Dracula", "Count Orlok" };

            string[] rarities = { "Common", "Uncommon", "Rare", "Epic" };
            Random rand = new Random();
            Encounter = rarities[rand.Next(rarities.Length)];

            if (Encounter == "Common")
            {
                Name = commonVampires[rand.Next(commonVampires.Length)];
                Encounter = "Common";
            }
            else if (Encounter == "Uncommon")
            {
                Name = uncommonVampires[rand.Next(uncommonVampires.Length)];
                Encounter = "Uncommon";
            }
            else if (Encounter == "Rare")
            {
                Name = rareVampires[rand.Next(rareVampires.Length)];
                Encounter = "Rare";
            }
            else if (Encounter == "Epic")
            {
                Name = epicVampires[rand.Next(epicVampires.Length)];
                Encounter = "Epic";
            }
        }
    }
}
