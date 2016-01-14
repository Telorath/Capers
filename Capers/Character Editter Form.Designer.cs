namespace Capers
{
    partial class Character_Editter_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CharactersListBox = new System.Windows.Forms.ListBox();
            this.PowersListBox = new System.Windows.Forms.ListBox();
            this.CharacterGroupBox = new System.Windows.Forms.GroupBox();
            this.EnergyReserveGroupBox = new System.Windows.Forms.GroupBox();
            this.EnergyReservePointCostLabel = new System.Windows.Forms.Label();
            this.EnergyReserveRecoveryUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnergyReserveRecoveryLabel = new System.Windows.Forms.Label();
            this.EnergyReserveMaxEnergyUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnergyReserveMaxEnergyLabel = new System.Windows.Forms.Label();
            this.EnergyReserveNameTextBox = new System.Windows.Forms.TextBox();
            this.EnergyReserveNameLabel = new System.Windows.Forms.Label();
            this.CharacterTierLabel = new System.Windows.Forms.Label();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.CharChaLabel = new System.Windows.Forms.Label();
            this.CharChaUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharWilLabel = new System.Windows.Forms.Label();
            this.CharWilUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharIntLabel = new System.Windows.Forms.Label();
            this.CharIntUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharEndLabel = new System.Windows.Forms.Label();
            this.CharEndUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharConLabel = new System.Windows.Forms.Label();
            this.CharConUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharAgiLabel = new System.Windows.Forms.Label();
            this.CharAgiUpDown = new System.Windows.Forms.NumericUpDown();
            this.CharStrengthLabel = new System.Windows.Forms.Label();
            this.CharStrUpDown = new System.Windows.Forms.NumericUpDown();
            this.ApplyCharacterButton = new System.Windows.Forms.Button();
            this.CharNameLabel = new System.Windows.Forms.Label();
            this.CharNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AddCharButton = new System.Windows.Forms.Button();
            this.DeleteCharButton = new System.Windows.Forms.Button();
            this.AddPowerButton = new System.Windows.Forms.Button();
            this.DeletePowerButton = new System.Windows.Forms.Button();
            this.PowerTypeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.ApplyEnergyReserveButton = new System.Windows.Forms.Button();
            this.CharacterGroupBox.SuspendLayout();
            this.EnergyReserveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyReserveRecoveryUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyReserveMaxEnergyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharChaUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharWilUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharIntUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEndUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharConUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharAgiUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharStrUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CharactersListBox
            // 
            this.CharactersListBox.FormattingEnabled = true;
            this.CharactersListBox.Location = new System.Drawing.Point(12, 12);
            this.CharactersListBox.Name = "CharactersListBox";
            this.CharactersListBox.Size = new System.Drawing.Size(261, 225);
            this.CharactersListBox.TabIndex = 0;
            this.CharactersListBox.SelectedIndexChanged += new System.EventHandler(this.CharactersListBox_SelectedIndexChanged);
            // 
            // PowersListBox
            // 
            this.PowersListBox.FormattingEnabled = true;
            this.PowersListBox.Location = new System.Drawing.Point(12, 283);
            this.PowersListBox.Name = "PowersListBox";
            this.PowersListBox.Size = new System.Drawing.Size(261, 186);
            this.PowersListBox.TabIndex = 1;
            this.PowersListBox.SelectedIndexChanged += new System.EventHandler(this.PowersListBox_SelectedIndexChanged);
            // 
            // CharacterGroupBox
            // 
            this.CharacterGroupBox.Controls.Add(this.CharacterTierLabel);
            this.CharacterGroupBox.Controls.Add(this.PointsLabel);
            this.CharacterGroupBox.Controls.Add(this.CharChaLabel);
            this.CharacterGroupBox.Controls.Add(this.CharChaUpDown);
            this.CharacterGroupBox.Controls.Add(this.CharWilLabel);
            this.CharacterGroupBox.Controls.Add(this.CharWilUpDown);
            this.CharacterGroupBox.Controls.Add(this.CharIntLabel);
            this.CharacterGroupBox.Controls.Add(this.CharIntUpDown);
            this.CharacterGroupBox.Controls.Add(this.CharEndLabel);
            this.CharacterGroupBox.Controls.Add(this.CharEndUpDown);
            this.CharacterGroupBox.Controls.Add(this.CharConLabel);
            this.CharacterGroupBox.Controls.Add(this.CharConUpDown);
            this.CharacterGroupBox.Controls.Add(this.CharAgiLabel);
            this.CharacterGroupBox.Controls.Add(this.CharAgiUpDown);
            this.CharacterGroupBox.Controls.Add(this.CharStrengthLabel);
            this.CharacterGroupBox.Controls.Add(this.CharStrUpDown);
            this.CharacterGroupBox.Controls.Add(this.ApplyCharacterButton);
            this.CharacterGroupBox.Controls.Add(this.CharNameLabel);
            this.CharacterGroupBox.Controls.Add(this.CharNameTextBox);
            this.CharacterGroupBox.Location = new System.Drawing.Point(279, 12);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(740, 521);
            this.CharacterGroupBox.TabIndex = 2;
            this.CharacterGroupBox.TabStop = false;
            // 
            // EnergyReserveGroupBox
            // 
            this.EnergyReserveGroupBox.Controls.Add(this.ApplyEnergyReserveButton);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReservePointCostLabel);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReserveRecoveryUpDown);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReserveRecoveryLabel);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReserveMaxEnergyUpDown);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReserveMaxEnergyLabel);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReserveNameTextBox);
            this.EnergyReserveGroupBox.Controls.Add(this.EnergyReserveNameLabel);
            this.EnergyReserveGroupBox.Location = new System.Drawing.Point(279, 6);
            this.EnergyReserveGroupBox.Name = "EnergyReserveGroupBox";
            this.EnergyReserveGroupBox.Size = new System.Drawing.Size(740, 521);
            this.EnergyReserveGroupBox.TabIndex = 8;
            this.EnergyReserveGroupBox.TabStop = false;
            // 
            // EnergyReservePointCostLabel
            // 
            this.EnergyReservePointCostLabel.AutoSize = true;
            this.EnergyReservePointCostLabel.Location = new System.Drawing.Point(27, 492);
            this.EnergyReservePointCostLabel.Name = "EnergyReservePointCostLabel";
            this.EnergyReservePointCostLabel.Size = new System.Drawing.Size(58, 13);
            this.EnergyReservePointCostLabel.TabIndex = 6;
            this.EnergyReservePointCostLabel.Text = "Point Cost:";
            // 
            // EnergyReserveRecoveryUpDown
            // 
            this.EnergyReserveRecoveryUpDown.Location = new System.Drawing.Point(74, 97);
            this.EnergyReserveRecoveryUpDown.Name = "EnergyReserveRecoveryUpDown";
            this.EnergyReserveRecoveryUpDown.Size = new System.Drawing.Size(643, 20);
            this.EnergyReserveRecoveryUpDown.TabIndex = 5;
            // 
            // EnergyReserveRecoveryLabel
            // 
            this.EnergyReserveRecoveryLabel.AutoSize = true;
            this.EnergyReserveRecoveryLabel.Location = new System.Drawing.Point(6, 97);
            this.EnergyReserveRecoveryLabel.Name = "EnergyReserveRecoveryLabel";
            this.EnergyReserveRecoveryLabel.Size = new System.Drawing.Size(56, 13);
            this.EnergyReserveRecoveryLabel.TabIndex = 4;
            this.EnergyReserveRecoveryLabel.Text = "Recovery:";
            // 
            // EnergyReserveMaxEnergyUpDown
            // 
            this.EnergyReserveMaxEnergyUpDown.Location = new System.Drawing.Point(74, 58);
            this.EnergyReserveMaxEnergyUpDown.Name = "EnergyReserveMaxEnergyUpDown";
            this.EnergyReserveMaxEnergyUpDown.Size = new System.Drawing.Size(643, 20);
            this.EnergyReserveMaxEnergyUpDown.TabIndex = 3;
            // 
            // EnergyReserveMaxEnergyLabel
            // 
            this.EnergyReserveMaxEnergyLabel.AutoSize = true;
            this.EnergyReserveMaxEnergyLabel.Location = new System.Drawing.Point(6, 60);
            this.EnergyReserveMaxEnergyLabel.Name = "EnergyReserveMaxEnergyLabel";
            this.EnergyReserveMaxEnergyLabel.Size = new System.Drawing.Size(66, 13);
            this.EnergyReserveMaxEnergyLabel.TabIndex = 2;
            this.EnergyReserveMaxEnergyLabel.Text = "Max Energy:";
            // 
            // EnergyReserveNameTextBox
            // 
            this.EnergyReserveNameTextBox.Location = new System.Drawing.Point(74, 19);
            this.EnergyReserveNameTextBox.Name = "EnergyReserveNameTextBox";
            this.EnergyReserveNameTextBox.Size = new System.Drawing.Size(643, 20);
            this.EnergyReserveNameTextBox.TabIndex = 1;
            // 
            // EnergyReserveNameLabel
            // 
            this.EnergyReserveNameLabel.AutoSize = true;
            this.EnergyReserveNameLabel.Location = new System.Drawing.Point(6, 19);
            this.EnergyReserveNameLabel.Name = "EnergyReserveNameLabel";
            this.EnergyReserveNameLabel.Size = new System.Drawing.Size(41, 13);
            this.EnergyReserveNameLabel.TabIndex = 0;
            this.EnergyReserveNameLabel.Text = "Name: ";
            // 
            // CharacterTierLabel
            // 
            this.CharacterTierLabel.AutoSize = true;
            this.CharacterTierLabel.Location = new System.Drawing.Point(52, 492);
            this.CharacterTierLabel.Name = "CharacterTierLabel";
            this.CharacterTierLabel.Size = new System.Drawing.Size(64, 13);
            this.CharacterTierLabel.TabIndex = 18;
            this.CharacterTierLabel.Text = "Tier: Normal";
            // 
            // PointsLabel
            // 
            this.PointsLabel.AutoSize = true;
            this.PointsLabel.Location = new System.Drawing.Point(52, 464);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(42, 13);
            this.PointsLabel.TabIndex = 17;
            this.PointsLabel.Text = "Points: ";
            // 
            // CharChaLabel
            // 
            this.CharChaLabel.AutoSize = true;
            this.CharChaLabel.Location = new System.Drawing.Point(52, 207);
            this.CharChaLabel.Name = "CharChaLabel";
            this.CharChaLabel.Size = new System.Drawing.Size(53, 13);
            this.CharChaLabel.TabIndex = 16;
            this.CharChaLabel.Text = "Charisma:";
            // 
            // CharChaUpDown
            // 
            this.CharChaUpDown.Location = new System.Drawing.Point(125, 205);
            this.CharChaUpDown.Name = "CharChaUpDown";
            this.CharChaUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharChaUpDown.TabIndex = 15;
            // 
            // CharWilLabel
            // 
            this.CharWilLabel.AutoSize = true;
            this.CharWilLabel.Location = new System.Drawing.Point(52, 177);
            this.CharWilLabel.Name = "CharWilLabel";
            this.CharWilLabel.Size = new System.Drawing.Size(56, 13);
            this.CharWilLabel.TabIndex = 14;
            this.CharWilLabel.Text = "Willpower:";
            // 
            // CharWilUpDown
            // 
            this.CharWilUpDown.Location = new System.Drawing.Point(125, 175);
            this.CharWilUpDown.Name = "CharWilUpDown";
            this.CharWilUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharWilUpDown.TabIndex = 13;
            // 
            // CharIntLabel
            // 
            this.CharIntLabel.AutoSize = true;
            this.CharIntLabel.Location = new System.Drawing.Point(52, 151);
            this.CharIntLabel.Name = "CharIntLabel";
            this.CharIntLabel.Size = new System.Drawing.Size(67, 13);
            this.CharIntLabel.TabIndex = 12;
            this.CharIntLabel.Text = "Intelligence: ";
            // 
            // CharIntUpDown
            // 
            this.CharIntUpDown.Location = new System.Drawing.Point(125, 149);
            this.CharIntUpDown.Name = "CharIntUpDown";
            this.CharIntUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharIntUpDown.TabIndex = 11;
            // 
            // CharEndLabel
            // 
            this.CharEndLabel.AutoSize = true;
            this.CharEndLabel.Location = new System.Drawing.Point(52, 125);
            this.CharEndLabel.Name = "CharEndLabel";
            this.CharEndLabel.Size = new System.Drawing.Size(62, 13);
            this.CharEndLabel.TabIndex = 10;
            this.CharEndLabel.Text = "Endurance:";
            // 
            // CharEndUpDown
            // 
            this.CharEndUpDown.Location = new System.Drawing.Point(125, 123);
            this.CharEndUpDown.Name = "CharEndUpDown";
            this.CharEndUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharEndUpDown.TabIndex = 9;
            // 
            // CharConLabel
            // 
            this.CharConLabel.AutoSize = true;
            this.CharConLabel.Location = new System.Drawing.Point(52, 99);
            this.CharConLabel.Name = "CharConLabel";
            this.CharConLabel.Size = new System.Drawing.Size(65, 13);
            this.CharConLabel.TabIndex = 8;
            this.CharConLabel.Text = "Constitution:";
            // 
            // CharConUpDown
            // 
            this.CharConUpDown.Location = new System.Drawing.Point(125, 97);
            this.CharConUpDown.Name = "CharConUpDown";
            this.CharConUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharConUpDown.TabIndex = 7;
            // 
            // CharAgiLabel
            // 
            this.CharAgiLabel.AutoSize = true;
            this.CharAgiLabel.Location = new System.Drawing.Point(52, 73);
            this.CharAgiLabel.Name = "CharAgiLabel";
            this.CharAgiLabel.Size = new System.Drawing.Size(37, 13);
            this.CharAgiLabel.TabIndex = 6;
            this.CharAgiLabel.Text = "Agility:";
            // 
            // CharAgiUpDown
            // 
            this.CharAgiUpDown.Location = new System.Drawing.Point(125, 71);
            this.CharAgiUpDown.Name = "CharAgiUpDown";
            this.CharAgiUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharAgiUpDown.TabIndex = 5;
            // 
            // CharStrengthLabel
            // 
            this.CharStrengthLabel.AutoSize = true;
            this.CharStrengthLabel.Location = new System.Drawing.Point(52, 47);
            this.CharStrengthLabel.Name = "CharStrengthLabel";
            this.CharStrengthLabel.Size = new System.Drawing.Size(50, 13);
            this.CharStrengthLabel.TabIndex = 4;
            this.CharStrengthLabel.Text = "Strength:";
            // 
            // CharStrUpDown
            // 
            this.CharStrUpDown.Location = new System.Drawing.Point(125, 45);
            this.CharStrUpDown.Name = "CharStrUpDown";
            this.CharStrUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharStrUpDown.TabIndex = 3;
            // 
            // ApplyCharacterButton
            // 
            this.ApplyCharacterButton.Location = new System.Drawing.Point(659, 492);
            this.ApplyCharacterButton.Name = "ApplyCharacterButton";
            this.ApplyCharacterButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyCharacterButton.TabIndex = 2;
            this.ApplyCharacterButton.Text = "Apply";
            this.ApplyCharacterButton.UseVisualStyleBackColor = true;
            this.ApplyCharacterButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CharNameLabel
            // 
            this.CharNameLabel.AutoSize = true;
            this.CharNameLabel.Location = new System.Drawing.Point(52, 22);
            this.CharNameLabel.Name = "CharNameLabel";
            this.CharNameLabel.Size = new System.Drawing.Size(41, 13);
            this.CharNameLabel.TabIndex = 1;
            this.CharNameLabel.Text = "Name: ";
            // 
            // CharNameTextBox
            // 
            this.CharNameTextBox.Location = new System.Drawing.Point(125, 19);
            this.CharNameTextBox.Name = "CharNameTextBox";
            this.CharNameTextBox.Size = new System.Drawing.Size(592, 20);
            this.CharNameTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(12, 530);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddCharButton
            // 
            this.AddCharButton.Location = new System.Drawing.Point(12, 243);
            this.AddCharButton.Name = "AddCharButton";
            this.AddCharButton.Size = new System.Drawing.Size(75, 23);
            this.AddCharButton.TabIndex = 4;
            this.AddCharButton.Text = "Add";
            this.AddCharButton.UseVisualStyleBackColor = true;
            this.AddCharButton.Click += new System.EventHandler(this.AddCharButton_Click);
            // 
            // DeleteCharButton
            // 
            this.DeleteCharButton.Location = new System.Drawing.Point(198, 243);
            this.DeleteCharButton.Name = "DeleteCharButton";
            this.DeleteCharButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteCharButton.TabIndex = 5;
            this.DeleteCharButton.Text = "Delete";
            this.DeleteCharButton.UseVisualStyleBackColor = true;
            this.DeleteCharButton.Click += new System.EventHandler(this.DeleteCharButton_Click);
            // 
            // AddPowerButton
            // 
            this.AddPowerButton.Location = new System.Drawing.Point(12, 476);
            this.AddPowerButton.Name = "AddPowerButton";
            this.AddPowerButton.Size = new System.Drawing.Size(75, 23);
            this.AddPowerButton.TabIndex = 6;
            this.AddPowerButton.Text = "Add";
            this.AddPowerButton.UseVisualStyleBackColor = true;
            this.AddPowerButton.Click += new System.EventHandler(this.AddPowerButton_Click);
            // 
            // DeletePowerButton
            // 
            this.DeletePowerButton.Location = new System.Drawing.Point(198, 476);
            this.DeletePowerButton.Name = "DeletePowerButton";
            this.DeletePowerButton.Size = new System.Drawing.Size(75, 23);
            this.DeletePowerButton.TabIndex = 7;
            this.DeletePowerButton.Text = "Delete";
            this.DeletePowerButton.UseVisualStyleBackColor = true;
            this.DeletePowerButton.Click += new System.EventHandler(this.DeletePowerButton_Click);
            // 
            // PowerTypeSelectionComboBox
            // 
            this.PowerTypeSelectionComboBox.FormattingEnabled = true;
            this.PowerTypeSelectionComboBox.Location = new System.Drawing.Point(93, 478);
            this.PowerTypeSelectionComboBox.Name = "PowerTypeSelectionComboBox";
            this.PowerTypeSelectionComboBox.Size = new System.Drawing.Size(99, 21);
            this.PowerTypeSelectionComboBox.TabIndex = 8;
            // 
            // ApplyEnergyReserveButton
            // 
            this.ApplyEnergyReserveButton.Location = new System.Drawing.Point(642, 487);
            this.ApplyEnergyReserveButton.Name = "ApplyEnergyReserveButton";
            this.ApplyEnergyReserveButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyEnergyReserveButton.TabIndex = 7;
            this.ApplyEnergyReserveButton.Text = "Apply";
            this.ApplyEnergyReserveButton.UseVisualStyleBackColor = true;
            this.ApplyEnergyReserveButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // Character_Editter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 565);
            this.Controls.Add(this.PowerTypeSelectionComboBox);
            this.Controls.Add(this.DeletePowerButton);
            this.Controls.Add(this.AddPowerButton);
            this.Controls.Add(this.DeleteCharButton);
            this.Controls.Add(this.AddCharButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PowersListBox);
            this.Controls.Add(this.CharactersListBox);
            this.Controls.Add(this.EnergyReserveGroupBox);
            this.Controls.Add(this.CharacterGroupBox);
            this.Name = "Character_Editter_Form";
            this.Text = "Character_Editter_Form";
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            this.EnergyReserveGroupBox.ResumeLayout(false);
            this.EnergyReserveGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyReserveRecoveryUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnergyReserveMaxEnergyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharChaUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharWilUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharIntUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharEndUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharConUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharAgiUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CharStrUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CharactersListBox;
        private System.Windows.Forms.ListBox PowersListBox;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.TextBox CharNameTextBox;
        private System.Windows.Forms.Button ApplyCharacterButton;
        private System.Windows.Forms.Label CharNameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label CharStrengthLabel;
        private System.Windows.Forms.NumericUpDown CharStrUpDown;
        private System.Windows.Forms.Label CharChaLabel;
        private System.Windows.Forms.NumericUpDown CharChaUpDown;
        private System.Windows.Forms.Label CharWilLabel;
        private System.Windows.Forms.NumericUpDown CharWilUpDown;
        private System.Windows.Forms.Label CharIntLabel;
        private System.Windows.Forms.NumericUpDown CharIntUpDown;
        private System.Windows.Forms.Label CharEndLabel;
        private System.Windows.Forms.NumericUpDown CharEndUpDown;
        private System.Windows.Forms.Label CharConLabel;
        private System.Windows.Forms.NumericUpDown CharConUpDown;
        private System.Windows.Forms.Label CharAgiLabel;
        private System.Windows.Forms.NumericUpDown CharAgiUpDown;
        private System.Windows.Forms.Label CharacterTierLabel;
        private System.Windows.Forms.Label PointsLabel;
        private System.Windows.Forms.Button AddCharButton;
        private System.Windows.Forms.Button DeleteCharButton;
        private System.Windows.Forms.Button AddPowerButton;
        private System.Windows.Forms.Button DeletePowerButton;
        private System.Windows.Forms.GroupBox EnergyReserveGroupBox;
        private System.Windows.Forms.Label EnergyReserveNameLabel;
        private System.Windows.Forms.NumericUpDown EnergyReserveRecoveryUpDown;
        private System.Windows.Forms.Label EnergyReserveRecoveryLabel;
        private System.Windows.Forms.NumericUpDown EnergyReserveMaxEnergyUpDown;
        private System.Windows.Forms.Label EnergyReserveMaxEnergyLabel;
        private System.Windows.Forms.TextBox EnergyReserveNameTextBox;
        private System.Windows.Forms.Label EnergyReservePointCostLabel;
        private System.Windows.Forms.ComboBox PowerTypeSelectionComboBox;
        private System.Windows.Forms.Button ApplyEnergyReserveButton;
    }
}