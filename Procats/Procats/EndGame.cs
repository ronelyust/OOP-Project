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
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
            label2.Text += GameGrid.GamePoints; //showing points gathered on the last round.
            int x = (59 - GameGrid.time); //showing time played.

            if (x == 60)
            {
                label3.Text += "01:00";
            }
            else
            {
                label3.Text += "00: " + x.ToString();
            }
        }

        private void NoButton_Click(object sender, EventArgs e) // No = showing a message and closing the application.
        {
            MessageBox.Show("Thank you for playing");
            Application.Exit();
        }

        private void YesButton_Click(object sender, EventArgs e) // Yes = starting anoter game.
        {
            GameGrid New = new GameGrid();
            this.Close();
            New.Show();
        }

    }
}
