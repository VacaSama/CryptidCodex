using System;
using System.Collections.Generic;
using System.Linq;
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

        private void getRandomVampire()
        {
            string[] commonVampires = {"Vladimir", "Count Orlok", "Maximillian"};
            string[] uncommonVampires = {"Fledgling Vampire", "Hybrid Vampire", };
            string[] rareVampires = { "Akasha", "Barnabas Collins", "Kinski" };
            string[] epicVampires = { "Nosferatu", "Count Dracula", "Blade"};

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
