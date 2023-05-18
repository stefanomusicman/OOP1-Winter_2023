namespace Lab_6._1
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.checkEmailBtn = new System.Windows.Forms.Button();
            this.removeSpaceBtn = new System.Windows.Forms.Button();
            this.checkPostalBtn = new System.Windows.Forms.Button();
            this.deleteLettersBtn = new System.Windows.Forms.Button();
            this.createArrayBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the text to validate:";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(183, 26);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(492, 20);
            this.inputBox.TabIndex = 1;
            // 
            // checkEmailBtn
            // 
            this.checkEmailBtn.Location = new System.Drawing.Point(12, 68);
            this.checkEmailBtn.Name = "checkEmailBtn";
            this.checkEmailBtn.Size = new System.Drawing.Size(102, 48);
            this.checkEmailBtn.TabIndex = 2;
            this.checkEmailBtn.Text = "Check Email";
            this.checkEmailBtn.UseVisualStyleBackColor = true;
            this.checkEmailBtn.Click += new System.EventHandler(this.checkEmailBtn_Click);
            // 
            // removeSpaceBtn
            // 
            this.removeSpaceBtn.Location = new System.Drawing.Point(150, 68);
            this.removeSpaceBtn.Name = "removeSpaceBtn";
            this.removeSpaceBtn.Size = new System.Drawing.Size(102, 48);
            this.removeSpaceBtn.TabIndex = 3;
            this.removeSpaceBtn.Text = "Delete Extra Space";
            this.removeSpaceBtn.UseVisualStyleBackColor = true;
            this.removeSpaceBtn.Click += new System.EventHandler(this.removeSpaceBtn_Click);
            // 
            // checkPostalBtn
            // 
            this.checkPostalBtn.Location = new System.Drawing.Point(290, 68);
            this.checkPostalBtn.Name = "checkPostalBtn";
            this.checkPostalBtn.Size = new System.Drawing.Size(102, 48);
            this.checkPostalBtn.TabIndex = 4;
            this.checkPostalBtn.Text = "Validate Postal Code";
            this.checkPostalBtn.UseVisualStyleBackColor = true;
            this.checkPostalBtn.Click += new System.EventHandler(this.checkPostalBtn_Click);
            // 
            // deleteLettersBtn
            // 
            this.deleteLettersBtn.Location = new System.Drawing.Point(432, 68);
            this.deleteLettersBtn.Name = "deleteLettersBtn";
            this.deleteLettersBtn.Size = new System.Drawing.Size(102, 48);
            this.deleteLettersBtn.TabIndex = 5;
            this.deleteLettersBtn.Text = "Delete Letter a,b,c and d";
            this.deleteLettersBtn.UseVisualStyleBackColor = true;
            this.deleteLettersBtn.Click += new System.EventHandler(this.deleteLettersBtn_Click);
            // 
            // createArrayBtn
            // 
            this.createArrayBtn.Location = new System.Drawing.Point(573, 68);
            this.createArrayBtn.Name = "createArrayBtn";
            this.createArrayBtn.Size = new System.Drawing.Size(102, 48);
            this.createArrayBtn.TabIndex = 6;
            this.createArrayBtn.Text = "Create an Array of words";
            this.createArrayBtn.UseVisualStyleBackColor = true;
            this.createArrayBtn.Click += new System.EventHandler(this.createArrayBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(573, 141);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(102, 34);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 200);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.createArrayBtn);
            this.Controls.Add(this.deleteLettersBtn);
            this.Controls.Add(this.checkPostalBtn);
            this.Controls.Add(this.removeSpaceBtn);
            this.Controls.Add(this.checkEmailBtn);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form Regex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button checkEmailBtn;
        private System.Windows.Forms.Button removeSpaceBtn;
        private System.Windows.Forms.Button checkPostalBtn;
        private System.Windows.Forms.Button deleteLettersBtn;
        private System.Windows.Forms.Button createArrayBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

