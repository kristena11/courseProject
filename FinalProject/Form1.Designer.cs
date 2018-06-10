namespace FinalProject
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxAnimalType = new System.Windows.Forms.ComboBox();
            this.addDetailsBtn = new System.Windows.Forms.Button();
            this.tabbyList = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AnimalSelectLabel = new System.Windows.Forms.Label();
            this.adoptBtn = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admin Pannel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(120, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Arrivals";
            // 
            // comboBoxAnimalType
            // 
            this.comboBoxAnimalType.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAnimalType.FormattingEnabled = true;
            this.comboBoxAnimalType.Items.AddRange(new object[] {
            "Cat ",
            "Dog"});
            this.comboBoxAnimalType.Location = new System.Drawing.Point(387, 332);
            this.comboBoxAnimalType.Name = "comboBoxAnimalType";
            this.comboBoxAnimalType.Size = new System.Drawing.Size(287, 44);
            this.comboBoxAnimalType.TabIndex = 3;
            // 
            // addDetailsBtn
            // 
            this.addDetailsBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDetailsBtn.Location = new System.Drawing.Point(132, 439);
            this.addDetailsBtn.Name = "addDetailsBtn";
            this.addDetailsBtn.Size = new System.Drawing.Size(313, 44);
            this.addDetailsBtn.TabIndex = 4;
            this.addDetailsBtn.Text = "Add Details";
            this.addDetailsBtn.UseVisualStyleBackColor = true;
            this.addDetailsBtn.Click += new System.EventHandler(this.addDetailsBtn_Click);
            // 
            // tabbyList
            // 
            this.tabbyList.AutoSize = true;
            this.tabbyList.Location = new System.Drawing.Point(159, 673);
            this.tabbyList.Name = "tabbyList";
            this.tabbyList.Size = new System.Drawing.Size(0, 25);
            this.tabbyList.TabIndex = 5;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(127, 732);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(896, 396);
            this.treeView1.TabIndex = 10;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = "Available Animals";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 36);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select Animal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(120, 543);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 69);
            this.label5.TabIndex = 13;
            this.label5.Text = "Adopt";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // AnimalSelectLabel
            // 
            this.AnimalSelectLabel.AutoSize = true;
            this.AnimalSelectLabel.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimalSelectLabel.Location = new System.Drawing.Point(126, 1158);
            this.AnimalSelectLabel.Name = "AnimalSelectLabel";
            this.AnimalSelectLabel.Size = new System.Drawing.Size(263, 36);
            this.AnimalSelectLabel.TabIndex = 14;
            this.AnimalSelectLabel.Text = "Select from above:";
            // 
            // adoptBtn
            // 
            this.adoptBtn.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adoptBtn.Location = new System.Drawing.Point(127, 1250);
            this.adoptBtn.Name = "adoptBtn";
            this.adoptBtn.Size = new System.Drawing.Size(313, 44);
            this.adoptBtn.TabIndex = 15;
            this.adoptBtn.Text = "Adopt";
            this.adoptBtn.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(132, 1497);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(313, 44);
            this.ReportButton.TabIndex = 16;
            this.ReportButton.Text = "Adopted Animals";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(120, 1357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 69);
            this.label6.TabIndex = 17;
            this.label6.Text = "Reports";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1187, 1760);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.adoptBtn);
            this.Controls.Add(this.AnimalSelectLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabbyList);
            this.Controls.Add(this.addDetailsBtn);
            this.Controls.Add(this.comboBoxAnimalType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "California Pet Resuce";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAnimalType;
        private System.Windows.Forms.Button addDetailsBtn;
        private System.Windows.Forms.Label tabbyList;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AnimalSelectLabel;
        private System.Windows.Forms.Button adoptBtn;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Label label6;
    }
}

