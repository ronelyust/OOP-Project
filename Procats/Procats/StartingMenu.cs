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
    public partial class StartingMenu : Form
    {
        public StartingMenu()
        {
            InitializeComponent();
        }

        private void NoButton_Click(object sender, EventArgs e) //pressing the no button will open a new form of Registration
        {
            Registration NewReg = new Registration();
            NewReg.Show();
            this.Hide();
        }

        private void YesButton_Click(object sender, EventArgs e) //pressing the yes button will open a new form of Loading Screen
        {
            Load NewLoad = new Load();
            NewLoad.Show();
            this.Hide();
        }

      }
}
