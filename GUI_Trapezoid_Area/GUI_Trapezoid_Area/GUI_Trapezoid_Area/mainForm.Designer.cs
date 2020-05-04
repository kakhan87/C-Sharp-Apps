namespace GUI_Trapezoid_Area
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
            this.firstParallelSideTextBox = new System.Windows.Forms.TextBox();
            this.firstParallelSideLabel = new System.Windows.Forms.Label();
            this.secondParallelSideTextBox = new System.Windows.Forms.TextBox();
            this.secondParallelSideLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.resultOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstParallelSideTextBox
            // 
            this.firstParallelSideTextBox.Location = new System.Drawing.Point(144, 20);
            this.firstParallelSideTextBox.Name = "firstParallelSideTextBox";
            this.firstParallelSideTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstParallelSideTextBox.TabIndex = 1;
            // 
            // firstParallelSideLabel
            // 
            this.firstParallelSideLabel.AutoSize = true;
            this.firstParallelSideLabel.Location = new System.Drawing.Point(13, 23);
            this.firstParallelSideLabel.Name = "firstParallelSideLabel";
            this.firstParallelSideLabel.Size = new System.Drawing.Size(125, 13);
            this.firstParallelSideLabel.TabIndex = 1;
            this.firstParallelSideLabel.Text = "Length of Parallel Side 1:";
            // 
            // secondParallelSideTextBox
            // 
            this.secondParallelSideTextBox.Location = new System.Drawing.Point(144, 48);
            this.secondParallelSideTextBox.Name = "secondParallelSideTextBox";
            this.secondParallelSideTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondParallelSideTextBox.TabIndex = 2;
            // 
            // secondParallelSideLabel
            // 
            this.secondParallelSideLabel.AutoSize = true;
            this.secondParallelSideLabel.Location = new System.Drawing.Point(13, 51);
            this.secondParallelSideLabel.Name = "secondParallelSideLabel";
            this.secondParallelSideLabel.Size = new System.Drawing.Size(125, 13);
            this.secondParallelSideLabel.TabIndex = 1;
            this.secondParallelSideLabel.Text = "Length of Parallel Side 2:";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(144, 77);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(100, 20);
            this.heightTextBox.TabIndex = 3;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(49, 80);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(89, 13);
            this.heightLabel.TabIndex = 1;
            this.heightLabel.Text = "Length of Height:";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(18, 110);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 4;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(18, 139);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(75, 23);
            this.quitButton.TabIndex = 0;
            this.quitButton.TabStop = false;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // resultOutputLabel
            // 
            this.resultOutputLabel.ForeColor = System.Drawing.Color.Blue;
            this.resultOutputLabel.Location = new System.Drawing.Point(105, 109);
            this.resultOutputLabel.Name = "resultOutputLabel";
            this.resultOutputLabel.Size = new System.Drawing.Size(100, 23);
            this.resultOutputLabel.TabIndex = 3;
            this.resultOutputLabel.Text = "Area Result";
            this.resultOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resultOutputLabel.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 175);
            this.Controls.Add(this.resultOutputLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.secondParallelSideLabel);
            this.Controls.Add(this.secondParallelSideTextBox);
            this.Controls.Add(this.firstParallelSideLabel);
            this.Controls.Add(this.firstParallelSideTextBox);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstParallelSideTextBox;
        private System.Windows.Forms.Label firstParallelSideLabel;
        private System.Windows.Forms.TextBox secondParallelSideTextBox;
        private System.Windows.Forms.Label secondParallelSideLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label resultOutputLabel;
    }
}

