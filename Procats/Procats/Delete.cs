using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;


namespace Procats
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }


        private void Ok_Click(object sender, EventArgs e)  // ok = proceeding to attempt to delete a user.
        {
            Edit.EditTemp.Name = textBox1.Text; // using an already created static user.

            var doc = XDocument.Load("UserData"); //creating a new variable and loading our UserData file
            var node = doc.Descendants("User").FirstOrDefault(n => n.Element("Name").Value == Edit.EditTemp.Name);
            //using the Descendants method in order to find the wanted name and then checking if it exists there.

            if (node == null) //if the line of code above returns null - it means there is no user with the wanted name in the file.
            {
                MessageBox.Show("Error - There are no users with that given name, try again");
            }

            else //when line 30 does return a value - we proceed to delete the user and then open a loading screen.
            {
                Edit.EditTemp.Delete();
                Load NewLoad = new Load();
                NewLoad.Show();
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
