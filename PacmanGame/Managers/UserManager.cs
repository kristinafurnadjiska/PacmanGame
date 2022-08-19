using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacmanGame.Items;

namespace PacmanGame.Managers
{
    public class UserManager
    {
        public List<Pacman> Users { get; set; }

        public static Color [] UserColors = {Color.Yellow, Color.GreenYellow};

        public void Initialize(List<String> UserNames)
        {
            Users = new List<Pacman>();

            for (int i = 0; i < UserNames.Count; i++)
            {
                Point position = new Point(i, 0);
                Pacman User = new Pacman(position, String.Format("{0}", i+1), UserNames[i], UserColors[i%2], Direction.DOWN);
                Users.Add(User);

            }
            
        }

        public void Draw(Graphics g)
        {
            foreach (Pacman Pacman in Users)
            {
                Pacman.Draw(g);
            }
        }

        public Pacman getUserById(String id)
        {
            foreach(Pacman Pacman in Users)
            {
                if(Pacman.Id == id)
                {
                    return Pacman;
                }
            }

            return null;
        }
    }
}
