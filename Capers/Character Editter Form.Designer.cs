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
            this.ApplyCharacterButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CharacterStrengthUpDown = new System.Windows.Forms.NumericUpDown();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.CharacterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStrengthUpDown)).BeginInit();
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
            this.CharacterGroupBox.Controls.Add(this.StrengthLabel);
            this.CharacterGroupBox.Controls.Add(this.CharacterStrengthUpDown);
            this.CharacterGroupBox.Controls.Add(this.ApplyCharacterButton);
            this.CharacterGroupBox.Controls.Add(this.NameLabel);
            this.CharacterGroupBox.Controls.Add(this.NameTextBox);
            this.CharacterGroupBox.Location = new System.Drawing.Point(279, 12);
            this.CharacterGroupBox.Name = "CharacterGroupBox";
            this.CharacterGroupBox.Size = new System.Drawing.Size(740, 521);
            this.CharacterGroupBox.TabIndex = 2;
            this.CharacterGroupBox.TabStop = false;
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
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(64, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name: ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(125, 19);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(592, 20);
            this.NameTextBox.TabIndex = 0;
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
            // CharacterStrengthUpDown
            // 
            this.CharacterStrengthUpDown.Location = new System.Drawing.Point(125, 45);
            this.CharacterStrengthUpDown.Name = "CharacterStrengthUpDown";
            this.CharacterStrengthUpDown.Size = new System.Drawing.Size(237, 20);
            this.CharacterStrengthUpDown.TabIndex = 3;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(52, 47);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(53, 13);
            this.StrengthLabel.TabIndex = 4;
            this.StrengthLabel.Text = "Strength: ";
            // 
            // Character_Editter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 565);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CharacterGroupBox);
            this.Controls.Add(this.PowersListBox);
            this.Controls.Add(this.CharactersListBox);
            this.Name = "Character_Editter_Form";
            this.Text = "Character_Editter_Form";
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterStrengthUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CharactersListBox;
        private System.Windows.Forms.ListBox PowersListBox;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button ApplyCharacterButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.NumericUpDown CharacterStrengthUpDown;
    }
}