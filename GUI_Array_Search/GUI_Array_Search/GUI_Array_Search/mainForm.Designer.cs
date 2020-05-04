namespace GUI_Array_Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchOutputLabel = new System.Windows.Forms.Label();
            this.randomOutputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number List:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Value to Search For:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(143, 55);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(53, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(208, 54);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchOutputLabel
            // 
            this.searchOutputLabel.Location = new System.Drawing.Point(291, 55);
            this.searchOutputLabel.Name = "searchOutputLabel";
            this.searchOutputLabel.Size = new System.Drawing.Size(255, 24);
            this.searchOutputLabel.TabIndex = 0;
            this.searchOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchOutputLabel.Visible = false;
            // 
            // randomOutputTextBox
            // 
            this.randomOutputTextBox.Location = new System.Drawing.Point(143, 26);
            this.randomOutputTextBox.Name = "randomOutputTextBox";
            this.randomOutputTextBox.ReadOnly = true;
            this.randomOutputTextBox.Size = new System.Drawing.Size(328, 20);
            this.randomOutputTextBox.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 111);
            this.Controls.Add(this.randomOutputTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchOutputLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainForm";
            this.Text = "Searching an Array GUI Application";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchOutputLabel;
        private System.Windows.Forms.TextBox randomOutputTextBox;
    }
}

