namespace Lab_4._1
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
            this.num1Label = new System.Windows.Forms.Label();
            this.num2Label = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.addResult = new System.Windows.Forms.TextBox();
            this.subResult = new System.Windows.Forms.TextBox();
            this.multResult = new System.Windows.Forms.TextBox();
            this.divResult = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1Label
            // 
            this.num1Label.AutoSize = true;
            this.num1Label.Location = new System.Drawing.Point(28, 82);
            this.num1Label.Name = "num1Label";
            this.num1Label.Size = new System.Drawing.Size(56, 13);
            this.num1Label.TabIndex = 0;
            this.num1Label.Text = "Number &1:";
            // 
            // num2Label
            // 
            this.num2Label.AutoSize = true;
            this.num2Label.Location = new System.Drawing.Point(28, 108);
            this.num2Label.Name = "num2Label";
            this.num2Label.Size = new System.Drawing.Size(56, 13);
            this.num2Label.TabIndex = 1;
            this.num2Label.Text = "Number &2:";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(90, 75);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(100, 20);
            this.input1.TabIndex = 0;
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(90, 105);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(100, 20);
            this.input2.TabIndex = 1;
            this.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addButton.Location = new System.Drawing.Point(212, 36);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(83, 29);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.subtractButton.Location = new System.Drawing.Point(212, 71);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(83, 29);
            this.subtractButton.TabIndex = 5;
            this.subtractButton.Text = "&Sub";
            this.subtractButton.UseVisualStyleBackColor = false;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.multiplyButton.Location = new System.Drawing.Point(212, 105);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(83, 29);
            this.multiplyButton.TabIndex = 6;
            this.multiplyButton.Text = "&Mul";
            this.multiplyButton.UseVisualStyleBackColor = false;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // divisionButton
            // 
            this.divisionButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.divisionButton.Location = new System.Drawing.Point(212, 140);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(83, 29);
            this.divisionButton.TabIndex = 7;
            this.divisionButton.Text = "&Div";
            this.divisionButton.UseVisualStyleBackColor = false;
            this.divisionButton.Click += new System.EventHandler(this.divisionButton_Click);
            // 
            // addResult
            // 
            this.addResult.Location = new System.Drawing.Point(332, 41);
            this.addResult.Name = "addResult";
            this.addResult.ReadOnly = true;
            this.addResult.Size = new System.Drawing.Size(100, 20);
            this.addResult.TabIndex = 8;
            this.addResult.TabStop = false;
            this.addResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // subResult
            // 
            this.subResult.Location = new System.Drawing.Point(332, 76);
            this.subResult.Name = "subResult";
            this.subResult.ReadOnly = true;
            this.subResult.Size = new System.Drawing.Size(100, 20);
            this.subResult.TabIndex = 9;
            this.subResult.TabStop = false;
            this.subResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // multResult
            // 
            this.multResult.Location = new System.Drawing.Point(332, 110);
            this.multResult.Name = "multResult";
            this.multResult.ReadOnly = true;
            this.multResult.Size = new System.Drawing.Size(100, 20);
            this.multResult.TabIndex = 10;
            this.multResult.TabStop = false;
            this.multResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // divResult
            // 
            this.divResult.Location = new System.Drawing.Point(332, 145);
            this.divResult.Name = "divResult";
            this.divResult.ReadOnly = true;
            this.divResult.Size = new System.Drawing.Size(100, 20);
            this.divResult.TabIndex = 11;
            this.divResult.TabStop = false;
            this.divResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.divResult.TextChanged += new System.EventHandler(this.divResult_TextChanged);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(329, 9);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(42, 13);
            this.resultsLabel.TabIndex = 12;
            this.resultsLabel.Text = "Results";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Location = new System.Drawing.Point(349, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(83, 29);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 233);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.divResult);
            this.Controls.Add(this.multResult);
            this.Controls.Add(this.subResult);
            this.Controls.Add(this.addResult);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.num2Label);
            this.Controls.Add(this.num1Label);
            this.Name = "Form1";
            this.Text = "Stefano Proietti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1Label;
        private System.Windows.Forms.Label num2Label;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button divisionButton;
        private System.Windows.Forms.TextBox addResult;
        private System.Windows.Forms.TextBox subResult;
        private System.Windows.Forms.TextBox multResult;
        private System.Windows.Forms.TextBox divResult;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Button exitButton;
    }
}

