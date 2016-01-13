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
            CharactersListBox.SelectedIndex = 0;
            CharacterGroupBox.Visible = false;
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
            NameTextBox.Text = c.Name;
CharacterStrengthUpDown.Value =  c.Str;
            Selected = selectiontype.Character;
            CharacterGroupBox.Visible = true;
        }

        private void PowersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PowersListBox.SelectedIndex < 0)
            {
                return;
            }
            Power p = (Power)PowersListBox.Items[PowersListBox.SelectedIndex];
            NameTextBox.Text = p.Name;
            if (p is EnergyReserve)
            {
                Selected = selectiontype.Energy_Reserve;
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
                c.Name = NameTextBox.Text;
                CharactersListBox.DataSource = null;
                CharactersListBox.DataSource = Database.GetActiveDatabase().CharList();
                CharactersListBox.SelectedIndex = index;
            }
            else
            {
                int index = PowersListBox.SelectedIndex;
                Power p = (Power)PowersListBox.SelectedItem;
                p.Name = NameTextBox.Text;
                PowersListBox.DataSource = null;
                PowersListBox.DataSource = (CharactersListBox.SelectedItem as Character).Powers;
                PowersListBox.SelectedIndex = index;
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Database.GetActiveDatabase().Save();
        }
    }
}
