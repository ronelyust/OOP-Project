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
    public partial class GameGrid : Form
    {

        bool AllowClick = false; //boolian AllowClick is used for being to click on 2 images at a time.
        PictureBox FirstPick; // the first PictureBox clicked.
        Random random = new Random(); //A random object to generate random numbers.
        Timer clickTimer = new Timer(); //A click timer to be used with Allowclick
        static public int time = 60; //the maximum time for a game round, its static to be used in the EndGame form.
        Timer timer = new Timer { Interval = 1000 }; //A timer counting seconds for the game round.
        static public long GamePoints = 0; //Game points available to get by matching Cats.

        //creating objects for the classes BlackCat, MaineCoon, Persian, British, Bomb - to be used later.
        public static GameObject.Cats.BlackCat BlackCat = new GameObject.Cats.BlackCat();
        public static GameObject.Cats.MaineCoon MaineCoon = new GameObject.Cats.MaineCoon();
        public static GameObject.Cats.Persian Persian = new GameObject.Cats.Persian();
        public static GameObject.Cats.British British = new GameObject.Cats.British();
        public static GameObject.Bomb Bomb = new GameObject.Bomb();
      

        public GameGrid()
        {
            InitializeComponent();
        }

        private PictureBox[] pictureBoxes // creating an array of pictureboxes.
        { //using the Method To Array and trageting all the picture boxes with the Controls Property of windows forms.
            get { return this.Controls.OfType<PictureBox>().ToArray(); } 
        } // now we have all the pictureboxes we created in the design in a single array.

       

        private void StartTimer(object sender, EventArgs e) //starting the timer for the game round.
        {
            timer.Start(); //using the Start function to actually start the timer.
            timer.Tick += delegate //using delegate since its a type that represents references to methods with a particular parameter list and return type, easy to use and write.
            {
                time--; 
                if (time < 0) // if time equals 0, the game is over.
                {
                    timer.Stop();
                    MessageBox.Show("You are out of time");
                    GameEnd(sender, e);
                }
 
                TimeLabel.Text = "Time: 00: " + time.ToString(); //displaying the remaining time on the time label.
            };
        }

           private void HideImages() //changing all the images in the picture boxes to catboxes
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.Catbox;
            }
        }

        private PictureBox getFreeSlot() //a method to return a random picture box with a tag value of Null.
        {
            int num = 0;
            int num2 = pictureBoxes.Length;


            do
            {
                num = random.Next(0, pictureBoxes.Length); // a loop that gives us a random number from 0 to the amount of out pictureboxes. 
            }

            while (pictureBoxes[num].Tag != null); // if the tag value of that picture box is not null - the loop continues.

            return pictureBoxes[num];
        }


        private void setRandomObjects() //a method to set the tag of the pictureboxes to the image of the cats (randomly)
        {
            for(int i = 0; i < 2; i++) //since we have 16 images we run 2 times.
            {
                if (i == 0) // we decided there would only be one pair of MaineCoons (since it has the highest value of points)
                    //and one pair of bombs since they can end the game.
                {
                    getFreeSlot().Tag = MaineCoon.getImage();
                    getFreeSlot().Tag = MaineCoon.getImage();
                    getFreeSlot().Tag = Bomb.getImage();
                    getFreeSlot().Tag = Bomb.getImage();
                }
                // the other cats will have 2 pairs each.

                getFreeSlot().Tag = BlackCat.getImage();
                getFreeSlot().Tag = BlackCat.getImage();
                getFreeSlot().Tag = Persian.getImage();
                getFreeSlot().Tag = Persian.getImage();
                getFreeSlot().Tag = British.getImage();
                getFreeSlot().Tag = British.getImage();
            }
        }

        private void ClickTimer_Tick(object sender, EventArgs e) // a simple function for the gameplay
        {
            HideImages();       //first we hide all the Images, then we allow clicking again and stop the clicktimer.
            AllowClick = true;
            clickTimer.Stop();
        }

        private void clickImage(object sender, EventArgs e)
        {
            if (!AllowClick) return; // if AlowClick is false - the function won't happen and the game continues.

            var pic = (PictureBox)sender;  //creating a local variable, it equals to the clicked picturebox.

            if (FirstPick == null)   // if the firstpick PictureBox we created at the start is empty
            { // it will become our first clicked picturebox and then we will assign the image randomlly asserted to the tag
              // earlier to the image value of the current picture box.
                FirstPick = pic;
                pic.Image = (Image)pic.Tag;
                return;
            }

            // if we got here - it means there was already a picturebox that was clicked before and we are on the second one now.

            pic.Image = (Image)pic.Tag; // again setting the image value of the current picture box from the tag.

            if (pic.Image == FirstPick.Image && pic != FirstPick) //if its not the same picture but the images are identical
            {
                pic.Visible = FirstPick.Visible = false; // both pictureboxes will become invisible.


                //geting the points for the cats that were paired.
                if (pic.Image == BlackCat.getImage()) 
                    GamePoints += BlackCat.getpoints();
                else if (pic.Image == MaineCoon.getImage())
                    GamePoints += MaineCoon.getpoints();
                else if (pic.Image == Persian.getImage())
                    GamePoints += Persian.getpoints();
                else if (pic.Image == British.getImage())
                    GamePoints += British.getpoints();
                else // if no cats been paired it means the bombs were
                {
                    timer.Stop();
                    MessageBox.Show("Oh no, The bomb has been set off - You lose");
                    GamePoints = 0; // when you lose you don't get points.
                    goto End;//skip to the end line.
                }


                ScoreLabel.Text = "Score: " + GamePoints.ToString(); //showing the current gamepoints.
            }

            else

            {
                AllowClick = false; //if the player guessed the pairs wrong - we will stop him from guessing again for 1 second.
                clickTimer.Start();
            }

            FirstPick = null; //making sure we can use Firstpick again.

            if (GamePoints != 70) { return;} //70 points is the maximum that can be achieved so the game continues
            // untill either the user found all the pairs but didn't pair the bombs - or untill his time has ran out.
            timer.Stop();
            MessageBox.Show("Congratulations, You have won!");
            End:
            GameEnd(sender, e); 
        }

        private void startGame(object sender, EventArgs e) //the startgame function to set everything up.
        {
            AllowClick = true; //firstly allowing clicking.
            GamePoints = 0; // gamepoints always start at 0.
            time = 60; //time always start at 60 = 1 min.
            setRandomObjects(); // setting all the pictureboxes tag to random.
            HideImages(); // all the images turning to catboxes so they look identical.
            StartTimer(sender, e); //starting out timer.
            clickTimer.Interval = 1000; //setting the click timer to 1 sec.
            clickTimer.Tick += ClickTimer_Tick; // tick = tick function.
            button1.Enabled = false; //you can't press start game when a round is already going.
        }

        private void GameEnd(object sender, EventArgs e) // a method that reset the timer tick and open the endgame form.
        {
            timer.Tick += delegate { time++; }; ; //resetting the timer tick.
            EndGame End = new EndGame();
            this.Close();
            End.Show();
        }
    }
}
