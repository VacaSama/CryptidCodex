namespace CryptidCodex
{
    public partial class Codex_form : Form
    {
        public Codex_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void creature_dropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When he user selects a creature from the dropdown,
            // it will change the type of creature to whatver one was selected
            // it will also update the image and randomly generate stats and in the Encounter it will 
            // tell us if the Encounter for this type of creature was: common, uncommon, rare, or epic. 

            if (creature_dropDown.Text == "Vampire")
            {
                Vampire vampire = new Vampire();
                type_txtbox.Text = "Vampire";
                origin_txtbox.Text = "Translyvania";
                creatureName_txtbox.Text = vampire.Name;
                rarity_txtbox.Text = vampire.Encounter;
                pictureBox1.Image = Properties.Resources.vampphoto; // Assuming you have a vampire image in resources

                StatsBox.Items.Clear(); // clear old stats

                if (vampire.Encounter == "Common")
                {
                    StatsBox.Items.Add("Strength: Notable");
                    StatsBox.Items.Add("Damage Dealt: 75");
                    StatsBox.Items.Add("Charm: Mild");
                    StatsBox.Items.Add("Bloodlust: Low");
                }
                else if (vampire.Encounter == "Uncommon")
                {
                    StatsBox.Items.Add("Strength: Imposing");
                    StatsBox.Items.Add("Damage Dealt: 450");
                    StatsBox.Items.Add("Charm: Off-Putting");
                    StatsBox.Items.Add("Bloodlust: Moderate");
                }
                else if (vampire.Encounter == "Rare")
                {
                    StatsBox.Items.Add("Strength: T-Terrifying");
                    StatsBox.Items.Add("Damage Dealt: 7500");
                    StatsBox.Items.Add("Charm: Alluring");
                    StatsBox.Items.Add("Bloodlust: High");
                }
                else if (vampire.Encounter == "Epic")
                {
                    StatsBox.Items.Add("Strength: Godlike");
                    StatsBox.Items.Add("Damage Dealt: 1100");
                    StatsBox.Items.Add("Charm: Hypnotic");
                    StatsBox.Items.Add("Abilities: Compulsion");
                    StatsBox.Items.Add("Bloodlust: Unquenchable");
                }
            }


            if (creature_dropDown.Text == "Werewolf")
            {
                Werewolf werewolf = new Werewolf();
                type_txtbox.Text = "Werewolf";
                origin_txtbox.Text = "Greece";
                creatureName_txtbox.Text = werewolf.Name;
                rarity_txtbox.Text = werewolf.Encounter;
                pictureBox1.Image = Properties.Resources.werewolfphoto; // Assuming you have a werewolf image in resources

                StatsBox.Items.Clear(); // clear old stats
                if (werewolf.Encounter == "Common")
                {
                    StatsBox.Items.Add("Strength: 110");
                    StatsBox.Items.Add("Bite Force: 30 PSI");
                    StatsBox.Items.Add("Lunar Bond: Nightly Shift");
                    StatsBox.Items.Add("Bloodlust: Unquenchable");
                }
                else if (werewolf.Encounter == "Uncommon")
                {
                    StatsBox.Items.Add("Strength: Pack Juggarnaut");
                    StatsBox.Items.Add("Bite Force: 170 PSI");
                    StatsBox.Items.Add("Lunar Bond: Every Full Moon");
                    StatsBox.Items.Add("Bloodlust: Frenzied");
                }
                else if (werewolf.Encounter == "Rare")
                {
                    StatsBox.Items.Add("Strength: Peltcrushing");
                    StatsBox.Items.Add("Bite Force: 350 PSI");
                    StatsBox.Items.Add("Lunar Bond: Every Full Moon");
                    StatsBox.Items.Add("Bloodlust: Moderate");
                }
                else if (werewolf.Encounter == "Epic")
                {
                    StatsBox.Items.Add("Strength: Bone Breaker");
                    StatsBox.Items.Add("Bite Force: 1200 PSI");
                    StatsBox.Items.Add("Lunar Bond: Free Shift");
                    StatsBox.Items.Add("Bloodlust: Dormant");
                }
            }


            if (creature_dropDown.Text == "Seraphim")
            {
                Seraphim seraphim = new Seraphim();
                type_txtbox.Text = "Seraphim";
                origin_txtbox.Text = "Unknown";
                creatureName_txtbox.Text = seraphim.Name;
                rarity_txtbox.Text = seraphim.Encounter;
                pictureBox1.Image = Properties.Resources.seraphoto; // Assuming you have a seraphim image in resources

                StatsBox.Items.Clear(); // clear old stats
                if (seraphim.Encounter == "Common")
                {
                    StatsBox.Items.Add("Strength: 75");
                    StatsBox.Items.Add("Speed: Average");
                    StatsBox.Items.Add("Beauty: Churrub");
                    StatsBox.Items.Add("Divine Power: Smite");
                }
                else if (seraphim.Encounter == "Uncommon")
                {
                    StatsBox.Items.Add("Strength: 225");
                    StatsBox.Items.Add("Speed: Fast");
                    StatsBox.Items.Add("Beauty: Luminous");
                    StatsBox.Items.Add("Divine Power: Holy Shield");
                }
                else if (seraphim.Encounter == "Rare")
                {
                    StatsBox.Items.Add("Strength: 550");
                    StatsBox.Items.Add("Speed: Light-Step");
                    StatsBox.Items.Add("Beauty: Radiant");
                    StatsBox.Items.Add("Divine Power: Blessing");
                }
                else if (seraphim.Encounter == "Epic")
                {
                    StatsBox.Items.Add("Strength: 950");
                    StatsBox.Items.Add("Speed: Blinding");
                    StatsBox.Items.Add("Beauty: Angel's Glow");
                    StatsBox.Items.Add("Divine Power: Revive");
                }
            }
            if (creature_dropDown.Text == "Goblin")
            {
                Goblin goblin = new Goblin();
                type_txtbox.Text = "Goblin";
                origin_txtbox.Text = "Germany";
                creatureName_txtbox.Text = goblin.Name;
                rarity_txtbox.Text = goblin.Encounter;
                pictureBox1.Image = Properties.Resources.goblinphoto; // Assuming you have a goblin image in resources

                StatsBox.Items.Clear(); // clear old stats
                if (goblin.Encounter == "Common")
                {
                    StatsBox.Items.Add("Cunning: Low Whits");
                    StatsBox.Items.Add("Greed: Hoarder");
                    StatsBox.Items.Add("Luck: Quite Unlucky");
                    StatsBox.Items.Add("Beauty: Ugly");
                }
                else if (goblin.Encounter == "Uncommon")
                {
                    StatsBox.Items.Add("Cunning: Double Crosser");
                    StatsBox.Items.Add("Greed: Hoarder");
                    StatsBox.Items.Add("Luck: Fated");
                    StatsBox.Items.Add("Beauty: Moss Face");
                }
                else if (goblin.Encounter == "Rare")
                {
                    StatsBox.Items.Add("Cunning: Trickster");
                    StatsBox.Items.Add("Greed: Treasurelust");
                    StatsBox.Items.Add("Luck: Chaos-Touched");
                    StatsBox.Items.Add("Beauty: Warty");
                }
                else if (goblin.Encounter == "Epic")
                {
                    StatsBox.Items.Add("Cunning: Backstabber");
                    StatsBox.Items.Add("Greed: Gold-Sick");
                    StatsBox.Items.Add("Luck: Fortunate");
                    StatsBox.Items.Add("Beauty: Mud-Charmer");
                }
            }
        }

        private void add_bttn_Click(object sender, EventArgs e)
        {
            // here we are going to add the creature Name, type and Encounter to the listbox
            string creatureName = creatureName_txtbox.Text;
            string creatureType = type_txtbox.Text;
            string creatureEncounter = rarity_txtbox.Text;

            // add the creature to the listbox
            // if the string in each is not null or empty, then add the items to the Encounter log/ user log
            if (!string.IsNullOrEmpty(creatureName) && !string.IsNullOrEmpty(creatureType) &&
                !string.IsNullOrEmpty(creatureEncounter))
            {
                // the $ sign is used to format the string
                // it will take the string and add the values of the variables to the string
                string creatureInfo = $"{creatureName} - {creatureType} - {creatureEncounter}";
                User_Log.Items.Add(creatureInfo);
            }

        }

        private void clear_bttn_Click(object sender, EventArgs e)
        {
            // clear the user log
            User_Log.Items.Clear();
        }

        private void exit_bttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StatsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            creatureName_txtbox.Clear();
            type_txtbox.Clear();
            rarity_txtbox.Clear();
            origin_txtbox.Clear();
            StatsBox.Items.Clear(); // clear the stats box
            creature_dropDown.SelectedIndex = -1; // clear the dropdown selection
            pictureBox1.Image = null; // clear the image
        }
        // this method will randomize the creature type, and everything else should fall into place
        // yup... falls into place \(^o^)/
        private void randomize_bttn_Click(object sender, EventArgs e)
        {
            // Randomly select a creature from the dropdown
            // creaturedrop has a index of 0 to 3, vampire[0], werewolf[1], seraphim[2], goblin[3]
            // /.SelectedIndex will select a random index from the dropdown list
            // it will also update the image and randomly generate stats and in the Encounter it will
            creature_dropDown.SelectedIndex = new Random().Next(creature_dropDown.Items.Count);
        }
    }
}
