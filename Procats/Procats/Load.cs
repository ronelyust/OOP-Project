using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Procats
{
    public partial class Load : Form
    {
        
        public Load()
        {
            InitializeComponent();
            LoadingTableFromFile(); //making sure that the table loads when the load form is created.
        }

        //creating a a data table to show the current user list.
        DataTable Table = new DataTable();

        private void LoadingTableFromFile() 
        {
            DataSet data = new DataSet(); 
            data.ReadXml(@"UserData");        // transfering the information from the file to the new dataset.
            dataGridView1.DataSource = data.Tables[0]; //showcasing the information on the table.
        }

        private void Add_Click(object sender, EventArgs e) //adding a user = opening a new Registration menu.
        {
            Registration NewReg = new Registration();
            NewReg.Show();
            this.Close();
        }

        private void Edit_Click(object sender, EventArgs e) //editing a user = opening a new Edit menu.
        {
            Edit NewEdit = new Edit();
            NewEdit.Show();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e) //deleting a user = opening a new delete menu.
        {
            Delete NewDelete = new Delete();
            NewDelete.Show();
            this.Close();
        }

        private void Load_Click(object sender, EventArgs e) //Load == starting the game.
        {
            GameGrid NewGame = new GameGrid();
            NewGame.Show();
            this.Close();
        }

    }
}
