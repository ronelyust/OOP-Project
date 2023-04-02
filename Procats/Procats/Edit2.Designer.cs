
namespace Procats
{
    partial class Edit2
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
            this.FavoriteCat = new System.Windows.Forms.Label();
            this.ShortHaired = new System.Windows.Forms.RadioButton();
            this.Persian = new System.Windows.Forms.RadioButton();
            this.MaineCoon = new System.Windows.Forms.RadioButton();
            this.British = new System.Windows.Forms.RadioButton();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Gender:";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(15, 69);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(48, 17);
            this.Male.TabIndex = 4;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            this.Male.CheckedChanged += new System.EventHandler(this.Male_CheckedChanged);
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(81, 69);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(59, 17);
            this.Female.TabIndex = 5;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            this.Female.CheckedChanged += new System.EventHandler(this.Female_CheckedChanged);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(151, 69);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(51, 17);
            this.Other.TabIndex = 6;
            this.Other.TabStop = true;
            this.Other.Text = "Other";
            this.Other.UseVisualStyleBackColor = true;
            this.Other.CheckedChanged += new System.EventHandler(this.Other_CheckedChanged);
            // 
            // FavoriteCat
            // 
            this.FavoriteCat.AutoSize = true;
            this.FavoriteCat.Location = new System.Drawing.Point(12, 100);
            this.FavoriteCat.Name = "FavoriteCat";
            this.FavoriteCat.Size = new System.Drawing.Size(64, 13);
            this.FavoriteCat.TabIndex = 7;
            this.FavoriteCat.Text = "Favorite Cat";
            // 
            // ShortHaired
            // 
            this.ShortHaired.AutoSize = true;
            this.ShortHaired.Location = new System.Drawing.Point(36, 117);
            this.ShortHaired.Name = "ShortHaired";
            this.ShortHaired.Size = new System.Drawing.Size(84, 17);
            this.ShortHaired.TabIndex = 8;
            this.ShortHaired.TabStop = true;
            this.ShortHaired.Text = "Short Haired";
            this.ShortHaired.UseVisualStyleBackColor = true;
            this.ShortHaired.CheckedChanged += new System.EventHandler(this.ShortHaired_CheckedChanged);
            // 
            // Persian
            // 
            this.Persian.AutoSize = true;
            this.Persian.Location = new System.Drawing.Point(36, 141);
            this.Persian.Name = "Persian";
            this.Persian.Size = new System.Drawing.Size(60, 17);
            this.Persian.TabIndex = 9;
            this.Persian.TabStop = true;
            this.Persian.Text = "Persian";
            this.Persian.UseVisualStyleBackColor = true;
            this.Persian.CheckedChanged += new System.EventHandler(this.Persian_CheckedChanged);
            // 
            // MaineCoon
            // 
            this.MaineCoon.AutoSize = true;
            this.MaineCoon.Location = new System.Drawing.Point(140, 117);
            this.MaineCoon.Name = "MaineCoon";
            this.MaineCoon.Size = new System.Drawing.Size(82, 17);
            this.MaineCoon.TabIndex = 10;
            this.MaineCoon.TabStop = true;
            this.MaineCoon.Text = "Maine Coon";
            this.MaineCoon.UseVisualStyleBackColor = true;
            this.MaineCoon.CheckedChanged += new System.EventHandler(this.MaineCoon_CheckedChanged);
            // 
            // British
            // 
            this.British.AutoSize = true;
            this.British.Location = new System.Drawing.Point(140, 141);
            this.British.Name = "British";
            this.British.Size = new System.Drawing.Size(53, 17);
            this.British.TabIndex = 11;
            this.British.TabStop = true;
            this.British.Text = "British";
            this.British.UseVisualStyleBackColor = true;
            this.British.CheckedChanged += new System.EventHandler(this.British_CheckedChanged);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(105, 177);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 12;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Edit2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 212);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.British);
            this.Controls.Add(this.MaineCoon);
            this.Controls.Add(this.Persian);
            this.Controls.Add(this.ShortHaired);
            this.Controls.Add(this.FavoriteCat);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.Male);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Edit2";
            this.Text = "Edit2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Other;
        private System.Windows.Forms.Label FavoriteCat;
        private System.Windows.Forms.RadioButton ShortHaired;
        private System.Windows.Forms.RadioButton Persian;
        private System.Windows.Forms.RadioButton MaineCoon;
        private System.Windows.Forms.RadioButton British;
        private System.Windows.Forms.Button Done;
    }
}