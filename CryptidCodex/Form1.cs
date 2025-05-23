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
            }
            else if (creature_dropDown.Text == "Werewolf")
            {
                type_txtbox.Text = "Werewolf";
                origin_txtbox.Text = "Greece";
            }
            else if (creature_dropDown.Text == "Seraphim")
            {
                type_txtbox.Text = "Seraphim";
                origin_txtbox.Text = "Unknown";
            }
            else if (creature_dropDown.Text == "Goblin")
            {
                type_txtbox.Text = "Goblin";
                origin_txtbox.Text = "Germany";
            }
            else
            {
                type_txtbox.Text = "Unknown Creature";
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
                string creatureInfo = $"{creatureName} - {creatureType} - {creatureEncounter}";
                User_Log.Items.Add(creatureInfo);
            }

        }
    }
}
