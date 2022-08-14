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

        public void Initialize()
        {
            Users = new List<Pacman>();
            Point position1 = new Point(0, 0);
            Pacman User1 = new Pacman(position1, "1", "Kristina", Color.Green, Direction.DOWN);
            Users.Add(User1);
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
