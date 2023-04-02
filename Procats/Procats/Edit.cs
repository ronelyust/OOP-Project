using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;

namespace Procats
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        static public User EditTemp = new User(); //static user to be used on the next form Edit2.

        private void Ok_Click(object sender, EventArgs e)  // ok = proceeding to attempt to edit a user.
        {
            EditTemp.Name = textBox1.Text; 

            var doc = XDocument.Load("UserData");  //creating a new variable and loading our UserData file
            var node = doc.Descendants("User").FirstOrDefault(n => n.Element("Name").Value == EditTemp.Name);
            //using the Descendants method in order to find the wanted name and then checking if it exists there.

            if (node == null) //if the line of code above returns null - it means there is no user with the wanted name in the file.
            {
                MessageBox.Show("Error - There are no users with that given name, try again");
            }

            else //when line 30 does return a value - we proceed to start editing the user with Edit2 form.
            {
                Edit2 NewEdit2 = new Edit2(); 
                NewEdit2.Show();
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e) //cancel = going back to loading screen without deleting the user.
        {
            Load NewLoad = new Load();
            NewLoad.Show();
            this.Close();
        }
    }
}
