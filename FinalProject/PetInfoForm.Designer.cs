namespace FinalProject
{
    partial class PetInfoForm
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
            this.breedLable = new System.Windows.Forms.Label();
            this.comboBoxBreedSelection = new System.Windows.Forms.ComboBox();
            this.chipLabel = new System.Windows.Forms.Label();
            this.arrivalDateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.chipTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addAnimalToList = new System.Windows.Forms.Button();
            this.ArrivalDateTime = new System.Windows.Forms.DateTimePicker();
            this.animalTypeLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // breedLable
            // 
            this.breedLable.AutoSize = true;
            this.breedLable.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breedLable.Location = new System.Drawing.Point(124, 153);
            this.breedLable.Name = "breedLable";
            this.breedLable.Size = new System.Drawing.Size(96, 36);
            this.breedLable.TabIndex = 0;
            this.breedLable.Text = "Breed";
            this.breedLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBoxBreedSelection
            // 
            this.comboBoxBreedSelection.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBreedSelection.FormattingEnabled = true;
            this.comboBoxBreedSelection.Items.AddRange(new object[] {
            "Chocolate",
            "Lollipops",
            "Gum"});
            this.comboBoxBreedSelection.Location = new System.Drawing.Point(129, 198);
            this.comboBoxBreedSelection.Name = "comboBoxBreedSelection";
            this.comboBoxBreedSelection.Size = new System.Drawing.Size(287, 44);
            this.comboBoxBreedSelection.TabIndex = 2;
            // 
            // chipLabel
            // 
            this.chipLabel.AutoSize = true;
            this.chipLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipLabel.Location = new System.Drawing.Point(124, 591);
            this.chipLabel.Name = "chipLabel";
            this.chipLabel.Size = new System.Drawing.Size(206, 36);
            this.chipLabel.TabIndex = 3;
            this.chipLabel.Text = "Chip Number";
            // 
            // arrivalDateLabel
            // 
            this.arrivalDateLabel.AutoSize = true;
            this.arrivalDateLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrivalDateLabel.Location = new System.Drawing.Point(125, 420);
            this.arrivalDateLabel.Name = "arrivalDateLabel";
            this.arrivalDateLabel.Size = new System.Drawing.Size(178, 36);
            this.arrivalDateLabel.TabIndex = 4;
            this.arrivalDateLabel.Text = "Arrival Date";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(125, 277);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(99, 36);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // chipTextBox
            // 
            this.chipTextBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chipTextBox.Location = new System.Drawing.Point(129, 670);
            this.chipTextBox.Name = "chipTextBox";
            this.chipTextBox.Size = new System.Drawing.Size(287, 43);
            this.chipTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(131, 333);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(287, 43);
            this.nameTextBox.TabIndex = 8;
            // 
            // addAnimalToList
            // 
            this.addAnimalToList.BackColor = System.Drawing.Color.Red;
            this.addAnimalToList.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimalToList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addAnimalToList.Location = new System.Drawing.Point(129, 834);
            this.addAnimalToList.Name = "addAnimalToList";
            this.addAnimalToList.Size = new System.Drawing.Size(287, 70);
            this.addAnimalToList.TabIndex = 9;
            this.addAnimalToList.Text = "Add Animal";
            this.addAnimalToList.UseVisualStyleBackColor = false;
            this.addAnimalToList.Click += new System.EventHandler(this.addAnimalToList_Click);
            // 
            // ArrivalDateTime
            // 
            this.ArrivalDateTime.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalDateTime.Location = new System.Drawing.Point(130, 490);
            this.ArrivalDateTime.Name = "ArrivalDateTime";
            this.ArrivalDateTime.Size = new System.Drawing.Size(414, 43);
            this.ArrivalDateTime.TabIndex = 10;
            // 
            // animalTypeLable
            // 
            this.animalTypeLable.AutoSize = true;
            this.animalTypeLable.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalTypeLable.ForeColor = System.Drawing.Color.Red;
            this.animalTypeLable.Location = new System.Drawing.Point(383, 72);
            this.animalTypeLable.Name = "animalTypeLable";
            this.animalTypeLable.Size = new System.Drawing.Size(210, 69);
            this.animalTypeLable.TabIndex = 11;
            this.animalTypeLable.Text = "Breed";
            // 
            // PetInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 1060);
            this.Controls.Add(this.animalTypeLable);
            this.Controls.Add(this.ArrivalDateTime);
            this.Controls.Add(this.addAnimalToList);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.chipTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.arrivalDateLabel);
            this.Controls.Add(this.chipLabel);
            this.Controls.Add(this.comboBoxBreedSelection);
            this.Controls.Add(this.breedLable);
            this.Name = "PetInfoForm";
            this.Text = "PetInfo";
            this.Load += new System.EventHandler(this.PetInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label breedLable;
        private System.Windows.Forms.ComboBox comboBoxBreedSelection;
        private System.Windows.Forms.Label chipLabel;
        private System.Windows.Forms.Label arrivalDateLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox chipTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addAnimalToList;
        private System.Windows.Forms.DateTimePicker ArrivalDateTime;
        private System.Windows.Forms.Label animalTypeLable;
    }
}