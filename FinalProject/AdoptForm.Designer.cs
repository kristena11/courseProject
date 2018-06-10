namespace FinalProject
{
    partial class AdoptForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.PetNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PetNameLabel
            // 
            this.PetNameLabel.AutoSize = true;
            this.PetNameLabel.Location = new System.Drawing.Point(144, 138);
            this.PetNameLabel.Name = "PetNameLabel";
            this.PetNameLabel.Size = new System.Drawing.Size(70, 25);
            this.PetNameLabel.TabIndex = 1;
            this.PetNameLabel.Text = "label1";
            // 
            // AdoptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PetNameLabel);
            this.Controls.Add(this.button1);
            this.Name = "AdoptForm";
            this.Text = "AdoptForm";
            this.Load += new System.EventHandler(this.AdoptForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label PetNameLabel;
    }
}