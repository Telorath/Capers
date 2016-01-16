namespace Capers
{
    partial class EnergyBlastEditForm
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
            this.Accept = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PointCostLabel = new System.Windows.Forms.Label();
            this.DiceLabel = new System.Windows.Forms.Label();
            this.DiceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EnergySourceComboBox = new System.Windows.Forms.ComboBox();
            this.EnergySourceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DiceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Accept
            // 
            this.Accept.Location = new System.Drawing.Point(13, 229);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(75, 23);
            this.Accept.TabIndex = 0;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = true;
            this.Accept.Click += new System.EventHandler(this.Accept_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(319, 229);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(41, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name: ";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(82, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(243, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // PointCostLabel
            // 
            this.PointCostLabel.AutoSize = true;
            this.PointCostLabel.Location = new System.Drawing.Point(12, 213);
            this.PointCostLabel.Name = "PointCostLabel";
            this.PointCostLabel.Size = new System.Drawing.Size(61, 13);
            this.PointCostLabel.TabIndex = 4;
            this.PointCostLabel.Text = "Point Cost: ";
            // 
            // DiceLabel
            // 
            this.DiceLabel.AutoSize = true;
            this.DiceLabel.Location = new System.Drawing.Point(12, 60);
            this.DiceLabel.Name = "DiceLabel";
            this.DiceLabel.Size = new System.Drawing.Size(35, 13);
            this.DiceLabel.TabIndex = 5;
            this.DiceLabel.Text = "Dice: ";
            // 
            // DiceNumericUpDown
            // 
            this.DiceNumericUpDown.Location = new System.Drawing.Point(82, 58);
            this.DiceNumericUpDown.Name = "DiceNumericUpDown";
            this.DiceNumericUpDown.Size = new System.Drawing.Size(243, 20);
            this.DiceNumericUpDown.TabIndex = 6;
            this.DiceNumericUpDown.ValueChanged += new System.EventHandler(this.DiceNumericUpDown_ValueChanged);
            // 
            // EnergySourceComboBox
            // 
            this.EnergySourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EnergySourceComboBox.FormattingEnabled = true;
            this.EnergySourceComboBox.Location = new System.Drawing.Point(94, 96);
            this.EnergySourceComboBox.Name = "EnergySourceComboBox";
            this.EnergySourceComboBox.Size = new System.Drawing.Size(154, 21);
            this.EnergySourceComboBox.TabIndex = 7;
            // 
            // EnergySourceLabel
            // 
            this.EnergySourceLabel.AutoSize = true;
            this.EnergySourceLabel.Location = new System.Drawing.Point(5, 99);
            this.EnergySourceLabel.Name = "EnergySourceLabel";
            this.EnergySourceLabel.Size = new System.Drawing.Size(83, 13);
            this.EnergySourceLabel.TabIndex = 8;
            this.EnergySourceLabel.Text = "Energy Source: ";
            // 
            // EnergyBlastEditForm
            // 
            this.AcceptButton = this.Accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(406, 264);
            this.Controls.Add(this.EnergySourceLabel);
            this.Controls.Add(this.EnergySourceComboBox);
            this.Controls.Add(this.DiceNumericUpDown);
            this.Controls.Add(this.DiceLabel);
            this.Controls.Add(this.PointCostLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Accept);
            this.Name = "EnergyBlastEditForm";
            ((System.ComponentModel.ISupportInitialize)(this.DiceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label PointCostLabel;
        private System.Windows.Forms.Label DiceLabel;
        private System.Windows.Forms.NumericUpDown DiceNumericUpDown;
        private System.Windows.Forms.ComboBox EnergySourceComboBox;
        private System.Windows.Forms.Label EnergySourceLabel;
    }
}