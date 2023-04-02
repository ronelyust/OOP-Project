using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Procats
{
    public partial class Registration : Form
    {
         public string NewName, NewGender, NewFavoriteCat;
         static public User NewUser = new User(); //static user so we would be able to acsses its information in other forms

        public Registration()
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

        private void MaineCoon_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = MaineCoon.Text;
        }

        private void Persian_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = Persian.Text;
        }
        private void British_CheckedChanged(object sender, EventArgs e)
        {
            NewFavoriteCat = British.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great, you have now been registered!\nName: " + NewName + "\nGender: " + NewGender + "\nFavorite Cat: " + NewFavoriteCat);
            NewUser.Name = NewName;
            NewUser.Gender = NewGender;
            NewUser.FavoriteCat = NewFavoriteCat;
            NewUser.Save(); //saving the new information and then openning the loading screen.
            Load NewLoad = new Load();
            NewLoad.Show();
            this.Close();
        }
    }
}
