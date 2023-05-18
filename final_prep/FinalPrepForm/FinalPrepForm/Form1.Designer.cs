namespace FinalPrepForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_name = new System.Windows.Forms.Button();
            this.btn_city = new System.Windows.Forms.Button();
            this.btn_age = new System.Windows.Forms.Button();
            this.btn_appendToTxt = new System.Windows.Forms.Button();
            this.btn_readTxt_appendXml = new System.Windows.Forms.Button();
            this.btn_readXML = new System.Windows.Forms.Button();
            this.btn_deleteTxt = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(93, 23);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(347, 20);
            this.txt_name.TabIndex = 3;
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(93, 59);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(347, 20);
            this.txt_city.TabIndex = 4;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(93, 94);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(347, 20);
            this.txt_age.TabIndex = 5;
            // 
            // btn_name
            // 
            this.btn_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_name.Location = new System.Drawing.Point(466, 17);
            this.btn_name.Name = "btn_name";
            this.btn_name.Size = new System.Drawing.Size(151, 31);
            this.btn_name.TabIndex = 6;
            this.btn_name.Text = "Validate";
            this.btn_name.UseVisualStyleBackColor = false;
            this.btn_name.Click += new System.EventHandler(this.btn_name_Click);
            // 
            // btn_city
            // 
            this.btn_city.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_city.Enabled = false;
            this.btn_city.Location = new System.Drawing.Point(466, 53);
            this.btn_city.Name = "btn_city";
            this.btn_city.Size = new System.Drawing.Size(151, 31);
            this.btn_city.TabIndex = 7;
            this.btn_city.Text = "Validate";
            this.btn_city.UseVisualStyleBackColor = false;
            this.btn_city.Click += new System.EventHandler(this.btn_city_Click);
            // 
            // btn_age
            // 
            this.btn_age.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_age.Enabled = false;
            this.btn_age.Location = new System.Drawing.Point(466, 88);
            this.btn_age.Name = "btn_age";
            this.btn_age.Size = new System.Drawing.Size(151, 31);
            this.btn_age.TabIndex = 8;
            this.btn_age.Text = "Validate";
            this.btn_age.UseVisualStyleBackColor = false;
            this.btn_age.Click += new System.EventHandler(this.btn_age_Click);
            // 
            // btn_appendToTxt
            // 
            this.btn_appendToTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_appendToTxt.Location = new System.Drawing.Point(93, 159);
            this.btn_appendToTxt.Name = "btn_appendToTxt";
            this.btn_appendToTxt.Size = new System.Drawing.Size(96, 57);
            this.btn_appendToTxt.TabIndex = 9;
            this.btn_appendToTxt.Text = "Append to txt file";
            this.btn_appendToTxt.UseVisualStyleBackColor = false;
            this.btn_appendToTxt.Click += new System.EventHandler(this.btn_appendToTxt_Click);
            // 
            // btn_readTxt_appendXml
            // 
            this.btn_readTxt_appendXml.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_readTxt_appendXml.Location = new System.Drawing.Point(215, 159);
            this.btn_readTxt_appendXml.Name = "btn_readTxt_appendXml";
            this.btn_readTxt_appendXml.Size = new System.Drawing.Size(96, 57);
            this.btn_readTxt_appendXml.TabIndex = 10;
            this.btn_readTxt_appendXml.Text = "Read txt \r\nCreate XML";
            this.btn_readTxt_appendXml.UseVisualStyleBackColor = false;
            this.btn_readTxt_appendXml.Click += new System.EventHandler(this.btn_readTxt_appendXml_Click);
            // 
            // btn_readXML
            // 
            this.btn_readXML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_readXML.Location = new System.Drawing.Point(344, 159);
            this.btn_readXML.Name = "btn_readXML";
            this.btn_readXML.Size = new System.Drawing.Size(96, 57);
            this.btn_readXML.TabIndex = 11;
            this.btn_readXML.Text = "Read XML";
            this.btn_readXML.UseVisualStyleBackColor = false;
            this.btn_readXML.Click += new System.EventHandler(this.btn_readXML_Click);
            // 
            // btn_deleteTxt
            // 
            this.btn_deleteTxt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_deleteTxt.Location = new System.Drawing.Point(215, 231);
            this.btn_deleteTxt.Name = "btn_deleteTxt";
            this.btn_deleteTxt.Size = new System.Drawing.Size(96, 57);
            this.btn_deleteTxt.TabIndex = 12;
            this.btn_deleteTxt.Text = "Delete txt file";
            this.btn_deleteTxt.UseVisualStyleBackColor = false;
            this.btn_deleteTxt.Click += new System.EventHandler(this.btn_deleteTxt_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(507, 257);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(110, 31);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 304);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_deleteTxt);
            this.Controls.Add(this.btn_readXML);
            this.Controls.Add(this.btn_readTxt_appendXml);
            this.Controls.Add(this.btn_appendToTxt);
            this.Controls.Add(this.btn_age);
            this.Controls.Add(this.btn_city);
            this.Controls.Add(this.btn_name);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_name;
        private System.Windows.Forms.Button btn_city;
        private System.Windows.Forms.Button btn_age;
        private System.Windows.Forms.Button btn_appendToTxt;
        private System.Windows.Forms.Button btn_readTxt_appendXml;
        private System.Windows.Forms.Button btn_readXML;
        private System.Windows.Forms.Button btn_deleteTxt;
        private System.Windows.Forms.Button btn_exit;
    }
}

