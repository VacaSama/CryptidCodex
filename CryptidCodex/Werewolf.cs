using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptidCodex
{
    public class Werewolf
    {

        public string Name { get; set; }
        public string Encounter { get; set; }
        public Werewolf()
        {
            getRandomWerewolf();
        }

        private void getRandomWerewolf()
        {
            string[] commonWerewolves = { "Fang", "Luna", "Dustpaw" };
            string[] uncommonWerewolves = { "Lykaon", "Moonshade Howler", };
            string[] rareWerewolves = { "Fenrir", "Bloodfang", "Shade Hunter" };
            string[] epicWerewolves = { "Alpha", "Direfang", "Lupin (Cursed)" };

            string[] rarities = { "Common", "Uncommon", "Rare", "Epic" };
            Random rand = new Random();
            Encounter = rarities[rand.Next(rarities.Length)];

            if (Encounter == "Common")
            {
                Name = commonWerewolves[rand.Next(commonWerewolves.Length)];
                Encounter = "Common";
            }
            else if (Encounter == "Uncommon")
            {
                Name = uncommonWerewolves[rand.Next(uncommonWerewolves.Length)];
                Encounter = "Uncommon";
            }
            else if (Encounter == "Rare")
            {
                Name = rareWerewolves[rand.Next(rareWerewolves.Length)];
                Encounter = "Rare";
            }
            else if (Encounter == "Epic")
            {
                Name = epicWerewolves[rand.Next(epicWerewolves.Length)];
                Encounter = "Epic";
            }

        }
    }
}
