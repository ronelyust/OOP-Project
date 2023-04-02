using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procats
{
    public partial class Edit2 : Form
    {
        public string NewName, NewGender, NewFavoriteCat;
        
        public Edit2()
        {
            InitializeComponent();
        }

        //pressing the buttons will transfer the selcted information to the new user created.

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            NewName = textBox1.Text; ;
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            NewGender = Male.Text;
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            NewGender = Female.Text;
        }
        private void Other_CheckedChanged(object sender, EventArgs e)
        {
            NewGender = Other.Text;
        }

        private void ShortHaired_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = ShortHaired.Text;
        }

        private void Persian_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = Persian.Text;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = Persian.Text;
        }

        private void MaineCoon_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = MaineCoon.Text;
        }

        private void British_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = British.Text;
        }

        private void Done_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great, you have now changed the user's information!\nName: " + NewName + "\nGender: " + NewGender + "\nFavorite Cat: " + NewFavoriteCat);
            Edit.EditTemp.Update(Edit.EditTemp.Name, NewName, NewGender, NewFavoriteCat); //using the static user and then updating it, opening loading screen afterwards.
            Load NewLoad = new Load(); 
            NewLoad.Show();
            this.Close();
        }

    }
  
}
