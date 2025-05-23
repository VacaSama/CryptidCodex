using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CryptidCodex
{
    public class Goblin
    {
        public string Name { get; set; }
        public string Encounter { get; set; }
        public Goblin()
        {
            getRandomGoblin();
        }

        private void getRandomGoblin()
        {
            string[] commonGoblin = { "Grub", "Snot", "Muck" };
            string[] uncommonGoblin = { "Razzle", "Blix", };
            string[] rareGoblin = { "Bogmok", "Plaguejaw", "Grognag" };
            string[] epicGoblin = { "Grimble Ironfang", "King Rotgob", "Snaretooth Ick" };

            string[] rarities = { "Common", "Uncommon", "Rare", "Epic" };
            Random rand = new Random();
            Encounter = rarities[rand.Next(rarities.Length)];

            if (Encounter == "Common")
            {
                Name = commonGoblin[rand.Next(commonGoblin.Length)];
                Encounter = "Common";
            }
            else if (Encounter == "Uncommon")
            {
                Name = uncommonGoblin[rand.Next(uncommonGoblin.Length)];
                Encounter = "Uncommon";
            }
            else if (Encounter == "Rare")
            {
                Name = rareGoblin[rand.Next(rareGoblin.Length)];
                Encounter = "Rare";
            }
            else if (Encounter == "Epic")
            {
                Name = epicGoblin[rand.Next(epicGoblin.Length)];
                Encounter = "Epic";
            }
        }
    }
}

