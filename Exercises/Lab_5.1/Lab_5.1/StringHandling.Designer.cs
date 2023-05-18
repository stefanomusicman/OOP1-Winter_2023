namespace Lab_5._1
{
    partial class StringHandling
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.nameBtn = new System.Windows.Forms.Button();
            this.numberBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter full name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter phone number:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(156, 27);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(164, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.Text = "Stefano Proietti";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(156, 71);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(117, 20);
            this.phoneTextBox.TabIndex = 3;
            this.phoneTextBox.Text = "(514) 555-6666";
            // 
            // nameBtn
            // 
            this.nameBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameBtn.Location = new System.Drawing.Point(370, 21);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(159, 30);
            this.nameBtn.TabIndex = 4;
            this.nameBtn.Text = "Parse Name";
            this.nameBtn.UseVisualStyleBackColor = false;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // numberBtn
            // 
            this.numberBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.numberBtn.Location = new System.Drawing.Point(370, 65);
            this.numberBtn.Name = "numberBtn";
            this.numberBtn.Size = new System.Drawing.Size(159, 31);
            this.numberBtn.TabIndex = 5;
            this.numberBtn.Text = "Edit Phone Number";
            this.numberBtn.UseVisualStyleBackColor = false;
            this.numberBtn.Click += new System.EventHandler(this.numberBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(370, 118);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(63, 31);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // StringHandling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 161);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.numberBtn);
            this.Controls.Add(this.nameBtn);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StringHandling";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button nameBtn;
        private System.Windows.Forms.Button numberBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

