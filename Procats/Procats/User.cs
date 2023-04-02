using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;

namespace Procats
{
    [Serializable()]

    
    public class User 
        {

        
        public string Name { get; set; }
       
        public string Gender { get; set; }
      
        public string FavoriteCat { get; set; }

        // serializing data

        public void Save()
        {
            // first we will check if there is a file already.
            if (File.Exists("UserData"))
            {
                //now we will deserialize the file with XML.
                var doc = XDocument.Load("UserData");
                //after loading the file - create a list of the User class,
                //we are giving each user the elemntes that are saved in the file.
                List<User> Userlist = doc.Descendants("User").Select(d => new User
                {
                    Name = d.Element("Name").Value,
                    Gender = d.Element("Gender").Value,
                    FavoriteCat = d.Element("FavoriteCat").Value
                }).ToList();

                //after creating the list, we will add the new static user to the list.
                Userlist.Add(Registration.NewUser);

                //then we shall save the file over the old one.
                using (FileStream stream = new FileStream("UserData", FileMode.Create))
                {
                    //serializing the new list to a file with XML.
                    var XML = new XmlSerializer(typeof(List<User>));
                    XML.Serialize(stream, Userlist);
                }
            }

            // if there is no file existing = create a new one and save the given data.
            else using (FileStream stream = new FileStream("UserData", FileMode.Create))
             {
                    //serializing the data to a file with XML.
                    var XML = new XmlSerializer(typeof(User));
                    XML.Serialize(stream, this);
             }
        }

        // Updating data of a specific user.
        public void Update(string OldName, string NewNameValue, string NewGenderValue, string NewFavoriteCatValue)
        {
            //we create a new variable and load the user data into it.
            //then we use the Descendants method to find the wanted user (oldname).
            //afterwards we are setting the new and changing the data.
            var info = XDocument.Load("UserData");
            var node = info.Descendants("User").FirstOrDefault(n => n.Element("Name").Value == OldName);
            node.SetElementValue("Name", NewNameValue);
            node.SetElementValue("Gender", NewGenderValue);
            node.SetElementValue("FavoriteCat", NewFavoriteCatValue);
            info.Save("UserData"); //saving
        }

        //deleting a user from a file.
        public void Delete()
        {
            ////we create a new variable and load the user data into it.
            //then we use the Descendants method to find the wanted user.
            //afterwards we are using the remove method and deleting it.
                var doc = XDocument.Load("UserData");
                var node = doc.Descendants("User").FirstOrDefault(n => n.Element("Name").Value == this.Name);
                node.Remove();
                doc.Save("UserData"); //saving
        }

    }
}