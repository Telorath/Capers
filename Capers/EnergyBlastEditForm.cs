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
    public partial class EnergyBlastEditForm : Form
    {
        Character mParentCharacter;
        EnergyBlast mSelectedEnergyBlast;
        int mPointCost;
        public Character ParentCharacter
        {
            get { return mParentCharacter; }
            set { mParentCharacter = value; }
        }
        public EnergyBlast SelectedEnergyBlast
        {
            get { return mSelectedEnergyBlast; }
            set { mSelectedEnergyBlast = value; }
        }
        public string name
        {
            get { return NameTextBox.Text; }
            set { NameTextBox.Text = value; }
        }
        public int dice
        {
            get { return (int)DiceNumericUpDown.Value; }
            set { DiceNumericUpDown.Value = value; }
        }
        public IEnergy energysource
        {
            get { return (IEnergy)EnergySourceComboBox.SelectedItem; }
        }
        public int pointcost
        {
            get { return mPointCost; }
            set
            {
                mPointCost = value;
                PointCostLabel.Text = "Point Cost: " + value;
            }
        }
        public EnergyBlastEditForm(Character Chara, EnergyBlast Pow)
        {
            InitializeComponent();
            ParentCharacter = Chara;
            SelectedEnergyBlast = Pow;
            EnergySourceComboBox.Items.Add(ParentCharacter);
            for (int i = 0; i < ParentCharacter.Powers.Count; i++)
            {
                if (ParentCharacter.Powers[i] is IEnergy)
                {
                    EnergySourceComboBox.Items.Add(ParentCharacter.Powers[i]);
                }
            }
            EnergySourceComboBox.SelectedIndex = 0;
            name = SelectedEnergyBlast.Name;
            dice = SelectedEnergyBlast.Dice;
            pointcost = SelectedEnergyBlast.PointCost;
        }

        private void DiceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            pointcost = dice * 10;
        }
    }
}
