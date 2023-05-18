namespace final_project
{
    partial class Lotto649Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lotto649Form));
            this.exitBtn = new System.Windows.Forms.Button();
            this.readFileBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitBtn.Location = new System.Drawing.Point(258, 336);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(109, 32);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // readFileBtn
            // 
            this.readFileBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.readFileBtn.Location = new System.Drawing.Point(143, 336);
            this.readFileBtn.Name = "readFileBtn";
            this.readFileBtn.Size = new System.Drawing.Size(109, 32);
            this.readFileBtn.TabIndex = 10;
            this.readFileBtn.Text = "&Read File";
            this.readFileBtn.UseVisualStyleBackColor = false;
            this.readFileBtn.Click += new System.EventHandler(this.readFileBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generateBtn.Location = new System.Drawing.Point(24, 336);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(109, 32);
            this.generateBtn.TabIndex = 9;
            this.generateBtn.Text = "&Generate";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // resultsBox
            // 
            this.resultsBox.Location = new System.Drawing.Point(258, 19);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(91, 293);
            this.resultsBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "The winning numbers are:";
            // 
            // Lotto649Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 390);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.readFileBtn);
            this.Controls.Add(this.generateBtn);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Lotto649Form";
            this.Text = "Lotto649Form - Stefano";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button readFileBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}