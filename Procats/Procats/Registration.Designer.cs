
namespace Procats
{
    partial class Registration
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Other = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.British = new System.Windows.Forms.RadioButton();
            this.Persian = new System.Windows.Forms.RadioButton();
            this.MaineCoon = new System.Windows.Forms.RadioButton();
            this.ShortHaired = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gender:";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(83, 52);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 3;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(137, 52);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(202, 52);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(51, 17);
            this.Other.TabIndex = 5;
            this.Other.TabStop = true;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.CheckedChanged += new System.EventHandler(this.Other_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Favorite Cat:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.British);
            this.groupBox1.Controls.Add(this.Persian);
            this.groupBox1.Controls.Add(this.MaineCoon);
            this.groupBox1.Controls.Add(this.ShortHaired);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Other);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 209);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration ";
            // 
            // British
            // 
            this.British.AutoSize = true;
            this.British.Location = new System.Drawing.Point(137, 133);
            this.British.Name = "British";
            this.British.Size = new System.Drawing.Size(53, 17);
            this.British.TabIndex = 14;
            this.British.TabStop = true;
            this.British.Text = "British";
            this.British.UseVisualStyleBackColor = true;
            this.British.CheckedChanged += new System.EventHandler(this.British_CheckedChanged);
            // 
            // Persian
            // 
            this.Persian.AutoSize = true;
            this.Persian.Location = new System.Drawing.Point(136, 110);
            this.Persian.Name = "Persian";
            this.Persian.Size = new System.Drawing.Size(60, 17);
            this.Persian.TabIndex = 13;
            this.Persian.TabStop = true;
            this.Persian.Text = "Persian";
            this.Persian.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Persian.UseVisualStyleBackColor = true;
            this.Persian.CheckedChanged += new System.EventHandler(this.Persian_CheckedChanged);
            // 
            // MaineCoon
            // 
            this.MaineCoon.AutoSize = true;
            this.MaineCoon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MaineCoon.Location = new System.Drawing.Point(31, 133);
            this.MaineCoon.Name = "MaineCoon";
            this.MaineCoon.Size = new System.Drawing.Size(82, 17);
            this.MaineCoon.TabIndex = 12;
            this.MaineCoon.TabStop = true;
            this.MaineCoon.Text = "Maine Coon";
            this.MaineCoon.UseVisualStyleBackColor = true;
            this.MaineCoon.CheckedChanged += new System.EventHandler(this.MaineCoon_CheckedChanged);
            // 
            // ShortHaired
            // 
            this.ShortHaired.AutoSize = true;
            this.ShortHaired.Location = new System.Drawing.Point(31, 110);
            this.ShortHaired.Name = "ShortHaired";
            this.ShortHaired.Size = new System.Drawing.Size(84, 17);
            this.ShortHaired.TabIndex = 11;
            this.ShortHaired.TabStop = true;
            this.ShortHaired.Text = "Short Haired";
            this.ShortHaired.UseVisualStyleBackColor = true;
            this.ShortHaired.CheckedChanged += new System.EventHandler(this.ShortHaired_CheckedChanged);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Persian;
        private System.Windows.Forms.RadioButton MaineCoon;
        private System.Windows.Forms.RadioButton ShortHaired;
        private System.Windows.Forms.RadioButton British;
    }
}

