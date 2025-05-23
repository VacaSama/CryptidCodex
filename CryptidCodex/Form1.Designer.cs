namespace CryptidCodex
{
    partial class Codex_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            creature_dropDown = new ComboBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            CreatureName = new Label();
            Type = new Label();
            creatureName_txtbox = new TextBox();
            type_txtbox = new TextBox();
            Origin = new Label();
            Stats = new Label();
            origin_txtbox = new TextBox();
            creature_gBox = new GroupBox();
            StatsBox = new ListBox();
            label5 = new Label();
            User_Log = new ListBox();
            EncounterLog_gBox = new GroupBox();
            Encounter = new Label();
            rarity_txtbox = new TextBox();
            add_bttn = new Button();
            exit_bttn = new Button();
            clear_bttn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            creature_gBox.SuspendLayout();
            EncounterLog_gBox.SuspendLayout();
            SuspendLayout();
            // 
            // creature_dropDown
            // 
            creature_dropDown.FormattingEnabled = true;
            creature_dropDown.Items.AddRange(new object[] { "Vampire", "Werewolf", "Seraphim", "Goblin" });
            creature_dropDown.Location = new Point(174, 70);
            creature_dropDown.Name = "creature_dropDown";
            creature_dropDown.Size = new Size(242, 40);
            creature_dropDown.TabIndex = 0;
            creature_dropDown.SelectedIndexChanged += creature_dropDown_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 200);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(72, 151);
            panel1.Name = "panel1";
            panel1.Size = new Size(356, 274);
            panel1.TabIndex = 2;
            // 
            // CreatureName
            // 
            CreatureName.AutoSize = true;
            CreatureName.Location = new Point(43, 44);
            CreatureName.Name = "CreatureName";
            CreatureName.Size = new Size(83, 32);
            CreatureName.TabIndex = 3;
            CreatureName.Text = "Name:";
            CreatureName.Click += label1_Click;
            // 
            // Type
            // 
            Type.AutoSize = true;
            Type.Location = new Point(43, 98);
            Type.Name = "Type";
            Type.Size = new Size(70, 32);
            Type.TabIndex = 4;
            Type.Text = "Type:";
            // 
            // creatureName_txtbox
            // 
            creatureName_txtbox.Location = new Point(174, 43);
            creatureName_txtbox.Name = "creatureName_txtbox";
            creatureName_txtbox.ReadOnly = true;
            creatureName_txtbox.Size = new Size(249, 39);
            creatureName_txtbox.TabIndex = 5;
            // 
            // type_txtbox
            // 
            type_txtbox.Location = new Point(174, 98);
            type_txtbox.Name = "type_txtbox";
            type_txtbox.ReadOnly = true;
            type_txtbox.Size = new Size(249, 39);
            type_txtbox.TabIndex = 6;
            // 
            // Origin
            // 
            Origin.AutoSize = true;
            Origin.Location = new Point(43, 164);
            Origin.Name = "Origin";
            Origin.Size = new Size(85, 32);
            Origin.TabIndex = 7;
            Origin.Text = "Origin:";
            // 
            // Stats
            // 
            Stats.AutoSize = true;
            Stats.Location = new Point(44, 230);
            Stats.Name = "Stats";
            Stats.Size = new Size(69, 32);
            Stats.TabIndex = 8;
            Stats.Text = "Stats:";
            // 
            // origin_txtbox
            // 
            origin_txtbox.Location = new Point(174, 157);
            origin_txtbox.Name = "origin_txtbox";
            origin_txtbox.ReadOnly = true;
            origin_txtbox.Size = new Size(249, 39);
            origin_txtbox.TabIndex = 9;
            // 
            // creature_gBox
            // 
            creature_gBox.Controls.Add(StatsBox);
            creature_gBox.Controls.Add(CreatureName);
            creature_gBox.Controls.Add(Type);
            creature_gBox.Controls.Add(origin_txtbox);
            creature_gBox.Controls.Add(creatureName_txtbox);
            creature_gBox.Controls.Add(Stats);
            creature_gBox.Controls.Add(type_txtbox);
            creature_gBox.Controls.Add(Origin);
            creature_gBox.Location = new Point(545, 151);
            creature_gBox.Name = "creature_gBox";
            creature_gBox.Size = new Size(462, 451);
            creature_gBox.TabIndex = 11;
            creature_gBox.TabStop = false;
            creature_gBox.Text = "Creature Description:";
            // 
            // StatsBox
            // 
            StatsBox.FormattingEnabled = true;
            StatsBox.Location = new Point(151, 230);
            StatsBox.Name = "StatsBox";
            StatsBox.Size = new Size(240, 164);
            StatsBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 70);
            label5.Name = "label5";
            label5.Size = new Size(110, 32);
            label5.TabIndex = 12;
            label5.Text = "Creature:";
            // 
            // User_Log
            // 
            User_Log.FormattingEnabled = true;
            User_Log.Location = new Point(32, 60);
            User_Log.Name = "User_Log";
            User_Log.Size = new Size(429, 164);
            User_Log.TabIndex = 13;
            // 
            // EncounterLog_gBox
            // 
            EncounterLog_gBox.Controls.Add(User_Log);
            EncounterLog_gBox.Location = new Point(24, 523);
            EncounterLog_gBox.Name = "EncounterLog_gBox";
            EncounterLog_gBox.Size = new Size(497, 255);
            EncounterLog_gBox.TabIndex = 14;
            EncounterLog_gBox.TabStop = false;
            EncounterLog_gBox.Text = "Encounter Log:";
            // 
            // Encounter
            // 
            Encounter.AutoSize = true;
            Encounter.Location = new Point(564, 74);
            Encounter.Name = "Encounter";
            Encounter.Size = new Size(127, 32);
            Encounter.TabIndex = 15;
            Encounter.Text = "Encounter:";
            // 
            // rarity_txtbox
            // 
            rarity_txtbox.Location = new Point(712, 72);
            rarity_txtbox.Name = "rarity_txtbox";
            rarity_txtbox.ReadOnly = true;
            rarity_txtbox.Size = new Size(200, 39);
            rarity_txtbox.TabIndex = 16;
            // 
            // add_bttn
            // 
            add_bttn.Location = new Point(665, 634);
            add_bttn.Name = "add_bttn";
            add_bttn.Size = new Size(271, 46);
            add_bttn.TabIndex = 17;
            add_bttn.Text = "Add Encounter";
            add_bttn.UseVisualStyleBackColor = true;
            add_bttn.Click += add_bttn_Click;
            // 
            // exit_bttn
            // 
            exit_bttn.Location = new Point(665, 718);
            exit_bttn.Name = "exit_bttn";
            exit_bttn.Size = new Size(271, 46);
            exit_bttn.TabIndex = 18;
            exit_bttn.Text = "Exit";
            exit_bttn.UseVisualStyleBackColor = true;
            exit_bttn.Click += exit_bttn_Click;
            // 
            // clear_bttn
            // 
            clear_bttn.Location = new Point(271, 471);
            clear_bttn.Name = "clear_bttn";
            clear_bttn.Size = new Size(214, 46);
            clear_bttn.TabIndex = 19;
            clear_bttn.Text = "Clear Log";
            clear_bttn.UseVisualStyleBackColor = true;
            clear_bttn.Click += clear_bttn_Click;
            // 
            // Codex_form
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 808);
            Controls.Add(clear_bttn);
            Controls.Add(exit_bttn);
            Controls.Add(add_bttn);
            Controls.Add(rarity_txtbox);
            Controls.Add(Encounter);
            Controls.Add(EncounterLog_gBox);
            Controls.Add(label5);
            Controls.Add(creature_gBox);
            Controls.Add(panel1);
            Controls.Add(creature_dropDown);
            Name = "Codex_form";
            Text = "Cryptid Codex";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            creature_gBox.ResumeLayout(false);
            creature_gBox.PerformLayout();
            EncounterLog_gBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox creature_dropDown;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label CreatureName;
        private Label Type;
        private TextBox creatureName_txtbox;
        private TextBox type_txtbox;
        private Label Origin;
        private Label Stats;
        private TextBox origin_txtbox;
        private GroupBox creature_gBox;
        private ListBox StatsBox;
        private Label label5;
        private ListBox User_Log;
        private GroupBox EncounterLog_gBox;
        private Label Encounter;
        private TextBox rarity_txtbox;
        private Button add_bttn;
        private Button exit_bttn;
        private Button clear_bttn;
    }
}
