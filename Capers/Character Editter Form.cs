using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capers
{
    public partial class Character_Editter_Form : Form
    {
        enum selectiontype
        {
            Character,
            Energy_Blast,
            Energy_Reserve,
            Armor
        }
        selectiontype Selected = selectiontype.Character;
        public Character_Editter_Form()
        {
            InitializeComponent();
            CharactersListBox.DataSource = Database.GetActiveDatabase().CharList();
            CharactersListBox.SelectedIndex = -1;
            PowerTypeSelectionComboBox.Items.Add("Energy Reserve");
            CharacterGroupBox.Visible = false;
            EnergyReserveGroupBox.Visible = false;
        }

        private void CharactersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CharactersListBox.SelectedIndex < 0)
            {
                return;
            }
            Character c = (Character)CharactersListBox.Items[CharactersListBox.SelectedIndex];
            PowersListBox.DataSource = c.Powers;
            PowersListBox.SelectedIndex = -1;
            CharNameTextBox.Text = c.Name;
            CharStrUpDown.Value = c.Str;
            CharConUpDown.Value = c.End;
            CharEndUpDown.Value = c.End;
            CharAgiUpDown.Value = c.Agi;
            CharIntUpDown.Value = c.Intel;
            CharWilUpDown.Value = c.Wil;
            CharChaUpDown.Value = c.Cha;
            int points = c.PointSpent;
            PointsLabel.Text = points.ToString();
            CharacterTierLabel.Text = "Tier: Normal";
            if (points > 25)
                CharacterTierLabel.Text = "Tier: Notable Normal";
            if (points > 50)
                CharacterTierLabel.Text = "Tier: Skilled Normal";
            if (points > 100)
                CharacterTierLabel.Text = "Tier: Badass Normal";
            if (points > 150)
                CharacterTierLabel.Text = "Tier: Low-power Super";
            if (points > 200)
                CharacterTierLabel.Text = "Tier: Mid-power Super";
            if (points > 350)
                CharacterTierLabel.Text = "Tier: High-power Super";
            if (points > 500)
                CharacterTierLabel.Text = "Tier: Cosmically Powerful Super";
            Selected = selectiontype.Character;
            CharacterGroupBox.Visible = true;
            EnergyReserveGroupBox.Visible = false;
        }

        private void PowersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CharacterGroupBox.Visible = false;
            if (PowersListBox.SelectedIndex < 0)
            {
                return;
            }
            Power p = (Power)PowersListBox.Items[PowersListBox.SelectedIndex];
            CharNameTextBox.Text = p.Name;
            if (p is EnergyReserve)
            {
                Selected = selectiontype.Energy_Reserve;
                EnergyReserve EnRes = (EnergyReserve)p;
                EnRes.calculatecost();
                EnergyReservePointCostLabel.Text = "Cost: " + EnRes.PointCost;
                EnergyReserveNameTextBox.Text = EnRes.Name;
                EnergyReserveMaxEnergyUpDown.Value = EnRes.MaxEnergy;
                EnergyReserveRecoveryUpDown.Value = EnRes.Recovery;
                EnergyReserveGroupBox.Visible = true;
                EnergyReserveGroupBox.BringToFront();
            }
            if (p is EnergyBlast)
            {
                Selected = selectiontype.Energy_Blast;
            }
            if (p is Armor)
            {
                Selected = selectiontype.Armor;
            }
        }
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (Selected == selectiontype.Character)
            {
                int index = CharactersListBox.SelectedIndex;
                Character c = (Character)CharactersListBox.SelectedItem;
                c.Name = CharNameTextBox.Text;
                c.Str = (int)CharStrUpDown.Value;
                c.Con = (int)CharConUpDown.Value;
                c.End = (int)CharEndUpDown.Value;
                c.Agi = (int)CharAgiUpDown.Value;
                c.Intel = (int)CharIntUpDown.Value;
                c.Wil = (int)CharWilUpDown.Value;
                c.Cha = (int)CharChaUpDown.Value;
                CharactersListBox.DataSource = null;
                CharactersListBox.DataSource = Database.GetActiveDatabase().CharList();
                CharactersListBox.SelectedIndex = index;
            }
            else if (Selected == selectiontype.Energy_Reserve)
            {
                int index = PowersListBox.SelectedIndex;
                EnergyReserve EnRes = (EnergyReserve)PowersListBox.SelectedItem;
                EnRes.Name = EnergyReserveNameTextBox.Text;
                EnRes.MaxEnergy = (int)EnergyReserveMaxEnergyUpDown.Value;
                EnRes.Recovery = (int)EnergyReserveRecoveryUpDown.Value;
                PowersListBox.DataSource = null;
                PowersListBox.DataSource = (CharactersListBox.SelectedItem as Character).Powers;
                PowersListBox.SelectedIndex = index;
            }
            else
            {
                int index = PowersListBox.SelectedIndex;
                Power p = (Power)PowersListBox.SelectedItem;
                p.Name = CharNameTextBox.Text;
                PowersListBox.DataSource = null;
                PowersListBox.DataSource = (CharactersListBox.SelectedItem as Character).Powers;
                PowersListBox.SelectedIndex = index;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Database.GetActiveDatabase().Save();
        }

        private void AddCharButton_Click(object sender, EventArgs e)
        {
            Character C = new Character();
            C.Name = "New Character";
            Database.GetActiveDatabase().AddCharacter(C);
            CharactersListBox.DataSource = null;
            CharactersListBox.DataSource = Database.GetActiveDatabase().CharList();
        }

        private void DeleteCharButton_Click(object sender, EventArgs e)
        {
            if (CharactersListBox.SelectedIndex < 0)
                return;
            Character c = (Character)CharactersListBox.SelectedItem;
            Database.GetActiveDatabase().RemoveCharacter(c);
            CharactersListBox.DataSource = null;
            CharactersListBox.DataSource = Database.GetActiveDatabase().CharList();
        }

        private void DeletePowerButton_Click(object sender, EventArgs e)
        {
            if ((CharactersListBox.SelectedIndex < 0) || (PowersListBox.SelectedIndex < 0))
                return;
            (CharactersListBox.SelectedItem as Character).removerpower((Power)PowersListBox.SelectedItem);
            PowersListBox.DataSource = null;
            PowersListBox.DataSource = (CharactersListBox.SelectedItem as Character).Powers;
        }

        private void AddPowerButton_Click(object sender, EventArgs e)
        {
            if ((string)PowerTypeSelectionComboBox.SelectedItem == string.Empty)
            {
                return;
            }
            if (CharactersListBox.SelectedIndex < 0)
                return;
            if (string.Compare((string)PowerTypeSelectionComboBox.SelectedItem, "Energy Reserve") == 0)
            {
                EnergyReserve En = new EnergyReserve();
                En.Name = "Energy Reserve";
                (CharactersListBox.SelectedItem as Character).addpower(En);
            }
            PowersListBox.DataSource = null;
            PowersListBox.DataSource = (CharactersListBox.SelectedItem as Character).Powers;
        }
    }
}
