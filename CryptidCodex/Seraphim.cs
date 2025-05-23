using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CryptidCodex
{
    public class Seraphim
    {
        public string Name { get; set; }
        public string Encounter { get; set; }
        public Seraphim()
        {
            getRandomSeraphim();
        }

        private void getRandomSeraphim()
        {
            string[] commonSeraphim = { "Halo", "Solis", "Aurel" };
            string[] uncommonSeraphim = { "Luz", "Seraphael", };
            string[] rareSeraphim = { "Raziel", "Uriel", "Ramlyon" };
            string[] epicSeraphim = { "Thoronos", "Enoch Eternal", "Metatron" };

            string[] rarities = { "Common", "Uncommon", "Rare", "Epic" };
            Random rand = new Random();
            Encounter = rarities[rand.Next(rarities.Length)];

            if (Encounter == "Common")
            {
                Name = commonSeraphim[rand.Next(commonSeraphim.Length)];
                Encounter = "Common";
            }
            else if (Encounter == "Uncommon")
            {
                Name = uncommonSeraphim[rand.Next(uncommonSeraphim.Length)];
                Encounter = "Uncommon";
            }
            else if (Encounter == "Rare")
            {
                Name = rareSeraphim[rand.Next(rareSeraphim.Length)];
                Encounter = "Rare";
            }
            else if (Encounter == "Epic")
            {
                Name = epicSeraphim[rand.Next(epicSeraphim.Length)];
                Encounter = "Epic";
            }
        }
    }
}
