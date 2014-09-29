namespace Simple_Calculator
{
    partial class simpleCalculatorUI
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
            this.firstNumberLebel = new System.Windows.Forms.Label();
            this.secondNumberLebel = new System.Windows.Forms.Label();
            this.resultLebel = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextbox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.devisionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberLebel
            // 
            this.firstNumberLebel.AutoSize = true;
            this.firstNumberLebel.Location = new System.Drawing.Point(13, 13);
            this.firstNumberLebel.Name = "firstNumberLebel";
            this.firstNumberLebel.Size = new System.Drawing.Size(66, 13);
            this.firstNumberLebel.TabIndex = 0;
            this.firstNumberLebel.Text = "First Number";
            // 
            // secondNumberLebel
            // 
            this.secondNumberLebel.AutoSize = true;
            this.secondNumberLebel.Location = new System.Drawing.Point(16, 49);
            this.secondNumberLebel.Name = "secondNumberLebel";
            this.secondNumberLebel.Size = new System.Drawing.Size(84, 13);
            this.secondNumberLebel.TabIndex = 1;
            this.secondNumberLebel.Text = "Second Number";
            // 
            // resultLebel
            // 
            this.resultLebel.AutoSize = true;
            this.resultLebel.Location = new System.Drawing.Point(16, 82);
            this.resultLebel.Name = "resultLebel";
            this.resultLebel.Size = new System.Drawing.Size(37, 13);
            this.resultLebel.TabIndex = 2;
            this.resultLebel.Text = "Result";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(121, 5);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(252, 20);
            this.firstNumberTextBox.TabIndex = 3;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(121, 42);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(252, 20);
            this.secondNumberTextBox.TabIndex = 4;
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(121, 75);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(252, 20);
            this.resultTextbox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(19, 199);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(110, 198);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 7;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(202, 198);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 23);
            this.multiplyButton.TabIndex = 8;
            this.multiplyButton.Text = "Multiply";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // devisionButton
            // 
            this.devisionButton.Location = new System.Drawing.Point(298, 198);
            this.devisionButton.Name = "devisionButton";
            this.devisionButton.Size = new System.Drawing.Size(75, 23);
            this.devisionButton.TabIndex = 9;
            this.devisionButton.Text = "Devision";
            this.devisionButton.UseVisualStyleBackColor = true;
            this.devisionButton.Click += new System.EventHandler(this.devisionButton_Click);
            // 
            // simpleCalculatorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.devisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.resultLebel);
            this.Controls.Add(this.secondNumberLebel);
            this.Controls.Add(this.firstNumberLebel);
            this.Name = "simpleCalculatorUI";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLebel;
        private System.Windows.Forms.Label secondNumberLebel;
        private System.Windows.Forms.Label resultLebel;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.TextBox resultTextbox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button devisionButton;
    }
}

