namespace GUI_Technical_Support
{
    partial class mainForm
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
            this.computerBeepCheckBox = new System.Windows.Forms.CheckBox();
            this.discSpinCheckBox = new System.Windows.Forms.CheckBox();
            this.recommendationButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.recommendationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // computerBeepCheckBox
            // 
            this.computerBeepCheckBox.AutoSize = true;
            this.computerBeepCheckBox.Location = new System.Drawing.Point(97, 32);
            this.computerBeepCheckBox.Name = "computerBeepCheckBox";
            this.computerBeepCheckBox.Size = new System.Drawing.Size(104, 17);
            this.computerBeepCheckBox.TabIndex = 0;
            this.computerBeepCheckBox.Text = "Computer Beeps";
            this.computerBeepCheckBox.UseVisualStyleBackColor = true;
            this.computerBeepCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxChanged);
            // 
            // discSpinCheckBox
            // 
            this.discSpinCheckBox.AutoSize = true;
            this.discSpinCheckBox.Location = new System.Drawing.Point(97, 55);
            this.discSpinCheckBox.Name = "discSpinCheckBox";
            this.discSpinCheckBox.Size = new System.Drawing.Size(99, 17);
            this.discSpinCheckBox.TabIndex = 0;
            this.discSpinCheckBox.Text = "Discdrive Spins";
            this.discSpinCheckBox.UseVisualStyleBackColor = true;
            // 
            // recommendationButton
            // 
            this.recommendationButton.Location = new System.Drawing.Point(96, 78);
            this.recommendationButton.Name = "recommendationButton";
            this.recommendationButton.Size = new System.Drawing.Size(104, 23);
            this.recommendationButton.TabIndex = 1;
            this.recommendationButton.Text = "What should I do?";
            this.recommendationButton.UseVisualStyleBackColor = true;
            this.recommendationButton.Click += new System.EventHandler(this.recommendationButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(97, 190);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(104, 23);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // recommendationLabel
            // 
            this.recommendationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recommendationLabel.ForeColor = System.Drawing.Color.Red;
            this.recommendationLabel.Location = new System.Drawing.Point(25, 108);
            this.recommendationLabel.Name = "recommendationLabel";
            this.recommendationLabel.Size = new System.Drawing.Size(257, 70);
            this.recommendationLabel.TabIndex = 2;
            this.recommendationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.recommendationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 227);
            this.Controls.Add(this.recommendationLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.recommendationButton);
            this.Controls.Add(this.discSpinCheckBox);
            this.Controls.Add(this.computerBeepCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox computerBeepCheckBox;
        private System.Windows.Forms.CheckBox discSpinCheckBox;
        private System.Windows.Forms.Button recommendationButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label recommendationLabel;
    }
}

