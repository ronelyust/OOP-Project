using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procats
{
    public abstract class GameObject
    {
        protected string name; 
        protected System.Drawing.Image Image;
        // using protected in order for the information to be accessible in the classes bellow.

        public System.Drawing.Image getImage() //a method to return an image.
        {
            return this.Image;
        }


        public class Cats : GameObject // a class under GameObject
        {
            protected long points; // a variable unique to the Cats classes.

            public long getpoints() // a method to return points.
            {
                return this.points;
            }

            public class BlackCat : Cats // a class under the Cats class, have a unique constructor and specific values.
            {
                public BlackCat() 
                {
                    name = "Black Cat";
                    points = 5;
                    Image = Properties.Resources.BlackCat;
                }
            }

            public class MaineCoon : Cats // a class under the Cats class, have a unique constructor and specific values.
            {
                public MaineCoon()
                {
                    name = "Maine Coon";
                    points = 20;
                    Image = Properties.Resources.Maincoon;
                }
            }

            public class Persian : Cats // a class under the Cats class, have a unique constructor and specific values.
            {
                public Persian()
                {
                    name = "Persian";
                    points = 10;
                    Image = Properties.Resources.Persian;
                }
            }

            public class British : Cats // a class under the Cats class, have a unique constructor and specific values.
            {
                public British()
                {
                    name = "British";
                    points = 10;
                    Image = Properties.Resources.British;
                }
            }

        }


        public class Bomb : GameObject // a class under the GameObject class, have a unique constructor and specific values.
        {
            public Bomb()
            {
                name = "Bomb";
                Image = Properties.Resources.Bomb;
            }
        }
    }
}
