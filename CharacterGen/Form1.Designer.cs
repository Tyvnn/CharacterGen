
namespace CharacterGen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rerollButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.strengthModLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rerollButton
            // 
            this.rerollButton.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rerollButton.Location = new System.Drawing.Point(340, 363);
            this.rerollButton.Name = "rerollButton";
            this.rerollButton.Size = new System.Drawing.Size(85, 75);
            this.rerollButton.TabIndex = 0;
            this.rerollButton.Text = "Reroll";
            this.rerollButton.UseVisualStyleBackColor = true;
            this.rerollButton.Click += new System.EventHandler(this.rerollButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Strength";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(52, 163);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(38, 15);
            this.strengthLabel.TabIndex = 2;
            this.strengthLabel.Text = "label2";
            // 
            // strengthModLabel
            // 
            this.strengthModLabel.AutoSize = true;
            this.strengthModLabel.Location = new System.Drawing.Point(142, 163);
            this.strengthModLabel.Name = "strengthModLabel";
            this.strengthModLabel.Size = new System.Drawing.Size(38, 15);
            this.strengthModLabel.TabIndex = 3;
            this.strengthModLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strengthModLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rerollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rerollButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label strengthModLabel;
    }
}

